using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System
{
    class ContServicesPrice
    {
        DbConnection Database = new DbConnection();
        public System.Data.DataTable LoadServicePrices()
        {
            try
            {
                string query = "SELECT service_price_ID,service_name,vehicle_type,service_fee FROM service_prices,services,vehicle_types WHERE service_prices.service_ID=services.service_ID AND service_prices.vehicletype_ID=vehicle_types.vehicletype_ID AND services.date_deleted IS NULL ORDER BY service_name ";
                System.Data.DataTable dt = new System.Data.DataTable();
                dt = Database.Retrieve(query);
                return (dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error on populating Services Price listview: '" + ex + "'", "Service Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }

        public List<string> LoadVehicleTypes() {
            try {
                string query = "SELECT vehicle_type FROM vehicle_types WHERE date_deleted IS NULL ";
                List<string> list = new List<string>();
                list = Database.Select(query);
                return (list);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading vehicle types: '" + ex + "'", "Service Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }

        public List<string> LoadServices() {
            try {
                string query = "SELECT service_name FROM services WHERE date_deleted IS NULL ";
                List<string> list = new List<string>();
                list = Database.Select(query);
                return (list);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading services: '" + ex + "'", "Service Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
        }

        public bool IsInsertServicePrices(string servicename, List<string> vehicletype, string fee)
        {
            bool status = false;
            try
            {
                string query;
                List<string> checkedItems = new List<string>();
                List<string> unCheckedItems = new List<string>();
                //loops through the checked item
                //gets the service_price_ID from service prices that already have price then update with the current price
                //if not, then insert to db the vehicleid,serviceid with the price
                foreach (string item in vehicletype) {
                    query = "SELECT service_price_ID FROM service_prices WHERE service_ID=(SELECT service_ID FROM services WHERE service_name='" + servicename + "') AND vehicletype_ID=(SELECT vehicletype_ID FROM vehicle_types WHERE vehicle_type='" + item + "')";
                    string res;
                    try {
                        res = Database.Select(query)[0];
                    } catch (Exception ex) {
                        res = null;
                        Console.WriteLine("error on contservice add line 70: " + ex.Message);
                    }
                    if (res != null)
                        checkedItems.Add(res);
                    else
                        unCheckedItems.Add(item);
                }

                foreach (string item in checkedItems) {
                    query = "UPDATE service_prices SET service_fee='" + fee + "' WHERE service_price_ID='" + item + "'";
                    if (!Database.Execute(query))
                        if (!IsUpdateServicePrices(item,fee))
                        System.Windows.Forms.MessageBox.Show("Error on setting product price", "Services", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                }

                foreach (string item in unCheckedItems) {
                    query = "INSERT INTO service_prices SET service_ID=(SELECT service_ID FROM services WHERE service_name='" + servicename + "'), vehicletype_ID=(SELECT vehicletype_ID FROM vehicle_types WHERE vehicle_type='" + item + "') , service_fee='" + fee + "'";
                    if (!Database.Execute(query))
                        System.Windows.Forms.MessageBox.Show("Error on setting product price", "Services", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                }
                status = true;
            }
            catch (Exception ex){
                System.Windows.Forms.MessageBox.Show("Error on saving service price" + ex.Message, "Service Price", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return status;
        }

        public bool IsUpdateServicePrices(string servicePriceID, string fee)
        {
            bool status = false;
            try
            {
                string query = "UPDATE service_prices SET service_fee='" + fee + "' WHERE service_price_ID='" + servicePriceID + "'";
                if (Database.Execute(query))
                    status = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
     
        public bool IsDeleteServicePrice(string servicePricesID)
        {
            bool status = false;
            try
            {
                string query = "DELETE FROM service_prices WHERE service_price_ID='" + servicePricesID + "'";
                if (Database.Execute(query))
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return status;
        }
    }
}
