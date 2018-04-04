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
    public partial class uCServices : UserControl {
        uCServicesServiceOffered ucServiceOffered = new uCServicesServiceOffered();
        uCServicesAdditionalService uCAdditionalService = new uCServicesAdditionalService();
        uCServicesServicePrice ucServicePrice = new uCServicesServicePrice();
        uCServicesVehicleTypes ucVehicleTypes = new uCServicesVehicleTypes();
        public uCServices() {
            InitializeComponent();
        }

        private void uCServices_Load(object sender, EventArgs e) {
            AddTabs();
        }
        void AddTabs() {
            //adds ucServicesServiceOffered to tabServiceOffered in tabcontrol
            tabServiceOffered.Controls.Clear();
            tabServiceOffered.Controls.Add(ucServiceOffered);
            //service prices
            tabServicePrice.Controls.Clear();
            tabServicePrice.Controls.Add(ucServicePrice);
            //vehicletypes
            tabVehicleTypes.Controls.Clear();
            tabVehicleTypes.Controls.Add(ucVehicleTypes);
            //additional service
            tabAdditionalChargees.Controls.Clear();
            tabAdditionalChargees.Controls.Add(uCAdditionalService);
        }
    }
}
