using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace ALG_POS_and_Inventory_Management_System {
    public partial class uCInventoryProducts : UserControl {
        ContInventoryProducts _contInvProducts = new ContInventoryProducts();
        static List<string> catDescID = new List<string>();
        static List<string> descValue = new List<string>();
        public uCInventoryProducts() {
            InitializeComponent();
        }
        DbConnection dbcon = new DbConnection();
        private void uCInventoryProducts_Load(object sender, EventArgs e) {
            LoadProducts(); LoadBrands(); LoadCategories();   // load for products tab
        }
        //======= Products ========
        bool add, edit;
        string tempOldName;
        void LoadProducts() {
            lvProducts.Items.Clear();
            DataTable dt = new DataTable();
            dt = _contInvProducts.LoadProducts(txtSearch.Text,cboSearch.Text);
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i+1).ToString());
                listitem.SubItems.Add(dr["product_ID"].ToString());
                listitem.SubItems.Add(dr["product_name"].ToString());
                listitem.SubItems.Add(dr["brand_name"].ToString());
                listitem.SubItems.Add(dr["category_name"].ToString());
                listitem.SubItems.Add(dr["prodDesc"].ToString());
                //listitem.SubItems.Add(_contInvProducts.GetProductDescription((dr["product_ID"]).ToString()));
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
            if (categories != null) {
                foreach (string item in categories) {
                    cboCategory.Items.Add(item);
                }
            }
        }
        private void txtProdNo_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txtProdName.Focus();
            }
        }
        void ProdClear() {
            cboSearch.Text = txtSearch.Text = "";
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
            UnLockDescriptions();
        }
        private void btnProdSave_Click(object sender, EventArgs e) {
            // to do: 
            if (txtProdNo.Text.Trim() == "" || txtProdName.Text.Trim() == "" || cboBrand.Text == "" || cboCategory.Text == "") {
                MessageBox.Show("Please fill out all");
                return;
            }
            SetDescriptions();
            if (add) {
                // checks if insert is successful
                if (_contInvProducts.IsInsertProduct(txtProdNo.Text, txtProdName.Text, cboCategory.Text, cboBrand.Text,catDescID,descValue)) {
                    btnProdClear.PerformClick();
                    // logs
                    //string uid = user.GetUserID();
                    //string prodid = prod.prodNo;
                    //log.addProduct(uid, date, prodid, "Added Product ");
                } else
                    return;
            } else if (edit) {
                // checks if update is successful
                if (_contInvProducts.IsUpdateProduct(txtProdNo.Text, txtProdName.Text, cboCategory.Text, cboBrand.Text, tempOldName,catDescID, descValue)) {
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
                txtProdNo.Text = item.SubItems[1].Text;
                txtProdName.Text = item.SubItems[2].Text;
                cboBrand.Text = item.SubItems[3].Text;
                cboCategory.Text = item.SubItems[4].Text; //cboCategory_SelectedIndexChanged -> SetDescriptions() triggered here
                //descValue.Clear();
                descValue = _contInvProducts.LoadDescOfSelectedItem(txtProdNo.Text);
               LoadDescriptionValue(cboCategory.Text);
                LockDescriptions();
            }
            //to do: add descvalues to 
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
            pnlInGroupBox.Controls.Clear();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e) {
            LoadDescription(cboCategory.Text);
        }

        private void btnProdPrint_Click(object sender, EventArgs e) {
            try
            {
                string query = "SELECT * FROM product_print";
                dbcon.mysqlconnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                MySqlDataAdapter adp = new MySqlDataAdapter();
                DataSet dt = new DataSet();
                adp.SelectCommand = cmd;
                adp.Fill(dt,"product_print");
                CrystalReportProduct reporting = new CrystalReportProduct();
                reporting.SetDataSource(dt);
                frmReports frmreports = new frmReports();
                frmreports.crystalReportViewer.ReportSource = reporting;
                frmreports.crystalReportViewer.Refresh();
                cmd.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();
                frmreports.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void SetDescriptions() {
            descValue.Clear();
            foreach (Control ctrl in this.Controls) {
                foreach (Control ctrl1 in ctrl.Controls) {
                    foreach (Control ctrl2 in ctrl1.Controls) {
                        if (ctrl2 is MyTextBox)
                            descValue.Add(ctrl2.Text);
                        else if (ctrl2 is NumericUpDown)
                            descValue.Add(((NumericUpDown)ctrl2).Value.ToString());
                    }
                }
            }
        }
        void LockDescriptions() {
            foreach (Control ctrl in this.Controls) {
                foreach (Control ctrl1 in ctrl.Controls) {
                    foreach (Control ctrl2 in ctrl1.Controls) {
                        ctrl2.Enabled = false;
                    }
                }
            }
        }
        void UnLockDescriptions() {
            foreach (Control ctrl in this.Controls) {
                foreach (Control ctrl1 in ctrl.Controls) {
                    foreach (Control ctrl2 in ctrl1.Controls) {
                        ctrl2.Enabled = true;
                    }
                }
            }
        }
        void LoadDescription(string catName) {
            catDescID.Clear();
            DataTable dt = new DataTable();
            dt = _contInvProducts.LoadCategoryDescription(catName);
            //cat_desc_ID, desc_name, desc_type
            if (dt.Rows.Count > 0) {
                pnlInGroupBox.Controls.Clear();
                int left = 1;
                Label[] lbl = new Label[dt.Rows.Count];
                Label[] lblUnit = new Label[dt.Rows.Count];
                MyTextBox[] txtbox = new MyTextBox[dt.Rows.Count];
                NumericUpDown[] num = new NumericUpDown[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++) {
                    DataRow dr = dt.Rows[i];
                    catDescID.Add(dr["cat_desc_ID"].ToString());
                    lbl[i] = new Label();
                    pnlInGroupBox.Controls.Add(lbl[i]);
                    lbl[i].Text = dr["desc_name"].ToString() + ":";
                    lbl[i].Top = left * 35;
                    lbl[i].Left = 50;
                    lbl[i].Width = 130;
                    if (dr["desc_type"].ToString() == "Text") {
                        txtbox[i] = new MyTextBox();
                        pnlInGroupBox.Controls.Add(txtbox[i]);
                        txtbox[i].BackColor = Color.CornflowerBlue;
                        txtbox[i].ForeColor = Color.White;
                        txtbox[i].Top = left * 35;
                        txtbox[i].Left = 200;
                        txtbox[i].Width = 190;

                        lblUnit[i] = new Label();
                        pnlInGroupBox.Controls.Add(lblUnit[i]);
                        lblUnit[i].Text = dr["desc_unit"].ToString();
                        lblUnit[i].Top = left * 30;
                        lblUnit[i].Left = 400;
                        lblUnit[i].Width = 75;

                        left += 1;
                    } else {
                        num[i] = new NumericUpDown();
                        pnlInGroupBox.Controls.Add(num[i]);
                        num[i].Top = left * 30;
                        num[i].Left = 200;
                        num[i].Width = 190;

                        lblUnit[i] = new Label();
                        pnlInGroupBox.Controls.Add(lblUnit[i]);
                        lblUnit[i].Text = dr["desc_unit"].ToString();
                        lblUnit[i].Top = left * 30;
                        lblUnit[i].Left = 400;
                        lblUnit[i].Width = 75;

                        left += 1;
                    }
                }
            } else {
                pnlInGroupBox.Controls.Clear();
                Label lblx = new Label();
                pnlInGroupBox.Controls.Add(lblx);
                lblx.Top = 30; lblx.Left = 100;
                lblx.ForeColor = Color.White;
                lblx.Text = "No description available";
                lblx.AutoSize = true;
            }
            
        }

        private void btnCategory_Click(object sender, EventArgs e) {
            frmCategory _frmCategory = new frmCategory();
            _frmCategory.ShowDialog();
            LoadCategories();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            LoadProducts();
        }

        private void btnAddBrand_Click(object sender, EventArgs e) {
            //showdialog frmBrands();
            LoadBrands();
        }

        private void btnWizard_Click(object sender, EventArgs e) {
            frmInventoryWizard frmwiz = new frmInventoryWizard();
            frmwiz.ShowDialog();
            btnProdClear.PerformClick();
        }

        void LoadDescriptionValue(string catName) {
            //error occurs when catDesc rows is > than rows in product description
            catDescID.Clear();
            DataTable dt = new DataTable();
            dt = _contInvProducts.LoadCategoryDescription(catName);
            //cat_desc_ID, desc_name, desc_type
            if (dt.Rows.Count > 0) {
                pnlInGroupBox.Controls.Clear();
                int left = 1;
                Label[] lbl = new Label[dt.Rows.Count];
                Label[] lblUnit = new Label[dt.Rows.Count];
                MyTextBox[] txtbox = new MyTextBox[dt.Rows.Count];
                NumericUpDown[] num = new NumericUpDown[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++) {
                    DataRow dr = dt.Rows[i];
                    catDescID.Add(dr["cat_desc_ID"].ToString());
                    lbl[i] = new Label();
                    pnlInGroupBox.Controls.Add(lbl[i]);
                    lbl[i].Text = dr["desc_name"].ToString() + ":";
                    lbl[i].Top = left * 35;
                    lbl[i].Left = 50;
                    lbl[i].Width = 130;
                    if (dr["desc_type"].ToString() == "Text") {
                        txtbox[i] = new MyTextBox();
                        pnlInGroupBox.Controls.Add(txtbox[i]);
                        txtbox[i].BackColor = Color.CornflowerBlue;
                        txtbox[i].ForeColor = Color.White;
                        txtbox[i].Top = left * 35;
                        txtbox[i].Left = 200;
                        txtbox[i].Width = 190;

                        lblUnit[i] = new Label();
                        pnlInGroupBox.Controls.Add(lblUnit[i]);
                        lblUnit[i].Text = dr["desc_unit"].ToString();
                        lblUnit[i].Top = left * 30;
                        lblUnit[i].Left = 400;
                        lblUnit[i].Width = 75;

                        left += 1;
                        try {
                            if (descValue.Count > 0)
                                txtbox[i].Text = descValue[i].ToString();
                        } catch (Exception ex) {
                            Console.WriteLine("error on: ucInventoryProducts->LoadDescriptionValue(string catname): " + ex.Message);
                        }
                    } else {
                        num[i] = new NumericUpDown();
                        pnlInGroupBox.Controls.Add(num[i]);
                        num[i].Top = left * 30;
                        num[i].Left = 200;
                        num[i].Width = 190;

                        lblUnit[i] = new Label();
                        pnlInGroupBox.Controls.Add(lblUnit[i]);
                        lblUnit[i].Text = dr["desc_unit"].ToString();
                        lblUnit[i].Top = left * 30;
                        lblUnit[i].Left = 400;
                        lblUnit[i].Width = 75;
                        left += 1;
                        try {
                            if (descValue.Count > 0)
                                num[i].Value = Convert.ToDecimal(descValue[i].ToString());
                        } catch (Exception ex) {
                            Console.WriteLine("error on: ucInventoryProducts->LoadDescriptionValue(string catname): " + ex.Message);
                        }
                    }
                }
            } else
                pnlInGroupBox.Controls.Clear();
        }

    }
}
