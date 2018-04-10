﻿using System;
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
            
            List<string> list = new List<string>();
            string transacID, productTransacRelaID, serviceTransacID, paymentID;
            string query;
            string[] param;

            query = "SELECT MAX(transac_ID)+1 FROM transactions";
            list = Database.Select(query);
            if (list == null)
                transacID = "10000001";
            else
                transacID = list[0];

            //====insert into transaction table
            query = "INSERT INTO transactions SET transac_ID='" + transacID + "', discount='" + discount + "', discounted_amount='" + discountedAmount + "', total_amount='" + total + "', paid='" + paid + "', balance='" + balance + "'";//, customer_ID='" + custID + "'";
            Database.Execute(query);

            //change because transac_ID changed as a foreignkey in prod_trans_rela
            //query = "SELECT MAX(prod_transac_rela_ID)+1 FROM prod_trans_rela";//
            //list = Database.Select(query);
            //if (list == null)
            //    productTransacRelaID = "1";
            //else
            //    productTransacRelaID = list[0];
            //insert prod_trans_rela
            //query = "INSERT INTO prod_trans_rela SET transac_ID=@0";
            //param = new string[] { transacID };
            //Database.Execute(query, param);

            query = "SELECT MAX(servtransac_ID)+1 FROM service_transac";
            list = Database.Select(query);
            if (list == null) 
                serviceTransacID = "1";
            else
                serviceTransacID = list[0];

            query = "SELECT MAX(payment_ID)+1 FROM payments";
            list = Database.Select(query);
            if (list == null) 
                paymentID = "1";
            else
                paymentID = list[0];
            //==== smaller tables
            
            //===to do: much smaller table(user foreach listviewItem item
            foreach (System.Windows.Forms.ListViewItem item in lvItems.Items) {
                int existing = 0, quantity = Convert.ToInt32(item.SubItems[6].Text);

                query = "SELECT stock_ID, remaining_stocks FROM stocks WHERE remaining_stocks!=0 AND product_ID='" + item.SubItems[1].Text + "' ORDER BY received_date ASC";
                System.Data.DataTable stock = new System.Data.DataTable();
                stock= Database.Retrieve(query);

                //foreach (System.Data.DataColumn col in stock.Columns) { // updates stock based on purchased quantity
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
                //}
                
                var totalAmount = Decimal.Parse(item.SubItems[7].Text, System.Globalization.NumberStyles.Currency);
                query = "INSERT INTO prod_trans_rela SET transac_ID='" + transacID + "', product_ID='" + item.SubItems[1].Text + "', quantity='" + item.SubItems[6].Text + "', total='" + totalAmount + "'";
                Database.Execute(query);
            }


            //foreach (System.Windows.Forms.ListViewItem item in lvServices.Items) {
            //    query = "INSERT INTO serv_transac_rela SET servtransac_ID='" + serviceTransacID + "', service_ID=(SELECT service_ID FROM service WHERE service_name= '" + item.SubItems[4].Text + "'), added_service='" + item.SubItems[7].Text + "', served_employee ='" + item.SubItems[6].Text + "', plate_no='" + item.SubItems[0].Text + "', vehicletype_ID(SELECT vehicletype_ID FROM vehicle_type WHERE vehicle_type='" + item.SubItems[1].Text + "') , ";
            //}
            ////insert serv_transac_ID
            //query = "INSERT INTO service_transac SET servtransac_ID='" + serviceTransacID + "'";
            //Database.Execute(query);

            //===to do: much smaller table(user foreach listviewService item
            //insert payment_ID --changed payment transaction rela, transaction is forreign key to payment
            query = "INSERT INTO payments SET payment_ID='" + paymentID + "', cash='" + paid + "', transac_ID='" + transacID + "'";
            Database.Execute(query);

            

        }
    }
}