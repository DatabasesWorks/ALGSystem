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
    public partial class uCInventoryProductPrice : UserControl {
        ContInventoryProductPrice contPrices = new ContInventoryProductPrice();
        public uCInventoryProductPrice() {
            InitializeComponent();
        }

        private void uCInventoryProductPrice_Load(object sender, EventArgs e) {
            LoadProductPrices();
        }
        void LoadProductPrices() {
            DataTable dt = new DataTable();
            dt = contPrices.LoadProductPrice();
            lvPriceProduct.View = View.Details;
            ListViewItem iItem;
            foreach (DataRow row in dt.Rows) {
                iItem = new ListViewItem();
                for (int i = 0; i < row.ItemArray.Length; i++) {
                    if (i == 0)
                        iItem.Text = row.ItemArray[i].ToString();
                    else
                        iItem.SubItems.Add(row.ItemArray[i].ToString());
                }
                lvPriceProduct.Items.Add(iItem);
            }
        }
    }
}
