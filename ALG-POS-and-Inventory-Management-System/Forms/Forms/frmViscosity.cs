using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public partial class frmViscosity : Form
    {
        classDatabaseConnect dbcon = new classDatabaseConnect(); bool add=false, edit=false; string query;
        public frmViscosity()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVisc.SelectedItems.Count > 0)
            {
                ListViewItem item = lvVisc.SelectedItems[0];
                txtViscNum.Text = item.SubItems[0].Text;
                txtViscName.Text = item.SubItems[1].Text;
                btnAdd.Enabled = false; btnEdit.Enabled = true;btnDelete.Enabled = true;btnSave.Enabled = false;
            }
            else
            {
                //
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false; btnSave.Enabled = true; txtViscName.Enabled = true;
            string res=""; add = true;
            try
            {
                query = "SELECT MAX(viscosity_ID) FROM viscosity";
                dbcon.mysqlconnect.Open();
                MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
                myCommand.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read()) { res = reader.GetString(0); res = (Convert.ToInt16(res) + 1).ToString(); }
                }
                else
                {
                    res = "0";
                }
                dbcon.mysqlconnect.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                // return false;   'no result is returned
            }
            txtViscNum.Text = res;
         }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false; btnSave.Enabled = true; edit = true;btnDelete.Enabled = false; txtViscName.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this viscosity?", "Inventory", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query = "DELETE FROM viscosity WHERE viscosity_ID='" + txtViscNum.Text+"'";
                dbcon.ManipulateData(query);
                MessageBox.Show("Deleted a viscosity", "Inventory");
                btnClear.PerformClick();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        private void LoadLV()
        {
            lvVisc.Items.Clear();
            try { 
                query = "SELECT viscosity_ID,viscosity_name FROM viscosity";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvVisc.View = View.Details;
                ListViewItem iItem;
                foreach (DataRow row in table.Rows)
                {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                    }
                    lvVisc.Items.Add(iItem);
                }

            dbcon.mysqlconnect.Close();
             }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadLV(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; txtViscName.Text = ""; txtViscNum.Text = ""; txtViscName.Enabled = false;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadLV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtViscName.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide a viscosity name");
                txtViscName.Focus();
            }
            else {
                string id = txtViscNum.Text, name = txtViscName.Text;
                if (add)
                {
                    add = false;
                    dbcon.mysqlconnect.Open();
                    query = "INSERT INTO viscosity SET viscosity_ID=@viscID, viscosity_name=@viscName";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@viscID", id);
                    cmd.Parameters.AddWithValue("@viscName", name);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    dbcon.mysqlconnect.Close();
                    MessageBox.Show("Added a new product viscosity", "Inventory");
                }else if (edit)
                {
                    edit = false;
                    dbcon.mysqlconnect.Open();
                    query = "UPDATE viscosity SET viscosity_name=@viscName WHERE viscosity_ID=@viscID";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@viscID", id);
                    cmd.Parameters.AddWithValue("@viscName", name);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    dbcon.mysqlconnect.Close();
                    MessageBox.Show("Updated a product viscosity", "Inventory");
                }
                btnClear.PerformClick();
            }
        }
    }
}
