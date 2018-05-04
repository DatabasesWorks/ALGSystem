using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContInventoryStocksSupplier {
        DbConnection Database = new DbConnection();
        
        public ContInventoryStocksSupplier() {
            //System.Windows.Forms.MessageBox.Show("Test 2");
        }
        public System.Data.DataTable LoadStocks(string sort) {
            try {
                string query = "";
                if (sort == "Product ID")
                    query = "SELECT stock_ID,products.product_ID AS prodID,product_name, CONCAT(product_name, 'DESC')  AS prodDesc,total_stocks,remaining_stocks,DATE_FORMAT(received_date, '%m-%d-%Y') AS dateProfiled,supplier_name,supplier_price FROM products,stocks,suppliers WHERE stocks.product_ID=products.product_ID AND suppliers.supplier_ID=stocks.supplier_ID AND stocks.date_deleted IS NULL ORDER BY stocks.product_ID";
                else if (sort == "Product Name")
                    query = "SELECT stock_ID,products.product_ID AS prodID,product_name, CONCAT(product_name, 'DESC')  AS prodDesc,total_stocks,remaining_stocks,DATE_FORMAT(received_date, '%m-%d-%Y') AS dateProfiled,supplier_name,supplier_price FROM products,stocks,suppliers WHERE stocks.product_ID=products.product_ID AND suppliers.supplier_ID=stocks.supplier_ID AND stocks.date_deleted IS NULL ORDER BY product_name";
                else if (sort == "Stock ID")
                    query = "SELECT stock_ID,products.product_ID AS prodID,product_name, CONCAT(product_name, 'DESC')  AS prodDesc,total_stocks,remaining_stocks,DATE_FORMAT(received_date, '%m-%d-%Y') AS dateProfiled,supplier_name,supplier_price FROM products,stocks,suppliers WHERE stocks.product_ID=products.product_ID AND suppliers.supplier_ID=stocks.supplier_ID AND stocks.date_deleted IS NULL ORDER BY stock_ID";
                else if (sort == "Available Stock")
                    query = "SELECT stock_ID,products.product_ID AS prodID,product_name, CONCAT(product_name, 'DESC')  AS prodDesc,total_stocks,remaining_stocks,DATE_FORMAT(received_date, '%m-%d-%Y') AS dateProfiled,supplier_name,supplier_price FROM products,stocks,suppliers WHERE stocks.product_ID=products.product_ID AND suppliers.supplier_ID=stocks.supplier_ID AND stocks.date_deleted IS NULL ORDER BY stock_quantity";
                else if (sort == "Date - Desc")
                    query = "SELECT stock_ID,products.product_ID AS prodID,product_name, CONCAT(product_name, 'DESC') ,total_stocks,remaining_stocks,DATE_FORMAT(received_date, '%m-%d-%Y') AS dateProfiled,supplier_name,supplier_price FROM products,stocks,suppliers WHERE stocks.product_ID=products.product_ID AND suppliers.supplier_ID=stocks.supplier_ID AND stocks.date_deleted IS NULL ORDER BY received_date DESC";
                else if (sort == "Date - Asc")
                    query = "SELECT stock_ID,products.product_ID AS prodID,product_name, CONCAT(product_name, 'DESC')  AS prodDesc,total_stocks,remaining_stocks,DATE_FORMAT(received_date, '%m-%d-%Y') AS dateProfiled,supplier_name,supplier_price FROM products,stocks,suppliers WHERE stocks.product_ID=products.product_ID AND suppliers.supplier_ID=stocks.supplier_ID AND stocks.date_deleted IS NULL ORDER BY received_date ASC";
                else if(sort == "running out")
                    //=========== query when displaying stocks running out use the sort parameter to achieve this
                    query = "SELECT stock_ID,products.product_ID AS prodID,product_name, CONCAT(product_name, ' description') AS prodDesc,total_stocks,remaining_stocks,DATE_FORMAT(received_date, '%m-%d-%Y') AS dateProfiled,supplier_name,supplier_price FROM products,stocks,suppliers WHERE stocks.product_ID=products.product_ID AND suppliers.supplier_ID=stocks.supplier_ID AND stocks.date_deleted IS NULL GROUP BY stock_ID HAVING SUM(remaining_stocks) <= 10";
                else
                    query = "SELECT stock_ID,products.product_ID AS prodID,product_name, CONCAT(product_name, 'DESC')  AS prodDesc,total_stocks,remaining_stocks, DATE_FORMAT(received_date, '%m-%d-%Y') AS dateProfiled,supplier_name,supplier_price FROM products,stocks,suppliers WHERE stocks.product_ID=products.product_ID AND suppliers.supplier_ID=stocks.supplier_ID AND stocks.date_deleted IS NULL";
                System.Data.DataTable table = new System.Data.DataTable();
                table = Database.Retrieve(query);
                return table;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
        }
        public string SelectMaxID() {
            string query = "SELECT MAX(stock_ID) FROM stocks";
            List<string> list = new List<string>();
            list = Database.Select(query);
            string id;
            if (list == null) {
                return "STK-1000001";
            } else {
                id = (Convert.ToInt32( list[0].Substring(4, 7)) + 1).ToString();
                id = "STK-" + id.ToString();
                return id ;
            }
        }
        public List<string> LoadSuppliers() {
            List<string> result = new List<string>();
            result = null;
            try {
                string query = "SELECT supplier_name FROM suppliers WHERE date_deleted IS NULL";
                result = Database.Select(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Stocks", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return result;
        }
        public List<string> LoadProductID() {
            List<string> result = new List<string>();
            result = null;
            try {
                string query = "SELECT product_ID FROM products WHERE date_deleted IS NULL";
                result = Database.Select(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Stocks", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
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
                System.Windows.Forms.MessageBox.Show(ex.Message, "Stocks", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
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
                System.Windows.Forms.MessageBox.Show(ex.Message, "Stocks", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
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
                System.Windows.Forms.MessageBox.Show(ex.Message, "Stocks", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return result;
        }
        public bool IsInsertStocks(string stockID, string dateReceived, string productID, string stockQuantity, string supplier, string supplierPrice) {
            bool status = false;
            try {
                    string query = "INSERT INTO stocks SET stock_ID=@0, received_date=@1, product_ID=@2, remaining_stocks=@3, total_stocks=@3, supplier_ID=(SELECT supplier_ID FROM suppliers WHERE supplier_name=@4), supplier_price=@5";
                    string[] param = { stockID , dateReceived, productID, stockQuantity, supplier, supplierPrice };
                    if (Database.Execute(query, param)) {
                        System.Windows.Forms.MessageBox.Show("Stock successfully saved!", "Stocks", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Stocks",  System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return status;
        }
        public bool IsUpdateStock(string stockID, string stockQuantity) {
            bool status = false;
            try {
                Int16 remaining = 0, total = 0, remresult = 0, totresult = 0;
                List<string> list = new List<string>();
                string query = "SELECT total_stocks,remaining_stocks FROM stocks WHERE stock_ID=@0";
                string[] param = { stockID };
                list = Database.Select(query, param);
                if (list!=null) {
                        total = Convert.ToInt16(list[0]);
                        remaining = Convert.ToInt16(list[1]);
                }
                totresult = (Int16)(Convert.ToInt16(stockQuantity) + total);
                remresult = (Int16)(Convert.ToInt16(stockQuantity) + remaining);
                query = "UPDATE stocks SET total_stocks=@0,remaining_stocks=@1 WHERE stock_ID=@2 ";
                string[] param1 = { totresult.ToString(), remresult.ToString(), stockID};
                if (Database.Execute(query, param1)) {
                    System.Windows.Forms.MessageBox.Show("Updated a stock", "Inventory", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Stocks", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return status;
        }
        public bool IsDeductStock(string stockID, string stockQuantity, string deduct) {
            bool status = false;
            try {
                int res = Convert.ToInt16(stockQuantity) - Convert.ToInt16(deduct);
                if (res < 0)
                    System.Windows.Forms.MessageBox.Show("Deduction should be lower than available stocks.", "Inventory");
                else {
                    string query = "UPDATE stocks SET remaining_stocks=@0 WHERE stock_ID=@1 ";
                    string[] param = { res.ToString(), stockID };
                    if (Database.Execute(query, param)) {
                        System.Windows.Forms.MessageBox.Show("Updated a stock", "Inventory", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        status = true;
                    }
                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Stocks", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return status;
        }
        public bool IsChangePrice(string stockID, string supplierPrice) {
            bool status = false;
            try {
                string query = "UPDATE stocks SET supplier_price=@0 WHERE stock_ID=@1 ";
                string[] param = { supplierPrice, stockID };
                if (Database.Execute(query, param)) {
                    System.Windows.Forms.MessageBox.Show("Updated a stock price", "Inventory", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Stocks", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return status;
        }
        public bool IsDeleteStock(string stockID) {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try {
                string query = String.Format("UPDATE stocks SET date_deleted='{0}' WHERE stock_ID=@0", now);
                string[] param = { stockID };
                if (Database.Execute(query, param)) {
                    System.Windows.Forms.MessageBox.Show("Stock deleted!", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Stocks", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return status;
        }
        public bool IsRemoveZeroStock() {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bool status = false;
            try {
                string query = String.Format("UPDATE stocks SET date_deleted='{0}' WHERE remaining_stocks=0", now);
                if (Database.Execute(query)) {
                    System.Windows.Forms.MessageBox.Show("Zero stocks deleted!", "Products", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Stocks", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return status;
        }
    }
}
