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
    public partial class ucWizProductPrice : UserControl {
        ContInventoryProductPrice contPrices = new ContInventoryProductPrice();
        bool isPriceSet;
        public ucWizProductPrice() {
            InitializeComponent();
        }

        private void ucWizProductPrice_Load(object sender, EventArgs e) {
            numPriceDiscount.TextChanged += new EventHandler(numPriceDiscount_TextChanged);
            numPriceSelling.TextChanged += new EventHandler(numPriceSelling_TextChanged);
            LoadProductsCbo();
            lblPriceDiscount.Text = "0";
            lblPriceDiscounted.Text = lblPriceProductPrice.Text = Convert.ToDecimal(0).ToString("C");
            numPriceDiscount.Value = numPriceSelling.Value = 0;
            cboProductID.Text = frmInventoryWizard.productID;
            cboProductName.Text = frmInventoryWizard.productName;
        }
        void LoadProductsCbo() {
            List<string> list = new List<string>();

            list = contPrices.LoadProductID();
            cboProductID.Items.Clear();
            if (list != null) {
                foreach (string item in list) {
                    cboProductID.Items.Add(item);
                }
            }
            

            list = contPrices.LoadProductName();
            cboProductName.Items.Clear();
            if (list != null) {
                foreach (string item in list) {
                    cboProductName.Items.Add(item);
                }
            }
            
        }
        void NumPriceDiscChange() {
            decimal discountedPrice;
            try {
                lblPriceProductPrice.Text = numPriceSelling.Value.ToString("C");
                discountedPrice = (Convert.ToDecimal(numPriceSelling.Value) - (Convert.ToDecimal(numPriceSelling.Value) * ((Convert.ToDecimal(numPriceDiscount.Value)) / 100)));
                lblPriceDiscounted.Text = discountedPrice.ToString("C");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        void SelectProduct() {
            List<string> list = new List<string>();
            try {
                list = contPrices.ProductSelectedForPrice(cboProductID.Text);
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

        private void cboProductID_SelectedIndexChanged(object sender, EventArgs e) {
            cboProductName.Text = contPrices.SelectProductName(cboProductID.Text)[0];
            SelectProduct();
            btnPriceSetPrice.Enabled = numPriceDiscount.Enabled = numPriceSelling.Enabled = true;
        }

        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e) {
            cboProductID.Text = contPrices.SelectProductID(cboProductName.Text)[0];
            SelectProduct();
            btnPriceSetPrice.Enabled = numPriceDiscount.Enabled = numPriceSelling.Enabled = true;
        }

        private void btnPriceSetPrice_Click(object sender, EventArgs e) {
            string priceDiscounted;
            if(cboProductID.Text == "" && cboProductName.Text == "" && numPriceSelling.Value == 0) {
                MessageBox.Show("Please provide product information and product price" , "ALG Autocare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                priceDiscounted = decimal.Parse(lblPriceDiscounted.Text, System.Globalization.NumberStyles.Currency).ToString();
                if (contPrices.SetProductPrice(isPriceSet, cboProductID.Text, numPriceSelling.Value.ToString(), numPriceDiscount.Value.ToString(), priceDiscounted))
                    btnPriceClear.PerformClick();

                //======= logs 
                //string sprodid = prodPrice.productID;
                //string uid = user.GetUserID();
                //log.setPrice(uid, date, sprodid, "Set Price ");
            }
        }

        private void btnPriceClear_Click(object sender, EventArgs e) {
            cboProductID.Text = cboProductName.Text = ""; isPriceSet = false;
            lblPriceDiscount.Text = "0";
            lblPriceDiscounted.Text = lblPriceProductPrice.Text = Convert.ToDecimal(0).ToString("C");
            numPriceDiscount.Value = numPriceSelling.Value = 0;
        }
    }
}
