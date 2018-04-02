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
            lvPriceProduct.View = View.Details;
            ListViewItem iItem;
            foreach (DataRow row in dt.Rows) {
                iItem = new ListViewItem();
                for (int i = 0; i < row.ItemArray.Length; i++) {
                    if (i == 0)
                        iItem.Text = row.ItemArray[i].ToString();
                    else if (i == 2)
                        iItem.SubItems.Add(Convert.ToDecimal(row.ItemArray[i].ToString()).ToString("C"));
                    else if (i == 4)
                        iItem.SubItems.Add(Convert.ToDecimal(row.ItemArray[i].ToString()).ToString("C"));
                    else
                        iItem.SubItems.Add(row.ItemArray[i].ToString());
                }
                lvPriceProduct.Items.Add(iItem);
            }
              
        }
        void LoadSupplierPrices() {
            totalStocks = 0;
            lvPriceSupplier.Items.Clear();
            DataTable table = new DataTable();
            table = contPrices.LoadSupplierPrices(cboSProductID.Text);
            lvPriceSupplier.View = View.Details;
            ListViewItem iItem;
            if (table.Rows.Count != 0) {
                foreach (DataRow row in table.Rows) {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++) {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else if (i == 1)
                            iItem.SubItems.Add(Convert.ToDecimal(row.ItemArray[i].ToString()).ToString("C"));
                        else if (i == 3)
                            iItem.SubItems.Add((row.ItemArray[i].ToString()).Substring(0, 10));
                        else if (i == 4) {
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                            totalStocks += Convert.ToInt32(row.ItemArray[i].ToString());
                        } else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                    }
                    lvPriceSupplier.Items.Add(iItem);
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
            foreach (string item in list) {
                cboSProductID.Items.Add(item);
            }

            list = contPrices.LoadProductName();
            cboSProductName.Items.Clear();
            foreach (string item in list) {
                cboSProductName.Items.Add(item);
            }
        }
        private void cboSProductID_SelectedIndexChanged_1(object sender, EventArgs e) {
            lblPriceProductName.Text = cboSProductName.Text = contPrices.SelectProductName(cboSProductID.Text)[0];
            SelectProduct();
            LoadSupplierPrices();
            btnPriceSetPrice.Enabled = numPriceDiscount.Enabled = numPriceSelling.Enabled = true;
        }

        private void cboSProductName_SelectedIndexChanged_1(object sender, EventArgs e) {
            lblPriceProductID.Text = cboSProductID.Text = contPrices.SelectProductID(cboSProductName.Text)[0];
            SelectProduct();
            LoadSupplierPrices();
            btnPriceSetPrice.Enabled = numPriceDiscount.Enabled = numPriceSelling.Enabled = true;
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
        }

        private void numPriceSelling_ValueChanged(object sender, EventArgs e) {
            try {
                lblPriceProductPrice.Text = numPriceSelling.Value.ToString("C");
                discountedPrice = (Convert.ToDecimal(numPriceSelling.Value) - (Convert.ToDecimal(numPriceSelling.Value) * ((Convert.ToDecimal(numPriceDiscount.Value)) / 100)));
                lblPriceDiscounted.Text = discountedPrice.ToString("C");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void numPriceDiscount_ValueChanged(object sender, EventArgs e) {
            try {
                lblPriceDiscount.Text = numPriceDiscount.Value.ToString();
                discountedPrice = (Convert.ToDecimal(numPriceSelling.Value) - (Convert.ToDecimal(numPriceSelling.Value) * ((Convert.ToDecimal(numPriceDiscount.Value)) / 100)));
                lblPriceDiscounted.Text = discountedPrice.ToString("C");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvPriceProduct_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvPriceProduct.SelectedItems.Count > 0) {
                ListViewItem item = lvPriceProduct.SelectedItems[0];
                lblPriceProductID.Text = cboSProductID.Text = item.SubItems[0].Text;
                lblPriceProductName.Text = cboSProductName.Text = item.SubItems[1].Text;
            }
            SelectProduct();
            LoadSupplierPrices();
            btnPriceSetPrice.Enabled = numPriceDiscount.Enabled = numPriceSelling.Enabled = true;
        }
    }
}
