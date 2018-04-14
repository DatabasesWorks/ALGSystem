﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALG_POS_and_Inventory_Management_System {
    public partial class frmPosOngoingService : Form {
        ContPointOfSale contPos = new ContPointOfSale();
        public frmPosOngoingService() {
            InitializeComponent();
        }

        private void frmPosOngoingService_Load(object sender, EventArgs e) {
            LoadOngoingService();
        }
        void LoadOngoingService() {
            lvOngoingServices.Items.Clear();
            DataTable dt = new DataTable();
            dt = contPos.LoadOngoingServices(txtSearch.Text, cboSearch.Text);
            for (int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["transID"].ToString());
                listitem.SubItems.Add(dr["customerName"].ToString());
                listitem.SubItems.Add(dr["noOfCars"].ToString());
                listitem.SubItems.Add(dr["discounted_amount"].ToString());
                listitem.SubItems.Add(dr["paid"].ToString());
                listitem.SubItems.Add(dr["balance"].ToString());
                //listitem.SubItems.Add(_contInvProducts.GetProductDescription((dr["product_ID"]).ToString()));
                lvOngoingServices.Items.Add(listitem);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            if (lvOngoingServices.SelectedItems.Count > 0) {
                uCPointOfSale.transacID = lvOngoingServices.SelectedItems[0].SubItems[1].Text;
                this.Close();
            }
        }

        private void lvOngoingServices_DoubleClick(object sender, EventArgs e) {
            btnSelect.PerformClick();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            LoadOngoingService();
        }
    }
}
