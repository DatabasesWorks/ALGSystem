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
    public partial class frmPosSearchItem : Form {
        ContPointOfSale contPos = new ContPointOfSale();

        public frmPosSearchItem() {
            InitializeComponent();
        }

        private void frmPosSearchItem_Load(object sender, EventArgs e) {
            LoadProducts();
        }
        void LoadProducts() {
            lvItems.Items.Clear();
            DataTable dt = new DataTable();
            dt = contPos.LoadProducts(txtSearch.Text,cboSearch.Text);
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["product_ID"].ToString());
                listitem.SubItems.Add(dr["product_name"].ToString());
                listitem.SubItems.Add(dr["category_name"].ToString());
                listitem.SubItems.Add(dr["brand_name"].ToString());
                listitem.SubItems.Add(dr["prodDesc"].ToString());
                listitem.SubItems.Add(dr["product_price"].ToString());
                listitem.SubItems.Add(dr["discount"].ToString());
                listitem.SubItems.Add(dr["discounted_price"].ToString());
                listitem.SubItems.Add(dr["remStocks"].ToString());
                //listitem.SubItems.Add(_contInvProducts.GetProductDescription((dr["product_ID"]).ToString()));
                lvItems.Items.Add(listitem);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            LoadProducts();
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            if (lvItems.SelectedItems.Count > 0) {
                uCPointOfSale.searchID = lvItems.SelectedItems[0].SubItems[1].Text;
                this.Close();
            }
        }

        private void lvItems_DoubleClick(object sender, EventArgs e) {
            btnSelect.PerformClick();
        }

    }
}
