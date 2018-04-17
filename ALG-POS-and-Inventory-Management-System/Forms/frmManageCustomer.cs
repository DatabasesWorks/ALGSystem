using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALG_POS_and_Inventory_Management_System
{
    public partial class frmManageCustomer : Form
    {
        ContManageCustomer contCustomer = new ContManageCustomer();
        bool custadd = false, custedit = false;
        string tempOldName;
        string Fullname;
        public frmManageCustomer()
        {
            InitializeComponent();
        }

        private void CustLock()
        {
            txtCustID.Enabled = txtGN.Enabled = txtFN.Enabled = txtMI.Enabled = txtAddress.Enabled = txtContact.Enabled = false;
        }
        private void CustUnLock()
        {
            txtCustID.Enabled = txtGN.Enabled = txtFN.Enabled = txtMI.Enabled = txtAddress.Enabled = txtContact.Enabled = true;
        }
        private void CustClear()
        {
            txtCustID.Text = txtGN.Text = txtFN.Text = txtMI.Text = txtAddress.Text = txtContact.Text = "";
            custadd = custedit = false;
        }

        void LoadCustomer()
        {
            lvCust.Items.Clear();
            DataTable dt = new DataTable();
            dt = contCustomer.LoadCustomer();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["cust_ID"].ToString());
                listitem.SubItems.Add(dr["fName"].ToString());
                listitem.SubItems.Add(dr["gName"].ToString());
                listitem.SubItems.Add(dr["mInitial"].ToString());
                listitem.SubItems.Add(dr["contact_num"].ToString());
                listitem.SubItems.Add(dr["address"].ToString());
                lvCust.Items.Add(listitem);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            btnEdit.Enabled = false; btnSave.Enabled = true; custedit = true; btnDelete.Enabled = false; CustUnLock(); txtCustID.Enabled = false;
            Fullname = txtGN.Text +" "+ txtMI.Text +". "+ txtFN.Text;
            tempOldName = Fullname;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Customer?", "Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (contCustomer.IsDeleteCustomer(txtCustID.Text))
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

        private void btnCustClear_Click(object sender, EventArgs e)
        {
            LoadCustomer(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; CustClear(); CustLock();
            custadd = custedit = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFN.Text.Trim() == "" || txtGN.Text.Trim() == "" || txtMI.Text.Trim() == "" || txtContact.Text.Trim() == "" || txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please fill-up all fields", "Customer");
            }
            else
            {
                if (custadd)
                {
                    Fullname = txtGN.Text + " " + txtMI.Text + ". " + txtFN.Text;
                    tempOldName = Fullname;
                    if (contCustomer.IsInsertCustomers(Fullname, txtFN.Text, txtGN.Text, txtMI.Text, txtContact.Text, txtAddress.Text))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.addSupplier(uid, date, sprodid, "Added Supplier ");
                        btnCustClear.PerformClick();
                    }
                }
                else if (custedit)
                {
                    if (contCustomer.IsUpdateCustomer(Fullname, txtFN.Text, txtGN.Text, txtMI.Text, txtContact.Text, txtAddress.Text, tempOldName))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.editSupplier(uid, date, sprodid, "Added Supplier ");
                        btnCustClear.PerformClick();
                    }
                }
            }
        }

        private void frmManageCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void lvCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCust.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCust.SelectedItems[0];
                txtCustID.Text = item.SubItems[1].Text;
                txtFN.Text = item.SubItems[2].Text;
                txtGN.Text = item.SubItems[3].Text;
                txtMI.Text = item.SubItems[4].Text;
                txtContact.Text = item.SubItems[5].Text;
                txtAddress.Text = item.SubItems[6].Text;
                btnAdd.Enabled = false; btnEdit.Enabled = true; btnDelete.Enabled = true; btnSave.Enabled = false; custadd = false; custedit = false; CustLock();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProdPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            btnAdd.Enabled = false; btnSave.Enabled = true; CustUnLock(); custadd = true; txtCustID.Enabled = false;
        }
    }
}
