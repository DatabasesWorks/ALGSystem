using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContTransactionLogs {
        DbConnection Database = new DbConnection();

        public List<string> LoadTransacID() {
            List<string> list = new List<string>();
            list = null;
            try {
                string query = "SELECT transac_ID FROM transactions ORDER BY transac_ID";
                list = Database.Select(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on load transaction ID's: " + ex.Message,"Transactions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return list;
        }

        public System.Data.DataTable LoadOngoingProductTrans(string transacID) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query = "SELECT transactions.transac_ID, products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value) AS prodDesc, TRUNCATE(discounted_price,2) AS discPrice, product_prices.discount, quantity, total FROM product_prices, stocks, brands, categories, product_description, prod_trans_rela INNER JOIN transactions ON transactions.transac_ID = prod_trans_rela.transac_ID INNER JOIN products ON prod_trans_rela.product_ID = products.product_ID WHERE products.brand_ID = brands.brand_ID AND products.product_ID = product_prices.product_ID AND products.product_ID = stocks.product_ID AND products.category_ID = categories.category_ID AND product_description.product_ID = products.product_ID AND prod_trans_rela.transac_ID = @0 GROUP BY prod_trans_rela.product_ID";

                string[] param = { transacID };
                bool[] like = { false };
                dt = Database.Retrieve(query, param, like);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading product information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }

        public System.Data.DataTable LoadOngoingServicesTrans(string transacID) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query = "SELECT customer_vehicle.plate_no, vehicle_types.vehicle_type,  vehicle_brands.vehicle_brand_name, customer_vehicle.model, customer_vehicle.color, CONCAT(services.service_name,' (P ',service_prices.service_fee,')') service, service_transac.total_amount, GROUP_CONCAT(DISTINCT CONCAT(employees.emp_fName,', ',employees.emp_gName,' ',employees.emp_mInitial) SEPARATOR '/ ') AS empName, GROUP_CONCAT(DISTINCT CONCAT(added_service_price.serv_added_name,' (P ',added_service_price.serv_added_price,')' ) SEPARATOR '/') addedService, GROUP_CONCAT(DISTINCT employees.emp_ID SEPARATOR '/') AS empID,GROUP_CONCAT(DISTINCT added_service_price.serv_added_ID SEPARATOR '/') AS addedServiceID, service_status, service_transac.servtransac_ID FROM transactions INNER JOIN service_transac ON transactions.transac_ID = service_transac.transac_ID INNER JOIN customers ON transactions.customer_ID = customers.cust_ID INNER JOIN customer_vehicle ON service_transac.plate_no = customer_vehicle.plate_no AND customer_vehicle.cust_ID = customers.cust_ID INNER JOIN services ON service_transac.service_ID = services.service_ID LEFT OUTER JOIN add_service_trans ON service_transac.servtransac_ID = add_service_trans.servtransac_ID LEFT OUTER JOIN added_service_price ON add_service_trans.serv_added_ID = added_service_price.serv_added_ID INNER JOIN service_emp_trans ON service_transac.servtransac_ID = service_emp_trans.servtransac_ID INNER JOIN employees ON service_emp_trans.emp_ID = employees.emp_ID INNER JOIN vehicle_brands ON customer_vehicle.vehicle_brand_ID = vehicle_brands.vehicle_brand_ID INNER JOIN vehicle_types ON customer_vehicle.vehicletype_ID = vehicle_types.vehicletype_ID , service_prices WHERE services.service_ID = service_prices.service_ID AND service_prices.vehicletype_ID = vehicle_types.vehicletype_ID AND transactions.transac_ID =@0 GROUP BY service_transac.servtransac_ID";

                string[] param = { transacID };
                bool[] like = { false };
                dt = Database.Retrieve(query, param, like);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading product information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }

        public System.Data.DataTable LoadPaymentDetails(string transacID) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query = $"SELECT payment_ID, payment, DATE_FORMAT(date_paid,'%M %d %Y') AS datePaid, CONCAT(fName,', ',gName,' ',mInitial) AS userName FROM payments, users WHERE users.userID=payments.user_ID AND transac_ID='{transacID}'";

                dt = Database.Retrieve(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading product information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }

        public List<string> GetOngoingTransDetails(string transID) {
            try {
                string query = "SELECT discount, discounted_amount, total_amount, paid, balance, items_total_amount, service_total_amount FROM transactions WHERE transac_ID='" + transID + "'";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection;
            } catch (Exception ex) {
                Console.WriteLine("Error on getting transaction details: '" + ex + "'" + "Point of Sale");
                return null;
            }
        }

        public List<string> CustInf(string transacID) {
            try {
                string query = $"SELECT cust_ID, contact_num, address, CONCAT(gName,' ', mInitial, '. ',fName) AS customerName FROM customers, transactions WHERE customers.cust_ID=transactions.customer_ID AND transac_ID='{transacID}'";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                //if (myCollection != null)
                //    custID = myCollection[0];
                return myCollection;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading customer information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
