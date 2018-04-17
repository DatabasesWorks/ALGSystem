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
    public partial class uCServicesServiceOffered : UserControl {
        ContServicesServiceOffered contService = new ContServicesServiceOffered();
        bool servadd = false, servedit = false;
        string tempOldName;
        public uCServicesServiceOffered() {
            InitializeComponent();
        }

        private void ServLock()
        {
            txtServiceID.Enabled = txtServiceName.Enabled = false;
        }
        private void ServUnLock()
        {
            txtServiceName.Enabled = txtServiceID.Enabled = true;
        }
        private void ServClear()
        {
            txtServiceID.Text = txtServiceName.Text = "";
            servadd = servedit = false;
        }

        private void btnServAdd_Click(object sender, EventArgs e)
        {
            btnServAdd.Enabled = false; btnServSave.Enabled = true; ServUnLock(); servadd = true; txtServiceID.Enabled = false;
        }

        private void btnServEdit_Click(object sender, EventArgs e)
        {
            btnServEdit.Enabled = false; btnServSave.Enabled = true; servedit = true; btnServDelete.Enabled = false; ServUnLock(); txtServiceID.Enabled = false;
            tempOldName = txtServiceName.Text;
        }

        private void btnServDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Service?", "Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (contService.IsDeleteService(txtServiceID.Text))
                {
                    // ======= logs
                    //string sprodid = stock.product_ID;
                    //string uid = user.GetUserID();
                    //log.deleteSupplier(uid, date, sprodid, "Delete Supplier");
                    btnServClear.PerformClick();

                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnServSave_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill-up all fields", "Vehicle Type");
            }
            else
            {
                if (servadd)
                {
                    if (contService.IsInsertService(txtServiceName.Text))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.addSupplier(uid, date, sprodid, "Added Supplier ");
                        btnServClear.PerformClick();
                    }
                }
                else if (servedit)
                {
                    if (contService.IsUpdateService(txtServiceID.Text, txtServiceName.Text, tempOldName))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.editSupplier(uid, date, sprodid, "Added Supplier ");
                        btnServClear.PerformClick();
                    }
                }
            }
        }

        private void lvServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvServices.SelectedItems.Count > 0)
            {
                ListViewItem item = lvServices.SelectedItems[0];
                txtServiceID.Text = item.SubItems[1].Text;
                txtServiceName.Text = item.SubItems[2].Text;
                btnServAdd.Enabled = false; btnServEdit.Enabled = true; btnServDelete.Enabled = true; btnServSave.Enabled = false; servadd = false; servedit = false; ServLock();
            }
        }

        private void btnServClear_Click(object sender, EventArgs e)
        {
            LoadService(); btnServSave.Enabled = false; btnServAdd.Enabled = true; btnServEdit.Enabled = false; btnServDelete.Enabled = false; ServClear(); ServLock();
            servadd = servedit = false;
        }
        void LoadService()
        {
            lvServices.Items.Clear();
            DataTable dt = new DataTable();
            dt = contService.LoadService();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["service_ID"].ToString());
                listitem.SubItems.Add(dr["service_name"].ToString());
                lvServices.Items.Add(listitem);
            }
        }

        private void uCServicesServiceOffered_Load(object sender, EventArgs e)
        {
            LoadService();
        }


    }
}
