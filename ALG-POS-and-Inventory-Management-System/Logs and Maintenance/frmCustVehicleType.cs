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
    public partial class frmCustVehicleType : Form {
        public frmCustVehicleType() {
            InitializeComponent();
        }

        private void frmCustVehicleType_Load(object sender, EventArgs e) {
            uCServicesVehicleTypes ucvtype = new uCServicesVehicleTypes();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucvtype);
        }
    }
}
