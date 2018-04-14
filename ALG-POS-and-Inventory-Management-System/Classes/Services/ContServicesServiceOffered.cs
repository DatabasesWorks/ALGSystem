using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System
{
    class ContServicesServiceOffered
    {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadService()
        {
            try
            {
                string query = "SELECT service_ID, service_name FROM services WHERE date_deleted IS NULL ";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error on populating Sevices listview: '" + ex + "'", "Service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public bool IsInsertService(string service_name)
        {
            bool status = false;
            try
            {
                if (!isDuplicateService(service_name))
                { // if no duplicate found
                    string query = "INSERT INTO services SET service_name=@0";
                    string[] param = { service_name };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Service successfully saved!", "Service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        public bool IsUpdateService(string service_ID, string service_name, string nvm)
        {
            bool status = false;
            try
            {
                //make a new function for this, check only the productname
                if (nvm != service_name) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = service_name;
                else
                    nvm = "nvm";
                if (!isDuplicateService(nvm))
                { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE services SET service_name=@0, WHERE service_ID=@1";
                    string[] param = { service_name, service_ID };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Service successfully updated!", "Service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        private bool isDuplicateService(string service_name)
        {
            string query2 = "SELECT service_name FROM services WHERE service_name =@0";
            string[] param2 = { service_name };
            if (Database.Select(query2, param2) != null)
            {
                System.Windows.Forms.MessageBox.Show("Service is existing, please enter another one.", "Service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDeleteService(string service_ID)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try
            {
                string query = String.Format("UPDATE services SET date_deleted='{0}' WHERE service_ID=@0", now);
                string[] param = { service_ID };
                if (Database.Execute(query, param))
                {
                    System.Windows.Forms.MessageBox.Show("Service deleted!", "Service", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
