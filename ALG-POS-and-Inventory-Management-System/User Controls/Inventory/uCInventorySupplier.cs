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
    public partial class uCInventorySupplier : UserControl {
        ContInventorySuppliers contSuppliers = new ContInventorySuppliers();
        bool supadd = false, supedit = false;
        string tempOldName;
        public uCInventorySupplier() {
            InitializeComponent();
        }

        private void uCInventorySupplier_Load(object sender, EventArgs e) {
            LoadSuppliers();
        }

        private void SupLock() {
            txtSupplierName.Enabled = txtSupplierAddress.Enabled =  txtSupplierContact.Enabled = false;
        }
        private void SupUnLock() {
            txtSupplierName.Enabled = txtSupplierAddress.Enabled = txtSupplierContact.Enabled = true;
        }
        private void SupClear() {
            txtSupplierName.Text = txtSupplierAddress.Text = txtSupplierContact.Text = lblSupplierID.Text = "";
            supadd = supedit = false;
        }
        void LoadSuppliers() {
            lvSupplier.Items.Clear();
            DataTable dt = new DataTable();
            dt = contSuppliers.LoadSuppliers();
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["supplier_ID"].ToString());
                listitem.SubItems.Add(dr["supplier_name"].ToString());
                listitem.SubItems.Add(dr["address"].ToString());
                listitem.SubItems.Add(dr["contact"].ToString());
                lvSupplier.Items.Add(listitem);
            }
        }
        private void btnSupAdd_Click(object sender, EventArgs e) {
            btnSupAdd.Enabled = false; btnSupSave.Enabled = true; SupUnLock(); supadd = true;
        }

        private void btnSupEdit_Click(object sender, EventArgs e) {
            btnSupEdit.Enabled = false; btnSupSave.Enabled = true; supedit = true; btnSupDelete.Enabled = false; SupUnLock();
            tempOldName = txtSupplierName.Text;
        }

        private void btnSupDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this supplier?", "Suppliers", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                if(contSuppliers.IsDeleteSupplier(lblSupplierID.Text)){
                    // ======= logs
                    //string sprodid = stock.product_ID;
                    //string uid = user.GetUserID();
                    //log.deleteSupplier(uid, date, sprodid, "Delete Supplier");
                    btnSupClear.PerformClick();

                }

            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }

        private void btnSupSave_Click(object sender, EventArgs e) {
            if (txtSupplierName.Text.Trim() == "" || txtSupplierContact.Text.Trim() == "" || txtSupplierAddress.Text.Trim() == "") {
                MessageBox.Show("Please fill-up all fields", "Supplier");
            } else {
                if (supadd) {
                    if (contSuppliers.IsInsertSupplier(txtSupplierName.Text, txtSupplierAddress.Text, txtSupplierContact.Text)) {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.addSupplier(uid, date, sprodid, "Added Supplier ");
                        btnSupClear.PerformClick();
                    }
                } else if (supedit) {
                   if(contSuppliers.IsUpdateSupplier(lblSupplierID.Text,txtSupplierName.Text, txtSupplierAddress.Text, txtSupplierContact.Text, tempOldName)) {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.editSupplier(uid, date, sprodid, "Added Supplier ");
                        btnSupClear.PerformClick();
                    }
                }
            }
        }

        private void lvSupplier_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvSupplier.SelectedItems.Count > 0) {
                ListViewItem item = lvSupplier.SelectedItems[0];
                lblSupplierID.Text = item.SubItems[0].Text;
                txtSupplierName.Text = item.SubItems[1].Text;
                txtSupplierAddress.Text = item.SubItems[2].Text;
                txtSupplierContact.Text = item.SubItems[3].Text;
                btnSupAdd.Enabled = false; btnSupEdit.Enabled = true; btnSupDelete.Enabled = true; btnSupSave.Enabled = false; supadd = false; supedit = false; SupLock();
            } else {
                //
            }
        }

        private void btnSupClear_Click(object sender, EventArgs e) {
            LoadSuppliers(); btnSupSave.Enabled = false; btnSupAdd.Enabled = true; btnSupEdit.Enabled = false; btnSupDelete.Enabled = false; SupClear(); SupLock();
            supadd = supedit = false;
        }
    }
}
