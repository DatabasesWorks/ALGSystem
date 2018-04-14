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
    public partial class frmMain : Form {
        frmLogin login = new frmLogin();
        ContMain contObj = new ContMain();
        public frmMain() {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e) {
            Login();
        }
        void Login() {
            this.Hide();
            login.ShowDialog();
            if (clsUsers.userID == null) {
                this.Close();
            }else if(clsUsers.userType == "admin") {
                clerkPanel.Visible = false;
                splitCont.Visible = true;
                btnCollapse.Visible = true;
                //timer1.Enabled = true;    -for idle program in the future, logsout
                btnLogout.Visible = true;
                this.Show();
            } else if (clsUsers.userType == "cashier") {
                btnCollapse.Visible = false;
                //UCPointOfSale ucpointofsale = new UCPointOfSale();
                clerkPanel.Controls.Clear();
                //clerkPanel.Controls.Add(ucpointofsale);
                btnCollapse.Visible = false;
                splitCont.Visible = false;
                //timer1.Enabled = true;     -for idle program in the future, logsout
                btnLogout.Visible = true;
                this.Show();
            } else if (clsUsers.userType == "encoder") {
                btnCollapse.Visible = false;
                //UCInventory ucinventory = new UCInventory();
                clerkPanel.Controls.Clear();
                //clerkPanel.Controls.Add(ucinventory);
                btnCollapse.Visible = false;
                splitCont.Visible = false;
                //timer1.Enabled = true;     -for idle program in the future, logsout
                btnLogout.Visible = true;
                this.Show();
            } else {
                Close();
            }
        }
        private void btnClose_Click(object sender, EventArgs e) {
            CloseExit();
        }
        private void frmMain_KeyDown(object sender, KeyEventArgs e) {
            if (e.Alt && e.KeyCode == Keys.F4)
                CloseExit();
        }
        void CloseExit() {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "ALG Autocare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                contObj.Logout();
                this.Close();
            }
        }
        void Logout() {
            contObj.Logout();
            if (true/*count != 3*/) {
                splitCont.Panel2.Controls.Clear();
                clerkPanel.Controls.Clear();
                clerkPanel.Visible = true;
                splitCont.Visible = false;
                btnCollapse.Visible = false;
                clsUsers.userID = null;
                clsUsers.userName = null;
                clsUsers.userType = null;
                clsUsers.isLogin = null;
                btnLogout.Visible = false;
                Login();
                login.txtUN.Text = "";
                login.txtPW.Text = "";
            } else {
                splitCont.Panel2.Controls.Clear();
                clerkPanel.Controls.Clear();
                clerkPanel.Visible = true;
                splitCont.Visible = false;
                login.txtUN.Text = "";
                login.txtPW.Text = "";
                btnCollapse.Visible = false;
                clsUsers.userID = null;
                clsUsers.userName = null;
                clsUsers.userType = null;
                clsUsers.isLogin = null;
                Login();
                //count = 0;
            }
            //--- for logs
            //string uid = clsUsers.userID;
            //log.userLogout(uid, date, "Logged Out");
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "ALG Autocare", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                Logout();
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            splitCont.Panel2.Controls.Clear();
            uCInventory usercontrol = new uCInventory();
            splitCont.Panel2.Controls.Add(usercontrol);
        }
        int i = 0;
        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                splitCont.Panel1Collapsed=true;
                i = 1;
            }
            else
            {
                splitCont.Panel1Collapsed = false;
                i = 0;
            }
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            splitCont.Panel2.Controls.Clear();
            uCServices usercontrol = new uCServices();
            splitCont.Panel2.Controls.Add(usercontrol);
        }

        private void btnLogsAndMaintenance_Click(object sender, EventArgs e)
        {
            splitCont.Panel2.Controls.Clear();
            maintenancePanel.Visible = true;
            splitCont.Panel2.Controls.Add(maintenancePanel);
            maintenancePanel.Dock = DockStyle.Fill;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            splitCont.Panel2.Controls.Clear();
            uCPointOfSale usercontrol = new uCPointOfSale();
            splitCont.Panel2.Controls.Add(usercontrol);
        }

        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            uCManageEmployeeInfo employee = new uCManageEmployeeInfo();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(employee);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            uCCustomerRecords customer = new uCCustomerRecords();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(customer);
        }
    }
}
