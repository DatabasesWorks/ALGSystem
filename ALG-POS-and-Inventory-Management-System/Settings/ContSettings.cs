using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALG_POS_and_Inventory_Management_System {
    class ContSettings {
        DbConnection Database = new DbConnection();

        public System.Data.DataTable LoadSettings() {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = null;
            try {
                string query = "SELECT taxpayer_name, business_name, tax_identification_number, branch_code, machine_identification_number, business_address, vat_percent, critical_stock_warning FROM settings";
                dt = Database.Retrieve(query);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on loading settings.: " + ex.Message , "Settings", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return dt;
        }

        public bool IsSaved(string taxpayer, string business, string tin, string branch, string mid, string address, string vat, string crit) {
            bool status = false;
            try {
                string query = "DELETE FROM settings";
                if (Database.Execute(query)) {
                    query = "INSERT INTO settings SET taxpayer_name=@0, business_name=@1, tax_identification_number=@2, branch_code=@3, machine_identification_number=@4, business_address=@5, vat_percent=@6, critical_stock_warning=@7";
                    string[] param = { taxpayer, business, tin, branch, mid, address, vat, crit };
                    if (Database.Execute(query, param))
                        status = true;
                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error on saving settings.: " + ex.Message, "Settings", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
