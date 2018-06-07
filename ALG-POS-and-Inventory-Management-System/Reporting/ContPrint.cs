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
            try
            {
                CrystalReportReceipt reporting = new CrystalReportReceipt();
                dbcon.mysqlconnect.Open();
                string query = $"SELECT * FROM transactions,customers,products,prod_trans_rela,product_prices,brands,categories WHERE transactions.transac_ID = '{transacID}'AND transactions.customer_ID = customers.cust_ID AND prod_trans_rela.transac_ID = transactions.transac_ID AND product_prices.product_ID = prod_trans_rela.product_ID AND products.product_ID = prod_trans_rela.product_ID AND brands.brand_ID = products.brand_ID AND categories.category_ID = products.category_ID";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                MySqlDataAdapter adp = new MySqlDataAdapter();
                DataSet dt = new DataSet();
                adp.SelectCommand = cmd;
                adp.Fill(dt, "dsreceipt");

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
        public void printproduct (string search, string searchBy)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlConnection mysqlconnect = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost ; User Id=root; Password= ;Database=algdb(2.0)");
                //string query = $"SELECT * FROM product_print WHERE category_name = 'Gasoline Engine Oil'";
                string query;
                if (searchBy == "Product ID")
                {
                    query = $"SELECT * FROM product_print WHERE product_ID LIKE '{search}'";
                }
                else if (searchBy == "Product Name")
                {
                    query = $"SELECT * FROM product_print WHERE product_name LIKE '{search}'";
                }
                else if (searchBy == "Brand")
                {
                    query = $"SELECT * FROM product_print WHERE brand_name LIKE '{search}'";
                }
                else if (searchBy == "Category")
                {
                    query = $"SELECT * FROM product_print WHERE category_name LIKE '{search}'";
                }
                else if (searchBy == "Description")
                {
                    query = $"SELECT * FROM product_print WHERE product_desc_value LIKE '{search}'";
                }
                else
                    #region old query
                    #endregion
                    query = "SELECT * FROM product_print";

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
    }
}
