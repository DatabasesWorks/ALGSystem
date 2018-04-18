using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System
{
    class ContManageUsers
    {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadUser()
        {
            try
            {
                string query = "SELECT userID,fName,gName,mInitial,user_address,username,password,user_type FROM users WHERE date_deleted IS NULL ";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error on populating User listview: '" + ex + "'", "User", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public bool IsInsertUsers(string Fullname, string fName, string gName, string mInitial,string user_address, string username, string password, string user_type)
        {
            bool status = false;
            try
            {
                if (!isDuplicateUser(Fullname))
                { // if no duplicate found
                    string query = "INSERT INTO users SET fName=@1,gName=@2,mInitial=@3,user_address=@4,username=@5,password=@6,user_type=@7";
                    string[] param = { Fullname, fName, gName, mInitial,user_address, username, password, user_type };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("User successfully saved!", "User", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        public bool IsUpdateUser(string Fullname, string fName, string gName, string mInitial,string user_address, string username, string password, string user_type, string nvm)
        {
            bool status = false;
            try
            {
                //make a new function for this, check only the productname
                if (nvm != Fullname) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = Fullname;
                else
                    nvm = "nvm";
                if (!isDuplicateUser(nvm))
                { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE users SET fName=@1,gName=@2,mInitial=@3,user_address@4,username=@5,password=@6,user_type=@7 WHERE CONCAT(gName,' ', mInitial, '. ',fName) =@0";
                    string[] param = { Fullname, fName, gName, mInitial, username, password, user_type, user_address };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("User successfully updated!", "User", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        private bool isDuplicateUser(string Fullname)
        {
            string query2 = "SELECT userID FROM users WHERE CONCAT(gName,' ', mInitial, '. ',fName) =@0";
            string[] param2 = { Fullname };
            if (Database.Select(query2, param2) != null)
            {
                System.Windows.Forms.MessageBox.Show("User is existing, please enter another one.", "User", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDeleteUser(string userID)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try
            {
                string query = String.Format("UPDATE users SET date_deleted='{0}' WHERE userID=@0", now);
                string[] param = { userID };
                if (Database.Execute(query, param))
                {
                    System.Windows.Forms.MessageBox.Show("User deleted!", "User", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
