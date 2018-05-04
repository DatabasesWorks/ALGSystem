using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;



namespace ALG_POS_and_Inventory_Management_System
{
    class ContPrint
    {
        DbConnection dbcon = new DbConnection();
        public void printreceipt(string transacID)
        {
            CrystalReportReceipt reporting = new CrystalReportReceipt();
            dbcon.mysqlconnect.Open();
            string query = $"SELECT * FROM transactions,customers,products,prod_trans_rela,product_prices,brands,categories WHERE transactions.transac_ID = '{transacID}'AND transactions.customer_ID = customers.cust_ID AND prod_trans_rela.transac_ID = transactions.transac_ID AND product_prices.product_ID = prod_trans_rela.product_ID AND products.product_ID = prod_trans_rela.product_ID AND brands.brand_ID = products.brand_ID AND categories.category_ID = products.category_ID";
            MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
            MySqlDataAdapter adp = new MySqlDataAdapter();
            DataSet dt = new DataSet();
            adp.SelectCommand = cmd;
            adp.Fill(dt, "dsreceipt");

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
            cmd.Dispose(); cmd1.Dispose(); adp1.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();

            frmreports.ShowDialog();

        }
    }
}
