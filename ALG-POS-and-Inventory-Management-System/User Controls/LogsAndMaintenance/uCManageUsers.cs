using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALG_POS_and_Inventory_Management_System {
    public partial class uCManageUsers : UserControl {
        ContManageUsers contUser = new ContManageUsers();
        bool useradd = false, useredit = false;
        string tempOldName;
        string Fullname;
        public uCManageUsers() {
            InitializeComponent();
        }

        private void UserLock()
        {
            txtUserNo.Enabled = txtGN.Enabled = txtFN.Enabled = txtMI.Enabled = txtAddress.Enabled = txtUN.Enabled = txtPW.Enabled = cboType.Enabled = false;
        }
        private void UserUnLock()
        {
            txtUserNo.Enabled = txtGN.Enabled = txtFN.Enabled = txtMI.Enabled = txtAddress.Enabled = txtUN.Enabled = txtPW.Enabled = cboType.Enabled = true;
        }
        private void UserClear()
        {
            txtUserNo.Text = txtGN.Text = txtFN.Text = txtMI.Text = txtAddress.Text = txtUN.Text = txtPW.Text = cboType.Text = "";
            useradd = useredit = false;
        }

        void LoadUser()
        {
            lvUsers.Items.Clear();
            DataTable dt = new DataTable();
            dt = contUser.LoadUser();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["userID"].ToString());
                listitem.SubItems.Add(dr["fName"].ToString());
                listitem.SubItems.Add(dr["gName"].ToString());
                listitem.SubItems.Add(dr["mInitial"].ToString());
                listitem.SubItems.Add(dr["user_address"].ToString());
                listitem.SubItems.Add(dr["username"].ToString());
                listitem.SubItems.Add(dr["password"].ToString());
                listitem.SubItems.Add(dr["user_type"].ToString());
                lvUsers.Items.Add(listitem);
            }
        }

        private void btnProdEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false; btnSave.Enabled = true; useredit = true; btnDelete.Enabled = false; UserUnLock(); txtUserNo.Enabled = false;
            Fullname = txtGN.Text + " " + txtMI.Text + ". " + txtFN.Text;
            tempOldName = Fullname;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this User?", "User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (contUser.IsDeleteUser(txtUserNo.Text))
                {
                    // ======= logs
                    //string sprodid = stock.product_ID;
                    //string uid = user.GetUserID();
                    //log.deleteSupplier(uid, date, sprodid, "Delete Supplier");
                    btnClear.PerformClick();

                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadUser(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; UserClear(); UserLock();
            useradd = useredit = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFN.Text.Trim() == "" || txtGN.Text.Trim() == "" || txtMI.Text.Trim() == "" || txtUN.Text.Trim() == "" || txtPW.Text.Trim() == "" || txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please fill-up all fields", "User");
            }
            else
            {
                if (useradd)
                {
                    Fullname = txtGN.Text + " " + txtMI.Text + ". " + txtFN.Text;
                    tempOldName = Fullname;
                    if (contUser.IsInsertUsers(Fullname, txtFN.Text, txtGN.Text, txtMI.Text, txtAddress.Text, txtUN.Text, txtPW.Text, cboType.Text))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.addSupplier(uid, date, sprodid, "Added Supplier ");
                        btnClear.PerformClick();
                    }
                }
                else if (useredit)
                {
                    if (contUser.IsUpdateUser(Fullname, txtFN.Text, txtGN.Text, txtMI.Text, txtAddress.Text, txtUN.Text, txtPW.Text, cboType.Text, tempOldName))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.editSupplier(uid, date, sprodid, "Added Supplier ");
                        btnClear.PerformClick();
                    }
                }
            }
        }

        private void uCManageUsers_Load(object sender, EventArgs e)
        {
            LoadUser();
            cboType.Items.Clear(); 
            cboType.Items.Add("admin");
            cboType.Items.Add("cashier");
            cboType.Items.Add("encoder");
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count > 0)
            {
                ListViewItem item = lvUsers.SelectedItems[0];
                txtUserNo.Text = item.SubItems[1].Text;
                txtFN.Text = item.SubItems[2].Text;
                txtGN.Text = item.SubItems[3].Text;
                txtMI.Text = item.SubItems[4].Text;
                txtAddress.Text = item.SubItems[5].Text;
                txtUN.Text = item.SubItems[6].Text;
                txtPW.Text = item.SubItems[7].Text;
                cboType.Text = item.SubItems[8].Text;
                btnAdd.Enabled = false; btnEdit.Enabled = true; btnDelete.Enabled = true; btnSave.Enabled = false; useredit = false; useradd = false; UserLock();
            }
        }

        private void btnProdAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false; btnSave.Enabled = true; UserUnLock(); useradd = true; txtUserNo.Enabled = false;
        }
    }
}
