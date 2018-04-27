using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace ALG_POS_and_Inventory_Management_System {
    public partial class uCServicesServicePrice : UserControl {
        public uCServicesServicePrice() {
            InitializeComponent();
        }
        DbConnection dbcon = new DbConnection();

        private void btnProdPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM transactions,customers,products,prod_trans_rela,product_prices,brands,categories WHERE transactions.transac_ID = '10000002'AND transactions.customer_ID = customers.cust_ID AND prod_trans_rela.transac_ID = transactions.transac_ID AND product_prices.product_ID = prod_trans_rela.product_ID AND products.product_ID = prod_trans_rela.product_ID AND brands.brand_ID = products.brand_ID AND categories.category_ID = products.category_ID";
                dbcon.mysqlconnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                MySqlDataAdapter adp = new MySqlDataAdapter();
                DataSet dt = new DataSet();
                adp.SelectCommand = cmd;
                adp.Fill(dt, "dsreceipt");
                CrystalReportReceipt reporting = new CrystalReportReceipt();
                reporting.SetDataSource(dt);
                frmReports frmreports = new frmReports();
                frmreports.crystalReportViewer.ReportSource = reporting;
                frmreports.crystalReportViewer.Refresh();
                cmd.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();
                frmreports.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
