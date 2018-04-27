﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALG_POS_and_Inventory_Management_System {
    public partial class ucTransactionLogs : UserControl {
        ContTransactionLogs conTransLogs = new ContTransactionLogs();
        public ucTransactionLogs() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void lblAddress_Click(object sender, EventArgs e) {

        }

        private void ucTransactionLogs_Load(object sender, EventArgs e) {

        }

        private void cboCustName_SelectedIndexChanged(object sender, EventArgs e) {
            string transacID = cboCustName.Text;
            try {
                if (transacID != "") {
                    frmPosPay.isOngoing = true;
                    List<string> list = new List<string>();
                    list = conTransLogs.GetOngoingTransDetails(transacID);
                    if (list != null) {
                        //lblTransNo.Text = list[0];
                        cboCustName.Text = list[1];
                        lblDiscount.Text = list[2];
                        lblDiscAmount.Text = Convert.ToDecimal(list[3]).ToString("C");
                        lblTotalAmount.Text = Convert.ToDecimal(list[4]).ToString("C");
                        lblPaid.Text = Convert.ToDecimal(list[5]).ToString("C");
                        lblBalance.Text = Convert.ToDecimal(list[6]).ToString("C");
                        lblTotalItems.Text = Convert.ToDecimal(list[7]).ToString("C");
                        lblTotalService.Text = Convert.ToDecimal(list[8]).ToString("C");
                        string[] result;
                        result = conTransLogs.CustInf(cboCustName.Text).ToArray();
                        ContPointOfSale.custID = result[0].ToString();
                        lblContact.Text = result[1].ToString();
                        lblAddress.Text = result[2].ToString();
                    }
                    //transactions.transac_ID, products.product_ID,product_name, category_name, brand_name, GROUP_CONCAT(DISTINCT product_desc_value) AS prodDesc, TRUNCATE(discounted_price,2) AS discPrice, product_prices.discount, quantity, total
                    lvItems.Items.Clear();
                    DataTable dt = new DataTable();
                    dt = conTransLogs.LoadOngoingProductTrans(transacID);
                    if (dt.Rows.Count > 0) {
                        //if (!IsSameItem()) {
                            for (int i = 0; i < dt.Rows.Count; i++) {
                                DataRow dr = dt.Rows[i];
                                ListViewItem listitem = new ListViewItem(((lvItems.Items.Count) + 1).ToString());
                                listitem.SubItems.Add(dr["product_ID"].ToString()); //0
                                listitem.SubItems.Add(dr["product_name"].ToString()); //1
                                listitem.SubItems.Add(dr["category_name"].ToString()); //1
                                listitem.SubItems.Add(dr["brand_name"].ToString());
                                listitem.SubItems.Add(dr["prodDesc"].ToString());
                                listitem.SubItems.Add(Convert.ToDecimal(dr["discPrice"]).ToString("C")); //3
                                listitem.SubItems.Add(dr["discount"].ToString() + "%"); //4
                                listitem.SubItems.Add(dr["quantity"].ToString()); //5
                                listitem.SubItems.Add(Convert.ToDecimal(dr["total"]).ToString("C")); //7
                                listitem.SubItems.Add(dr["quantity"].ToString());
                                lvItems.Items.Add(listitem);
                            }
                        //}
                    }
                    //customer_vehicle.plate_no, vehicle_types.vehicle_type,  vehicle_brands.vehicle_brand_name, customer_vehicle.model, customer_vehicle.color, CONCAT(services.service_name,' (P ',service_prices.service_fee,')') service, service_transac.total_amount, GROUP_CONCAT(DISTINCT CONCAT(employees.emp_fName,', ',employees.emp_gName,' ',employees.emp_mInitial) SEPARATOR '/ ') AS empName, GROUP_CONCAT(DISTINCT CONCAT(added_service_price.serv_added_name,' (P ',added_service_price.serv_added_price,')' ) SEPARATOR '/') addedService, GROUP_CONCAT(DISTINCT employees.emp_ID SEPARATOR '/') AS empID,GROUP_CONCAT(DISTINCT added_service_price.serv_added_ID SEPARATOR '/') AS addedServiceID, service_status
                    lvServices.Items.Clear();
                    DataTable table = new DataTable();
                    table = conTransLogs.LoadOngoingServicesTrans(transacID);
                    if (table.Rows.Count > 0) {
                        //if (!IsSameItem()) {
                            for (int i = 0; i < table.Rows.Count; i++) {
                                DataRow dr = table.Rows[i];
                                ListViewItem listitem = new ListViewItem(((lvServices.Items.Count) + 1).ToString());
                                listitem.SubItems.Add(dr["plate_no"].ToString());
                                listitem.SubItems.Add(dr["vehicle_type"].ToString());
                                listitem.SubItems.Add(dr["vehicle_brand_name"].ToString());
                                listitem.SubItems.Add(dr["model"].ToString());
                                listitem.SubItems.Add(dr["color"].ToString());
                                listitem.SubItems.Add(dr["service"].ToString());
                                listitem.SubItems.Add(Convert.ToDecimal(dr["total_amount"]).ToString("C"));
                                listitem.SubItems.Add(dr["empName"].ToString());
                                listitem.SubItems.Add(dr["addedService"].ToString());
                                listitem.SubItems.Add(dr["empID"].ToString());
                                listitem.SubItems.Add(dr["addedServiceID"].ToString());
                                listitem.SubItems.Add(dr["service_status"].ToString());
                                listitem.SubItems.Add(dr["servtransac_ID"].ToString());
                                lvServices.Items.Add(listitem);
                            }
                        //}
                        cboCustName.Enabled = false;
                    } else {
                        //MessageBox.Show("Barcode may not be found, no stocks in the inventory for the particular product, or the product price is not set.", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception ex ) {
                MessageBox.Show("Error on loading transaction logs: " + ex.Message , "Transaction Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
