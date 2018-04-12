using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System
{
    class ContManageEmployee
    {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadEmployees()
        {
            try
            {
                string query = "SELECT emp_ID, emp_fName,emp_gName,emp_mInitial,emp_position,emp_address FROM employees WHERE date_deleted IS NULL ";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error on populating employee listview: '" + ex + "'", "Employee", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public bool IsInsertEmployees(string Fullname, string emp_fName, string emp_gName, string emp_mInitial, string emp_position, string emp_address )
        {
            bool status = false;
            try
            {
                if (!isDuplicateEmployees(Fullname))
                { // if no duplicate found
                    string query = "INSERT INTO employees SET  emp_fName=@1,emp_gName=@2,emp_mInitial=@3,emp_position=@4,emp_address=@5";
                    string[] param = { Fullname, emp_fName,  emp_gName,  emp_mInitial,  emp_position,  emp_address };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Employee Type successfully saved!", "Employee", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        public bool IsUpdateEmployees(string Fullname, string emp_fName, string emp_gName, string emp_mInitial, string emp_position, string emp_address, string nvm)
        {
            bool status = false;
            try
            {
                //make a new function for this, check only the productname
                if (nvm != Fullname) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = Fullname;
                else
                    nvm = "nvm";
                if (!isDuplicateEmployees(nvm))
                { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE employees SET emp_fName=@1,emp_gName=@2,emp_mInitial=@3,emp_position=@4,emp_address=@5 WHERE CONCAT(gName,' ', mInitial, '. ',fName) =@0";
                    string[] param = { Fullname,  emp_fName,  emp_gName,  emp_mInitial,  emp_position,  emp_address };
                    if (Database.Execute(query, param))
                    {
                        System.Windows.Forms.MessageBox.Show("Employee successfully updated!", "Employee", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        private bool isDuplicateEmployees(string Fullname)
        {
            string query2 = "SELECT emp_ID FROM employees WHERE CONCAT(gName,' ', mInitial, '. ',fName) =@0";
            string[] param2 = { Fullname };
            if (Database.Select(query2, param2) != null)
            {
                System.Windows.Forms.MessageBox.Show("Employees is existing, please enter another one.", "Employees", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDeleteEmployees(string emp_ID)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try
            {
                string query = String.Format("UPDATE employees SET date_deleted='{0}' WHERE emp_ID=@0", now);
                string[] param = { emp_ID };
                if (Database.Execute(query, param))
                {
                    System.Windows.Forms.MessageBox.Show("Employee deleted!", "Employee", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
