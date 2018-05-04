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
        public uCInventory() {
            InitializeComponent();
        }

        private void uCInventory_Load(object sender, EventArgs e) {
            //tabInventory.SelectedIndexChanged += new EventHandler(tabInventory_SelectedIndexChanged);
            LoadProducts();
            LoadStocks();
            LoadSupplier();
            LoadProductPrice();
        }
        void LoadProducts() {
            uCInventoryProducts uCInventoryProducts = new uCInventoryProducts();
            tabProducts.Controls.Clear();
            tabProducts.Controls.Add(uCInventoryProducts);
        }
        void LoadStocks() {
            uCInventoryStocksProduct uCInventoryStocks = new uCInventoryStocksProduct();
            tabStocks.Controls.Clear();
            tabStocks.Controls.Add(uCInventoryStocks);
        }
        void LoadSupplier() {
            uCInventorySupplier uCInventorySupplier = new uCInventorySupplier();
            tabSuppliers.Controls.Clear();
            tabSuppliers.Controls.Add(uCInventorySupplier);
        }
        void LoadProductPrice() {
            uCInventoryProductPrice uCInventoryProductPrice = new uCInventoryProductPrice();
            tabProductPrice.Controls.Clear();
            tabProductPrice.Controls.Add(uCInventoryProductPrice);
        }

        private void tabInventory_Selected(object sender, TabControlEventArgs e) {
            if (e.TabPage == tabProducts)
                LoadProducts();
            else if (e.TabPage == tabStocks)
                LoadStocks();
            else if (e.TabPage == tabSuppliers)
                LoadSupplier();
            else if (e.TabPage == tabProductPrice)
                LoadProductPrice();
        }

        private void tabInventory_SelectedIndexChanged(object sender, EventArgs e) {
            //if (tabInventory.SelectedTab == tabProducts)
            //    LoadProducts();
            //else if (tabInventory.SelectedTab == tabStocks)
            //    LoadStocks();
            //else if (tabInventory.SelectedTab == tabSuppliers)
            //    LoadSupplier();
            //else if (tabInventory.SelectedTab == tabProductPrice)
            //    LoadProductPrice();
        }
    }
}
