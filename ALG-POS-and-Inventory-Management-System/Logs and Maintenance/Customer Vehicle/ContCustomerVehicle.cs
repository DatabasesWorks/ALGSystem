using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System
{
    class ContCustomerVehicle
    {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadCustomerVehicle(string custID)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try
            {
                string query = "SELECT plate_no,cust_ID,(SELECT vehicle_type FROM vehicle_types WHERE vehicle_types.vehicletype_ID = customer_vehicle.vehicletype_ID),(SELECT vehicle_brand_name FROM vehicle_brands WHERE vehicle_brands.vehicle_brand_ID = customer_vehicle.vehicle_brand_ID) ,color,model FROM customer_vehicle WHERE cust_ID LIKE @0 AND date_deleted IS NULL ";
                string[] param = { custID };
                bool[] like = { true };
                dt = Database.Retrieve(query, param, like);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error on populating Vehicle listview: '" + ex + "'", "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }
        public bool IsInsertCustomerVehicle(string plate_no,string cust_ID,string vehicletype_ID,string brand_ID, string color, string model)
        {
            bool status = false;
            try
            {
                if (!isDuplicateCustomerVehicle(plate_no))
                { // if no duplicate found
                    string query = "INSERT INTO customer_vehicle SET plate_no=@0,cust_ID=@1,vehicletype_ID=(SELECT vehicletype_ID FROM vehicle_types WHERE vehicle_types.vehicle_type=@2),vehicle_brand_ID=(SELECT vehicle_brand_ID FROM vehicle_brands WHERE vehicle_brands.vehicle_brand_name = @3),color=@4,model=@5";
                    string[] param = { plate_no, cust_ID, vehicletype_ID, brand_ID,color,model };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Customer Vehicle successfully saved!", "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        public bool IsUpdateCustomerVehicle(string plate_no, string vehicletype_ID, string brand_ID, string color, string model, string nvm)
        {
            bool status = false;
            try
            {
                //make a new function for this, check only the productname
                if (nvm != plate_no) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = plate_no;
                else
                    nvm = "nvm";
                if (!isDuplicateCustomerVehicle(nvm))
                { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE customer_vehicle SET vehicletype_ID=(SELECT vehicletype_ID FROM vehicle_types WHERE vehicle_type=@1),vehicle_brand_ID=(SELECT vehicle_brand_ID FROM vehicle_brands WHERE vehicle_brands.vehicle_brand_name = @2),color=@3,model=@4 WHERE plate_no=@0";
                    string[] param = { plate_no, vehicletype_ID, brand_ID, color,model};
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Customer Vehicle successfully updated!", "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        private bool isDuplicateCustomerVehicle(string plate_no)
        {
            string query2 = "SELECT plate_no FROM customer_vehicle WHERE plate_no=@0";
            string[] param2 = { plate_no };
            if (Database.Select(query2, param2) != null)
            {
                System.Windows.Forms.MessageBox.Show("Plate No. is existing, please enter another one.", "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDeleteCustomerVehicle(string plate_no)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try
            {
                string query = String.Format("UPDATE customer_vehicle SET date_deleted='{0}' WHERE plate_no=@0", now);
                string[] param = { plate_no };
                if (Database.Execute(query, param))
                {
                    System.Windows.Forms.MessageBox.Show("Vehicle deleted!", "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        public List<string> LoadVehicle()
        {
            List<string> result = new List<string>();
            result = null;
            try
            {
                string query = "SELECT vehicle_type FROM vehicle_types WHERE date_deleted IS NULL";
                result = Database.Select(query);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return result;
        }
        public List<string> LoadBrand()
        {
            List<string> result = new List<string>();
            result = null;
            try
            {
                string query = "SELECT vehicle_brand_name FROM vehicle_brands WHERE date_deleted IS NULL";
                result = Database.Select(query);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return result;
        }
    }
}
