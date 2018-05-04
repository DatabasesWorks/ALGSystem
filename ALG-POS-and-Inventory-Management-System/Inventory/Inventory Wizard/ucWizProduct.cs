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
    public partial class ucWizProduct : UserControl {
        public ucWizProduct() {
            InitializeComponent();
        }
        static List<string> catDescID = new List<string>();
        static List<string> descValue = new List<string>();
        ContInventoryProducts contProducts = new ContInventoryProducts();

        private void ucWizProduct_Load(object sender, EventArgs e) {
            LoadBrands(); LoadCategories();
        }

        void LoadBrands() {
            cboBrand.Items.Clear();
            List<string> brands = new List<string>();
            brands = contProducts.LoadBrands();
            if (brands != null) {
                foreach (string item in brands) {
                    cboBrand.Items.Add(item);
                }
            }
        }

        void LoadCategories() {
            cboCategory.Items.Clear();
            List<string> categories = new List<string>();
            categories = contProducts.LoadCategories();
            if (categories != null) {
                foreach (string item in categories) {
                    cboCategory.Items.Add(item);
                }
            }
        }

        private void btnProdSave_Click(object sender, EventArgs e) {
            SaveProduct();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e) {
            LoadDescription(cboCategory.Text);
        }

        private void btnCategory_Click(object sender, EventArgs e) {
            frmCategory _frmCategory = new frmCategory();
            _frmCategory.ShowDialog();
            LoadCategories();
        }

        void LoadDescription(string catName) {
            catDescID.Clear();
            DataTable dt = new DataTable();
            dt = contProducts.LoadCategoryDescription(catName);
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
                        num[i].Maximum = 100000;
                        
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

        bool SaveProduct() {
            if (txtProdNo.Text.Trim() == "" || txtProdName.Text == "" || cboBrand.Text == "" || cboCategory.Text == "") {
                MessageBox.Show("Please fill out all fields", "ALG Autocare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            } else {
                SetDescriptions();
                // checks if insert is successful
                if (contProducts.IsInsertProduct(txtProdNo.Text, txtProdName.Text, cboCategory.Text, cboBrand.Text, catDescID, descValue)) {
                    frmInventoryWizard.productID = txtProdNo.Text;
                    frmInventoryWizard.productName = txtProdName.Text;
                    btnPriceClear.PerformClick();
                    // logs 
                    //string uid = user.GetUserID();
                    //string prodid = prod.prodNo;
                    //log.addProduct(uid, date, prodid, "Updated Product ");
                    return true;
                } else
                    return false;
            }
        }

        private void btnPriceClear_Click(object sender, EventArgs e) {
            ProdClear(); LoadBrands(); LoadCategories();
            pnlInGroupBox.Controls.Clear();
        }
        void ProdClear() {
            descValue.Clear();
            txtProdNo.Text = txtProdName.Text = cboCategory.Text = "";
            cboBrand.Text = "Petron";
        }

        private void btnAddBrand_Click(object sender, EventArgs e) {
            frmProductsBrands frmbrands = new frmProductsBrands();
            frmbrands.ShowDialog();
        }
    }
}