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
    public partial class frmInventoryStocksSuppliers : Form {
        public frmInventoryStocksSuppliers() {
            InitializeComponent();
        }

        private void frmInventoryStocksSuppliers_Load(object sender, EventArgs e) {
            uCInventoryStocksSupplier ucObj = new uCInventoryStocksSupplier();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucObj);
        }
    }
}
