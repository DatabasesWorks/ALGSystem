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
    public partial class uCCustomerRecords : UserControl {
        public uCCustomerRecords() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManageCustomer frmManageCustomer = new frmManageCustomer();
            frmManageCustomer.ShowDialog();
        }
    }
}
