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
namespace WindowsFormsApplication1 {
    public partial class frmBrands : Form {
        public frmBrands() {
            InitializeComponent();
        }
        classDatabaseConnect dbcon = new classDatabaseConnect(); bool add = false, edit = false; string query;
        private void btnAdd_Click(object sender, EventArgs e) {
            btnAdd.Enabled = false; btnSave.Enabled = true; txtBrandName.Enabled = true;
            string res = ""; add = true;
            try {
                query = "SELECT MAX(brand_ID) FROM brand";
                dbcon.mysqlconnect.Open();
                MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
                myCommand.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = myCommand.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) { res = reader.GetString(0); res = (Convert.ToInt16(res) + 1).ToString(); }
                } else {
                    res = "0";
                }
                dbcon.mysqlconnect.Close();
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                // return false;   'no result is returned
            }
            txtBrandNum.Text = res;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            btnEdit.Enabled = false; btnSave.Enabled = true; edit = true; btnDelete.Enabled = false; txtBrandName.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this brand?", "Inventory", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                query = "DELETE FROM brand WHERE brand_ID='" + txtBrandNum.Text + "'";
                dbcon.ManipulateData(query);
                MessageBox.Show("Deleted a brand", "Inventory");
                btnClear.PerformClick();
            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }
        private void LoadLV() {
            lvBrand.Items.Clear();
            try {
                query = "SELECT brand_ID,brand_name FROM brand";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvBrand.View = View.Details;
                ListViewItem iItem;
                foreach (DataRow row in table.Rows) {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++) {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                    }
                    lvBrand.Items.Add(iItem);
                }

                dbcon.mysqlconnect.Close();
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e) {
            LoadLV(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; txtBrandName.Text = ""; txtBrandNum.Text = ""; txtBrandName.Enabled = false;
        }

        private void frmCategory_Load(object sender, EventArgs e) {
            LoadLV();
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (txtBrandName.Text.Trim() == "") {
                MessageBox.Show("Please Provide a brand name");
                txtBrandName.Focus();
            } else {
                string id = txtBrandNum.Text, name = txtBrandName.Text;
                if (add) {
                    add = false;
                    dbcon.mysqlconnect.Open();
                    query = "INSERT INTO brand SET brand_ID=@brandID, brand_name=@brandName";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@brandID", id);
                    cmd.Parameters.AddWithValue("@brandName", name);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    dbcon.mysqlconnect.Close();
                    MessageBox.Show("Added a new product brand", "Inventory");
                } else if (edit) {
                    edit = false;
                    dbcon.mysqlconnect.Open();
                    query = "UPDATE brand SET brand_name=@brandName WHERE brand_ID=@brandID";
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    cmd.Parameters.AddWithValue("@brandID", id);
                    cmd.Parameters.AddWithValue("@brandName", name);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteReader();
                    dbcon.mysqlconnect.Close();
                    MessageBox.Show("Updated a product brand", "Inventory");
                }
                btnClear.PerformClick();
            }
        }
        private void lvVisc_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvBrand.SelectedItems.Count > 0) {
                ListViewItem item = lvBrand.SelectedItems[0];
                txtBrandNum.Text = item.SubItems[0].Text;
                txtBrandName.Text = item.SubItems[1].Text;
                btnAdd.Enabled = false; btnEdit.Enabled = true; btnDelete.Enabled = true; btnSave.Enabled = false;
            } else {
                //
            }
        }
    }
}
