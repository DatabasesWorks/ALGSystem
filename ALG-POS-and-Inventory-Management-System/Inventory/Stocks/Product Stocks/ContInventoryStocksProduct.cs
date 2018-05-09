using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    public class ContInventoryStocksProduct {
        DbConnection Database = new DbConnection();

        public ContInventoryStocksProduct() {
            //System.Windows.Forms.MessageBox.Show("Test");
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

        public System.Data.DataTable LoadProductStocks(string search, string searchBy) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query;
                if (searchBy == "Product ID") {
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(remaining_stocks) AS remStocks, SUM(total_stocks) AS totalStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID=brands.brand_ID AND products.product_ID=product_prices.product_ID AND products.product_ID=stocks.product_ID AND products.category_ID=categories.category_ID AND products.date_deleted IS NULL AND stocks.date_deleted IS NULL AND products.product_ID LIKE @0 GROUP BY products.product_ID ORDER BY products.product_ID";
                } else if (searchBy == "Product Name") {
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(remaining_stocks) AS remStocks, SUM(total_stocks) AS totalStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID=brands.brand_ID AND products.product_ID=product_prices.product_ID AND products.product_ID=stocks.product_ID AND products.category_ID=categories.category_ID AND products.date_deleted IS NULL AND product_name LIKE @0  GROUP BY products.product_ID ORDER BY products.product_ID";
                } else if (searchBy == "Brand") {
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(remaining_stocks) AS remStocks, SUM(total_stocks) AS totalStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID = brands.brand_ID AND products.product_ID = product_prices.product_ID AND products.product_ID = stocks.product_ID AND products.category_ID = categories.category_ID AND products.date_deleted IS NULL AND brand_name  LIKE @0  GROUP BY products.product_ID ORDER BY products.product_ID";
                } else if (searchBy == "Category") {
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(remaining_stocks) AS remStocks, SUM(total_stocks) AS totalStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID = brands.brand_ID AND products.product_ID = product_prices.product_ID AND products.product_ID = stocks.product_ID AND products.category_ID = categories.category_ID AND products.date_deleted IS NULL AND category_name LIKE @0  GROUP BY products.product_ID ORDER BY products.product_ID";
                } else if (searchBy == "Description") {
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(remaining_stocks) AS remStocks, SUM(total_stocks) AS totalStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID = brands.brand_ID AND products.product_ID = product_prices.product_ID AND products.product_ID = stocks.product_ID AND products.category_ID = categories.category_ID AND products.date_deleted IS NULL AND product_desc_value LIKE @0  GROUP BY products.product_ID ORDER BY products.product_ID";
                } else
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(remaining_stocks) AS remStocks, SUM(total_stocks) AS totalStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID LEFT OUTER JOIN stocks ON products.product_ID=stocks.product_ID, product_prices, brands, categories WHERE products.brand_ID=brands.brand_ID AND products.product_ID=product_prices.product_ID AND products.category_ID=categories.category_ID AND products.date_deleted IS NULL AND stocks.date_deleted IS NULL GROUP BY products.product_ID ORDER BY products.product_ID";
                //SELECT products.product_ID,product_name, brand_name, category_name, IF(GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) IS NULL,'No description set', GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit)) AS prodDesc, IF(discounted_price IS NULL,'Price not set',discounted_price) AS discounted_price, IF(discount IS NULL,'discount not set',discount) AS discount , IF(product_price IS NULL,'discount not set',product_price) AS product_price, SUM(total_stocks) AS sumTotStocks, SUM(remaining_stocks) AS sumRemStocks FROM products LEFT OUTER JOIN product_prices ON products.product_ID=product_prices.product_ID LEFT OUTER JOIN product_description ON products.product_ID=product_description.product_ID LEFT OUTER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID LEFT OUTER JOIN descriptions ON category_description.description_ID=descriptions.description_ID LEFT OUTER JOIN stocks ON products.product_ID=stocks.product_ID, brands , categories WHERE products.brand_ID=brands.brand_ID AND categories.category_ID=products.category_ID AND products.date_deleted IS NULL AND stocks.date_deleted IS NULL GROUP BY stocks.product_ID
                string[] param = { search };
                bool[] like = { true };
                dt = Database.Retrieve(query, param, like);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading product information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }

        public System.Data.DataTable LoadProductStocks(string productID) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query = "SELECT IF(SUM(remaining_stocks) IS NULL, 0,SUM(remaining_stocks)) AS remStocks,  IF(SUM(total_stocks) IS NULL, 0,SUM(total_stocks)) AS totStocks FROM products LEFT OUTER JOIN  stocks ON products.product_ID=stocks.product_ID WHERE products.date_deleted IS NULL AND stocks.date_deleted IS NULL AND products.product_ID=@0 GROUP BY products.product_ID ORDER BY products.product_ID";
                string[] param = { productID };
                bool[] like = { false };
                dt = Database.Retrieve(query, param, like);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading product information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
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
        public bool IsDeductStock(string productID, string stockQuantity, string deduct) {
            bool status = false;
            try {
                int res = Convert.ToInt16(stockQuantity) - Convert.ToInt16(deduct);
                if (res < 0)
                    System.Windows.Forms.MessageBox.Show("Deduction should be lower than available stocks.", "Inventory");
                else {
                    int existing = 0, quantity = Convert.ToInt32(deduct);
                    string query;
                    query = $"SELECT stock_ID, remaining_stocks FROM stocks WHERE remaining_stocks!=0 AND product_ID='{productID}' AND date_deleted IS NULL ORDER BY received_date ASC";
                    System.Data.DataTable stock = new System.Data.DataTable();
                    stock = Database.Retrieve(query);

                    //loops through all stocks available then deducts each stock
                    foreach (System.Data.DataRow row in stock.Rows) {
                        existing = Convert.ToInt32(row["remaining_stocks"].ToString());
                        if (quantity > 0) {
                            if (quantity > existing) { //
                                quantity = quantity - existing;
                                query = "UPDATE stocks SET remaining_stocks=0 WHERE stock_ID='" + row["stock_ID"].ToString() + "'";
                                Database.Execute(query);
                            } else if (quantity == existing) {
                                query = "UPDATE stocks SET remaining_stocks=0 WHERE stock_ID='" + row["stock_ID"].ToString() + "'";
                                Database.Execute(query);
                                break;
                            } else if (quantity < existing) {
                                existing = existing - quantity;
                                query = "UPDATE stocks SET remaining_stocks='" + existing + "' WHERE stock_ID='" + row["stock_ID"].ToString() + "'";
                                Database.Execute(query);
                                break;
                            }
                        }
                    }
                       
                    System.Windows.Forms.MessageBox.Show("Updated a stock", "Inventory", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    status = true;
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
