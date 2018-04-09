using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContPointOfSale {
        DbConnection Database = new DbConnection();
        public static string  custID, transID;
        public static decimal discount, total, totalDisc, totalItems, totalServices, paid, balance, discountedAmount;
        public static System.Windows.Forms.ListView lvItems = new System.Windows.Forms.ListView();
        public static System.Windows.Forms.ListView lvServices = new System.Windows.Forms.ListView();
        public System.Data.DataTable LoadProduct(string itemCode) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query = "SELECT products.product_ID,product_name, brand_name, GROUP_CONCAT(product_desc_value) AS prodDesc, TRUNCATE(discounted_price,2) AS discPrice, discount FROM products, product_prices, stocks, brands, product_description WHERE products.brand_ID=brands.brand_ID AND products.product_ID=product_prices.product_ID AND products.product_ID=stocks.product_ID AND product_description.product_ID=products.product_ID AND products.product_ID=@0 HAVING SUM(remaining_stocks)>0";

                string[] param = { itemCode };
                bool[] like = { false };
                dt = Database.Retrieve(query, param, like);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading product information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }
        public List<string> LoadCustomer() {
            try {
                string query = "SELECT CONCAT(gName,' ', mInitial, '. ',fName) FROM customers WHERE date_deleted IS NULL";
                return (Database.Select(query));
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading customer information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }
        public List<string> CustInf(string custName) {
            try {
                string query = "SELECT cust_ID, contact_num, address FROM customers WHERE CONCAT(gName,' ', mInitial, '. ',fName) = '" + custName + "'";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading customer information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }
        public void SaveToDb() {
            //1st phase: test saving foreing keys -->deduct from stocks
            //save products
            //save items in listviewItem
            //service
            //service personnnel, added charges
            //payment

            string transacID, productTransacRelaID, serviceTransacID, paymentID;
            string query;
            string[] param;

            query = "SELECT MAX(transac_ID)+1 FROM transactions";
            transacID = Database.Select(query)[0];
            if (transacID == "") {
                transacID = "10000001";
            }

            query = "SELECT MAX(prod_transac_rela_ID)+1 FROM prod_trans_rela";//
            productTransacRelaID = Database.Select(query)[0];
            if (productTransacRelaID == "") {
                productTransacRelaID = "1";
            }

            query = "SELECT MAX(servtransac_ID)+1 FROM service_transac";
            serviceTransacID = Database.Select(query)[0];
            if (serviceTransacID == "") {
                serviceTransacID = "1";
            }

            query = "SELECT MAX(payment_ID)+1 FROM payments";
            paymentID = Database.Select(query)[0];
            if (productTransacRelaID == "") {
                productTransacRelaID = "1";
            }
            //==== smaller tables
            //insert prod_trans_rela
            query = "INSERT INTO prod_trans_rela SET prod_transac_rela_ID=@0";
            param = new string[] { productTransacRelaID };
            Database.Execute(query, param);
            //===to do: much smaller table(user foreach listviewItem item
            foreach (System.Windows.Forms.ListViewItem item in lvItems.Items) {
                int existing = 0, quantity = Convert.ToInt32(item.SubItems[5].Text);
                query = "SELECT stock_ID, remaining_stocks FROM stock WHERE remaining_stocks!=0 AND stock.product_ID='" + item.SubItems[0].Text + "' ORDER BY received_date ASC";
                System.Data.DataTable stock = new System.Data.DataTable();
                stock= Database.Retrieve(query);

                foreach (System.Data.DataColumn col in stock.Columns) { // updates stock based on purchased quantity

                    foreach (System.Data.DataRow row in stock.Rows) {
                        existing = Convert.ToInt32(row["remaining_stocks"].ToString());
                        if (quantity > 0) {
                            if (quantity > existing) {
                                quantity = quantity - existing;
                                query = "UPDATE stocks SET remaining_stock=0 WHERE stock_ID='" + row["stock_ID"].ToString() + "'";
                                Database.Execute(query);
                            } else if (quantity == existing) {
                                query = "UPDATE stocks SET remaining_stock=0 WHERE stock_ID='" + row["stock_ID"].ToString() + "'";
                                Database.Execute(query);
                                continue;
                            } else if (quantity < existing) {
                                existing = existing - quantity;
                                query = "UPDATE stock SET remaining_stock='" + existing + "' WHERE stock_ID='" + row["stock_ID"].ToString() + "'";
                                Database.Execute(query);
                                continue;
                            }
                        }
                    }

                }

                query = "INSERT INTO product_trans SET prod_trans_rela_ID='" + productTransacRelaID + "', product_ID='" + item.SubItems[0].Text + "', quantity='" + item.SubItems[5].Text + "', total_amount'" + item.SubItems[6].Text + "'";
                Database.Execute(query);
            }


            foreach (System.Windows.Forms.ListViewItem item in lvServices.Items) {
                query = "INSERT INTO serv_transac_rela SET servtransac_ID='" + serviceTransacID + "', service_ID=(SELECT service_ID FROM service WHERE service_name= '" + item.SubItems[4].Text + "'), added_service='" + item.SubItems[7].Text + "', served_employee ='" + item.SubItems[6].Text + "', plate_no='" + item.SubItems[0].Text + "', vehicletype_ID(SELECT vehicletype_ID FROM vehicle_type WHERE vehicle_type='" + item.SubItems[1].Text + "') , ";
            }
            //insert serv_transac_ID
            query = "INSERT INTO service_transac SET servtransac_ID='" + serviceTransacID + "'";
            Database.Execute(query);

            //===to do: much smaller table(user foreach listviewService item
            //insert payment_ID --changed payment transaction rela, transaction is forreign key to payment
            query = "INSERT INTO payment SET payment_ID='" + paymentID + "', cash='" + paid + "', ";
            Database.Execute(query);

            //====insert into transaction table
            query = "INSERT INTO transaction SET transac_ID='" + transacID + "' prod_transac_rela_ID='" + productTransacRelaID + "', servtransac_ID='" + serviceTransacID + "', discount='" + discount + "', discounted_amount='" + discountedAmount + "', total_amount='" + total + "', paid'" + paid + "', balance'" + balance + "', customer_ID='" + custID + "'";
            Database.Execute(query);

        }
    }
}
