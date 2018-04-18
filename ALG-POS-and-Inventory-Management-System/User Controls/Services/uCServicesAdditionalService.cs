using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALG_POS_and_Inventory_Management_System {
    public partial class uCServicesAdditionalService : UserControl {
        ContServiceAddedService contAdded = new  ContServiceAddedService();
        bool addedadd = false, addededit = false;
        string tempOldName;
        string servadded;
        public uCServicesAdditionalService() {
            InitializeComponent();
        }
        private void AddedLock()
        {
            txtaddedID.Enabled = txtaddedname.Enabled = txtaddedprice.Enabled = cboservname.Enabled = false;
        }
        private void AddedUnLock()
        {
            txtaddedID.Enabled = txtaddedname.Enabled = txtaddedprice.Enabled = cboservname.Enabled = true;
        }
        private void AddedClear()
        {
            txtaddedID.Text = txtaddedname.Text = txtaddedprice.Text = cboservname.Text = "";
            addedadd = addededit = false;
        }

        private void btnProdEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false; btnSave.Enabled = true; addededit = true; btnDelete.Enabled = false; AddedUnLock(); txtaddedID.Enabled = false;
            servadded = txtaddedname.Text + " " + cboservname.Text;
            tempOldName = servadded;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Added Service?", "Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (contAdded.IsDeleteAddedService(txtaddedID.Text))
                {
                    // ======= logs
                    //string sprodid = stock.product_ID;
                    //string uid = user.GetUserID();
                    //log.deleteSupplier(uid, date, sprodid, "Delete Supplier");
                    btnClear.PerformClick();

                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        void LoadAddedService()
        {
            lvadded.Items.Clear();
            DataTable dt = new DataTable();
            dt = contAdded.LoadAddedService();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["serv_added_ID"].ToString());
                listitem.SubItems.Add(dr["(SELECT service_name FROM services WHERE services.service_ID = added_service_price.service_ID)"].ToString());
                listitem.SubItems.Add(dr["serv_added_name"].ToString());
                listitem.SubItems.Add(dr["serv_added_price"].ToString());
                lvadded.Items.Add(listitem);
            }
        }
        void LoadService()
        {
            List<string> list = new List<string>();
            list = contAdded.LoadServices();
            cboservname.Items.Clear();
            foreach (string item in list)
            {
                cboservname.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadAddedService(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; AddedClear(); AddedLock();
            addedadd = addededit = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false; btnSave.Enabled = true; AddedUnLock(); addedadd = true; txtaddedID.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtaddedname.Text.Trim() == "" || txtaddedprice.Text.Trim() == "" || cboservname.Text.Trim() == "")
            {
                MessageBox.Show("Please fill-up all fields", "Service");
            }
            else
            {
                if (addedadd)
                {
                    servadded = txtaddedname.Text + " " + cboservname.Text;
                    tempOldName = servadded;
                    if (contAdded.IsInsertAddedService(servadded, txtaddedname.Text, txtaddedprice.Text, cboservname.Text))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.addSupplier(uid, date, sprodid, "Added Supplier ");
                        btnClear.PerformClick();
                    }
                }
                else if (addededit)
                {
                    if (contAdded.IsUpdateAddedService(servadded, txtaddedID.Text, txtaddedname.Text, txtaddedprice.Text, cboservname.Text, tempOldName))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.editSupplier(uid, date, sprodid, "Added Supplier ");
                        btnClear.PerformClick();
                    }
                }
            }
        }

        private void lvadded_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvadded.SelectedItems.Count > 0)
            {
                ListViewItem item = lvadded.SelectedItems[0];
                txtaddedID.Text = item.SubItems[1].Text;
                cboservname.Text = item.SubItems[2].Text;
                txtaddedname.Text = item.SubItems[3].Text;
                txtaddedprice.Text = item.SubItems[4].Text;
                btnAdd.Enabled = false; btnEdit.Enabled = true; btnDelete.Enabled = true; btnSave.Enabled = false; addedadd = false; addededit = false; AddedLock();
            }
        }

        private void uCServicesAdditionalService_Load(object sender, EventArgs e)
        {
            LoadAddedService();
            LoadService();
        }
    }
}
