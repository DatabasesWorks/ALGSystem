using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContProductsBrands {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadBrands() {
            try {
                string query = "SELECT brand_ID, brand_name FROM brands WHERE date_deleted IS NULL ";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on populating brands listview: '" + ex + "'", "Brands", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public bool IsInsertBrands(string brandName) {
            bool status = false;
            try {
                if (!isDuplicateBrandName(brandName)) { // if no duplicate found
                    string query = "INSERT INTO brands SET brand_name=@0";
                    string[] param = { brandName };
                    if (Database.Execute(query, param)) {
                        System.Windows.Forms.MessageBox.Show("Brands successfully saved!", "Brands", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        public bool IsUpdateBrands(string brandID, string brandName, string nvm) {
            bool status = false;
            try {
                //make a new function for this, check only the productname
                if (nvm != brandName) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = brandName;
                else
                    nvm = "nvm";
                if (!isDuplicateBrandName(nvm)) { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE brands SET brand_name=@0 WHERE brand_ID=@1";
                    string[] param = { brandName, brandID };
                    if (Database.Execute(query, param)) {
                        System.Windows.Forms.MessageBox.Show("Brand successfully updated!", "Brands", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        private bool isDuplicateBrandName(string brandName) {
            string query2 = "SELECT brand_name FROM brands WHERE brand_name =@0";
            string[] param2 = { brandName };
            if (Database.Select(query2, param2) != null) {
                System.Windows.Forms.MessageBox.Show("Brand name is existing, please enter another one.", "Vehicle Type", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            } else {
                return false;
            }
        }
        public bool IsDeleteBrand(string brandID) {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try {
                string query = String.Format("UPDATE brands SET date_deleted='{0}' WHERE brand_ID=@0", now);
                string[] param = { brandID };
                if (Database.Execute(query, param)) {
                    System.Windows.Forms.MessageBox.Show("Brand deleted!", "Brands", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
    }
}
