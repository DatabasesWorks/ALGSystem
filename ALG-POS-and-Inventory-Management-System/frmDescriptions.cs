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
    public partial class frmDescriptions : Form {
        ContDescription contDescription = new ContDescription();
        bool supadd = false, supedit = false;
        string tempOldName;
        public frmDescriptions() {
            InitializeComponent();
        }
        private void frmDescriptions_Load(object sender, EventArgs e) {
            LoadDescriptions();
        }
        private void SupLock() {
            txtDescriptionName.Enabled = grpDesc.Enabled = false;
        }
        private void SupUnLock() {
            txtDescriptionName.Enabled = grpDesc.Enabled = true;
        }
        private void SupClear() {
            txtDescriptionName.Text= lblDescriptionID.Text = "";
            rdNumeric.Checked = false; rdText.Checked = true;
            supadd = supedit = false;
        }
        void LoadDescriptions() {
            lvDescription.Items.Clear();
            DataTable dt = new DataTable();
            dt = contDescription.LoadDescriptions();
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["description_ID"].ToString());
                listitem.SubItems.Add(dr["desc_name"].ToString());
                listitem.SubItems.Add(dr["desc_type"].ToString());
                lvDescription.Items.Add(listitem);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            btnAdd.Enabled = false; btnSave.Enabled = true; SupUnLock(); supadd = true;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            btnEdit.Enabled = false; btnSave.Enabled = true; supedit = true; btnDelete.Enabled = false; SupUnLock();
            tempOldName = txtDescriptionName.Text;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (txtDescriptionName.Text.Trim() == "") {
                MessageBox.Show("Please enter the description", "Descriptions");
            } else {
                string type = "";
                if (rdText.Checked == true)
                    type = "Text";
                else
                    type = "Numeric";
                if (supadd) {
                    if (contDescription.IsInsertDescription(txtDescriptionName.Text, type)) {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.addSupplier(uid, date, sprodid, "Added Supplier ");
                        btnClear.PerformClick();
                    }
                } else if (supedit) {
                    if (contDescription.IsUpdateDescription(lblDescriptionID.Text, txtDescriptionName.Text, type, tempOldName)) {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.editSupplier(uid, date, sprodid, "Added Supplier ");
                        btnClear.PerformClick();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Description?", "Descriptions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                if (contDescription.IsDeleteDescription(lblDescriptionID.Text)) {
                    // ======= logs
                    //string sprodid = stock.product_ID;
                    //string uid = user.GetUserID();
                    //log.deleteSupplier(uid, date, sprodid, "Delete Supplier");
                    btnClear.PerformClick();

                }

            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            LoadDescriptions(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; SupClear(); SupLock();
            supadd = supedit = false;
        }

        private void lvDescription_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvDescription.SelectedItems.Count > 0) {
                ListViewItem item = lvDescription.SelectedItems[0];
                lblDescriptionID.Text = item.SubItems[0].Text;
                txtDescriptionName.Text = item.SubItems[1].Text;
                if (item.SubItems[2].Text == "Text") {
                    rdText.Checked = true; rdNumeric.Checked = false;
                } else {
                    rdText.Checked = false; rdNumeric.Checked = true;
                }
                btnAdd.Enabled = false; btnEdit.Enabled = true; btnDelete.Enabled = true; btnSave.Enabled = false; supadd = false; supedit = false; SupLock();
            } else {
                //
            }
        }
    }
}
