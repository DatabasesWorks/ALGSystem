using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace ALG_POS_and_Inventory_Management_System {
    class ContLogin {
        DbConnection Database = new DbConnection();
        public void InsertUser(string userName, string password) {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] hash = SHA256.Create().ComputeHash(data);
            string query = "INSERT INTO users SET username=@0, password=@1";
            string[] param = { userName, System.Text.Encoding.UTF8.GetString(hash)};
            Database.Execute(query, param);
            System.Windows.Forms.MessageBox.Show("User Set");
        }

        public List<string> Authenticate(string userName, string password) {
            try {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hash = SHA256.Create().ComputeHash(data);
                string query = "SELECT userID, CONCAT(fName,' ,',gName,' ',mInitial) AS Name, user_type, login_status FROM users WHERE username=@0 AND password=@1";
                string[] param = { userName, System.Text.Encoding.UTF8.GetString(hash) };
                List<string> result = new List<string>();
                result = Database.Select(query, param);
                if (result != null) {
                    clsUsers.userID = result[0];
                    clsUsers.userName = result[1];
                    clsUsers.userType = result[2];
                    clsUsers.isLogin = result[3];
                    UpdateLoginStatus();
                }
                return result;
            } catch (Exception /*ex*/) {
                //System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public void UpdateLoginStatus() {
            string query = "UPDATE users SET login_status=1 WHERE userID='" + clsUsers.userID + "'";
            Database.Execute(query);
        }
        public void UnlockAll() {
            string query = "UPDATE users SET login_status=0";
            Database.Execute(query);
        }
        public void Logout() {

        }
    }
}
