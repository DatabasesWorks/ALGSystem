using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System
{
    class ContServicesVehicleTypes
    {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadVehicleTypes()
        {
            try
            {
                string query = "SELECT vehicletype_ID, vehicle_type FROM vehicle_type WHERE date_deleted IS NULL ";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error on populating vehicle Type listview: '" + ex + "'", "Vehicle Type", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public bool IsInsertVehicleTypes(string vehicle_type)
        {
            bool status = false;
            try
            {
                if (!isDuplicateVehicleTypes(vehicle_type))
                { // if no duplicate found
                    string query = "INSERT INTO vehicle_type SET vehicle_type=@0";
                    string[] param = { vehicle_type };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Vehicle Type successfully saved!", "Vehicle Type", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        public bool IsUpdateVehicleTypes(string vehicle_ID, string vehicle_type, string nvm)
        {
            bool status = false;
            try
            {
                //make a new function for this, check only the productname
                if (nvm != vehicle_type) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = vehicle_type;
                else
                    nvm = "nvm";
                if (!isDuplicateVehicleTypes(nvm))
                { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE vehicle_type SET vehicle_type=@0, WHERE vehicletype_ID=@1";
                    string[] param = { vehicle_type,  vehicle_ID };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Vehicle Type successfully updated!", "Vehicle Type", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        private bool isDuplicateVehicleTypes(string vehicle_type)
        {
            string query2 = "SELECT vehicle_type FROM vehicle_type WHERE vehicle_type =@0";
            string[] param2 = { vehicle_type };
            if (Database.Select(query2, param2) != null)
            {
                System.Windows.Forms.MessageBox.Show("Vehicle Type is existing, please enter another one.", "Vehicle Type", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDeleteVehicleTypes(string vehicletype_ID)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try
            {
                string query = String.Format("UPDATE vehicle_type SET date_deleted='{0}' WHERE vehicletype_ID=@0", now);
                string[] param = { vehicletype_ID };
                if (Database.Execute(query, param))
                {
                    System.Windows.Forms.MessageBox.Show("Vehicle Type deleted!", "Vehicle Type", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
    }
}
