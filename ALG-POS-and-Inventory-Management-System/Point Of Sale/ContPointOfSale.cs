using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContPointOfSale {
        DbConnection Database = new DbConnection();
        public static string  custID, transID;
        public static decimal discount, totalAmount, totalDisc, totalItems, totalServices,cash,paid, balance, vatPercent, vat, vatableSale, change;
        public static System.Windows.Forms.ListView lvItems = new System.Windows.Forms.ListView();
        public static System.Windows.Forms.ListView lvServices = new System.Windows.Forms.ListView();
        public static string plateNo, vehicleType, brand, model, color, serviceRendered, serviceName, payment, employees, addedService, serviceNo;
        public static string employeesID, addedServicesID;
        public static bool isUpdateOnly = false, isChangeServiceDetail = false;
  
        //=========== render service ==========
        public decimal GetAddedServicePrice(List<string> addedServicePrice) {
            try {
                string query = "";
                List<string> myCollection = new List<string>();
                decimal addedPrice=0;
                foreach (string item in addedServicePrice) {
                    query = "SELECT serv_added_price FROM added_service_price WHERE CONCAT(serv_added_name,' (P ', serv_added_price,')')='" + item + "'";
                    addedPrice += decimal.Parse( Database.Select(query)[0]);
                }
                return (addedPrice);
            } catch (Exception ex) {
                Console.WriteLine("Error on adding added service price information: '" + ex + "'" + "Point of Sale");
                return 0;
            }
        }

        public List<string> LoadAddedServices(string serviceName) {
            try {
                string query = "SELECT CONCAT(serv_added_name,' (P ', serv_added_price,')') AS addedServicePrice FROM added_service_price WHERE service_ID = (SELECT service_ID FROM services WHERE service_name = '" + serviceName + "')";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading customer information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public List<string> LoadEmployees() {
            try {
                string query = "SELECT CONCAT(emp_fName,', ',emp_gName,' ',emp_mInitial) FROM employees";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading customer information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public List<string> LoadPlateNo() {
            try {
                string query = "SELECT plate_no FROM customer_vehicle WHERE cust_ID= '" + custID + "'";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading plate No: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public List<string> LoadCarDetails(string plateNo) {
            try {
                string query = "SELECT vehicle_brand_name, model, color, vehicle_type FROM customer_vehicle, vehicle_brands, vehicle_types WHERE vehicle_brands.vehicle_brand_ID=customer_vehicle.vehicle_brand_ID AND vehicle_types.vehicletype_ID=customer_vehicle.vehicletype_ID AND plate_no ='" + plateNo + "'";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading customer information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public List<string> LoadServices(string vehicleType) {
            try {
                string query = "SELECT DISTINCT service_name FROM services, service_prices, vehicle_types WHERE services.service_ID = service_prices.service_ID AND service_prices.vehicletype_ID = (SELECT vehicletype_ID FROM vehicle_types WHERE vehicle_type ='" + vehicleType + "')";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading customer information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public string GetAddedServiceID(string addedServiceName) {
            try {
                string query = "SELECT serv_added_ID FROM added_service_price WHERE CONCAT(serv_added_name,' (P ', serv_added_price,')')='" + addedServiceName + "'";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection[0];
            } catch (Exception ex) {
                Console.WriteLine("Error on getting added service id's: '" + ex + "'" + "Point of Sale");
                return null;
            }
        }

        public string GetEmployeeID(string employeeName) {
            try {
                string query = "SELECT emp_ID FROM employees WHERE CONCAT(emp_fName,', ',emp_gName,' ',emp_mInitial)='" + employeeName + "'";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection[0];
            } catch (Exception ex) {
                Console.WriteLine("Error on getting customer id's: '" + ex + "'" + "Point of Sale");
                return null;
            }
        }
        public string GetServicePrice(string serviceName, string vehicleType) {
            try {
                string query = "SELECT TRUNCATE(service_fee,2) FROM service_prices,services,vehicle_types WHERE (SELECT service_ID FROM services WHERE service_name='" + serviceName + "') = service_prices.service_ID AND (SELECT vehicletype_ID FROM vehicle_types WHERE vehicle_type='" + vehicleType + "') = service_prices.vehicletype_ID LIMIT 1";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection[0];
            } catch (Exception ex) {
                Console.WriteLine("Error on loading customer information: '" + ex + "'" + "Point of Sale");
                return null;
            }
        }
        
        public string GetServiceDesc(string serviceName) {
            try {
                string query = "SELECT service_desc FROM services WHERE service_name='" + serviceName + "'";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection[0];
            } catch (Exception ex) {
                Console.WriteLine("Error on loading customer information: '" + ex + "'" + "Point of Sale");
                return "";
            }
        }

        public string GetServiceID(string serviceName, string vehicleType) {
            try {
                string query = "SELECT services.service_ID FROM vehicle_types, services INNER JOIN service_prices on services.service_ID=service_prices.service_ID WHERE CONCAT(service_name, ' (P ', service_fee, ')') = '" + serviceName + "' AND vehicle_type = '" + vehicleType + "'";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection[0];
            } catch (Exception ex) {
                Console.WriteLine("Error on loading customer information: '" + ex + "'" + "Point of Sale");
                return "";
            }
        }

        //=========== search items ============
        public System.Data.DataTable LoadProducts(string search, string searchBy) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query;
                if (searchBy == "Product ID") {
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(DISTINCT remaining_stocks) AS remStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID=brands.brand_ID AND products.product_ID=product_prices.product_ID AND products.product_ID=stocks.product_ID AND products.category_ID=categories.category_ID AND products.date_deleted IS NULL AND stocks.date_deleted IS NULL AND products.product_ID LIKE @0 GROUP BY products.product_ID ORDER BY products.product_ID";
                } else if (searchBy == "Product Name") {
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(DISTINCT remaining_stocks) AS remStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID=brands.brand_ID AND products.product_ID=product_prices.product_ID AND products.product_ID=stocks.product_ID AND products.category_ID=categories.category_ID AND products.date_deleted IS NULL AND product_name LIKE @0  GROUP BY products.product_ID ORDER BY products.product_ID";
                } else if (searchBy == "Brand") {
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(DISTINCT remaining_stocks) AS remStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID = brands.brand_ID AND products.product_ID = product_prices.product_ID AND products.product_ID = stocks.product_ID AND products.category_ID = categories.category_ID AND products.date_deleted IS NULL AND brand_name  LIKE @0  GROUP BY products.product_ID ORDER BY products.product_ID";
                } else if (searchBy == "Category") {
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(DISTINCT remaining_stocks) AS remStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID = brands.brand_ID AND products.product_ID = product_prices.product_ID AND products.product_ID = stocks.product_ID AND products.category_ID = categories.category_ID AND products.date_deleted IS NULL AND category_name LIKE @0  GROUP BY products.product_ID ORDER BY products.product_ID";
                } else if (searchBy == "Description") {
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(DISTINCT remaining_stocks) AS remStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID = brands.brand_ID AND products.product_ID = product_prices.product_ID AND products.product_ID = stocks.product_ID AND products.category_ID = categories.category_ID AND products.date_deleted IS NULL AND product_desc_value LIKE @0  GROUP BY products.product_ID ORDER BY products.product_ID";
                } else
                    query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc,product_price , discount,discounted_price , SUM(DISTINCT remaining_stocks) AS remStocks FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID=brands.brand_ID AND products.product_ID=product_prices.product_ID AND products.product_ID=stocks.product_ID AND products.category_ID=categories.category_ID AND products.date_deleted IS NULL AND stocks.date_deleted IS NULL GROUP BY products.product_ID ORDER BY products.product_ID";
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
                string query = "SELECT IF(SUM(remaining_stocks) IS NULL, 0,SUM(remaining_stocks)) AS remStocks,  IF(SUM(total_stocks) IS NULL, 0,SUM(total_stocks)) AS totStocks FROM products LEFT OUTER JOIN  stocks ON products.product_ID=stocks.product_ID WHERE products.date_deleted IS NULL AND stocks.date_deleted IS NULL AND products.product_ID =@0 GROUP BY products.product_ID ORDER BY products.product_ID";
                string[] param = { productID };
                bool[] like = { false };
                dt = Database.Retrieve(query,param,like);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading product information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }

        //=========== view ongoing service ============

        public System.Data.DataTable LoadOngoingServices(string search, string searchBy) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query;
                if (searchBy == "Transaction No.")
                    query = "SELECT transactions.transac_ID AS transID, CONCAT(fName,' ,',gName,' ',mInitial) as customerName, COUNT(service_ID) AS countServices, COUNT(distinct plate_no) AS countCars,count(CASE WHEN service_status = 'Ongoing' THEN 1 END) AS ongoing, count(CASE WHEN service_status = 'Finished' THEN 1 END) AS finished ,GROUP_CONCAT(DISTINCT plate_no SEPARATOR ', ') AS plateNo, discounted_amount, paid, balance FROM transactions INNER JOIN service_transac ON transactions.transac_ID=service_transac.transac_ID INNER JOIN customers ON transactions.customer_ID = customers.cust_ID WHERE balance!= 0.00 AND transactions.transac_ID LIKE @0 GROUP BY transID";
                else if (searchBy == "Customer Name")
                    query = "SELECT transactions.transac_ID AS transID, CONCAT(fName,' ,',gName,' ',mInitial) as customerName, COUNT(plate_no) AS countServices, COUNT(distinct plate_no) AS countCars, count(CASE WHEN service_status = 'Ongoing' THEN 1 END) AS ongoing, count(CASE WHEN service_status = 'Finished' THEN 1 END) AS finished,GROUP_CONCAT(DISTINCT plate_no SEPARATOR ', ') AS plateNo, discounted_amount, paid, balance FROM transactions INNER JOIN service_transac ON transactions.transac_ID=service_transac.transac_ID INNER JOIN customers ON transactions.customer_ID = customers.cust_ID WHERE balance!= 0.00 AND CONCAT(fName,' ,',gName,' ',mInitial) LIKE @0 GROUP BY transID";
                else if (searchBy == "Plate No.")
                    query = "SELECT transactions.transac_ID AS transID, CONCAT(fName,' ,',gName,' ',mInitial) as customerName, COUNT(plate_no) AS countServices, COUNT(distinct plate_no) AS countCars, count(CASE WHEN service_status = 'Ongoing' THEN 1 END) AS ongoing, count(CASE WHEN service_status = 'Finished' THEN 1 END) AS finished, GROUP_CONCAT(DISTINCT plate_no SEPARATOR ', ') AS plateNo, discounted_amount, paid, balance FROM transactions INNER JOIN service_transac ON transactions.transac_ID=service_transac.transac_ID INNER JOIN customers ON transactions.customer_ID = customers.cust_ID WHERE balance!= 0.00 AND plate_no LIKE @0 GROUP BY transID";
                else
                    query = "SELECT transactions.transac_ID AS transID, CONCAT(fName,' ,',gName,' ',mInitial) as customerName, COUNT(plate_no) AS countServices, COUNT(distinct plate_no) AS countCars, count(CASE WHEN service_status = 'Ongoing' THEN 1 END) AS ongoing, count(CASE WHEN service_status = 'Finished' THEN 1 END) AS finished, GROUP_CONCAT(DISTINCT plate_no SEPARATOR ', ') AS plateNo, discounted_amount, paid, balance FROM transactions INNER JOIN service_transac ON transactions.transac_ID=service_transac.transac_ID INNER JOIN customers ON transactions.customer_ID = customers.cust_ID WHERE balance!= 0.00 GROUP BY transID";
                string[] param = { search };
                bool[] like = { true };
                dt = Database.Retrieve(query, param, like);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading ongoing services: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }

        //=========== point of sale ===========
        public string GetTransacID() {
            try {
                string query = "SELECT MAX(transac_ID)+1 FROM transactions";
                var list = Database.Select(query);
                if (list == null)
                    return "10000001";
                else
                    return  list[0];
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on getting transaction no. error: " + ex.Message, "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return "";
            }
        }

        public List<string> GetOngoingTransDetails(string transID) {
            try {
                string query = "SELECT transactions.transac_ID AS transID,CONCAT(gName,' ', mInitial, '. ',fName) AS customer, discount, discounted_amount, total_amount, paid, balance, items_total_amount, service_total_amount FROM transactions, customers WHERE transactions.customer_ID=customers.cust_ID AND transactions.transac_ID='" + transID + "'";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection;
            } catch (Exception ex) {
                Console.WriteLine("Error on getting transaction details: '" + ex + "'" + "Point of Sale");
                return null;
            }
        }

        public System.Data.DataTable SearchProduct(string itemCode) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query = "SELECT products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value,' ',desc_unit) AS prodDesc, TRUNCATE(discounted_price,2) AS discPrice, discount FROM products LEFT OUTER JOIN product_description ON product_description.product_ID=products.product_ID INNER JOIN category_description ON product_description.cat_desc_ID=category_description.cat_desc_ID INNER JOIN descriptions ON category_description.description_ID=descriptions.description_ID, product_prices, stocks, brands, categories WHERE products.brand_ID=brands.brand_ID AND products.product_ID=product_prices.product_ID AND products.product_ID=stocks.product_ID AND products.category_ID=categories.category_ID AND products.date_deleted IS NULL AND products.product_ID=@0 HAVING SUM(remaining_stocks)>0";
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
                if (myCollection != null)
                    custID = myCollection[0];
                return myCollection;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading customer information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
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

        public bool IsWithinAvailableStock(string productID,string quantity) {
            bool status = false;
            try {
                string query = "SELECT SUM(remaining_stocks), product_name FROM stocks, products WHERE stocks.product_ID=products.product_ID AND products.product_ID='" + productID + "' AND stocks.date_deleted IS NULL AND products.date_deleted IS NULL";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                if (myCollection != null) {
                    if ((Convert.ToInt32(myCollection[0]) - Convert.ToInt32(quantity)) >= 0)
                        status = true;
                    else
                        System.Windows.Forms.MessageBox.Show("Item " + myCollection[1] + " is not within the available quantity of '" + myCollection[0] + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading customer information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return status;
        }

        public bool IsIdFound(string productID) {
            bool status = false;
            try {
                string query = "SELECT SUM(remaining_stocks), product_name FROM stocks, products WHERE stocks.product_ID=products.product_ID AND products.product_ID=@0 AND stocks.date_deleted IS NULL AND products.date_deleted IS NULL";
                string[] param = { productID };
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query, param);
                if (myCollection != null)
                    status = true;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading customer information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return status;
        }

        public string GetVat() {
            try {
                string query = "SELECT vat_percent FROM settings LIMIT 1";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection[0];
            } catch (Exception ex) {
                Console.WriteLine("Error on loading customer information: '" + ex + "'" + "Point of Sale");
                return null;
            }
        }

        public bool IsSufficientStock(string productID, string quantity) {
            bool status = false;
            try {

            } catch (Exception ex) {
                Console.WriteLine("error on issufficientstock : " + ex.Message);
                //throw;
            }
            return status;
        }

        //=========== pay transaction =========
        public bool SaveToDb() {
            //1st phase: test saving foreing keys -->deduct from stocks
            //save products
            //save items in listviewItem
            //service
            //service personnnel, added charges
            //payment

            //checks first if quantity is within the remaining stocks
           

                bool status =false;
            if (balance == 0) {
                vatPercent = decimal.Parse(GetVat());
                vatableSale = totalAmount / decimal.Parse("1." + vatPercent);
                vat = totalAmount - vatableSale;
            } else {
                vatPercent = 0;
                vatableSale = 0;
                vat = 0;
            }
          
            List<string> list = new List<string>();
            string transacID, productTransacRelaID, serviceTransacID, paymentID;
            string query;
            string[] param;
            transacID = GetTransacID();
            paid = cash + paid;

            if (paid > totalDisc) {
                paid = totalDisc;
            }

            //====insert into transaction table
            if (custID == "")
                query = "INSERT INTO transactions SET transac_ID='" + transacID + "', discount='" + discount + "', discounted_amount='" + totalDisc + "', total_amount='" + totalAmount + "', items_total_amount='" + totalItems + "', service_total_amount='" + totalServices + "', vatable_sales='" + vatableSale + "', vat='" + vat + "', vat_percent='" + vatPercent + "', paid='" + paid + "', balance='" + balance + "'";
            else
                query = "INSERT INTO transactions SET transac_ID='" + transacID + "', discount='" + discount + "', discounted_amount='" + totalDisc + "', total_amount='" + totalAmount + "', items_total_amount='" + totalItems + "', service_total_amount='" + totalServices + "', vatable_sales='" + vatableSale + "', vat='" + vat + "', vat_percent='" + vatPercent + "', paid='" + paid + "', balance='" + balance + "', customer_ID='" + custID + "'";
            if (Database.Execute(query)) {
                #region comment
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
                #endregion
                query = "SELECT MAX(payment_ID)+1 FROM payments";
                list = Database.Select(query);
                if (list == null)
                    paymentID = "1";
                else
                    paymentID = list[0];
                //==== smaller tables

                //===to do: much smaller table(user foreach listviewItem item
                foreach (System.Windows.Forms.ListViewItem item in lvItems.Items) {
                    int existing = 0, quantity = Convert.ToInt32(item.SubItems[8].Text);

                    query = "SELECT stock_ID, remaining_stocks FROM stocks WHERE remaining_stocks!=0 AND product_ID='" + item.SubItems[1].Text + "' AND date_deleted IS NULL ORDER BY received_date ASC";
                    System.Data.DataTable stock = new System.Data.DataTable();
                    stock = Database.Retrieve(query);

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

                    var totalAmount = Decimal.Parse(item.SubItems[9].Text, System.Globalization.NumberStyles.Currency);
                    query = "INSERT INTO prod_trans_rela SET transac_ID='" + transacID + "', product_ID='" + item.SubItems[1].Text + "', quantity='" + item.SubItems[8].Text + "', total='" + totalAmount + "'";
                    Database.Execute(query);
                }

                foreach (System.Windows.Forms.ListViewItem item in lvServices.Items) {
                    query = "SELECT MAX(servtransac_ID)+1 FROM service_transac";
                    list = Database.Select(query);
                    if (list == null)
                        serviceTransacID = "1";
                    else
                        serviceTransacID = list[0];

                    string serviceStatus, dateReleased;
                    if (balance == 0) {
                        serviceStatus = "Finished";
                        dateReleased = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    } else {
                        serviceStatus = item.SubItems[12].Text;
                        dateReleased = DBNull.Value.ToString();
                    }

                    query = "INSERT INTO service_transac SET servtransac_ID='" + serviceTransacID + "', date_released='" + dateReleased + "', service_status='" + serviceStatus + "', transac_ID='" + transacID + "', service_ID='" + GetServiceID(item.SubItems[6].Text, item.SubItems[2].Text) + "', plate_no='" + item.SubItems[1].Text + "', total_amount='" + decimal.Parse(item.SubItems[7].Text, System.Globalization.NumberStyles.Currency) + "'";

                    if (Database.Execute(query)) {
                        string empID;
                        string[] values = item.SubItems[10].Text.Split('/');
                        for (int i = 0; i < values.Length; i++) {
                            empID = values[i].Trim();
                            query = "INSERT INTO service_emp_trans SET servtransac_ID='" + serviceTransacID + "', emp_ID='" + empID + "' ";
                            Database.Execute(query);
                        }

                        string addedServiceID;
                        string[] val = item.SubItems[11].Text.Split('/');
                        if (item.SubItems[11].Text != "") {
                            for (int i = 0; i < val.Length; i++) {
                                addedServiceID = val[i].Trim();
                                query = "INSERT INTO add_service_trans SET servtransac_ID='" + serviceTransacID + "', serv_added_ID='" + addedServiceID + "'";
                                Database.Execute(query);
                            }
                        }
                    }
                }
                ////insert serv_transac_ID
                //query = "INSERT INTO service_transac SET servtransac_ID='" + serviceTransacID + "'";
                //Database.Execute(query);

                //===to do: much smaller table(user foreach listviewService item
                //insert payment_ID --changed payment transaction rela, transaction is forreign key to payment
             
                query = "INSERT INTO payments SET payment_ID='" + paymentID + "', payment='" + paid + "', transac_ID='" + transacID + "', user_ID='" + clsUsers.userID + "'";
                Database.Execute(query);

                uCPointOfSale.isCancelled = false;
                status = true;
                System.Windows.Forms.MessageBox.Show("Transaction Success!", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                //ContPrint contprint = new ContPrint();
                //contprint.printreceipt(transID);

            }
            return status;
        }

        public bool UpdateToDb() {
            //1st phase: test saving foreing keys -->deduct from stocks
            //save products
            //save items in listviewItem
            //service
            //service personnnel, added charges
            //payment
            
            bool status = false;
            if (balance == 0) {
                vatPercent = decimal.Parse(GetVat());
                vatableSale = totalAmount / decimal.Parse("1." + vatPercent);
                vat = totalAmount - vatableSale;
            } else {
                vatPercent = 0;
                vatableSale = 0;
                vat = 0;
            }

            List<string> list = new List<string>();
            string productTransacRelaID, serviceTransacID, paymentID;
            string query;
            string[] param;

            paid = cash + paid;

            if (cash > balance) {
                cash = cash - change;
            }

            if (paid > totalDisc) {
                paid = totalDisc;
            }
            //====insert into transaction table
            query = "UPDATE transactions SET discount='" + discount + "', discounted_amount='" + totalDisc + "', total_amount='" + totalAmount + "', items_total_amount='" + totalItems + "', service_total_amount='" + totalServices + "', vatable_sales='" + vatableSale + "', vat='" + vat + "', vat_percent='" + vatPercent + "', paid='" + paid + "', balance='" + balance + "' WHERE transac_ID = '" + transID + "'";
            if (Database.Execute(query)) {
                #region comment
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
                #endregion
                query = "SELECT MAX(payment_ID)+1 FROM payments";
                list = Database.Select(query);
                if (list == null)
                    paymentID = "1";
                else
                    paymentID = list[0];
                //==== smaller tables

                //===to do: much smaller table(user foreach listviewItem item
                foreach (System.Windows.Forms.ListViewItem item in lvItems.Items) {
                    int existing = 0;
                    int quantity = Convert.ToInt32(item.SubItems[8].Text) - Convert.ToInt32(item.SubItems[10].Text); //deducts the current from previous

                    query = "SELECT stock_ID, remaining_stocks FROM stocks WHERE remaining_stocks!=0 AND product_ID='" + item.SubItems[1].Text + "' AND date_deleted IS NULL ORDER BY received_date ASC";
                    System.Data.DataTable stock = new System.Data.DataTable();
                    stock = Database.Retrieve(query);

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
                    var totalAmount = Decimal.Parse(item.SubItems[9].Text, System.Globalization.NumberStyles.Currency);
                    if (item.SubItems[10].Text == "0") {
                        query = "INSERT INTO prod_trans_rela SET transac_ID='" + transID + "', product_ID='" + item.SubItems[1].Text + "', quantity='" + item.SubItems[8].Text + "', total='" + totalAmount + "'";
                        Database.Execute(query);
                    } else {
                        query = "UPDATE prod_trans_rela SET quantity='" + item.SubItems[8].Text + "', total='" + totalAmount + "' WHERE transac_ID='" + transID + "' AND product_ID='" + item.SubItems[1].Text + "'";
                        Database.Execute(query);
                    }
                }

                foreach (System.Windows.Forms.ListViewItem item in lvServices.Items) {
                    query = "SELECT MAX(servtransac_ID)+1 FROM service_transac";
                    list = Database.Select(query);
                    if (list == null)
                        serviceTransacID = "1";
                    else
                        serviceTransacID = list[0];


                    string serviceStatus, dateReleased;
                    if (balance == 0) {
                        serviceStatus = "Finished";
                        dateReleased = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    } else {
                        serviceStatus = item.SubItems[12].Text;
                        dateReleased = DBNull.Value.ToString();
                    }


                    if (item.SubItems[13].Text == "0") {
                        query = "INSERT INTO service_transac SET servtransac_ID='" + serviceTransacID + "', date_released='" + dateReleased + "', service_status='" + serviceStatus + "', transac_ID='" + transID + "', service_ID='" + GetServiceID(item.SubItems[6].Text, item.SubItems[2].Text) + "', plate_no='" + item.SubItems[1].Text + "', total_amount='" + decimal.Parse(item.SubItems[7].Text, System.Globalization.NumberStyles.Currency) + "'";

                        if (Database.Execute(query)) {
                            string empID;
                            string[] values = item.SubItems[10].Text.Split('/');
                            for (int i = 0; i < values.Length; i++) {
                                empID = values[i].Trim();
                                query = "INSERT INTO service_emp_trans SET servtransac_ID='" + serviceTransacID + "', emp_ID='" + empID + "' ";
                                Database.Execute(query);
                            }

                            string addedServiceID;
                            string[] val = item.SubItems[11].Text.Split('/');
                            if (item.SubItems[11].Text != "") {
                                for (int i = 0; i < val.Length; i++) {
                                    addedServiceID = val[i].Trim();
                                    query = "INSERT INTO add_service_trans SET servtransac_ID='" + serviceTransacID + "', serv_added_ID='" + addedServiceID + "'";
                                    Database.Execute(query);
                                }
                            }
                        }
                    } else {

                        query = "UPDATE service_transac SET date_released='" + dateReleased + "', service_status='" + serviceStatus + "', transac_ID='" + transID + "', service_ID='" + GetServiceID(item.SubItems[6].Text, item.SubItems[2].Text) + "', plate_no='" + item.SubItems[1].Text + "', total_amount='" + decimal.Parse(item.SubItems[7].Text, System.Globalization.NumberStyles.Currency) + "' WHERE servtransac_ID='" + item.SubItems[13].Text + "'";
                        // tbd: disregard this if employee servicing and added services can not be edited once saved
                        if (Database.Execute(query)) {
                            string empID;
                            string[] values = item.SubItems[10].Text.Split('/'); 
                            query = "DELETE FROM service_emp_trans WHERE servtransac_ID='" + item.SubItems[13].Text + "'";
                            Database.Execute(query);
                            for (int i = 0; i < values.Length; i++) {
                                empID = values[i].Trim();
                                query = "INSERT INTO service_emp_trans SET servtransac_ID='" + item.SubItems[13].Text + "', emp_ID='" + empID + "' ";
                                Database.Execute(query);
                            }
                            
                            string addedServiceID;
                            string[] val = item.SubItems[11].Text.Split('/');
                            if (item.SubItems[11].Text != "") {
                                query = "DELETE FROM add_service_trans WHERE servtransac_ID='" + item.SubItems[13].Text + "'";
                                Database.Execute(query);
                                for (int i = 0; i < val.Length; i++) {
                                    addedServiceID = val[i].Trim();
                                    query = "INSERT INTO add_service_trans SET servtransac_ID='" + item.SubItems[13].Text + "', serv_added_ID='" + addedServiceID + "'";
                                    Database.Execute(query);
                                }
                            }
                        }
                    }
                }

                

                if (isUpdateOnly) {
                    isUpdateOnly = false;
                } else {
                    query = "INSERT INTO payments SET payment_ID='" + paymentID + "', payment='" + cash + "', transac_ID='" + transID + "', user_ID='" + clsUsers.userID + "'";
                    Database.Execute(query);
                }

                uCPointOfSale.isCancelled = false;
                status = true;
                System.Windows.Forms.MessageBox.Show("Transaction Updated!", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                //ContPrint contprint = new ContPrint();
                //contprint.printreceipt(transID);
            }
            return status;
        }

        //========== view services offered ==========

        public System.Data.DataTable LoadServices() {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query = "SELECT service_ID, service_name FROM services";
                dt = Database.Retrieve(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading services information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }

        public System.Data.DataTable LoadVehicleType() {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query = "SELECT vehicletype_ID, vehicle_type FROM vehicle_types";
                dt = Database.Retrieve(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading vehicle types information: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }

        public System.Data.DataTable LoadAddedServicesEasier(string serviceID) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query = $"SELECT serv_added_ID, serv_added_name, serv_added_price FROM added_service_price WHERE service_ID='{serviceID}'";
                dt = Database.Retrieve(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading added services: '" + ex + "'", "Point of Sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return (dt);
        }

        public string GetServicePriceEasier(string serviceID, string vehicleTypeID) {
            try {
                string query = $"SELECT TRUNCATE(service_fee,2) FROM service_prices WHERE service_ID='{serviceID}' AND vehicletype_ID='{vehicleTypeID}' LIMIT 1";
                List<string> myCollection = new List<string>();
                myCollection = Database.Select(query);
                return myCollection[0];
            } catch (Exception ex) {
                Console.WriteLine("Error on loading servicepriceeasier() information: '" + ex + "'" + "Point of Sale");
                return null;
            }
        }
    }
}
