using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System
{
    class ContServiceAddedService
    {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadAddedService()
        {
            try
            {
                string query = "SELECT serv_added_ID,(SELECT service_name FROM services WHERE services.service_ID = added_service_price.service_ID) ,serv_added_name,serv_added_price FROM added_service_price WHERE date_deleted IS NULL ";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error on populating Added Sevices listview: '" + ex + "'", "Service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public bool IsInsertAddedService(string servadded, string serv_added_name, string serv_added_fee, string services)
        {
            bool status = false;
            try
            {
                if (!isDuplicateAddedService(servadded))
                { // if no duplicate found
                    string query = "INSERT INTO added_service_price SET serv_added_name=@1,serv_added_price=@2,service_ID=(SELECT service_ID FROM services WHERE services.service_name = @3)";
                    string[] param = { servadded, serv_added_name, serv_added_fee, services };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Added Service successfully saved!", "Service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        public bool IsUpdateAddedService(string servadded, string serv_added_ID, string serv_added_name,string  serv_added_fee, string services, string nvm)
        {
            bool status = false;
            try
            {
                //make a new function for this, check only the productname
                if (nvm != servadded) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = servadded;
                else
                    nvm = "nvm";
                if (!isDuplicateAddedService(nvm))
                { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE added_service_price SET serv_added_name=@1,serv_added_price=@2,service_ID=(SELECT service_ID FROM services WHERE services.service_name = @3) WHERE serv_added_ID=@4";
                    string[] param = { servadded, serv_added_name, serv_added_fee,services,serv_added_ID };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Added Service successfully updated!", "Service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        private bool isDuplicateAddedService(string servadded)
        {
            string query2 = "SELECT serv_added_ID FROM added_service_price WHERE CONCAT(serv_added_name,' ', service_ID) =@0";
            string[] param2 = { servadded };
            if (Database.Select(query2, param2) != null)
            {
                System.Windows.Forms.MessageBox.Show("Added Service is existing, please enter another one.", "Service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDeleteAddedService(string serv_added_ID)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try
            {
                string query = String.Format("UPDATE added_service_price SET date_deleted='{0}' WHERE serv_added_ID=@0", now);
                string[] param = { serv_added_ID };
                if (Database.Execute(query, param))
                {
                    System.Windows.Forms.MessageBox.Show("Added Service deleted!", "Service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        public List<string> LoadServices()
        {
            List<string> result = new List<string>();
            result = null;
            try
            {
                string query = "SELECT service_name FROM services WHERE date_deleted IS NULL";
                result = Database.Select(query);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Services", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return result;
        }
    }
}
