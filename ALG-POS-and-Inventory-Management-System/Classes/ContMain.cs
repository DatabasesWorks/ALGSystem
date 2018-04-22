using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContMain {
        DbConnection Database = new DbConnection();
        public void Logout() {
            try {
                string query = "UPDATE users SET login_status=0 WHERE userID='" + clsUsers.userID + "'";
                Database.Execute(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on logging out: " + ex.Message);
            }
            //logs, logout
        }

        public string SelectStocksRunningOut() {
            string num = "0";
            try {
                string query = "SELECT COUNT(DISTINCT product_ID) AS numProduct FROM stocks WHERE remaining_stocks<=10 AND date_deleted IS NULL";
                num = Database.Select(query)[0];
            } catch (Exception ex) {
                Console.WriteLine("Error on logging out: " + ex.Message);
            }
            return num;
        }
    }
}
