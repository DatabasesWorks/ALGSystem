using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System
{
    class ContManageCustomer
    {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadCustomer()
        {
            try
            {
                string query = "SELECT cust_ID,fName,gName,mInitial,contact_num,address FROM customers WHERE date_deleted IS NULL ";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error on populating Customer listview: '" + ex + "'", "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public bool IsInsertCustomers(string Fullname, string fName, string gName, string mInitial, string contact_num, string address)
        {
            bool status = false;
            try
            {
                if (!isDuplicateCustomer(Fullname))
                { // if no duplicate found
                    string query = "INSERT INTO customers SET fName=@1,gName=@2,mInitial=@3,contact_num=@4,address=@5";
                    string[] param = { Fullname, fName, gName, mInitial, contact_num, address };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Customer successfully saved!", "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        public bool IsUpdateCustomer(string Fullname, string fName, string gName, string mInitial, string contact_num, string address, string nvm)
        {
            bool status = false;
            try
            {
                //make a new function for this, check only the productname
                if (nvm != Fullname) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = Fullname;
                else
                    nvm = "nvm";
                if (!isDuplicateCustomer(nvm))
                { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE customers SET fName=@1,gName=@2,mInitial=@3,contact_num=@4,address=@5 WHERE CONCAT(gName,' ', mInitial, '. ',fName) =@0";
                    string[] param = { Fullname,fName, gName, mInitial, contact_num, address };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Customer successfully updated!", "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        private bool isDuplicateCustomer(string Fullname)
        {
            string query2 = "SELECT cust_ID FROM Customers WHERE CONCAT(gName,' ', mInitial, '. ',fName) =@0";
            string[] param2 = { Fullname };
            if (Database.Select(query2, param2) != null)
            {
                System.Windows.Forms.MessageBox.Show("Customer is existing, please enter another one.", "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDeleteCustomer(string cust_ID)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try
            {
                string query = String.Format("UPDATE Customers SET date_deleted='{0}' WHERE cust_ID=@0", now);
                string[] param = { cust_ID };
                if (Database.Execute(query, param))
                {
                    System.Windows.Forms.MessageBox.Show("Customer deleted!", "Customer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
