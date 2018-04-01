using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContMain {
        DbConnection Database = new DbConnection();
        public void Logout() {
            string query = "UPDATE users SET login_status=0 WHERE userID='" + clsUsers.userID + "'";
            Database.Execute(query);
        }
    }
}
