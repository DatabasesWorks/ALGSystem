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
    public partial class frmTesting : Form {
        public frmTesting() {
            InitializeComponent();
        }

        private void frmTesting_Load(object sender, EventArgs e) {
            uCInventory userControl = new uCInventory();
            pnlTest.Controls.Clear();
            pnlTest.Controls.Add(userControl);
        }
    }
}
