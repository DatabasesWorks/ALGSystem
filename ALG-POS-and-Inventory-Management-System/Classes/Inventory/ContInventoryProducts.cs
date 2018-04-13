using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContInventoryProducts {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadProducts(string search, string searchBy) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query;
                if (searchBy == "Product ID") {
                    query = "SELECT products.product_ID, product_name, brand_name, category_name, GROUP_CONCAT(DISTINCT product_desc_value) AS prodDesc FROM products, categories, brands, product_description WHERE products.brand_ID=brands.brand_ID AND products.category_ID=categories.category_ID AND product_description.product_ID=products.product_ID AND products.date_deleted IS NULL AND products.product_ID LIKE @0 GROUP BY products.product_ID";
                } else if(searchBy == "Product Name") {
                    query = "SELECT products.product_ID, product_name, brand_name, category_name, GROUP_CONCAT(DISTINCT product_desc_value) AS prodDesc FROM products, categories, brands, product_description WHERE products.brand_ID=brands.brand_ID AND products.category_ID=categories.category_ID AND product_description.product_ID=products.product_ID AND products.date_deleted IS NULL AND product_name LIKE @0 GROUP BY products.product_ID";
                } else if (searchBy == "Brand") {
                    query = "SELECT products.product_ID, product_name, brand_name, category_name, GROUP_CONCAT(DISTINCT product_desc_value) AS prodDesc FROM products, categories, brands, product_description WHERE products.brand_ID=brands.brand_ID AND products.category_ID=categories.category_ID AND product_description.product_ID=products.product_ID AND products.date_deleted IS NULL AND brand_name LIKE @0 GROUP BY products.product_ID";
                } else if (searchBy == "Category") {
                    query = "SELECT products.product_ID, product_name, brand_name, category_name, GROUP_CONCAT(DISTINCT product_desc_value) AS prodDesc FROM products, categories, brands, product_description WHERE products.brand_ID=brands.brand_ID AND products.category_ID=categories.category_ID AND product_description.product_ID=products.product_ID AND products.date_deleted IS NULL AND category_name LIKE @0 GROUP BY products.product_ID";
                } else if (searchBy == "Description") {
                    query = "SELECT products.product_ID, product_name, brand_name, category_name, GROUP_CONCAT(DISTINCT product_desc_value) AS prodDesc FROM products, categories, brands, product_description WHERE products.brand_ID=brands.brand_ID AND products.category_ID=categories.category_ID AND product_description.product_ID=products.product_ID AND products.date_deleted IS NULL AND product_desc_value LIKE @0 GROUP BY products.product_ID";
                } else
                    query = "SELECT products.product_ID, product_name, brand_name, category_name, GROUP_CONCAT(DISTINCT product_desc_value) AS prodDesc FROM products, categories, brands, product_description WHERE products.brand_ID=brands.brand_ID AND products.category_ID=categories.category_ID AND product_description.product_ID=products.product_ID AND products.date_deleted IS NULL GROUP BY products.product_ID";

                string[] param = { search };
                bool[] like = { true };
               dt = Database.Retrieve(query,param,like);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on populating products listview: '" + ex + "'", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }
        public string GetProductDescription(string productID) {
            string result;
            result = "";
            try {
                //SELECT products.product_ID, product_name, brand_name, category_name, GROUP_CONCAT(DISTINCT product_desc_value) AS productDescription FROM products, categories, brands, product_description WHERE products.product_ID = product_description.product_ID AND products.brand_ID = brands.brand_ID AND products.category_ID = categories.category_ID AND products.date_deleted IS NULL
                string query = "SELECT GROUP_CONCAT(DISTINCT product_desc_value) AS productDescription FROM products, product_description WHERE products.product_ID = product_description.product_ID AND products.product_ID=@0";
                string[] param = { productID };
                result = Database.Select(query, param)[0];
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on populating products listview: '" + ex + "'", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (result);
        }
        public bool IsInsertProduct(string productID, string productName, string categoryName, string brandName, List<string> catDescID, List<string> descValue) {
            bool status = false;
            try {
                if (!isDuplicateProductIDandName(productID, productName)) { // if no duplicate found
                    string query = "INSERT INTO products SET product_ID=@0, product_name=@1, category_ID=(SELECT category_ID FROM categories WHERE category_name =@2), brand_ID=(SELECT brand_ID FROM brands WHERE brand_name =@3)";
                    string[] param = { productID, productName, categoryName, brandName };
                    if (Database.Execute(query, param)) {
                        for(int i = 0; i<catDescID.Count; i++) {
                            query = "INSERT INTO product_description SET product_ID=@0, cat_desc_ID=@1, product_desc_value=@2";
                            param = new string[] { productID, catDescID[i], descValue[i] };
                            Database.Execute(query, param);
                        }
                        System.Windows.Forms.MessageBox.Show("Product successfully saved!", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                } 
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on inserting product: '" + ex + "'", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return status;
        }

        public bool IsUpdateProduct(string productID, string productName, string categoryName, string brandName, string nvm, List<string> catDescID, List<string> descValue) {
            bool status = false;
            try {
                //make a new function for this, check only the productname
                if (nvm != productName) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = productName;
                else
                    nvm = "nvm";
                if (!isDuplicateProductIDandName("nvm", nvm)) { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found

                    string query = "DELETE FROM product_description WHERE product_ID=@0";
                    string[] param = {productID};
                    Database.Execute(query, param);

                    query = "UPDATE products SET product_name=@1, category_ID=(SELECT category_ID FROM categories WHERE category_name =@2), brand_ID=(SELECT brand_ID FROM brands WHERE brand_name =@3) WHERE product_ID=@0";
                    param = new string[] { productID, productName, categoryName, brandName };
                    if (Database.Execute(query, param)) {
                        for (int i = 0; i < catDescID.Count ; i++) {
                            query = "INSERT INTO product_description SET product_ID=@0, cat_desc_ID=@1, product_desc_value=@2";
                            param = new string[] { productID, catDescID[i], descValue[i] };
                            Database.Execute(query, param);
                        }
                        System.Windows.Forms.MessageBox.Show("Product successfully updated!", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                  }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on updating product: '" + ex + "'", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return status;
        }
        private bool isDuplicateProductIDandName(string productID, string productName) {
            string query1 = "SELECT product_ID FROM products WHERE product_ID =@0";
            string[] param1 = { productID };
            string query2 = "SELECT product_name FROM products WHERE product_name =@0";
            string[] param2 = { productName };
            if (Database.Select(query1, param1) != null) {
                System.Windows.Forms.MessageBox.Show("Product ID is existing, please enter another one.", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            } else if (Database.Select(query2, param2) != null) {
                System.Windows.Forms.MessageBox.Show("Product Name is existing, please enter another one.", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            } else {
                return false;
            }
        }
        public bool IsDeleteProduct(string productID) {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try {
                string query = String.Format("UPDATE products SET date_deleted='{0}' WHERE product_ID=@0", now);
                string[] param = {productID};
                if (Database.Execute(query, param)) {
                    System.Windows.Forms.MessageBox.Show("Product deleted!", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        public List<string> LoadBrands() {
            List<string> result = new List<string>();
            result = null;
            try {
                string query = "SELECT brand_name FROM brands WHERE date_deleted IS NULL";
                result = Database.Select(query);
            } catch (Exception) {
                throw;
            }
            return result;
        }
        public List<string> LoadCategories() {
            List<string> result = new List<string>();
            result = null;
            try {
                string query = "SELECT category_name FROM categories WHERE date_deleted IS NULL";
                result = Database.Select(query);
            } catch (Exception) {
                throw;
            }
            return result;
        }
        public System.Data.DataTable LoadCategoryDescription(string categoryName) {
            System.Data.DataTable result = new System.Data.DataTable();
            result = null;
            try {
                string query = "SELECT cat_desc_ID, desc_name, desc_type FROM category_description INNER JOIN descriptions ON descriptions.description_ID=category_description.description_ID WHERE category_ID=(SELECT category_ID FROM categories WHERE category_name = '" + categoryName + "')";
                result = Database.Retrieve(query);
            } catch (Exception) {
                throw;
            }
            return result;
        }
        public List<string> LoadDescOfSelectedItem(string productID) {
            List<string> result = new List<string>();
            result = null;
            try {
                string query = "SELECT product_desc_value FROM product_description WHERE product_ID=@0 ORDER BY cat_desc_ID";
                string[] param = { productID };
                result = Database.Select(query,param);
            } catch (Exception) {
                throw;
            }
            return result;
        }
    }
}
