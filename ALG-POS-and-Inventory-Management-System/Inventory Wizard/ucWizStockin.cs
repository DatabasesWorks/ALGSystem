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
    public partial class ucWizStockin : UserControl {
        ContInventoryStocks ContInventoryStocks = new ContInventoryStocks();
        public ucWizStockin() {
            InitializeComponent();
        }

        private void ucWizStockin_Load(object sender, EventArgs e) {
            SetStockID();
            LoadProductsCbo(); LoadSuppliers();
            dtpReceive.Value = DateTime.Now;
            cboSProductID.Text = frmInventoryWizard.productID;
            cboSProductName.Text = frmInventoryWizard.productName;
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
        private void cboSProductID_SelectedIndexChanged(object sender, EventArgs e) {
             try {
                cboSProductName.Text = ContInventoryStocks.SelectProductName(cboSProductID.Text)[0];
            } catch (Exception ex) {
                Console.WriteLine("error on cboSProductID_SelectedIndexChanged: " + ex.Message);
            }
        }

        private void cboSProductName_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                cboSProductID.Text = ContInventoryStocks.SelectProductID(cboSProductName.Text)[0];
            } catch (Exception ex) {
                Console.WriteLine("error on cboSProductName_SelectedIndexChanged: " + ex.Message);
            }
        }

        private void btnProdSave_Click(object sender, EventArgs e) {
            if (numSQuan.Value.ToString() == "0") {
                MessageBox.Show("Quantity must not be equal to zero", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                numSQuan.Focus();
            } else if (lblStockID.Text == "" || cboSProductID.Text == "" || cboSSuppliers.Text == "" || numSSupPrice.Text == "0") {
                MessageBox.Show("Please fill-up all fields", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            } else {
                if (ContInventoryStocks.IsInsertStocks(lblStockID.Text, dtpReceive.Value.ToString("yyyy-MM-dd"), cboSProductID.Text, numSQuan.Value.ToString(), cboSSuppliers.Text, numSSupPrice.Value.ToString())) {
                    SClear();
                    //=========== logs
                    //string sprodid = stock.product_ID;
                    //string uid = user.GetUserID();
                    //log.addStock(uid, date, sprodid, "Added Stock ");
                }
            }
        }
        private void SClear() {
            cboSSuppliers.Text = cboSProductName.Text = cboSProductID.Text = "";
            LoadSuppliers(); LoadProductsCbo();
            numSSupPrice.Value = numSQuan.Minimum = numSQuan.Value = numSSupPrice.Value = 0;
            dtpReceive.Value = DateTime.Now;
            SetStockID();
        }

        private void btnPriceClear_Click(object sender, EventArgs e) {
            SClear();
        }
    }
}
