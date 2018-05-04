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
    public partial class uCInventoryStocksProduct : UserControl {
        public static bool showRunningOut;
        ContInventoryStocksProduct ContInventoryStocks = new ContInventoryStocksProduct();
        bool sAdd = false, sDeduct = false, sEdit = false, cChange = false;
        public uCInventoryStocksProduct() {
            InitializeComponent();
        }

        private void uCInventoryStocks_Load(object sender, EventArgs e) {
            if (showRunningOut)
                LoadRunningOutStocks();
            else
                LoadProducts(); //LoadStocks();
            SetStockID();
            LoadProductsCbo(); LoadSuppliers();
            dtpReceive.Value = DateTime.Now;
        }
        void LoadStocks() {
            lvStocks.Items.Clear();
            DataTable dt = new DataTable();
            dt = ContInventoryStocks.LoadStocks(cboSSort.Text);
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["stock_ID"].ToString());
                listitem.SubItems.Add(dr["prodID"].ToString());
                listitem.SubItems.Add(dr["product_name"].ToString());
                listitem.SubItems.Add(dr["prodDesc"].ToString());
                listitem.SubItems.Add(dr["total_stocks"].ToString());
                listitem.SubItems.Add(dr["remaining_stocks"].ToString());
                listitem.SubItems.Add(dr["dateProfiled"].ToString().Substring(0, 10));
                listitem.SubItems.Add(dr["supplier_name"].ToString());
                listitem.SubItems.Add(Convert.ToDecimal(dr["supplier_price"]).ToString("C"));

                lvStocks.Items.Add(listitem);
            }
        }

        void LoadProducts() {
            lvStocks.Items.Clear();
            DataTable dt = new DataTable();
            dt = ContInventoryStocks.LoadProducts(txtSearch.Text, cboSSort.Text);
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["product_ID"].ToString());
                listitem.SubItems.Add(dr["product_name"].ToString());
                listitem.SubItems.Add(dr["prodDesc"].ToString());
                listitem.SubItems.Add(dr["totalStocks"].ToString());
                listitem.SubItems.Add(dr["remStocks"].ToString());
                listitem.SubItems.Add(decimal.Parse((dr["product_price"].ToString())).ToString("C"));
                listitem.SubItems.Add(dr["discount"].ToString());
                listitem.SubItems.Add(decimal.Parse((dr["discounted_price"].ToString())).ToString("C"));
                //listitem.SubItems.Add(_contInvProducts.GetProductDescription((dr["product_ID"]).ToString()));
                lvStocks.Items.Add(listitem);
            }
        }

        void LoadRunningOutStocks() {
            lvStocks.Items.Clear();
            DataTable dt = new DataTable();
            dt = ContInventoryStocks.LoadStocks("running out");
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["stock_ID"].ToString());
                listitem.SubItems.Add(dr["prodID"].ToString());
                listitem.SubItems.Add(dr["product_name"].ToString());
                listitem.SubItems.Add(dr["prodDesc"].ToString());
                listitem.SubItems.Add(dr["total_stocks"].ToString());
                listitem.SubItems.Add(dr["remaining_stocks"].ToString());
                listitem.SubItems.Add(dr["dateProfiled"].ToString().Substring(0, 10));
                listitem.SubItems.Add(dr["supplier_name"].ToString());
                listitem.SubItems.Add(Convert.ToDecimal(dr["supplier_price"]).ToString("C"));

                lvStocks.Items.Add(listitem);
            }
        }
        void SetStockID() {
            lblStockID.Text = ContInventoryStocks.SelectMaxID();
        }
        void LoadProductsCbo() {
            List<string> list = new List<string>();

            list = ContInventoryStocks.LoadProductID();
            cboSProductID.Items.Clear();
            if (list != null) {
                foreach (string item in list) {
                    cboSProductID.Items.Add(item);
                }
            }
            
            list = ContInventoryStocks.LoadProductName();
            cboSProductName.Items.Clear();
            if(list!= null) {
                foreach (string item in list) {
                    cboSProductName.Items.Add(item);
                }
            }
            
        }
        void LoadSuppliers() {
            List<string> list = new List<string>();
            list = ContInventoryStocks.LoadSuppliers();
            cboSSuppliers.Items.Clear();
            foreach (string item in list) {
                cboSSuppliers.Items.Add(item);
            }
        }
        private void SLock() {
           cboSProductName.Enabled = cboSProductID.Enabled = numSQuan.Enabled = cboSSuppliers.Enabled = numSSupPrice.Enabled = false;
        }
        private void SUnLock() {
            cboSProductName.Enabled = cboSProductID.Enabled = numSQuan.Enabled = cboSSuppliers.Enabled = numSSupPrice.Enabled = true;
        }
        private void SClear() {
            SLock();
            cboSSuppliers.Text = cboSProductName.Text = cboSProductID.Text = "";
            LoadSuppliers(); LoadProductsCbo();
            numSSupPrice.Value = numSQuan.Minimum = numDeduct.Minimum = numSQuan.Value = numDeduct.Value = numSSupPrice.Value = 0;
            dtpReceive.Value = DateTime.Now; 
            SetStockID();
            sAdd = sDeduct = sEdit = cChange = false;
            LoadProducts();
            btnSAdd.Enabled = true;
            numDeduct.Enabled = btnSDeduct.Enabled = false;
            showRunningOut = false;
        }
        // make others false ie: when sadd = true, sedit = false
        private void btnSSave_Click(object sender, EventArgs e) {
            if (sAdd) {
                if (numSQuan.Value.ToString() == "0") {
                    MessageBox.Show("Quantity must not be equal to zero", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    numSQuan.Focus();
                } else if (lblStockID.Text == "" || cboSProductID.Text == "" || cboSSuppliers.Text == "" || numSSupPrice.Text == "0") {
                    MessageBox.Show("Please fill-up all fields", "Inventory",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                } else {
                    if (ContInventoryStocks.IsInsertStocks(lblStockID.Text, dtpReceive.Value.ToString("yyyy-MM-dd"), cboSProductID.Text, numSQuan.Value.ToString(),cboSSuppliers.Text, numSSupPrice.Value.ToString())) {
                        btnSClear.PerformClick();
                        //=========== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.addStock(uid, date, sprodid, "Added Stock ");
                    }
                }
            } else if (sEdit) {
                if(ContInventoryStocks.IsUpdateStock(lblStockID.Text, numSQuan.Value.ToString()))
                    btnSClear.PerformClick();
                
                //=========== logs
                //string sprodid = stock.product_ID;
                //string uid = user.GetUserID();
                //log.update_stock(uid, date, sprodid, "Updated Stock ");
            } else if (sDeduct) {
                if (lvStocks.SelectedItems.Count > 0) {
                    string productID = lvStocks.SelectedItems[0].SubItems[1].Text;
                    if(ContInventoryStocks.IsDeductStock(productID, numSQuan.Value.ToString(),numDeduct.Value.ToString()))
                        btnSClear.PerformClick();

                    //=========== logs
                    //string sprodid = stock.product_ID;
                    //string uid = user.GetUserID();
                    //log.deduct_stock(uid, date, sprodid, "Deduct Stock ");
                }
               
            } else if (cChange) {
                if(ContInventoryStocks.IsChangePrice(lblStockID.Text,numSSupPrice.Value.ToString()))
                    btnSClear.PerformClick();

                //=========== logs
                //string sprodid = stock.product_ID;
                //string uid = user.GetUserID();
                //log.change(uid, date, sprodid, "Change Product Price ");
            }
        }

        private void btnSClear_Click(object sender, EventArgs e) {
            SClear();
        }

        private void btnSEdit_Click(object sender, EventArgs e) {
            btnSDeduct.Enabled = btnSAdd.Enabled = false; btnSDeduct.Enabled = false;
            sEdit = true;
            sAdd = sDeduct = cChange = false;
            numDeduct.Enabled = false;
            numSQuan.Enabled = true; numSQuan.Focus(); btnSSave.Enabled = true; numSQuan.Value = 0;

            timer1.Start(); numSQuan.Focus(); numSQuan.BackColor = Color.RoyalBlue;
        }

        private void btnSDeduct_Click(object sender, EventArgs e) {
            sDeduct = true;
            sAdd = sEdit = cChange = false;
            numDeduct.Enabled = btnSSave.Enabled = true;
            numSQuan.Enabled = btnSDeduct.Enabled = false;
            numDeduct.Focus(); numDeduct.Maximum = numSQuan.Value;

            timer1.Start(); numDeduct.Focus(); numDeduct.BackColor = Color.RoyalBlue;
        }

        private void btnSChangePrice_Click(object sender, EventArgs e) {
            cChange = true;
            sAdd = sEdit = sDeduct = false;
            numSSupPrice.Focus();
            numSSupPrice.Enabled = btnSSave.Enabled = true;
            btnSDeduct.Enabled = false;

            timer1.Start(); numSSupPrice.Focus(); numSSupPrice.BackColor = Color.RoyalBlue;
        }

        private void lvStocks_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvStocks.SelectedItems.Count > 0) {
                ListViewItem item = lvStocks.SelectedItems[0];
                if (!cboSProductID.Items.Contains(item.SubItems[1].Text)) {
                    cboSProductID.Items.Add(item.SubItems[1].Text);
                }
                cboSProductID.Text = item.SubItems[1].Text;
                if (!cboSProductName.Items.Contains(item.SubItems[2].Text)) {
                    cboSProductName.Items.Add(item.SubItems[2].Text);
                }
                cboSProductName.Text = item.SubItems[2].Text;
                numSQuan.Value = Convert.ToDecimal(item.SubItems[5].Text);
                btnSAdd.Enabled = false; btnSSave.Enabled = false; btnSDeduct.Enabled = true; SLock(); sAdd = false; sEdit = false; cChange = false; numDeduct.Enabled = false;
            }
        }

        private void btnRemoveZero_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all zero stocks?", "Inventory", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
               if(ContInventoryStocks.IsRemoveZeroStock())
                    btnSClear.PerformClick();
                //=========== logs
                //string sprodid = stock.product_ID;
                //string uid = user.GetUserID();
                //log.removeStock(uid, date, sprodid, "Remove Stock ");
            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }

        private void btnSRemoveStocks_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this stock?", "Inventory", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                if(ContInventoryStocks.IsDeleteStock(lblStockID.Text))
                    btnSClear.PerformClick();

                //=========== logs
                //string sprodid = stock.product_ID;
                //string uid = user.GetUserID();
                //log.removeStock(uid, date, sprodid, "Remove Stock ");
            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }

        private void cboSSort_SelectedIndexChanged(object sender, EventArgs e) {
            LoadStocks();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            timer1.Stop();
            numSSupPrice.BackColor = numSQuan.BackColor = numDeduct.BackColor = Color.CornflowerBlue;
        }

        private void btnShowCritical_Click(object sender, EventArgs e) {
            ContMain contMain = new ContMain();
            contMain.SelectStocksRunningOut();
            btnSClear.PerformClick();
            LoadRunningOutStocks();
        }

        private void btnShowAllStocks_Click(object sender, EventArgs e) {
            btnSClear.PerformClick();
            LoadStocks();
        }

        private void btnSAdd_Click(object sender, EventArgs e) {
            SUnLock();
            cboSProductName.Enabled = cboSProductID.Enabled = dtpReceive.Enabled = true;
            btnSSave.Enabled = true;
            btnSDeduct.Enabled= btnSAdd.Enabled = false;
            sAdd = true;
            sDeduct =  sEdit =  cChange = false;
            SetStockID();
        }

        private void cboSProductID_SelectedIndexChanged(object sender, EventArgs e) {
            cboSProductName.Text = ContInventoryStocks.SelectProductName(cboSProductID.Text)[0];
        }

        private void cboSProductName_SelectedIndexChanged(object sender, EventArgs e) {
            cboSProductID.Text = ContInventoryStocks.SelectProductID(cboSProductName.Text)[0];
        }
    }
}
