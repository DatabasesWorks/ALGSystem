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
    public partial class frmLogin : Form {
        ContLogin contObj = new ContLogin();
        public frmLogin() {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e) {
            lblDateTime.Text = System.DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnINsert_Click(object sender, EventArgs e) {
            contObj.InsertUser(txtUN.Text, txtPW.Text);
        }
        private void btnOK_Click(object sender, EventArgs e) {
            if (txtUN.Text.Trim() == "") {
                MessageBox.Show("Please input username", "Login", MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
            }else if (txtPW.Text.Trim() == "") {
                MessageBox.Show("Please input password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (contObj.Authenticate(txtUN.Text.Trim(), txtPW.Text.Trim()) == null) {
                MessageBox.Show("Invalid username or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            } else if (clsUsers.isLogin=="1") {
                MessageBox.Show("User is logged-in in other computer", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            } else {
                MessageBox.Show("Welcome '" +clsUsers.userName + "'!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void cbPass_CheckedChanged(object sender, EventArgs e) {
            if (this.cbPass.Checked) {
                txtPW.PasswordChar = '\0';
            } else {
                txtPW.PasswordChar = '•';
            }
        }
        private void label5_Click(object sender, EventArgs e) {
            contObj.UnlockAll();
        }
        private void frmLogin_Load(object sender, EventArgs e) {
            txtUN.Text = ""; txtPW.Text = ""; cbPass.Checked = false;
        }

        private void frmLogin_DoubleClick(object sender, EventArgs e) {
            frmConfigs frmconfig = new frmConfigs();
            frmconfig.ShowDialog();
        }
    }
}
