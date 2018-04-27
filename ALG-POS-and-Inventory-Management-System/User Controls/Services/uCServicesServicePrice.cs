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
    public partial class uCServicesServicePrice : UserControl {
        ContServicesPrice contservprice = new ContServicesPrice();
        bool isAdd, isEdit;
        public uCServicesServicePrice() {
            InitializeComponent();
            ccbVehicleType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ccbVehicleType_ItemCheck);
        }

        private void uCServicesServicePrice_Load(object sender, EventArgs e) {
            LoadServicePrice();
            LoadVehicleTypes();
            LoadServices();
            //ccbVehicleType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ccbVehicleType_ItemCheck);
        }

        void LoadServicePrice() {
            DataTable dt = new DataTable();
            dt = contservprice.LoadServicePrices();
            lvPrices.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["service_price_ID"].ToString());
                listitem.SubItems.Add(dr["service_name"].ToString());
                listitem.SubItems.Add(dr["vehicle_type"].ToString());
                listitem.SubItems.Add(decimal.Parse(dr["service_fee"].ToString()).ToString("C"));
                lvPrices.Items.Add(listitem);
            }
        }

        private void ccbVehicleType_DropDownClosed(object sender, EventArgs e) {
            // Display all checked items.
            if (ccbVehicleType.CheckedItems.Count > 0) {
                StringBuilder sb = new StringBuilder("");
                foreach (CCBoxItem item in ccbVehicleType.CheckedItems) {
                    sb.Append(item.Name).Append(ccbVehicleType.ValueSeparator);
                }
                sb.Remove(sb.Length - ccbVehicleType.ValueSeparator.Length, ccbVehicleType.ValueSeparator.Length);
            }
        }

        bool allClicked = false;
        List<string> checkedNotAll = new List<string>();

        private void ccbVehicleType_ItemCheck(object sender, ItemCheckEventArgs e) {
            //CCBoxItem item = ccbVehicleType.Items[e.Index] as CCBoxItem;
            //if ($"{item.Name}" == "All") {
            //    //StringBuilder sb = new StringBuilder("");
            //    //foreach (CCBoxItem checkItem in ccbVehicleType.CheckedItems) {
            //    //    sb.Append(checkItem.Name).Append(ccbVehicleType.ValueSeparator);
            //    //}
            //    for (int i = 0; i < ccbVehicleType.Items.Count; i++) {

            //        var handler = (EventHandler<ItemCheckEventArgs<T>>)Delegate.CreateDelegate(typeof(EventHandler<GenericEventArgs<T>>), ccbVehicleType_ItemCheck.Target, value.Method);
            //        Event -= handler;
            //        ccbVehicleType.SetItemChecked(i, true);
            //        ccbVehicleType_ItemCheck += this.ccbVehicleType_ItemCheck;
            //    }
            //} else {
            //    checkedNotAll.Add(item.Name);
            //}
        }

        void LoadVehicleTypes() {
            ccbVehicleType.Items.Clear();
           
            List<string> vehicleType = new List<string>();
            vehicleType = contservprice.LoadVehicleTypes();
            for (int i = 0; i < vehicleType.Count; i++) {
                CCBoxItem item = new CCBoxItem(vehicleType[i], i+1);
                ccbVehicleType.Items.Add(item);
            }
            // If more then 5 items, add a scroll bar to the dropdown.
            ccbVehicleType.MaxDropDownItems = 5;
            // Make the "Name" property the one to display, rather than the ToString() representation.
            ccbVehicleType.DisplayMember = "Name";
            ccbVehicleType.ValueSeparator = ", ";
        }

        void LoadServices() {
            cboServiceName.Items.Clear();
            List<string> services = new List<string>();
            services = contservprice.LoadServices();
            foreach (string item in services) {
                cboServiceName.Items.Add(item);
            }
        }
        private void btnPAdd_Click(object sender, EventArgs e) {
            isAdd = true; btnPAdd.Enabled = false; btnPSave.Enabled = true; numFee.Enabled = true; cboServiceName.Enabled = true; ccbVehicleType.Enabled = true;
        }

        private void btnPEdit_Click(object sender, EventArgs e) {
            btnPEdit.Enabled = false; btnPSave.Enabled = true; isEdit = true; btnPDelete.Enabled = false; numFee.Enabled = true;
        }

        private void btnPSave_Click(object sender, EventArgs e) {
            if (cboServiceName.Text.Trim() == "" || ccbVehicleType.Text.Trim() == "" || numFee.Value <= 10) {
                MessageBox.Show("Please Provide valid Service, Vehicle Type, and Service Fee", "Services",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //cboServiceName.Focus();
            }else {
                List<string> vTypes = new List<string>();
                foreach(CCBoxItem item in ccbVehicleType.CheckedItems) {
                    vTypes.Add(item.Name);
                }
                if (isAdd) {
                    if (contservprice.IsInsertServicePrices(cboServiceName.Text, vTypes, numFee.Value.ToString())) {
                        isAdd = false;
                        MessageBox.Show("Added a service price.", "Services", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //string uid = user.GetUserID();
                        //string id = log.getServiceID();
                        //log.addServicePrice(uid, date, id, "Added new service price");
                        btnPClear.PerformClick();
                    }
                } else if (isEdit) {
                    if (contservprice.IsUpdateServicePrices(txtPriceID.Text, numFee.Value.ToString())) {
                        isEdit = false;
                        btnPClear.PerformClick();
                        MessageBox.Show("Updated a service price.", "Services", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //string uid = user.GetUserID();
                        //string uid = user.GetUserID();
                        //string id = log.getServiceID();
                        //log.editServicePrice(uid, date, id, "Updated Service Price ");
                        btnPClear.PerformClick();
                    }
                }
            }
        }

        private void btnPDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service price?", "Services", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                if (contservprice.IsDeleteServicePrice(txtPriceID.Text)) {
                    MessageBox.Show("Deleted a service", "Service", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    btnPClear.PerformClick();
                }
                //string uid = user.GetUserID();
                //string id = log.getServiceID();

                //log.deleteServicePrice(uid, date, id, "Deleted");
            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }

        private void cboServiceName_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void lvPrices_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvPrices.SelectedItems.Count > 0) {
                decimal fee;
                ListViewItem item = lvPrices.SelectedItems[0];
                txtPriceID.Text = item.SubItems[1].Text;
                cboServiceName.Text = item.SubItems[2].Text;
                ccbVehicleType.Text = item.SubItems[3].Text;
                fee = decimal.Parse(item.SubItems[4].Text, System.Globalization.NumberStyles.Currency);
                numFee.Value = fee;

                //log.setServiceID(txtPriceID.Text);
                btnPAdd.Enabled = false; btnPEdit.Enabled = true; btnPDelete.Enabled = true; btnPSave.Enabled = false; isAdd = false; isEdit = false; cboServiceName.Enabled = false; ccbVehicleType.Enabled = false; numFee.Enabled = false;
            } else {
                //
            }
        }

        //foreach(CCBoxItem item in ccbVehicleType.CheckedItems) {
        //    MessageBox.Show(item.Name);
        //}
        private void btnProdClear_Click(object sender, EventArgs e) {
            LoadServicePrice(); txtPriceID.Text = ""; cboServiceName.Text = ""; ccbVehicleType.Text = ""; numFee.Text = ""; btnPAdd.Enabled = true; btnPSave.Enabled = false; btnPDelete.Enabled = false; btnPEdit.Enabled = false; LoadServices(); LoadVehicleTypes(); cboServiceName.Enabled = false; ccbVehicleType.Enabled = false; numFee.Enabled = false;
        }
    }
}
