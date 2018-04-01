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
    public partial class uCInventoryProducts : UserControl {
        ContInventoryProducts _contInvProducts = new ContInventoryProducts();

        public uCInventoryProducts() {
            InitializeComponent();
        }
        private void uCInventoryProducts_Load(object sender, EventArgs e) {
            LoadProducts(); LoadBrands(); LoadCategories();   // load for products tab
        }
        //======= Products ========
        bool add, edit;
        string tempOldName;
        void LoadProducts() {
            lvProducts.Items.Clear();
            DataTable dt = new DataTable();
            dt = _contInvProducts.LoadProducts();
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["product_ID"].ToString());
                listitem.SubItems.Add(dr["product_name"].ToString());
                listitem.SubItems.Add(dr["brand_name"].ToString());
                listitem.SubItems.Add(dr["category_name"].ToString());
                lvProducts.Items.Add(listitem);
            }
        }
        void LoadBrands() {
            cboBrand.Items.Clear();
            List<string> brands = new List<string>();
            brands = _contInvProducts.LoadBrands();
            foreach (string item in brands) {
                cboBrand.Items.Add(item);
            }
        }
        void LoadCategories() {
            cboCategory.Items.Clear();
            List<string> categories = new List<string>();
            categories = _contInvProducts.LoadCategories();
            foreach (string item in categories) {
                cboCategory.Items.Add(item);
            }
        }
        private void txtProdNo_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txtProdName.Focus();
            }
        }
        void ProdClear() {
            txtProdNo.Text = txtProdName.Text = cboCategory.Text = "";
            cboBrand.Text = "Petron";
        }
        void ProdLock() {
            txtProdNo.Enabled = txtProdName.Enabled = cboBrand.Enabled = cboCategory.Enabled = false;
        }
        void ProdUnlock() {
            txtProdNo.Enabled = txtProdName.Enabled = cboBrand.Enabled = cboCategory.Enabled = true;
        }
        private void btnProdAdd_Click(object sender, EventArgs e) {
            ProdClear();
            add = true; edit = false;
            btnProdAdd.Enabled = btnProdEdit.Enabled = btnProdDelete.Enabled = false;
            btnProdSave.Enabled = true;
            ProdUnlock();
        }
        private void btnProdEdit_Click(object sender, EventArgs e) {
            add = false; edit = true;
            btnProdAdd.Enabled = btnProdEdit.Enabled = btnProdDelete.Enabled = false;
            btnProdSave.Enabled = true;
            ProdUnlock();
            txtProdNo.Enabled = false;
            tempOldName = txtProdName.Text;
        }
        private void btnProdSave_Click(object sender, EventArgs e) {
            // to do: 
            if (txtProdNo.Text.Trim() == "" || txtProdName.Text == "" || cboBrand.Text == "" || cboCategory.Text == "") {
                MessageBox.Show("Please fill out all");
                return;
            }

            if (add) {
                // checks if insert is successful
                if (_contInvProducts.IsInsertProduct(txtProdNo.Text, txtProdName.Text, cboCategory.Text, cboBrand.Text)) {
                    btnProdClear.PerformClick();
                    // logs
                    //string uid = user.GetUserID();
                    //string prodid = prod.prodNo;
                    //log.addProduct(uid, date, prodid, "Added Product ");
                } else
                    return;
            } else if (edit) {
                // checks if update is successful
                if (_contInvProducts.IsUpdateProduct(txtProdNo.Text, txtProdName.Text, cboCategory.Text, cboBrand.Text, tempOldName)) {
                    btnProdClear.PerformClick();
                    // logs 
                    //string uid = user.GetUserID();
                    //string prodid = prod.prodNo;
                    //log.addProduct(uid, date, prodid, "Updated Product ");
                } else
                    return;
            }
        }
        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e) {
            btnProdAdd.Enabled = btnProdSave.Enabled = false;
            btnProdEdit.Enabled = btnProdDelete.Enabled = true;
            add = edit = false;
            if (lvProducts.SelectedItems.Count > 0) {
                ListViewItem item = lvProducts.SelectedItems[0];
                txtProdNo.Text = item.SubItems[0].Text;
                txtProdName.Text = item.SubItems[1].Text;
                cboBrand.Text = item.SubItems[2].Text;
                cboCategory.Text = item.SubItems[3].Text;
            }
        }

        private void btnProdDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                _contInvProducts.IsDeleteProduct(txtProdNo.Text);
                btnProdClear.PerformClick();
                //string uid = user.GetUserID();
                //string prodid = prod.prodNo;

                //log.deleteProduct(uid, date, prodid, "Deleted");
            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }
        private void btnProdClear_Click(object sender, EventArgs e) {
            ProdClear();
            ProdLock();
            add = edit = false;
            btnProdSave.Enabled = btnProdEdit.Enabled = btnProdDelete.Enabled = false;
            btnProdAdd.Enabled = true;
            LoadProducts(); LoadBrands(); LoadCategories();
        }


    }
}
