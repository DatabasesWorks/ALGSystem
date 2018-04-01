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
    public partial class uCInventory : UserControl {
        uCInventoryProducts uCInventoryProducts = new uCInventoryProducts();
        uCInventoryStocks uCInventoryStocks = new uCInventoryStocks();
        uCInventorySupplier uCInventorySupplier = new uCInventorySupplier();
        uCInventoryProductPrice uCInventoryProductPrice = new uCInventoryProductPrice();
        public uCInventory() {
            InitializeComponent();
        }

        private void uCInventory_Load(object sender, EventArgs e) {
            LoadProducts();
            LoadStocks();
            LoadSupplier();
            LoadProductPrice();
        }
        void LoadProducts() {
            tabProducts.Controls.Clear();
            tabProducts.Controls.Add(uCInventoryProducts);
        }
        void LoadStocks() {
            tabStocks.Controls.Clear();
            tabStocks.Controls.Add(uCInventoryStocks);
        }
        void LoadSupplier() {
            tabSuppliers.Controls.Clear();
            tabSuppliers.Controls.Add(uCInventorySupplier);
        }
        void LoadProductPrice() {
            tabProductPrice.Controls.Clear();
            tabProductPrice.Controls.Add(uCInventoryProductPrice);
        }
    }
}
