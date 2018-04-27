using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ALG_POS_and_Inventory_Management_System {
    public partial class frmConfigs : Form {
        public frmConfigs() {
            InitializeComponent();
        }

        private void frmConfigs_Load(object sender, EventArgs e) {
            txtMyIP.Text = GetLocalIPAddress();
            txtDbAddress.Text = Properties.Settings.Default.dbIpAddress;
            txtName.Text  = Properties.Settings.Default.dbName;
            txtUN.Text = Properties.Settings.Default.dbUsername;
            txtPW.Text = Properties.Settings.Default.dbPassword;
        }

        public static string GetLocalIPAddress() {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList) {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
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
                    pw = txtPW.Text.Trim();
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
