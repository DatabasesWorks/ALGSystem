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
        bool isPriceSet; int totalStocks;
        decimal discountedPrice;
        public uCInventoryProductPrice() {
            InitializeComponent();
        }

        private void uCInventoryProductPrice_Load(object sender, EventArgs e) {
            numPriceDiscount.TextChanged += new EventHandler(numPriceDiscount_TextChanged);
            numPriceSelling.TextChanged += new EventHandler(numPriceSelling_TextChanged);
            LoadProductPrices(); LoadProductsCbo();
            LoadSupplierPrices(); // testing only
            lblPriceDiscount.Text = "0";
            lblPriceDiscounted.Text = lblPriceProductPrice.Text = Convert.ToDecimal(0).ToString("C");
            numPriceDiscount.Value = numPriceSelling.Value = 0;
            lblPriceProductID.Text = "";
            lblPriceProductName.Text = "All Stocks";
        }

        void LoadProductPrices() {
            lvPriceProduct.Items.Clear();
            DataTable dt = new DataTable();
            dt = contPrices.LoadProductPrice();
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["prodID"].ToString());
                listitem.SubItems.Add(dr["product_name"].ToString());
                listitem.SubItems.Add(Convert.ToDecimal(dr["product_price"].ToString()).ToString("C"));
                listitem.SubItems.Add(dr["discount"].ToString());
                listitem.SubItems.Add(Convert.ToDecimal(dr["discounted_price"].ToString()).ToString("C"));
                lvPriceProduct.Items.Add(listitem);
            }
        }
        void LoadSupplierPrices() {
            totalStocks = 0;
            lvPriceSupplier.Items.Clear();
            DataTable dt = new DataTable();
            dt = contPrices.LoadSupplierPrices(cboSProductID.Text);
            if (dt.Rows.Count != 0) {
                for (int i = 0; i < dt.Rows.Count; i++) {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem((i + 1).ToString());
                    listitem.SubItems.Add(dr["supplier_name"].ToString());
                    listitem.SubItems.Add(Convert.ToDecimal(dr["supplier_price"].ToString()).ToString("C"));
                    listitem.SubItems.Add(dr["stock_ID"].ToString());
                    listitem.SubItems.Add(dr["received_date"].ToString().Substring(0, 10));
                    listitem.SubItems.Add(dr["remaining_stocks"].ToString());
                    totalStocks += Convert.ToInt32(dr["remaining_stocks"].ToString());
                    lvPriceSupplier.Items.Add(listitem);
                }
                lblAvailableStocks.Text = totalStocks.ToString();
            
            } else {
                lblPriceDiscount.Text = ""; lblPriceDiscounted.Text = ""; lblPriceProductPrice.Text = ""; btnPriceSetPrice.Enabled = false; numPriceDiscount.Value = 0; numPriceDiscount.Enabled = false; numPriceSelling.Value = 0; numPriceSelling.Enabled = false;
            }
        }
        void LoadProductsCbo() {
            List<string> list = new List<string>();

            list = contPrices.LoadProductID();
            cboSProductID.Items.Clear();
            if (list != null) {
                foreach (string item in list) {
                    cboSProductID.Items.Add(item);
                }
            }

            list = contPrices.LoadProductName();
            cboSProductName.Items.Clear();
            if (list != null) {
                foreach (string item in list) {
                    cboSProductName.Items.Add(item);
                }
            }
            
        }
        private void cboSProductID_SelectedIndexChanged_1(object sender, EventArgs e) {
            lblPriceProductName.Text = cboSProductName.Text = contPrices.SelectProductName(cboSProductID.Text)[0];
            SelectProduct();
            LoadSupplierPrices();
            btnPriceSetPrice.Enabled = numPriceDiscount.Enabled = numPriceSelling.Enabled = true;
            GetAveragePrice();
        }

        private void cboSProductName_SelectedIndexChanged_1(object sender, EventArgs e) {
            lblPriceProductID.Text = cboSProductID.Text = contPrices.SelectProductID(cboSProductName.Text)[0];
            SelectProduct();
            LoadSupplierPrices();
            btnPriceSetPrice.Enabled = numPriceDiscount.Enabled = numPriceSelling.Enabled = true;
            GetAveragePrice();
        }

        void SelectProduct() {
            List<string> list = new List<string>();
            try {
                list = contPrices.ProductSelectedForPrice(cboSProductID.Text);
                if (list != null) {
                    lblPriceProductPrice.Text = Convert.ToDecimal(list[0]).ToString("C");
                    lblPriceDiscount.Text = list[1];
                    lblPriceDiscounted.Text = Convert.ToDecimal(list[2]).ToString("C");
                    numPriceSelling.Value = Convert.ToDecimal(list[0]);
                    numPriceDiscount.Value = Convert.ToDecimal(list[1]);
                    isPriceSet = true;
                } else {
                    isPriceSet = false;
                    lblPriceDiscount.Text = "0";
                    lblPriceDiscounted.Text = lblPriceProductPrice.Text = Convert.ToDecimal(0).ToString("C");
                    numPriceSelling.Value = 0;
                    numPriceDiscount.Value = 0;
                }
            } catch (Exception ex) {
                Console.WriteLine("select product in ucinventoryproductprices" + ex.Message);
            }
        }

        void GetAveragePrice() {
            try {
                decimal avg;
                List<decimal> price = new List<decimal>();
                if (lvPriceSupplier.Items.Count > 0) {
                    lblAvg.Visible = lblAvgPrice.Visible = true;
                    foreach (ListViewItem item in lvPriceSupplier.Items) {
                        price.Add(decimal.Parse(item.SubItems[2].Text, System.Globalization.NumberStyles.Currency));
                    }
                    avg = price.Average();
                    lblAvgPrice.Text = avg.ToString("C");
                } else {
                    lblAvg.Visible = lblAvgPrice.Visible = false;
                }
            } catch (Exception ex) {
                Console.WriteLine("select product in ucinventoryproductprices" + ex.Message);
            }
        }

        private void btnPriceSetPrice_Click(object sender, EventArgs e) {
            string priceDiscounted;
            priceDiscounted = decimal.Parse(lblPriceDiscounted.Text, System.Globalization.NumberStyles.Currency).ToString();
            if(contPrices.SetProductPrice(isPriceSet, cboSProductID.Text, numPriceSelling.Value.ToString(), numPriceDiscount.Value.ToString(), priceDiscounted))
                btnPriceClear.PerformClick();

            //======= logs 
            //string sprodid = prodPrice.productID;
            //string uid = user.GetUserID();
            //log.setPrice(uid, date, sprodid, "Set Price ");
        }

        private void btnPriceClear_Click(object sender, EventArgs e) {
            cboSProductID.Text = cboSProductName.Text = ""; btnPriceSetPrice.Enabled = false; isPriceSet = false; 
            lblPriceDiscount.Text = "0";
            lblPriceDiscounted.Text = lblPriceProductPrice.Text = Convert.ToDecimal(0).ToString("C");
            numPriceDiscount.Value = numPriceSelling.Value = 0;
            lblPriceProductID.Text = "";
            lblPriceProductName.Text = "All Stocks";
            btnPriceSetPrice.Enabled = numPriceDiscount.Enabled = numPriceSelling.Enabled = false;
            LoadProductPrices(); LoadSupplierPrices();
            lblAvg.Visible = lblAvgPrice.Visible = false;
        }

        void NumPriceDiscChange() {
            try {
                lblPriceProductPrice.Text = numPriceSelling.Value.ToString("C");
                discountedPrice = (Convert.ToDecimal(numPriceSelling.Value) - (Convert.ToDecimal(numPriceSelling.Value) * ((Convert.ToDecimal(numPriceDiscount.Value)) / 100)));
                lblPriceDiscounted.Text = discountedPrice.ToString("C");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void numPriceSelling_ValueChanged(object sender, EventArgs e) {
            NumPriceDiscChange();
        }
        private void numPriceSelling_TextChanged(object sender, EventArgs e) {
            NumPriceDiscChange();
        }

        private void numPriceDiscount_ValueChanged(object sender, EventArgs e) {
            NumPriceDiscChange();
        }
        private void numPriceDiscount_TextChanged(object sender, EventArgs e) {
            NumPriceDiscChange();
        }
        private void lvPriceProduct_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvPriceProduct.SelectedItems.Count > 0) {
                ListViewItem item = lvPriceProduct.SelectedItems[0];
                lblPriceProductID.Text = cboSProductID.Text = item.SubItems[1].Text;
                lblPriceProductName.Text = cboSProductName.Text = item.SubItems[2].Text;
            }
            SelectProduct();
            LoadSupplierPrices();
            btnPriceSetPrice.Enabled = numPriceDiscount.Enabled = numPriceSelling.Enabled = true;
            GetAveragePrice();
        }

        private void lvPriceSupplier_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
