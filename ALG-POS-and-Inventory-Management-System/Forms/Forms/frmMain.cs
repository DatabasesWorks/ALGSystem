using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form {
        frmLogin frmlogin = new frmLogin();
        classDatabaseConnect dbcon = new classDatabaseConnect();
        clsLogs log = new clsLogs();
        bool f = false;
        clsUser user = new clsUser();
        string date = "";
        public static int count = 0;
        public frmMain() {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e) {
            Login();
            date = System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            //  clsUser clsUser = new clsUser(); --- supposse to create a new object but doesn't work
            //used the clsUser user object from frmLogin :(
            if (user.GetPrivelege() == null) {
                Close();
            }
            timer1.Enabled = true;
        }
        private void Login() {
            frmlogin.ShowDialog();
            if (user.GetPrivelege() == "admin") {
                //this.clerkPanel.SendToBack();
                clerkPanel.Visible = false;
                splitCont.Visible = true;
                btnCollapse.Visible = true;
                // this.sidePanel.Visible = true;
                //this.btnCollapse.Visible = true;
                timer1.Enabled = true;
                btnLogout.Visible = true;
            } else if (user.GetPrivelege() == "cashier") {
                btnCollapse.Visible = false;
                UCPointOfSale ucpointofsale = new UCPointOfSale();
                clerkPanel.Controls.Clear();
                clerkPanel.Controls.Add(ucpointofsale);
                btnCollapse.Visible = false;
                splitCont.Visible = false;
                timer1.Enabled = true;
                btnLogout.Visible = true;
            } else if (user.GetPrivelege() == "encoder") {
                btnCollapse.Visible = false;
                UCInventory ucinventory = new UCInventory();
                clerkPanel.Controls.Clear();
                clerkPanel.Controls.Add(ucinventory);
                btnCollapse.Visible = false;
                splitCont.Visible = false;
                timer1.Enabled = true;
                btnLogout.Visible = true;
            } else {
                Close();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            ClosingTheForm();
        }
        private void ClosingTheForm() {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                string query = "UPDATE users SET login_status=0 WHERE userID='" + user.GetUserID() + "'";
                dbcon.ManipulateData(query);

                string uid = user.GetUserID();
                log.userLogout(uid, date, "Logged Out");
                Close();
            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }
        private void ucFunctions1_Load(object sender, EventArgs e) {

        }

        private void ucFunctions2_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            UCInventory ucinventory = new UCInventory();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(ucinventory);
        }

        private void ucFunctions2_Load_1(object sender, EventArgs e) {

        }

        private void button4_Click_1(object sender, EventArgs e) {

        }

        private void button6_Click(object sender, EventArgs e) {
            //for  point of sale
            UCPointOfSale ucpointofsale = new UCPointOfSale();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(ucpointofsale);

        }

        private void button2_Click_1(object sender, EventArgs e) {
            //for inventory
            UCInventory ucinventory = new UCInventory();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(ucinventory);
            ucinventory.Dock = DockStyle.Fill;
        }

        private void button3_Click_1(object sender, EventArgs e) {
            //for reports
            ucReports rep = new ucReports();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(rep);
            rep.Dock = DockStyle.Fill;
        }

        private void button4_Click_2(object sender, EventArgs e) {
            ucServices ucservices = new ucServices();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(ucservices);
            ucservices.Dock = DockStyle.Fill;

        }

        private void button5_Click(object sender, EventArgs e) {
            //ucLogsAndMaintenance uclogsandmaintenance = new ucLogsAndMaintenance();

            //myPanel.Controls.Add(uclogsandmaintenance);
        }

        private void button7_Click(object sender, EventArgs e) {
            Logout();
        }
        private void Logout() {
            if (count != 3) {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    string query = "UPDATE users SET login_status=0 WHERE userID='" + user.GetUserID() + "'";
                    dbcon.ManipulateData(query);
                    splitCont.Panel2.Controls.Clear();
                    clerkPanel.Controls.Clear();
                    clerkPanel.Visible = true;
                    splitCont.Visible = false;
                    frmlogin.txtUN.Text = "";
                    frmlogin.txtPW.Text = "";
                    btnCollapse.Visible = false;
                    frmlogin.user.SetGName(null);
                    frmlogin.user.SetUserID(null);
                    frmlogin.user.SetPrivelge(null);
                    btnLogout.Visible = false;
                    Login();

                    string uid = user.GetUserID();
                    log.userLogout(uid, date, "Logged Out");
                    
                } else if (dialogResult == DialogResult.No) {
                    //do something else
                }
            } else {
                string query = "UPDATE users SET login_status=0 WHERE userID='" + user.GetUserID() + "'";
                dbcon.ManipulateData(query);
                splitCont.Panel2.Controls.Clear();
                clerkPanel.Controls.Clear();
                clerkPanel.Visible = true;
                splitCont.Visible = false;
                frmlogin.txtUN.Text = "";
                frmlogin.txtPW.Text = "";
                btnCollapse.Visible = false;
                frmlogin.user.SetGName(null);
                frmlogin.user.SetUserID(null);
                frmlogin.user.SetPrivelge(null);
                Login();
                count = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e) {
            count++;
            if (count == 600000) {
                Logout();
            }
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e) {
            count = 0;
        }
        private void btnManageEmp_Click(object sender, EventArgs e) {
            UCEmployeeInfo employee = new UCEmployeeInfo();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(employee);
        }

        private void btnManageUsers_Click(object sender, EventArgs e) {
            UCManageUser manage = new UCManageUser();
            //frmMain frmmain = new frmMain();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(manage);
        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            frmManageCustomer cv = new frmManageCustomer();
            cv.ShowDialog();
            //UCCustomerRecord cust = new UCCustomerRecord();
            //splitCont.Panel2.Controls.Clear();
            //splitCont.Panel2.Controls.Add(cust);
        }

        private void btnLogs_Click(object sender, EventArgs e) {
            ucLogs logs = new ucLogs();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(logs);
        }

        private void button6_Click_1(object sender, EventArgs e) {

            UCPointOfSale ucpointofsale = new UCPointOfSale();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(ucpointofsale);
            ucpointofsale.Dock = DockStyle.Fill;
        }

        private void btnPos_MouseEnter(object sender, EventArgs e) {
            //this.btnPOS.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pos_firebrick));
            //btnPOS.UseVisualStyleBackColor = false;
            //btnPOS.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void btnPos_MouseLeave(object sender, EventArgs e) {
            //this.btnPOS.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pos_white));
            btnPOS.BackColor = Color.Transparent;
        }

        private void btnCollapse_Click(object sender, EventArgs e) {
            if (f == false) {
                splitCont.Panel1Collapsed = true;
                f = true;
            } else {
                splitCont.Panel1Collapsed = false;

                f = false;
            }

        }

        private void button2_Click_2(object sender, EventArgs e) {
            splitCont.Panel2.Controls.Clear();
            maintenancePanel.Visible = true;
            splitCont.Panel2.Controls.Add(maintenancePanel);
            maintenancePanel.Dock = DockStyle.Fill;
        }

        private void btnInventory_MouseEnter(object sender, EventArgs e)
        {
            btnInventory.UseVisualStyleBackColor = false;
            //btnInventory.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void btnInventory_MouseLeave(object sender, EventArgs e) {
            btnInventory.BackColor = Color.Transparent;
        }

        private void btnReports_MouseEnter(object sender, EventArgs e) {
            //btnReports.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void btnReports_MouseLeave(object sender, EventArgs e) {
            btnReports.BackColor = Color.Transparent;
        }

        private void btnServices_MouseEnter(object sender, EventArgs e) {
            //btnServices.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

        }

        private void btnServices_MouseLeave(object sender, EventArgs e) {
            btnServices.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e) {
            //button2.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void button2_MouseLeave(object sender, EventArgs e) {
            button2.BackColor = Color.Transparent;
        }
        private void frmMain_KeyDown(object sender, KeyEventArgs e) {
            if (e.Alt && e.KeyCode == Keys.F4)
                ClosingTheForm();
        }

        private void maintenancePanel_MouseMove(object sender, MouseEventArgs e) {
            count = 0;
        }

        private void splitCont_Panel1_MouseMove(object sender, MouseEventArgs e) {
            count = 0;
        }

        private void splitCont_MouseMove(object sender, MouseEventArgs e) {
            count = 0;
        }

        private void clerkPanel_MouseMove(object sender, MouseEventArgs e) {
            count = 0;

        }

        private void maintenancePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitCont_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
