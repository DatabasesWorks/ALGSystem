using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALG_POS_and_Inventory_Management_System {
    public partial class frmManageSettings : Form {
        public frmManageSettings() {
            InitializeComponent();
        }

        private void btnProdSave_Click(object sender, EventArgs e) {

        }

        private void frmManageSettings_Load(object sender, EventArgs e) {
            LoadSettings();
        }

        //no controller
        void LoadSettings() {
            try {
                DbConnection db = new DbConnection();
                DataTable table = new DataTable();
                string query = "SELECT tax_identification_number, business_name, business_address, vat_percent, critical_stock_warning FROM settings";
                table = db.Retrieve(query);
                for(int i=0; i<table.Rows.Count; i++) {
                    DataRow dr = table.Rows[i];
                    txtTin.Text = dr["tax_identification_number"].ToString();
                    txtBusinessName.Text = dr["business_name"].ToString();
                    txtBusinessAddress.Text = dr["business_address"].ToString();
                    numVat.Value = Convert.ToDecimal(dr["vat_percent"].ToString());
                    numCritStock.Value = Convert.ToDecimal(dr["critical_stock_warning"].ToString());
                }
            } catch (Exception ex) {
                MessageBox.Show("Error on loading settings: " + ex.Message, "Manage Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SaveToDB() {
            if(txtTin.Text.Trim() == "" || txtBusinessName.Text.Trim() == "" || txtBusinessAddress.Text.Trim() == "") {
                MessageBox.Show("Please provide business informations. ", "Manage Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(numCritStock.Value == 0) {
                MessageBox.Show("Please provide critical stock value. ", "Manage Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try {
                DbConnection db = new DbConnection();
                DataTable table = new DataTable();
                string query = "DELETE FROM settings";
                if (db.Execute(query)) {
                    query = "INSERT INTO settings SET tax_identification_number=@0, business_name=@1, business_address=@2, vat_percent=@3, critical_stock_warning=@4 FROM settings";
                    string[] param = { txtTin.Text, txtBusinessName.Text, txtBusinessAddress.Text, txtBusinessAddress.Text, numVat.Value.ToString() };
                    if (db.Execute(query,param)) {
                        MessageBox.Show("Settings saved!. ", "Manage Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                        MessageBox.Show("An error occured while saving settings", "Manage Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } catch (Exception ex) {
                MessageBox.Show("An error occured: " + ex, "Manage Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
