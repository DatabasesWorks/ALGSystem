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
    public partial class frmViewServicesOffered : Form {
        ContPointOfSale contPos = new ContPointOfSale();
        public frmViewServicesOffered() {
            InitializeComponent();
        }

        private void frmViewServicesOffered_Load(object sender, EventArgs e) {
            LoadServices(); LoadVehicleType();
        }
        void LoadServices() {
            lvServices.Items.Clear();
            DataTable dt = new DataTable();
            dt = contPos.LoadServices();
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["service_ID"].ToString());
                listitem.SubItems.Add(dr["service_name"].ToString());
                lvServices.Items.Add(listitem);
            }
        }

        void LoadVehicleType() {
            lvVehicleType.Items.Clear();
            DataTable dt = new DataTable();
            dt = contPos.LoadVehicleType();
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["vehicletype_ID"].ToString());
                listitem.SubItems.Add(dr["vehicle_type"].ToString());
                lvVehicleType.Items.Add(listitem);
            }
        }

        void SelectServicePrice() {
            if (lvServices.SelectedItems.Count>0 && lvVehicleType.SelectedItems.Count > 0) {
                string serviceID = lvServices.SelectedItems[0].SubItems[1].Text;
                string vehiclID = lvVehicleType.SelectedItems[0].SubItems[1].Text;
                try {
                    var price = contPos.GetServicePriceEasier(serviceID, vehiclID);
                    if (price == "" || price == null)
                        lblServicePrice.Text = "Price not Set";
                    else
                        lblServicePrice.Text = decimal.Parse(price).ToString("C");
                } catch (Exception ex) {
                    lblServicePrice.Text = "Price not Set";
                    MessageBox.Show("error on selecting service price id " + ex.Message);
                }
            }
        }

        private void lvServices_SelectedIndexChanged(object sender, EventArgs e) {
            SelectServicePrice();
            foreach (ListViewItem item in lvServices.Items) {
                item.BackColor = Color.White;
            }
            foreach (ListViewItem item in lvServices.SelectedItems) {
                item.BackColor = Color.CornflowerBlue;
            }

            if (lvServices.SelectedItems.Count > 0) {
                string serviceID = lvServices.SelectedItems[0].SubItems[1].Text;
                //loads added services
                lvAddedservice.Items.Clear();
                DataTable dt = new DataTable();
                dt = contPos.LoadAddedServicesEasier(serviceID);
                for (int i = 0; i < dt.Rows.Count; i++) {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem((i + 1).ToString());
                    listitem.SubItems.Add(dr["serv_added_ID"].ToString());
                    listitem.SubItems.Add(dr["serv_added_name"].ToString());
                    listitem.SubItems.Add(decimal.Parse(dr["serv_added_price"].ToString()).ToString("C"));
                    lvAddedservice.Items.Add(listitem);
                }
            }
        }

        private void lvServices_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up) {
                SelectServicePrice();
                foreach (ListViewItem item in lvServices.Items) {
                    item.BackColor = Color.White;
                }
                foreach (ListViewItem item in lvServices.SelectedItems) {
                    item.BackColor = Color.CornflowerBlue;
                }
            }
            if (lvServices.SelectedItems.Count > 0) {
                string serviceID = lvServices.SelectedItems[0].SubItems[1].Text;
                //loads added services
                lvAddedservice.Items.Clear();
                DataTable dt = new DataTable();
                dt = contPos.LoadAddedServicesEasier(serviceID);
                for (int i = 0; i < dt.Rows.Count; i++) {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem((i + 1).ToString());
                    listitem.SubItems.Add(dr["serv_added_ID"].ToString());
                    listitem.SubItems.Add(dr["serv_added_name"].ToString());
                    listitem.SubItems.Add(decimal.Parse(dr["serv_added_price"].ToString()).ToString("C"));
                    lvAddedservice.Items.Add(listitem);
                }
            }
        }

        private void lvVehicleType_SelectedIndexChanged(object sender, EventArgs e) {
            SelectServicePrice();
            foreach (ListViewItem item in lvVehicleType.Items) {
                item.BackColor = Color.White;
            }
            foreach (ListViewItem item in lvVehicleType.SelectedItems) {
                item.BackColor = Color.CornflowerBlue;
            }
        }

        private void lvVehicleType_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up) {
                SelectServicePrice();
                foreach (ListViewItem item in lvVehicleType.Items) {
                    item.BackColor = Color.White;
                }
                foreach (ListViewItem item in lvVehicleType.SelectedItems) {
                    item.BackColor = Color.CornflowerBlue;
                }
            }
        }

        private void lvServices_Click(object sender, EventArgs e) {
            
        }
    }
}
