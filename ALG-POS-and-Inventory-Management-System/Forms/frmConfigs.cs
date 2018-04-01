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
    public partial class frmConfigs : Form {
        public frmConfigs() {
            InitializeComponent();
        }

        private void frmConfigs_Load(object sender, EventArgs e) {
           txtDbAddress.Text = Properties.Settings.Default.dbIpAddress;
           txtName.Text  = Properties.Settings.Default.dbName;
           txtUN.Text = Properties.Settings.Default.dbUsername;
           txtDbAddress.Text = Properties.Settings.Default.dbPassword;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (txtDbAddress.Text.Trim() == "") {
                MessageBox.Show("Please input database ip address", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDbAddress.Focus();
                return;
            } else if (txtName.Text.Trim() == "") {
                MessageBox.Show("Please input database name", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtName.Focus();
                return;
            } else if (txtUN.Text.Trim() == "") {
                MessageBox.Show("Please input username", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtUN.Focus();
                return;
            //} else if (txtPW.Text.Trim() == "") {
            //    MessageBox.Show("Please input password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    txtPW.Focus();
            //    return;
            } else {
                string pw="";
                if(txtPW.Text.Trim() == "") {
                    pw = null;
                }
                Properties.Settings.Default.dbIpAddress = txtDbAddress.Text;
                Properties.Settings.Default.dbName = txtName.Text;
                Properties.Settings.Default.dbUsername = txtUN.Text;
                Properties.Settings.Default.dbPassword = pw;
                Properties.Settings.Default.Save();
                MessageBox.Show("Configurations Saved!");
            }
        }
    }
}
