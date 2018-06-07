using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ALG_POS_and_Inventory_Management_System {
    public partial class frmTesting : Form {
        public frmTesting() {
            InitializeComponent();
        }

        private void frmTesting_Load(object sender, EventArgs e) {
            //uCServices userControl = new uCServices();
            //pnlTest.Controls.Clear();
            //pnlTest.Controls.Add(userControl);
        }

        private void pnlTest_Paint(object sender, PaintEventArgs e)
        {

        }
        DbConnection dbcon = new DbConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlConnection mysqlconnect = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost ; User Id=root; Password= ;Database=algdb(2.0)");
                string query = "SELECT * FROM product_print WHERE category_name = 'Gasoline Engine Oil'";
                mysqlconnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                MySqlDataAdapter adp = new MySqlDataAdapter();
                DataSet dt = new DataSet();
                adp.SelectCommand = cmd;
                adp.Fill(dt, "dsProduct");
                CrystalReportProduct reporting = new CrystalReportProduct();
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

        private void button2_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection mysqlconnect = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost ; User Id=root; Password= ;Database=algdb(2.0)");
            CrystalReportReceipt reporting = new CrystalReportReceipt();
            //dbcon.mysqlconnect.Open();
            mysqlconnect.Open();
            string query = "SELECT * FROM transactions,products,prod_trans_rela,product_prices,brands,categories WHERE transactions.transac_ID = '10000001'AND prod_trans_rela.transac_ID = transactions.transac_ID AND product_prices.product_ID = prod_trans_rela.product_ID AND products.product_ID = prod_trans_rela.product_ID AND brands.brand_ID = products.brand_ID AND categories.category_ID = products.category_ID";
            //string query = "SELECT * FROM transactions,customers,products,prod_trans_rela,product_prices,brands,categories WHERE transactions.transac_ID = '10000001'AND transactions.customer_ID = customers.cust_ID AND prod_trans_rela.transac_ID = transactions.transac_ID AND product_prices.product_ID = prod_trans_rela.product_ID AND products.product_ID = prod_trans_rela.product_ID AND brands.brand_ID = products.brand_ID AND categories.category_ID = products.category_ID";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                MySqlDataAdapter adp = new MySqlDataAdapter();
                DataSet dt = new DataSet();
                adp.SelectCommand = cmd;
                adp.Fill(dt,"dsreceipt");

                string query1 = "SELECT * FROM services";
                MySqlCommand cmd1 = new MySqlCommand(query1, dbcon.mysqlconnect);
                MySqlDataAdapter adp1 = new MySqlDataAdapter();
                DataSet dt1 = new DataSet();
                adp1.SelectCommand = cmd1;
                adp1.Fill(dt1, "services");

                reporting.SetDataSource(dt);
                //reporting.Database.Tables["dsreceipt"].SetDataSource(dt.Tables[0]);
                //reporting.Database.Tables["services"].SetDataSource(dt1.Tables[0]);
                frmReports frmreports = new frmReports();
                frmreports.crystalReportViewer.ReportSource = reporting;
                frmreports.crystalReportViewer.Refresh();
                cmd.Dispose(); cmd1.Dispose();  adp1.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();

                frmreports.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e){
            try
            {
                MySql.Data.MySqlClient.MySqlConnection mysqlconnect = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost ; User Id=root; Password= ;Database=algdb(2.0)");
                string query = "SELECT * FROM stocks_print";
                mysqlconnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                MySqlDataAdapter adp = new MySqlDataAdapter();
                DataSet dt = new DataSet();
                adp.SelectCommand = cmd;
                adp.Fill(dt, "dsStock");
                CrystalReportStock reporting = new CrystalReportStock();
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

        private void button4_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection mysqlconnect = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost ; User Id=root; Password= ;Database=algdb(2.0)");
            frmReports frmreports = new frmReports();
            mysqlconnect.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter("getTransaction",mysqlconnect);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("ID", MySql.Data.MySqlClient.MySqlDbType.Int32, 20).Value = textBox1.Text;
            DataSet dt = new System.Data.DataSet();
            adp.Fill(dt,"transaction");
            mysqlconnect.Close();

            //CrystalReport1 reporting = new CrystalReport1();
            //reporting.Database.Tables["transactions"].SetDataSource(dt.Tables[0]);
            //frmreports.crystalReportViewer.ReportSource = null;
            //frmreports.crystalReportViewer.ReportSource = reporting;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //frmReports frmreports = new frmReports();
            //CrystalReport3 reporting = new CrystalReport3();
            //frmreports.crystalReportViewer.ReportSource = null;
            //frmreports.crystalReportViewer.ReportSource = reporting;
            //frmreports.ShowDialog();
        }
    
    }
}
