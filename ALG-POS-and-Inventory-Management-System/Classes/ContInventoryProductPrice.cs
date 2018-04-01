using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContInventoryProductPrice {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadProductPrice() {
            try {
                string query = "SELECT products.product_ID, products.product_name, product_price, discount, discounted_price FROM products, product_prices WHERE products.product_ID=product_prices.product_ID";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on populating product price listview: '" + ex + "'", "Product Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public bool IsInsertSupplier(string supplier_name, string address, string contact) {
            bool status = false;
            try {
                if (!isDuplicateSupplierName(supplier_name)) { // if no duplicate found
                    string query = "INSERT INTO suppliers SET supplier_name=@0, address=@1, contact=@2";
                    string[] param = { supplier_name, address, contact };
                    if (Database.Execute(query, param)) {
                        System.Windows.Forms.MessageBox.Show("Supplier successfully saved!", "Suppliers", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        public bool IsUpdateSupplier(string supplierID, string supplierName, string address, string contact, string nvm) {
            bool status = false;
            try {
                //make a new function for this, check only the productname
                if (nvm != supplierName) // quite confusing but purpose is to check only productname excluding the existing one
                    nvm = supplierName;
                else
                    nvm = "nvm";
                if (!isDuplicateSupplierName(nvm)) { // if no duplicate found, nvm is to make sure that it will return false; no duplicate found
                    string query = "UPDATE suppliers SET supplier_name=@0, address=@1, contact=@2 WHERE supplier_ID=@3";
                    string[] param = { supplierName, address, contact, supplierID };
                    if (Database.Execute(query, param)) {
                        System.Windows.Forms.MessageBox.Show("Supplier successfully updated!", "Suppliers", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
        private bool isDuplicateSupplierName(string supplierName) {
            string query2 = "SELECT supplier_name FROM suppliers WHERE supplier_name =@0";
            string[] param2 = { supplierName };
            if (Database.Select(query2, param2) != null) {
                System.Windows.Forms.MessageBox.Show("Supplier Name is existing, please enter another one.", "Suppliers", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
                return true;
            } else {
                return false;
            }
        }
        public bool IsDeleteSupplier(string supplierID) {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try {
                string query = String.Format("UPDATE suppliers SET date_deleted='{0}' WHERE supplier_ID=@0", now);
                string[] param = { supplierID };
                if (Database.Execute(query, param)) {
                    System.Windows.Forms.MessageBox.Show("Supplier deleted!", "Suppliers", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
    }
}
