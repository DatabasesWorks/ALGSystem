using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System
{
    class ContServicesPrice
    {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadServicePrices()
        {
            try
            {
                string query = "SELECT service_price_ID,service_name,vehicle_type,service_fee FROM service_prices,services,vehicle_types WHERE service_prices.service_ID=services.service_ID AND service_prices.vehicletype_ID=vehicle_types.vehicletype_ID AND date_deleted IS NULL ";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error on populating Services Price listview: '" + ex + "'", "Service Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public bool IsInsertServicePrices(string price, string servicename, string vehicletype, string fee)
        {
            bool status = false;
            try
            {
                if (!isDuplicateServicePrices(price))
                { // if no duplicate found
                    string query = "INSERT INTO service_price(service_ID,vehicletype_ID,service_fee) VALUES ((SELECT service_ID FROM service WHERE service_name='" + servicename + "'),(SELECT vehicletype_ID FROM vehicle_type WHERE vehicle_type='" + vehicletype + "'),'" + fee + "')";
                    string[] param = { price, servicename, vehicletype, fee };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Service Price successfully saved!", "Service Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        public bool IsUpdateServicePrices(string vehicle_ID, string vehicle_type, string nvm)
        {
            bool status = false;
            try
            {
                //make a new function for this, check only the productname
                if (nvm != vehicle_type) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = vehicle_type;
                else
                    nvm = "nvm";
                if (!isDuplicateServicePrices(nvm))
                { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE vehicle_types SET vehicle_type=@0, WHERE vehicletype_ID=@1";
                    string[] param = { vehicle_type, vehicle_ID };
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
        private bool isDuplicateServicePrices(string vehicle_type)
        {
            string query2 = "SELECT vehicle_type FROM vehicle_types WHERE vehicle_type =@0";
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
                string query = String.Format("UPDATE vehicle_types SET date_deleted='{0}' WHERE vehicletype_ID=@0", now);
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
