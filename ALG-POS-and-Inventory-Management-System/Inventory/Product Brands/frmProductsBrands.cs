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
    public partial class frmProductsBrands : Form {
        ContProductsBrands contBrands = new ContProductsBrands();
        bool add = false, edit = false; string query; string tempOldName;

        public frmProductsBrands() {
            InitializeComponent();
        }

        private void frmBrands_Load(object sender, EventArgs e) {
            LoadLV();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            btnAdd.Enabled = false; btnSave.Enabled = true; txtBrandName.Enabled = true;
            add = true;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            btnEdit.Enabled = false; btnSave.Enabled = true; edit = true; btnDelete.Enabled = false; txtBrandName.Enabled = true;
            tempOldName = txtBrandName.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this brand?", "Inventory", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                if (contBrands.IsDeleteBrand(txtBrandNum.Text)) {
                    btnClear.PerformClick();
                }
            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }
        private void LoadLV() {
            lvBrand.Items.Clear();
            try {
                DataTable table = new DataTable();
                table = contBrands.LoadBrands();
                lvBrand.Items.Clear();
                for (int i = 0; i < table.Rows.Count; i++) {
                    DataRow dr = table.Rows[i];
                    ListViewItem listitem = new ListViewItem((i + 1).ToString());
                    listitem.SubItems.Add(dr["brand_ID"].ToString());
                    listitem.SubItems.Add(dr["brand_name"].ToString());
                    lvBrand.Items.Add(listitem);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e) {
            LoadLV(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; txtBrandName.Text = ""; txtBrandNum.Text = ""; txtBrandName.Enabled = false;
        }

        private void frmCategory_Load(object sender, EventArgs e) {
            LoadLV();
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (txtBrandName.Text.Trim() == "") {
                MessageBox.Show("Please Provide a brand name");
                txtBrandName.Focus();
            } else {
                string id = txtBrandNum.Text, name = txtBrandName.Text;
                if (add) {
                    if (contBrands.IsInsertBrands(name)) {
                        add = false;
                        btnClear.PerformClick();
                    }
                } else if (edit) {
                    if (contBrands.IsUpdateBrands(id, name, tempOldName)) {
                        btnClear.PerformClick();
                        edit = false;
                    }
                }
            }
        }

        private void lvBrand_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvBrand.SelectedItems.Count > 0) {
                ListViewItem item = lvBrand.SelectedItems[0];
                txtBrandNum.Text = item.SubItems[1].Text;
                txtBrandName.Text = item.SubItems[2].Text;
                btnAdd.Enabled = false; btnEdit.Enabled = true; btnDelete.Enabled = true; btnSave.Enabled = false;
            } else {
                //
            }
        }

    }
}
