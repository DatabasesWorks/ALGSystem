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
    public partial class frmPosAddService : Form {
        ContPointOfSale contPos = new ContPointOfSale();
        string servicePrice;
        public frmPosAddService() {
            InitializeComponent();
        }

        private void frmPosAddService_Load(object sender, EventArgs e) {
            lblBrand.Text = lblColor.Text = lblModel.Text = lblVehicleType.Text = "";
            lblFee.Text = "0.00";
            LoadPlateNo(); LoadEmployee();
        }

        void LoadPlateNo() {
            try {
                List<string> plateNo = new List<string>();
                plateNo = contPos.LoadPlateNo();
                if (plateNo != null) {
                    foreach (string item in plateNo) {
                        cboPlateNum.Items.Add(item);
                    }
                } else {
                    MessageBox.Show("Please register cars of the particular customer","Point of Sale", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    this.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error on loading plate numbers: " + ex.Message);
            }
        }

        private void cboPlateNum_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                List<string> list = new List<string>();
                list = contPos.LoadCarDetails(cboPlateNum.Text);
                //vehicle_brand_name, model, color, vehicle_type
                lblBrand.Text = list[0];
                lblModel.Text = list[1];
                lblColor.Text = list[2];
                lblVehicleType.Text = list[3];
                GetServicePrice();
                LoadServices();
            } catch (Exception ex) {
                MessageBox.Show("Error on loading plate numbers: " + ex.Message);
            }
        }

        void LoadEmployee() {
            try {
                List<string> list = new List<string>();
                list = contPos.LoadEmployees();
                if (list != null) {
                    foreach (string item in list) {
                        clbEmployee.Items.Add(item);
                    }
                } else {
                    MessageBox.Show("No is employee registerd", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error on loading plate numbers: " + ex.Message);
            }
        }

        void LoadServices() {
            try {
                cboServiceName.Items.Clear();
                List<string> services = new List<string>();
                services = contPos.LoadServices(lblVehicleType.Text);
                if (services != null) {
                    foreach (string item in services) {
                        cboServiceName.Items.Add(item);
                    }
                    cboServiceName.Enabled = true;
                } else {
                    MessageBox.Show("No services available for this vehicle type yet", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error on loading plate numbers: " + ex.Message);
            }
        }

        private void cboServiceName_SelectedIndexChanged(object sender, EventArgs e) {
            GetServicePrice();
            try {
                clbAddedService.Items.Clear();
                lblDescription.Text = "";
                lblDescription.Text = contPos.GetServiceDesc(cboServiceName.Text);
                foreach(string item in contPos.LoadAddedServices(cboServiceName.Text)) {
                    clbAddedService.Items.Add(item);
                }
            } catch (Exception ex) {
                Console.WriteLine("error on loading service added price: " + ex);
            }
            
        }
        void GetServicePrice() {
            try {
                string servicePrice;
                servicePrice = contPos.GetServicePrice(cboServiceName.Text, lblVehicleType.Text);
                if (servicePrice != null) {
                    lblFee.Text = servicePrice;
                    this.servicePrice = servicePrice;
                } else
                    lblFee.Text = "0.00";
            } catch (Exception ex) {
                lblFee.Text = "0.00";
                Console.WriteLine("error on selecting service price: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if(cboPlateNum.Text=="")
                MessageBox.Show("Please select customer vehicle plate number.", "Point of Sale",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (lblFee.Text=="0.00")
                MessageBox.Show("Please select service to be rendered.", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (clbEmployee.CheckedItems.Count==0)
                MessageBox.Show("Please select employee that will render the service.", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else {
                ContPointOfSale.plateNo = cboPlateNum.Text;
                ContPointOfSale.brand = lblBrand.Text;
                ContPointOfSale.model = lblModel.Text;
                ContPointOfSale.color = lblColor.Text;
                ContPointOfSale.vehicleType = lblVehicleType.Text;
                ContPointOfSale.serviceRendered = string.Format("{0} (P {1}) ",cboServiceName.Text,decimal.Parse(servicePrice).ToString("C"));
                ContPointOfSale.payment = lblFee.Text;
                int i = 0;
                foreach(string item in clbEmployee.CheckedItems) {
                    if (i == 0) {
                        ContPointOfSale.employees += item;
                        i = 1;
                    }else
                        ContPointOfSale.employees += " ; " + item;
                }
                i = 0;
                foreach (string item in clbAddedService.CheckedItems) {
                    if (i == 0) {
                        ContPointOfSale.addedService += item;
                        i = 1;
                    } else
                        ContPointOfSale.addedService += " ; " + item;
                }
                this.Close();
            }
        }

        private void clbAddedService_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void clbAddedService_ItemCheck(object sender, ItemCheckEventArgs e) {
            this.BeginInvoke(new Action(() =>
            {
                GetServicePrice();
                decimal addedPayment = 0;
                List<string> list = new List<string>();
                foreach (string item in clbAddedService.CheckedItems) {
                    list.Add(item);
                }
                addedPayment = contPos.GetAddedServicePrice(list);
                lblFee.Text = (decimal.Parse(lblFee.Text) + addedPayment).ToString();
            }));
        }
    }
}
