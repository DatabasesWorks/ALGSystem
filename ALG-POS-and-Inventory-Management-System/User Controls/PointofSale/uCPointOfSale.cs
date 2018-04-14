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
        public static string searchID, transacID;
        public uCPointOfSale() {
            InitializeComponent();
        }
        private void uCPointOfSale_Load(object sender, EventArgs e) {
            numDiscount.TextChanged += new EventHandler(numDiscount_TextChanged);
            lblTotalService.Text = lblTotalItems.Text = lblBalance.Text = lblPaid.Text = lblDiscAmount.Text = lblTotalAmount.Text = 0.ToString("C");
            LoadCustCbo();
            lblTransNo.Text = contPos.GetTransacID();
            lblCashierName.Text = clsUsers.userName;
        }
        private void txtItemCode_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                SelectItem(txtItemCode.Text);
                AddTotalItem();
                //MessageBox.Show("Test");
            }
        }
        private void LoadCustCbo() {
            foreach (string item in contPos.LoadCustomer()) {
                cboCustName.Items.Add(item.ToString());
            }
        }
        private void SelectItem(string itemCode) {
            double total = 0.0;
            bool isItemExisting = false;
            try {
                //products.product_ID,product_name, brand_name ,GROUP_CONCAT(product_desc_value) AS prodDesc,TRUNCATE(discounted_price, 2) AS discPrice, discount
                DataTable dt = new DataTable();
                dt = contPos.SearchProduct(itemCode);
                if(dt.Rows.Count > 0) {
                    if (!IsSameItem()) {
                        for (int i = 0; i < dt.Rows.Count; i++) {
                            DataRow dr = dt.Rows[i];
                            ListViewItem listitem = new ListViewItem(((lvItems.Items.Count)+1).ToString());
                            listitem.SubItems.Add(dr["product_ID"].ToString()); //0
                            listitem.SubItems.Add(dr["product_name"].ToString()); //1
                            listitem.SubItems.Add(dr["category_name"].ToString()); //1
                            listitem.SubItems.Add(dr["brand_name"].ToString());
                            listitem.SubItems.Add(dr["prodDesc"].ToString());
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
                    MessageBox.Show("Barcode may not be found, no stocks in the inventory for the particular product, or the product price is not set.", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    item.SubItems[8].Text = (Convert.ToInt16(numQuan.Value) + Convert.ToInt16(item.SubItems[8].Text)).ToString();
                    price = Decimal.Parse(item.SubItems[6].Text, NumberStyles.Currency);
                    item.SubItems[9].Text = (Convert.ToDouble(price) * Convert.ToDouble(item.SubItems[8].Text)).ToString("C");
                    same = true;
                } else if (txtItemCode.Text == item.SubItems[1].Text && lvIclick) {
                    item.SubItems[8].Text = Convert.ToInt16(numQuan.Value).ToString();
                    price = Decimal.Parse(item.SubItems[6].Text, NumberStyles.Currency);
                    item.SubItems[9].Text = (Convert.ToDouble(price) * Convert.ToDouble(item.SubItems[8].Text)).ToString("C");
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
                    price = Decimal.Parse(item.SubItems[9].Text, NumberStyles.Currency);
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
        private void AddTotalService() {
            decimal total = 0;
            //foreach (ListViewItem item in lvServices.Items) {
            //    total = total + (Convert.ToDouble(item.SubItems[5].Text.ToString()));
            //}
            //lblTotalService.Text = total.ToString();
            //lblTotalAmount.Text = (Convert.ToDouble(lblTotalService.Text) + Convert.ToDouble(lblTotalItems.Text)).ToString();
            //if (numDiscount.Value == 0)
            //    lblDiscAmount.Text = lblTotalAmount.Text;
            try {
                foreach (ListViewItem item in lvServices.Items) {
                    price = Decimal.Parse(item.SubItems[7].Text, NumberStyles.Currency);
                    total = total + price;
                }
                lblTotalService.Text = total.ToString("C");
                itemPrice = Decimal.Parse(lblTotalService.Text, NumberStyles.Currency);
                total = Decimal.Parse(lblTotalItems.Text, NumberStyles.Currency) + itemPrice;
                lblTotalAmount.Text = (total).ToString("C");
                if (numDiscount.Value == 0)     // ???????
                    lblDiscAmount.Text = lblTotalAmount.Text;
            } catch (Exception ex) {
                MessageBox.Show("Something went wrong: " + ex.Message, "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void lvItems_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvItems.SelectedItems.Count > 0) {
                ListViewItem item = lvItems.SelectedItems[0];
                txtItemCode.Text = item.SubItems[1].Text;
                numQuan.Value = Convert.ToDecimal(item.SubItems[8].Text);
                lvIclick = true;
                btnRemove.Enabled = true;
                lvServices.SelectedItems.Clear();   //
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e) {
            SelectItem(txtItemCode.Text);
            AddTotalItem();
        }

        private void cboCustName_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                string[] result;
                result = contPos.CustInf(cboCustName.Text).ToArray();
                ContPointOfSale.custID = result[0].ToString();
                lblContact.Text = result[1].ToString();
                lblAddress.Text = result[2].ToString();
                lvServices.Items.Clear();
                lblTotalService.Text = 0.ToString("C");
                AddTotalItem();
            } catch (Exception ex) {
                Console.WriteLine("error on cboCustName_SelectedIndexChanged: " + ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e) {
            if (lvServices.Items.Count > 0 || lvItems.Items.Count > 0) {
                if (lvServices.Items.Count > 0 && (cboCustName.Text == "")) {
                    MessageBox.Show("Please provide customer information", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else {
                    ContPointOfSale.totalAmount = Decimal.Parse(lblTotalAmount.Text, NumberStyles.Currency);
                    ContPointOfSale.totalItems = Decimal.Parse(lblTotalItems.Text, NumberStyles.Currency);
                    ContPointOfSale.totalServices = Decimal.Parse(lblTotalService.Text, NumberStyles.Currency);
                    ContPointOfSale.discount = numDiscount.Value;
                    ContPointOfSale.totalDisc = Decimal.Parse(lblDiscAmount.Text, NumberStyles.Currency);
                    ContPointOfSale.transID = lblTransNo.Text;
                    ContPointOfSale.lvItems = lvItems;
                    ContPointOfSale.lvServices = lvServices;
                   
                    //ContPointOfSale.custID = contPos.CustInf(cboCustName.Text)[0];
                    frmPosPay frmpospay = new frmPosPay();
                    frmpospay.ShowDialog();
                }
            } else {
                MessageBox.Show("Please select items/services.", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnAddService_Click(object sender, EventArgs e) {
            contPos.CustInf(cboCustName.Text); // to save the customer name
            if (cboCustName.Text == "") {
                MessageBox.Show("Please provide customer information", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                frmPosAddService frmAddService = new frmPosAddService();
                frmAddService.ShowDialog();
                if(ContPointOfSale.plateNo=="" || ContPointOfSale.plateNo == null) {
                    //do nothing
                } else {
                    ListViewItem listitem = new ListViewItem(((lvServices.Items.Count) + 1).ToString());
                    listitem.SubItems.Add(ContPointOfSale.plateNo);
                    listitem.SubItems.Add(ContPointOfSale.vehicleType);
                    listitem.SubItems.Add(ContPointOfSale.brand);
                    listitem.SubItems.Add(ContPointOfSale.model);
                    listitem.SubItems.Add(ContPointOfSale.color);
                    listitem.SubItems.Add(ContPointOfSale.serviceRendered);
                    listitem.SubItems.Add(decimal.Parse(ContPointOfSale.payment).ToString("C"));
                    listitem.SubItems.Add(ContPointOfSale.employees);
                    listitem.SubItems.Add(ContPointOfSale.addedService);
                    listitem.SubItems.Add(ContPointOfSale.employeesID);
                    listitem.SubItems.Add(ContPointOfSale.addedServicesID);
                    lvServices.Items.Add(listitem);
                    AddTotalService();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if (lvItems.SelectedItems.Count > 0) {
                foreach (ListViewItem eachItem in lvItems.SelectedItems) {
                    lvItems.Items.Remove(eachItem);
                }
                for(int i =0; i<lvItems.Items.Count; i++) {
                    lvItems.Items[i].SubItems[0].Text = (i + 1).ToString();
                }
                AddTotalItem(); AddTotalService();
            } else if (lvServices.SelectedItems.Count > 0) {
                foreach (ListViewItem eachItem in lvServices.SelectedItems) {
                    lvServices.Items.Remove(eachItem);
                }
                for (int i = 0; i < lvServices.Items.Count; i++) {
                    lvServices.Items[i].SubItems[0].Text = (i + 1).ToString();
                }
                AddTotalItem(); AddTotalService();
            } else
                MessageBox.Show("Select item/service to be removed", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
        }

        private void lvServices_SelectedIndexChanged(object sender, EventArgs e) {
            lvItems.SelectedItems.Clear();
        }

        private void btnNewTrans_Click(object sender, EventArgs e) {
            txtItemCode.Text = cboCustName.Text = lblAddress.Text = lblContact.Text = "";
            lblTotalService.Text = lblTotalItems.Text = lblBalance.Text = lblPaid.Text = lblDiscAmount.Text = lblTotalAmount.Text = 0.ToString("C");
            lblTransNo.Text = contPos.GetTransacID();
            ContPointOfSale.totalAmount = ContPointOfSale.totalItems = ContPointOfSale.totalServices =  ContPointOfSale.totalDisc = 0;
            ContPointOfSale.plateNo = ContPointOfSale.vehicleType = ContPointOfSale.brand = ContPointOfSale.model = ContPointOfSale.color = ContPointOfSale.serviceRendered = ContPointOfSale.payment = ContPointOfSale.employees = ContPointOfSale.addedService="";
            ContPointOfSale.discount = 0;
            ContPointOfSale.transID = "";
            ContPointOfSale.lvItems = null;
            ContPointOfSale.lvServices = null;
            numDiscount.Value = 0;
            lvItems.Items.Clear();
            lvServices.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lblDateAndTime.Text = DateTime.Now.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            searchID = "";
            frmPosSearchItem frmSearch = new frmPosSearchItem();
            frmSearch.ShowDialog();
            if (searchID != "") {
                txtItemCode.Text = searchID;
                SelectItem(searchID);
                AddTotalItem();
            }
        }

        private void btnViewOngoing_Click(object sender, EventArgs e) {
            //transactions.transac_ID AS transID,CONCAT(gName, ' ', mInitial, '. ', fName) AS customer, discount, discounted_amount, total_amount, paid, balance, items_total_amount, service_total_amount
            transacID = "";
            frmPosOngoingService frmOngoing = new frmPosOngoingService();
            frmOngoing.ShowDialog();
            if (transacID != "") {
                List<string> list = new List<string>();
                list = contPos.GetOngoingTransDetails(transacID);
                if (list != null) {
                    lblTransNo.Text = list[0];
                    cboCustName.Text = list[1];
                    numDiscount.Value = Convert.ToDecimal(list[2]);
                    lblDiscAmount.Text = Convert.ToDecimal(list[3]).ToString("C");
                    lblTotalAmount.Text = Convert.ToDecimal(list[4]).ToString("C");
                    lblPaid.Text = Convert.ToDecimal(list[5]).ToString("C");
                    lblBalance.Text = Convert.ToDecimal(list[6]).ToString("C");
                    lblTotalItems.Text = Convert.ToDecimal(list[7]).ToString("C");
                    lblTotalService.Text = Convert.ToDecimal(list[8]).ToString("C");
                    string[] result;
                    result = contPos.CustInf(cboCustName.Text).ToArray();
                    ContPointOfSale.custID = result[0].ToString();
                    lblContact.Text = result[1].ToString();
                    lblAddress.Text = result[2].ToString();
                }
                //transactions.transac_ID, products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value) AS prodDesc, TRUNCATE(discounted_price,2) AS discPrice, product_prices.discount, quantity, total
                DataTable dt = new DataTable();
                dt = contPos.LoadOngoingProductTrans(transacID);
                if (dt.Rows.Count > 0) {
                    if (!IsSameItem()) {
                        for (int i = 0; i < dt.Rows.Count; i++) {
                            DataRow dr = dt.Rows[i];
                            ListViewItem listitem = new ListViewItem(((lvItems.Items.Count) + 1).ToString());
                            listitem.SubItems.Add(dr["product_ID"].ToString()); //0
                            listitem.SubItems.Add(dr["product_name"].ToString()); //1
                            listitem.SubItems.Add(dr["category_name"].ToString()); //1
                            listitem.SubItems.Add(dr["brand_name"].ToString());
                            listitem.SubItems.Add(dr["prodDesc"].ToString());
                            listitem.SubItems.Add(Convert.ToDecimal(dr["discPrice"]).ToString("C")); //3
                            listitem.SubItems.Add(dr["discount"].ToString() + "%"); //4
                            listitem.SubItems.Add(dr["quantity"].ToString()); //5
                            listitem.SubItems.Add(Convert.ToDecimal(dr["total"]).ToString("C")); //7
                            lvItems.Items.Add(listitem);
                        }
                    }
                } else {
                    MessageBox.Show("Barcode may not be found, no stocks in the inventory for the particular product, or the product price is not set.", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
