using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContInventoryProductPrice {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadSupplierPrices(string productID) {
            try {
                string query;
                if (productID=="")
                    query = "SELECT supplier_name, supplier_price, stock_ID, received_date, remaining_stocks FROM suppliers, stocks WHERE suppliers.supplier_ID=stocks.supplier_ID AND stocks.date_deleted IS NULL";
                else
                    query = "SELECT supplier_name, supplier_price, stock_ID, received_date, remaining_stocks FROM suppliers, stocks WHERE suppliers.supplier_ID=stocks.supplier_ID AND stocks.product_ID=(SELECT product_ID FROM products WHERE product_ID='" + productID + "') AND stocks.date_deleted IS NULL";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on populating stock prices listview: '" + ex + "'", "Product Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public System.Data.DataTable LoadProductPrice() {
            try {
                string query = "SELECT products.product_ID AS prodID, product_name, product_price, discount, discounted_price FROM products, product_prices WHERE products.product_ID=product_prices.product_ID";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on populating product price listview: '" + ex + "'", "Product Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }
        public List<string> LoadProductID() {
            List<string> result = new List<string>();
            result = null;
            try {
                string query = "SELECT product_ID FROM products WHERE date_deleted IS NULL";
                result = Database.Select(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Product Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return result;
        }
        public List<string> LoadProductName() {
            List<string> result = new List<string>();
            result = null;
            try {
                string query = "SELECT product_name FROM products WHERE date_deleted IS NULL";
                result = Database.Select(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Product Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return result;
        }
        public List<string> SelectProductID(string productName) {
            List<string> result = new List<string>();
            result = null;
            try {
                string query = "SELECT product_ID FROM products WHERE date_deleted IS NULL AND product_name='" + productName + "'";
                result = Database.Select(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Product Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return result;
        }
        public List<string> SelectProductName(string productID) {
            List<string> result = new List<string>();
            result = null;
            try {
                string query = "SELECT product_name FROM products WHERE date_deleted IS NULL AND product_ID='" + productID + "'";
                result = Database.Select(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Product Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return result;
        }
        public List<string> ProductSelectedForPrice(string productID) {
            List<string> result = new List<string>();
            result = null;
            try {
                string query = "SELECT product_price, discount, discounted_price FROM product_prices WHERE product_prices.product_ID=(SELECT product_ID FROM products WHERE product_ID='" + productID + "')";
                result = Database.Select(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Product Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return result;
        }
        
        public bool SetProductPrice(bool isPriceSet, string productID, string productPrice, string discount, string discountedPrice) {
            bool status = false;
            try {
                string query,msg;
                string[] param;
                if (!isPriceSet) {
                    //====== insert product price
                    query = "INSERT INTO product_prices SET product_ID=@0, product_price=@1, discount=@2, discounted_price=@3";
                    param = new string[] { productID, productPrice, discount, discountedPrice};
                    msg = "Added product Price";
                } else {
                    //====== UPDATE product price
                    query = "UPDATE product_prices SET product_price=@0, discount=@1, discounted_price=@2 WHERE product_ID=@3";
                    param = new string[] {productPrice, discount, discountedPrice, productID};
                    msg = "Updated product Price";
                }

                if (Database.Execute(query, param)) {
                    System.Windows.Forms.MessageBox.Show(msg, "Product Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
    }
}
