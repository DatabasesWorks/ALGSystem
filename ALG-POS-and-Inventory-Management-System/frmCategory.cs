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
    public partial class frmCategory : Form {
        ContCategory contCategory = new ContCategory();
        bool supadd = false, supedit = false;
        string tempOldName;
        public frmCategory() {
            InitializeComponent();
        }
        private void frmCategory_Load(object sender, EventArgs e) {
            LoadDescriptions();
            LoadCategories();
        }
        void LoadDescriptions() {
            clbDescriptions.Items.Clear();
            List<string> list = new List<string>();
            list = contCategory.LoadDescriptions();
            foreach(string item in list) {
                clbDescriptions.Items.Add(item);
            }
        }
        void LoadCategories() {
            lvCategory.Items.Clear();
            DataTable dt = new DataTable();
            dt = contCategory.LoadCategories();
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["category_ID"].ToString());
                listitem.SubItems.Add((i + 1).ToString());
                listitem.SubItems.Add(dr["category_name"].ToString());
                lvCategory.Items.Add(listitem);
            }
        }
        void LoadSelectedCatDesc() {
            clbDescriptions.Items.Clear();
            List<string> list = new List<string>();
            list = contCategory.LoadDescriptions();
            foreach (string item in list) {
                clbDescriptions.Items.Add(item);
            }
            List<string> catDesc = new List<string>();
            catDesc = contCategory.SelectedDescription(lblCategoryID.Text);
            if (catDesc != null) {
                foreach (string item in catDesc) {
                    for (int i = 0; i < clbDescriptions.Items.Count; i++) {
                        if ((string)clbDescriptions.Items[i] == item) {
                            clbDescriptions.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }
        

       private void SupLock() {
            txtCategoryName.Enabled = clbDescriptions.Enabled = false;
        }
        private void SupUnLock() {
            txtCategoryName.Enabled = clbDescriptions.Enabled = true;
        }
        private void SupClear() {
            txtCategoryName.Text= clbDescriptions.Text = "";
            supadd = supedit = false;
        }
        
        private void btnAdd_Click(object sender, EventArgs e) {
            btnAdd.Enabled = false; btnSave.Enabled = true; SupUnLock(); supadd = true;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Editing category when a product is already profiled might remove records of existitng product. Would you like to proceed?", "Descriptions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                btnEdit.Enabled = false; btnSave.Enabled = true; supedit = true; btnDelete.Enabled = false; SupUnLock();
                tempOldName = txtCategoryName.Text;
            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (txtCategoryName.Text.Trim() == "" || clbDescriptions.CheckedItems.Count<1) {
                MessageBox.Show("Please enter the category name/select category descriptions", "Descriptions");
            } else {
                List<string> checkedItem = new List<string>();
                foreach (string item in clbDescriptions.CheckedItems) {
                    checkedItem.Add(item);
                }
                if (supadd) {
                    if (contCategory.IsInsertCategory(txtCategoryName.Text, checkedItem)) {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.addSupplier(uid, date, sprodid, "Added Supplier ");
                        btnClear.PerformClick();
                    }
                } else if (supedit) {
                    if (contCategory.IsUpdateCategory(lblCategoryID.Text, txtCategoryName.Text, checkedItem, tempOldName)) {
                        //    //===== logs
                        //    //string sprodid = stock.product_ID;
                        //    //string uid = user.GetUserID();
                        //    //log.editSupplier(uid, date, sprodid, "Added Supplier ");
                        //}
                        btnClear.PerformClick();
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e) {
            //DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Description?", "Descriptions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes) {
            //    if (contDescription.IsDeleteDescription(lblDescriptionID.Text)) {
            //        // ======= logs
            //        //string sprodid = stock.product_ID;
            //        //string uid = user.GetUserID();
            //        //log.deleteSupplier(uid, date, sprodid, "Delete Supplier");
            //        btnClear.PerformClick();

            //    }

            //} else if (dialogResult == DialogResult.No) {
            //    //do something else
            //}
        }

        private void btnClear_Click(object sender, EventArgs e) {
            LoadDescriptions(); LoadCategories(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; SupClear(); SupLock();
            supadd = supedit = false;
        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvCategory.SelectedItems.Count > 0) {
                ListViewItem item = lvCategory.SelectedItems[0];
                lblCategoryID.Text = item.SubItems[0].Text;
                txtCategoryName.Text = item.SubItems[2].Text;
                LoadSelectedCatDesc();
                btnAdd.Enabled = false; btnEdit.Enabled = true; btnDelete.Enabled = true; btnSave.Enabled = false; supadd = false; supedit = false; SupLock();
            } else {
                //
            }
        }
        private void btnDesc_Click(object sender, EventArgs e) {
            frmDescriptions frmDesc = new frmDescriptions();
            frmDesc.ShowDialog();
            LoadDescriptions();
            LoadCategories();
        }
        private void lvDescription_SelectedIndexChanged(object sender, EventArgs e) {
            //if (lvDescription.SelectedItems.Count > 0) {
            //    ListViewItem item = lvDescription.SelectedItems[0];
            //    lblDescriptionID.Text = item.SubItems[0].Text;
            //    txtDescriptionName.Text = item.SubItems[1].Text;
            //    if (item.SubItems[2].Text == "Text") {
            //        rdText.Checked = true; rdNumeric.Checked = false;
            //    } else {
            //        rdText.Checked = false; rdNumeric.Checked = true;
            //    }
            //    btnAdd.Enabled = false; btnEdit.Enabled = true; btnDelete.Enabled = true; btnSave.Enabled = false; supadd = false; supedit = false; SupLock();
            //} else {
            //    //
            //}
        }
    }
}
