using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContCategory {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadCategories() {
            try {
                string query = "SELECT category_ID, category_name FROM categories WHERE date_deleted IS NULL";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on populating categories listview: '" + ex + "'", "Categories", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public List<string> LoadDescriptions() {
            try {
                string query = "SELECT CONCAT(desc_name, ' (',desc_type,')') AS Description FROM descriptions WHERE date_deleted IS NULL ORDER BY description_ID";
                List<string> list = new List<string>();
                list = Database.Select(query);
                return (list);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on selecting descriptions: '" + ex + "'", "Descriptions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public List<string> SelectedDescription(string catID) {
            try {
                string query = "SELECT CONCAT(desc_name, ' (',desc_type,')') AS Description FROM descriptions, category_description WHERE descriptions.date_deleted IS NULL AND descriptions.description_ID=category_description.description_ID AND category_description.category_ID='" + catID + "' ORDER BY descriptions.description_ID";
                List<string> list = new List<string>();
                list = Database.Select(query);
                return (list);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on selecting descriptions: '" + ex + "'", "Descriptions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public bool IsInsertCategory(string catName, List<string> descriptionName) {
            bool status = false;
            string lastInsertID = "";
            try {
                if (!isDuplicateDescName(catName)) { // if no duplicate found
                    string query = "INSERT INTO categories SET category_name=@0";
                    string[] param = {catName};
                    if (Database.Execute(query, param)) {
                        lastInsertID = Database.Select("SELECT LAST_INSERT_ID() FROM categories")[0];
                        foreach(string desc in descriptionName) {
                            query = "INSERT INTO category_description SET category_ID=@0, description_ID=(SELECT description_ID FROM descriptions WHERE CONCAT(desc_name, ' (',desc_type,')')=@1)";
                            param = new string[] {lastInsertID, desc };
                            Database.Execute(query, param);
                        }
                        System.Windows.Forms.MessageBox.Show("Category successfully saved!", "Categories", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        public bool IsUpdateCategory(string catID, string catName, List<string> descriptionName, string nvm) {
            bool status = false;
            try {
                //make a new function for this, check only the productname
                if (nvm != catName) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = catName;
                else
                    nvm = "nvm";
                if (!isDuplicateDescName(nvm)) { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE categories SET category_name=@0 WHERE category_ID=@1";
                    string[] param = { catName, catID };
                    if (Database.Execute(query, param)) {
                        //gets all the cat_desc_ID's of current category id the deletes rows in product decription first before deleting rows in category_description. then insert to category_description the category_ID and the description description
                        List<string> list = new List<string>();
                        query = "SELECT cat_desc_ID FROM category_description WHERE category_ID=@0";
                        param = new string[] {catID };
                        list = Database.Select(query, param);
                        if (list != null) {
                            foreach (string catDescID in list) {
                                query = "DELETE FROM product_description WHERE cat_desc_ID=@0";
                                param = new string[] { catDescID };
                                Database.Execute(query, param);
                            }
                        }
                        query = "DELETE FROM category_description WHERE category_ID=@0";
                        param = new string[] { catID };
                        Database.Execute(query, param);
                        if (descriptionName != null) {
                            foreach (string desc in descriptionName) {
                                query = "INSERT INTO category_description SET category_ID=@0, description_ID=(SELECT description_ID FROM descriptions WHERE CONCAT(desc_name, ' (',desc_type,')')=@1)";
                                param = new string[] { catID, desc };
                                Database.Execute(query, param);
                            }
                        }
                        System.Windows.Forms.MessageBox.Show("Description successfully updated!", "Descriptions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on category update" + ex, "Descriptions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                //throw;
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
