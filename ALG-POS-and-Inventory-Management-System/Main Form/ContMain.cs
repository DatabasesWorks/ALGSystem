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
                string query = "SELECT product_ID FROM stocks WHERE date_deleted IS NULL GROUP BY product_ID HAVING SUM(remaining_stocks)<=(SELECT critical_stock_warning FROM settings)";
                num = Database.Select(query).Count.ToString();
            } catch (Exception ex) {
                Console.WriteLine("Error on logging out: " + ex.Message);
            }
            return num;
        }
    }
}
