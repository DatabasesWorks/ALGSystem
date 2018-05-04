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
    public partial class frmUcTesting : Form {
        public frmUcTesting() {
            InitializeComponent();
        }

        private void frmUcTesting_Load(object sender, EventArgs e) {
            ucTransactionLogs ucTransLogs = new ucTransactionLogs();
            pnlUc.Controls.Clear();
            pnlUc.Controls.Add(ucTransLogs);
        }
    }
}
