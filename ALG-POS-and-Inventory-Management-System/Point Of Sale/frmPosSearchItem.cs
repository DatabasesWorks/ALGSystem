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
                string prodID = dr["product_ID"].ToString();
                listitem.SubItems.Add(prodID);
                listitem.SubItems.Add(dr["product_name"].ToString());
                listitem.SubItems.Add(dr["category_name"].ToString());
                listitem.SubItems.Add(dr["brand_name"].ToString());
                listitem.SubItems.Add(dr["prodDesc"].ToString()); 
                listitem.SubItems.Add(decimal.Parse((dr["product_price"].ToString())).ToString("C"));
                listitem.SubItems.Add(dr["discount"].ToString());
                listitem.SubItems.Add(decimal.Parse((dr["discounted_price"].ToString())).ToString("C"));

                DataTable dt1 = new DataTable();
                dt1 = contPos.LoadProductStocks(prodID);
                for (int j = 0; j < dt1.Rows.Count; j++) {
                    DataRow dr1 = dt1.Rows[j];
                    listitem.SubItems.Add(dr1["remStocks"].ToString());
                }
                    //listitem.SubItems.Add(_contInvProducts.GetProductDescription((dr["product_ID"]).ToString()));
                    lvItems.Items.Add(listitem);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            LoadProducts();
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            if (lvItems.SelectedItems.Count > 0) {
                if (lvItems.SelectedItems[0].SubItems[9].Text == "0") {
                    MessageBox.Show("Item " + lvItems.SelectedItems[0].SubItems[1].Text +" has no available stocks", "Point of Sale", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                } else {
                    uCPointOfSale.searchID = lvItems.SelectedItems[0].SubItems[1].Text;
                    this.Close();
                }
                
            }
        }

        private void lvItems_DoubleClick(object sender, EventArgs e) {
            btnSelect.PerformClick();
        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
