using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace ALG_POS_and_Inventory_Management_System {
    public partial class uCPointOfSale : UserControl {
        ContPointOfSale contPos = new ContPointOfSale();
        bool lvIclick = false; bool lvSclick=false;
        decimal itemPrice, servicePrice; double total = 0.0; decimal price;
        public uCPointOfSale() {
            InitializeComponent();
        }
        private void uCPointOfSale_Load(object sender, EventArgs e) {
            numDiscount.TextChanged += new EventHandler(numDiscount_TextChanged);
            lblTotalService.Text = lblTotalItems.Text = lblBalance.Text = lblPaid.Text = lblDiscAmount.Text = lblTotalAmount.Text = 0.ToString("C");
            LoadCustCbo();
        }
        private void txtItemCode_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                SelectItem();
                AddTotalItem();
                //MessageBox.Show("Test");
            }
        }
        private void LoadCustCbo() {
            foreach (string item in contPos.LoadCustomer()) {
                cboCustName.Items.Add(item.ToString());
            }
        }
        private void SelectItem() {
            double total = 0.0;
            bool isItemExisting = false;
            try {
                //products.product_ID,product_name, brand_name ,GROUP_CONCAT(product_desc_value) AS prodDesc,TRUNCATE(discounted_price, 2) AS discPrice, discount
                DataTable dt = new DataTable();
                dt = contPos.LoadProduct(txtItemCode.Text);
                if(dt.Rows.Count > 0) {
                    if (!IsSameItem()) {
                        for (int i = 0; i < dt.Rows.Count; i++) {
                            DataRow dr = dt.Rows[i];
                            ListViewItem listitem = new ListViewItem((i + 1).ToString());
                            listitem.SubItems.Add(dr["product_ID"].ToString()); //0
                            listitem.SubItems.Add(dr["product_name"].ToString()); //1
                            listitem.SubItems.Add(dr["brand_name"].ToString()+ " " + dr["prodDesc"].ToString()); //2
                            listitem.SubItems.Add(dr["discPrice"].ToString()); //3
                            total = Convert.ToDouble(dr["discPrice"].ToString()) * Convert.ToDouble(numQuan.Value.ToString());
                            isItemExisting = true;
                            listitem.SubItems.Add(dr["discount"].ToString() + "%"); //4
                            listitem.SubItems.Add(numQuan.Value.ToString()); //5
                            listitem.SubItems.Add(total.ToString("C")); //7
                            lvItems.Items.Add(listitem);
                        }
                    }
                } else {
                    MessageBox.Show("Barcode may not be found, no stocks in the inventory for the particular prodcut, or the product price is not set ", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtItemCode.Clear(); numQuan.Value = 1;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private bool IsSameItem() {
            bool same = false;
            foreach (ListViewItem item in lvItems.Items) {
                if (txtItemCode.Text == item.SubItems[1].Text && !lvIclick) {
                    item.SubItems[6].Text = (Convert.ToInt16(numQuan.Value) + Convert.ToInt16(item.SubItems[6].Text)).ToString();
                    price = Decimal.Parse(item.SubItems[4].Text, NumberStyles.Currency);
                    item.SubItems[7].Text = (Convert.ToDouble(price) * Convert.ToDouble(item.SubItems[6].Text)).ToString("C");
                    same = true;
                } else if (txtItemCode.Text == item.SubItems[1].Text && lvIclick) {
                    item.SubItems[6].Text = Convert.ToInt16(numQuan.Value).ToString();
                    price = Decimal.Parse(item.SubItems[4].Text, NumberStyles.Currency);
                    item.SubItems[7].Text = (Convert.ToDouble(price) * Convert.ToDouble(item.SubItems[6].Text)).ToString("C");
                    lvIclick = false;
                    same = true;
                }
            }
            return same;
        }
        private void AddTotalItem() {
            double total = 0.0; //local variable
            try {
                foreach (ListViewItem item in lvItems.Items) {
                    price = Decimal.Parse(item.SubItems[7].Text, NumberStyles.Currency);
                    total = total + (Convert.ToDouble(price));
                }
                lblTotalItems.Text = total.ToString("C");
                itemPrice = Decimal.Parse(lblTotalItems.Text, NumberStyles.Currency);
                servicePrice = Decimal.Parse(lblTotalService.Text, NumberStyles.Currency);
                total = (Convert.ToDouble(servicePrice)) + (Convert.ToDouble(itemPrice));
                lblTotalAmount.Text = (total).ToString("C");
                if (numDiscount.Value == 0)
                    lblDiscAmount.Text = lblTotalAmount.Text;
            } catch (Exception) {
                throw;
            }
        }
        private void lvItems_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvItems.SelectedItems.Count > 0) {
                ListViewItem item = lvItems.SelectedItems[0];
                txtItemCode.Text = item.SubItems[1].Text;
                numQuan.Text = item.SubItems[5].Text;
                lvIclick = true;
                btnRemove.Enabled = true;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e) {
            SelectItem();
            AddTotalItem();
        }

        private void cboCustName_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                string[] result;
                result = contPos.CustInf(cboCustName.Text).ToArray();
                //clsPointOfSale.custID = result[0].ToString();
                lblContact.Text = result[1].ToString();
                lblAddress.Text = result[2].ToString();
            } catch (Exception) {
                
            }
        }

        private void btnPay_Click(object sender, EventArgs e) {
            if (lvServices.Items.Count > 0 || lvItems.Items.Count > 0) {
                frmPosPay frmpospay = new frmPosPay();
                if (lvServices.Items.Count > 0 && (cboCustName.Text == "")) {
                    MessageBox.Show("Please provide customer information", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else {
                    ContPointOfSale.total = Decimal.Parse(lblTotalAmount.Text, NumberStyles.Currency);
                    ContPointOfSale.totalItems = Decimal.Parse(lblTotalItems.Text, NumberStyles.Currency);
                    ContPointOfSale.totalServices = Decimal.Parse(lblTotalService.Text, NumberStyles.Currency);
                    ContPointOfSale.discount = numDiscount.Value;
                    ContPointOfSale.totalDisc = Decimal.Parse(lblDiscAmount.Text, NumberStyles.Currency);
                    ContPointOfSale.lvItems = lvItems;
                    ContPointOfSale.lvServices = lvServices;
                    ContPointOfSale.transID = lblTransNo.Text;
                    frmpospay.ShowDialog();
                }
            } else {

            }
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e) {
            try {
                if (numDiscount.Value == 0) {
                    lblDiscAmount.Text = lblTotalAmount.Text;
                } else {
                    decimal total; //local variable
                    total = Decimal.Parse(lblTotalAmount.Text, NumberStyles.Currency);
                    lblDiscAmount.Text = (total - (total * ((numDiscount.Value) / 100))).ToString("C");
                }
            } catch (Exception ex) {
                Console.WriteLine("numdiscount_value changed error: " + ex.Message);
                numDiscount.Value = 0;
            }
        }
        private void numDiscount_TextChanged(object sender, EventArgs e) {
            try {
                if (numDiscount.Value == 0) {
                    lblDiscAmount.Text = lblTotalAmount.Text;
                } else {
                    decimal total; //local variable
                    total = Decimal.Parse(lblTotalAmount.Text, NumberStyles.Currency);
                    lblDiscAmount.Text = (total - (total * ((numDiscount.Value) / 100))).ToString("C");
                }
            } catch (Exception ex) {
                Console.WriteLine("numdiscount_value changed error: " + ex.Message);
                numDiscount.Value = 0;
            }
        }
    }
}
