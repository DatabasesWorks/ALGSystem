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
    public partial class uCInventoryStocks : UserControl {
        ContInventoryStocks ContInventoryStocks = new ContInventoryStocks();
        bool sAdd = false, sDeduct = false, sEdit = false, cChange = false;

        public uCInventoryStocks() {
            InitializeComponent();
        }

        private void uCInventoryStocks_Load(object sender, EventArgs e) {
            LoadStocks();
            SetStockID();
            LoadProductsCbo(); LoadSuppliers();
            dtpReceive.Value = DateTime.Now;
        }
        void LoadStocks() {
            lvStocks.Items.Clear();
            DataTable table = new DataTable();
            table = ContInventoryStocks.LoadStocks(cboSSort.Text);
            ListViewItem iItem;
            foreach (DataRow row in table.Rows) {
                iItem = new ListViewItem();
                for (int i = 0; i < row.ItemArray.Length; i++) {
                    if (i == 0)
                        iItem.Text = row.ItemArray[i].ToString();
                    else if (i == 3)
                        iItem.SubItems.Add("temp description");
                    else if (i == 6)
                        iItem.SubItems.Add((row.ItemArray[i].ToString()).Substring(0, 10));
                    else if (i == 8)
                        iItem.SubItems.Add(Convert.ToDecimal(row.ItemArray[i].ToString()).ToString("C"));
                    else
                        iItem.SubItems.Add(row.ItemArray[i].ToString());
                }
                lvStocks.Items.Add(iItem);
            }
        }
        void SetStockID() {
            lblStockID.Text = ContInventoryStocks.SelectMaxID();
        }
        void LoadProductsCbo() {
            List<string> list = new List<string>();

            list = ContInventoryStocks.LoadProductID();
            cboSProductID.Items.Clear();
            foreach(string item in list) {
                cboSProductID.Items.Add(item);
            }

            list = ContInventoryStocks.LoadProductName();
            cboSProductName.Items.Clear();
            foreach (string item in list) {
                cboSProductName.Items.Add(item);
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
            cboSProductName.Text = cboSProductID.Text = ""; numSQuan.Minimum = 0; numDeduct.Minimum = 0; numSQuan.Value = 0; numDeduct.Value = 0; dtpReceive.Value = DateTime.Now; numSSupPrice.Value = 0; cboSSuppliers.Text = "";
            SetStockID();
            sAdd = sDeduct = sEdit = cChange = false;
            LoadStocks();
            btnRemoveZero.Enabled = true; btnSAdd.Enabled = true; cboSSuppliers.Text = ""; numSSupPrice.Value = 0; btnSChangePrice.Enabled = false; numDeduct.Enabled = true; btnSEdit.Enabled = false; btnSRemoveStocks.Enabled = false;
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
               if(ContInventoryStocks.IsDeductStock(lblStockID.Text, numSQuan.Value.ToString(),numDeduct.Value.ToString()))
                    btnSClear.PerformClick();

                //=========== logs
                //string sprodid = stock.product_ID;
                //string uid = user.GetUserID();
                //log.deduct_stock(uid, date, sprodid, "Deduct Stock ");
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
            btnSAdd.Enabled = false; btnSDeduct.Enabled = false; btnSRemoveStocks.Enabled = false;
            sEdit = true;
            sAdd = sDeduct = cChange = false;
            btnSChangePrice.Enabled = false; numDeduct.Enabled = false;
            numSQuan.Enabled = true; numSQuan.Focus(); btnSSave.Enabled = true; btnSEdit.Enabled = false; numSQuan.Value = 0;
        }

        private void btnSDeduct_Click(object sender, EventArgs e) {
            sDeduct = true;
            sAdd = sEdit = cChange = false;
            numDeduct.Enabled = btnSSave.Enabled = true;
            numSQuan.Enabled = btnSEdit.Enabled = btnSDeduct.Enabled = btnSChangePrice.Enabled = btnRemoveZero.Enabled = btnSRemoveStocks.Enabled = false;
            numDeduct.Focus(); numDeduct.Maximum = numSQuan.Value;
        }

        private void btnSChangePrice_Click(object sender, EventArgs e) {
            cChange = true;
            sAdd = sEdit = sDeduct = false;
            numSSupPrice.Focus();
            numSSupPrice.Enabled = btnSSave.Enabled = true;
            btnSChangePrice.Enabled = btnSEdit.Enabled = btnSDeduct.Enabled = btnSRemoveStocks.Enabled = false;
        }

        private void lvStocks_SelectedIndexChanged(object sender, EventArgs e) {
            decimal fee;
            if (lvStocks.SelectedItems.Count > 0) {
                ListViewItem item = lvStocks.SelectedItems[0];
                lblStockID.Text = item.SubItems[0].Text;
                cboSProductID.Text = item.SubItems[1].Text;
                cboSProductName.Text = item.SubItems[2].Text;
                numSQuan.Value = Convert.ToDecimal(item.SubItems[5].Text);
                dtpReceive.Value =  DateTime.ParseExact(item.SubItems[6].Text, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                cboSSuppliers.Text = item.SubItems[7].Text;
                fee = decimal.Parse(item.SubItems[8].Text,System.Globalization.NumberStyles.Currency);
                numSSupPrice.Value = fee;
                btnSAdd.Enabled = false; btnSSave.Enabled = false; btnSEdit.Enabled = true; btnSRemoveStocks.Enabled = true; btnSDeduct.Enabled = true; btnRemoveZero.Enabled = false; SLock(); sAdd = false; sEdit = false; cChange = false; btnSChangePrice.Enabled = true; numDeduct.Enabled = false;
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

        private void label14_Click(object sender, EventArgs e) {

        }

        private void label15_Click(object sender, EventArgs e) {

        }

        private void btnSAdd_Click(object sender, EventArgs e) {
            SUnLock();
            cboSProductName.Enabled = cboSProductID.Enabled = dtpReceive.Enabled = true;
            btnSSave.Enabled = true;
            btnRemoveZero.Enabled = btnSAdd.Enabled = btnSChangePrice.Enabled = false;
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
