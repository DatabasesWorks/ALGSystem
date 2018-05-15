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
    public partial class frmSettings : Form {

        ContSettings contobj = new ContSettings();

        public frmSettings() {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e) {
            LoadSettings();
        }

        void LoadSettings() {
            try {
                DataTable dt = new DataTable();
                dt = contobj.LoadSettings();
                DataRow dr = dt.Rows[0];
                //taxpayer_name, business_name, tax_identification_number, branch_code, machine_identification_number, business_address, vat_percent, critical_stock_warning
                txtTpName.Text = dr["taxpayer_name"].ToString();
                txtBName.Text = dr["business_name"].ToString();
                txtTin.Text = dr["tax_identification_number"].ToString();
                txtBcode.Text = dr["branch_code"].ToString();
                txtMIDNum.Text = dr["machine_identification_number"].ToString();
                txtBAddress.Text = dr["business_address"].ToString();
                numVatPerc.Value = Convert.ToDecimal(dr["vat_percent"].ToString());
                numWarning.Value = Convert.ToDecimal(dr["critical_stock_warning"].ToString());
            } catch (Exception ex) {
                MessageBox.Show("Error on loading settings: " + ex.Message, "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                if (contobj.IsSaved(txtTpName.Text, txtBName.Text, txtTin.Text, txtBcode.Text, txtMIDNum.Text, txtBAddress.Text, numVatPerc.Value.ToString(), numWarning.Value.ToString())) {
                    MessageBox.Show("Settings saved successfully.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSettings();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error on saving settings: " + ex.Message, "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
