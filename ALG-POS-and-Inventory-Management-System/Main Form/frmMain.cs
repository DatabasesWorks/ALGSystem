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
                timerCritStock.Enabled = true;
                picWarning.Visible = lblWarning.Visible = true;
                //timer1.Enabled = true;    -for idle program in the future, logsout
                btnLogout.Visible = true;
                this.Show();
            } else if (clsUsers.userType == "cashier") {
                btnCollapse.Visible = false;
                uCPointOfSale ucpointofsale = new uCPointOfSale();
                clerkPanel.Controls.Clear();
                clerkPanel.Controls.Add(ucpointofsale);
                btnCollapse.Visible = false;
                splitCont.Visible = false;
                timerCritStock.Enabled = false;
                picWarning.Visible = lblWarning.Visible = false;
                //timer1.Enabled = true;     -for idle program in the future, logsout
                btnLogout.Visible = true;
                this.Show();
            } else if (clsUsers.userType == "encoder") {
                btnCollapse.Visible = false;
                uCInventory ucinventory = new uCInventory();
                clerkPanel.Controls.Clear();
                clerkPanel.Controls.Add(ucinventory);
                btnCollapse.Visible = false;
                splitCont.Visible = false;
                timerCritStock.Enabled = true;
                picWarning.Visible = lblWarning.Visible = true;
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
            uCInventoryStocksProduct.showRunningOut = false;
        }

        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            uCManageEmployeeInfo employee = new uCManageEmployeeInfo();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(employee);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmManageCustomer customer = new frmManageCustomer();
            //splitCont.Panel2.Controls.Clear();
            //splitCont.Panel2.Controls.Add(customer);
            customer.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            uCManageUsers user = new uCManageUsers();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(user);
        }

        private void btnLogs_Click(object sender, EventArgs e) {
            ucTransactionLogs user = new ucTransactionLogs();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(user);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            string num = contObj.SelectStocksRunningOut();
            if (num != "0") {
                lblWarning.Text = num;
                lblWarning.Visible = picWarning.Visible = true;
            } else {
                lblWarning.Visible = picWarning.Visible = false;
            }
        }

        private void picWarning_Click(object sender, EventArgs e) {
            string num = contObj.SelectStocksRunningOut();
            MessageBox.Show(num + " products are running out of stocks", "ALG Autocare", MessageBoxButtons.OK,MessageBoxIcon.Information);
            uCInventoryStocksProduct.showRunningOut = true;
            splitCont.Panel2.Controls.Clear();
            uCInventory usercontrol = new uCInventory();
            splitCont.Panel2.Controls.Add(usercontrol);
            usercontrol.tabInventory.SelectedIndex = 1 ;
        }

        private void btnSales_Click(object sender, EventArgs e) {
            frmSales frmSales = new frmSales();
            frmSales.ShowDialog();
        }
    }
}
