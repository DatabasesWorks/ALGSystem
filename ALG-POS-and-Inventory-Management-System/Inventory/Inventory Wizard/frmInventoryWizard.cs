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
    public partial class frmInventoryWizard : Form {
        public static string productID, productName;

        public frmInventoryWizard() {
            InitializeComponent();
        }
        private void frmInventoryWizard_Load(object sender, EventArgs e) {
            LoadProducts();
        }

        void LoadProducts() {
            ucWizProduct uc = new ucWizProduct();
            pnlWizard.Controls.Clear();
            pnlWizard.Controls.Add(uc);
        }

        void LoadStockIn() {
            ucWizStockin uc = new ucWizStockin();
            pnlWizard.Controls.Clear();
            pnlWizard.Controls.Add(uc);
        }

        void LoadProductPrice() {
            ucWizProductPrice uc = new ucWizProductPrice();
            pnlWizard.Controls.Clear();
            pnlWizard.Controls.Add(uc);
        }

        //========== buttons =============
        private void btnStockIn_Click(object sender, EventArgs e) {
            LoadStockIn();
            btnProducts.ForeColor = btnProductPrice.ForeColor = Color.Snow;
            btnStockIn.ForeColor = Color.MidnightBlue;
        }

        private void btnProductPrice_Click(object sender, EventArgs e) {
            LoadProductPrice();
            btnProducts.ForeColor = btnStockIn.ForeColor = Color.Snow;
            btnProductPrice.ForeColor = Color.MidnightBlue;
        }

        private void btnProducts_Click(object sender, EventArgs e) {
            LoadProducts();
            btnProductPrice.ForeColor = btnStockIn.ForeColor = Color.Snow;
            btnProducts.ForeColor = Color.MidnightBlue;
        }

    }
}
