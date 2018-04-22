using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContDescription {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadDescriptions() {
            try {
                string query = "SELECT description_ID, desc_name, desc_type, desc_unit FROM descriptions WHERE date_deleted IS NULL";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on populating description listview: '" + ex + "'", "Descriptions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public bool IsInsertDescription(string descName, string descType, string descUnit) {
            bool status = false;
            try {
                if (!isDuplicateDescName(descName)) { // if no duplicate found
                    string query = "INSERT INTO descriptions SET desc_name=@0, desc_type=@1, desc_unit";
                    string[] param = { descName, descType, descUnit};
                    if (Database.Execute(query, param)) {
                        System.Windows.Forms.MessageBox.Show("Description successfully saved!", "Descriptions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        public bool IsUpdateDescription(string descID, string descName, string descType, string descUnit, string nvm) {
            bool status = false;
            try {
                //make a new function for this, check only the productname
                if (nvm != descName) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = descName;
                else
                    nvm = "nvm";
                if (!isDuplicateDescName(nvm)) { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE descriptions SET desc_name=@0, desc_type=@1, desc_unit=@2 WHERE description_ID=@3";
                    string[] param = { descName, descType, descUnit, descID };
                    if (Database.Execute(query, param)) {
                        System.Windows.Forms.MessageBox.Show("Description successfully updated!", "Descriptions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        private bool isDuplicateDescName(string descName) {
            string query2 = "SELECT desc_name FROM descriptions WHERE desc_name =@0";
            string[] param2 = { descName };
            if (Database.Select(query2, param2) != null) {
                System.Windows.Forms.MessageBox.Show("Description Name is existing, please enter another one.", "Descriptions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            } else {
                return false;
            }
        }
        public bool IsDeleteDescription(string descID) {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try {
                string query = String.Format("UPDATE descriptions SET date_deleted='{0}' WHERE description_ID=@0", now);
                string[] param = { descID };
                if (Database.Execute(query, param)) {
                    System.Windows.Forms.MessageBox.Show("Description deleted!", "Descriptions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
    }
}
