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
    public partial class frmSales : Form {
        ContSales contSales = new ContSales();
        public frmSales() {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e) {
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;

            LoadUsers();
            if (!cboUser.Items.Contains("ALL")) {
                cboUser.Items.Add("All");
            }
            cboUser.SelectedIndex = 0;

            LoadPaymentLv();
            LoadTotalTransactions();
            LoadBalance();
        }

        void LoadUsers() {
            cboUser.Items.Clear();
            cboUser.Items.Add("All");
            List<string> list = new List<string>();
            list = contSales.LoadUsers();
            if (list != null) {
                foreach(string item in list) {
                    cboUser.Items.Add(item);
                }
            }
        }

        void LoadPaymentLv() {
            lvSales.Items.Clear();
            DataTable dt = new DataTable();
            dt = contSales.LoadPayments(cboUser.Text, dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd"));
            for(int i = 0; i < dt.Rows.Count; i++) {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["datePaid"].ToString());
                listitem.SubItems.Add(dr["userName"].ToString());
                var sumPayment = Convert.ToDecimal(dr["sumPayment"].ToString()).ToString("C");
                listitem.SubItems.Add(sumPayment);
                lvSales.Items.Add(listitem);
            }
        }

        void LoadTotalTransactions() {
            List<string> list = new List<string>();
            list = contSales.GetTransactionsTotal(dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd"));
            if (list != null) {
                lblTotalSales.Text = Convert.ToDecimal(list[0]).ToString("C");
                lblVatable.Text = Convert.ToDecimal(list[1]).ToString("C");
                lblVat.Text = Convert.ToDecimal(list[2]).ToString("C");
            }
        }

        void LoadBalance() {
            List<string> list = new List<string>();
            list = contSales.GetBalance(dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd"));
            if (list != null) {
                lblUnsettledBalance.Text = Convert.ToDecimal(list[0]).ToString("C");
                lblNumUnsettled.Text = Convert.ToDecimal(list[1]).ToString("C");
            }
        }

        private void btnShowSales_Click(object sender, EventArgs e) {
            LoadPaymentLv();
            LoadTotalTransactions();
            LoadBalance();
        }

    }
}
