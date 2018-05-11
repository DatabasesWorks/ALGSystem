using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContSales {
        DbConnection Database = new DbConnection();

        public List<string> LoadUsers() {
            List<string> list = new List<string>();
            list = null;
            try {
                string query = "SELECT CONCAT(gName,' ',IF(TRIM(mInitial) = '','',CONCAT(mInitial,'.')),' ',fName) FROM users";
                list = Database.Select(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading users. " + ex.Message, "Sales Report", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return list;
        }

        public System.Data.DataTable LoadPayments(string userName, string dateStart, string dateEnd) {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query;
                if (userName=="All")
                 query = $"SELECT DATE_FORMAT(date_paid, '%M %d %Y') AS datePaid, SUM(payment) AS sumPayment, CONCAT(gName,' ',IF(TRIM(mInitial) = '','',CONCAT(mInitial,'.')),' ',fName) AS userName FROM payments INNER JOIN users ON payments.user_ID = users.userID WHERE(DATE_FORMAT(date_paid, '%M %d %Y') BETWEEN DATE_FORMAT('{dateStart}', '%M %d %Y') AND DATE_FORMAT('{dateEnd}', '%M %d %Y')) GROUP BY datePaid, user_ID";
                else {
                    query = $"SELECT DATE_FORMAT(date_paid, '%M %d %Y') AS datePaid, SUM(payment) AS sumPayment, CONCAT(gName,' ',IF(TRIM(mInitial) = '','',CONCAT(mInitial,'.')),' ',fName) AS userName FROM payments INNER JOIN users ON payments.user_ID = users.userID WHERE(DATE_FORMAT(date_paid, '%M %d %Y') BETWEEN DATE_FORMAT('{dateStart}', '%M %d %Y') AND DATE_FORMAT('{dateEnd}', '%M %d %Y')) AND (CONCAT(gName,' ',CONCAT(mInitial,'.'),' ',fName )='{userName}' OR CONCAT(gName,' ',fName )='{userName}') GROUP BY datePaid, user_ID";
                }
                    
                dt = Database.Retrieve(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading payments. " + ex.Message, "Sales Report", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return dt;
        }

        public List<string> GetTransactionsTotal(string dateStart, string dateEnd) {
            List<string> list = new List<string>();
            list = null;
            try {
                string query = $"SELECT SUM(discounted_amount) AS totalDiscAmount, SUM(vatable_sales) AS totalVatable, SUM(vat) AS totalVat FROM transactions WHERE balance=0.00 AND (DATE_FORMAT(date_transact, '%M %d %Y') BETWEEN DATE_FORMAT('{dateStart}', '%M %d %Y') AND DATE_FORMAT('{dateEnd}', '%M %d %Y'))";
                list = Database.Select(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading transactions total. " + ex.Message, "Sales Report", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return list;
        }

        public List<string> GetBalance(string dateStart, string dateEnd) {
            List<string> list = new List<string>();
            list = null;
            try {
                string query = $"SELECT IF(SUM(balance) IS NULL, 0, SUM(balance)) AS totalBalance, COUNT(balance) AS balanceCount FROM transactions WHERE balance!=0.00 AND (DATE_FORMAT(date_transact, '%M %d %Y') BETWEEN DATE_FORMAT('{dateStart}', '%M %d %Y') AND DATE_FORMAT('{dateEnd}', '%M %d %Y'))";
                list = Database.Select(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading transactions total. " + ex.Message, "Sales Report", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return list;
        }
    }
}
