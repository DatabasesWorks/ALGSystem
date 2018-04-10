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
    public partial class uCServicesVehicleTypes : UserControl {
        ContServicesVehicleTypes contVehicleTypes = new ContServicesVehicleTypes();
        bool vetadd = false, vetedit = false;
        string tempOldName;
        public uCServicesVehicleTypes() {
            InitializeComponent();
        }
        private void VetLock()
        {
            txtTypeID.Enabled = txtTypeName.Enabled = false;
        }
        private void VetUnLock()
        {
            txtTypeName.Enabled = txtTypeID.Enabled = true;
        }
        private void VetClear()
        {
            txtTypeID.Text = txtTypeName.Text = "";
            vetadd = vetedit = false;
        }

        private void uCServicesVehicleTypes_Load(object sender, EventArgs e)
        {
            LoadVehicleTypes();
        }

        private void btnVetAdd_Click(object sender, EventArgs e)
        {
            btnVetAdd.Enabled = false; btnVetSave.Enabled = true; VetUnLock(); vetadd = true;
        }

        private void btnVetEdit_Click(object sender, EventArgs e)
        {
            btnVetEdit.Enabled = false; btnVetSave.Enabled = true; vetedit = true; btnVetDelete.Enabled = false; VetUnLock(); txtTypeID.Enabled = false;
            tempOldName = txtTypeName.Text;
        }

        private void btnVetDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Vehicle Type?", "Vehicle Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (contVehicleTypes.IsDeleteVehicleTypes(txtTypeID.Text))
                {
                    // ======= logs
                    //string sprodid = stock.product_ID;
                    //string uid = user.GetUserID();
                    //log.deleteSupplier(uid, date, sprodid, "Delete Supplier");
                    btnVetClear.PerformClick();

                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnVetSave_Click(object sender, EventArgs e)
        {
            if (txtTypeName.Text.Trim() == "" || txtTypeID.Text.Trim() == "")
            {
                MessageBox.Show("Please fill-up all fields", "Vehicle Type");
            }
            else
            {
                if (vetadd)
                {
                    if (contVehicleTypes.IsInsertVehicleTypes(txtTypeName.Text))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.addSupplier(uid, date, sprodid, "Added Supplier ");
                        btnVetClear.PerformClick();
                    }
                }
                else if (vetedit)
                {
                    if (contVehicleTypes.IsUpdateVehicleTypes(txtTypeID.Text, txtTypeName.Text, tempOldName))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.editSupplier(uid, date, sprodid, "Added Supplier ");
                        btnVetClear.PerformClick();
                    }
                }
            }
        }

        private void lvType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvType.SelectedItems.Count > 0)
            {
                ListViewItem item = lvType.SelectedItems[0];
                txtTypeID.Text = item.SubItems[1].Text;
                txtTypeName.Text = item.SubItems[2].Text;
                btnVetAdd.Enabled = false; btnVetEdit.Enabled = true; btnVetDelete.Enabled = true; btnVetSave.Enabled = false; vetadd = false; vetedit = false; VetLock();
            }
        }

        private void btnVetClear_Click(object sender, EventArgs e)
        {
            LoadVehicleTypes(); btnVetSave.Enabled = false; btnVetAdd.Enabled = true; btnVetEdit.Enabled = false; btnVetDelete.Enabled = false; VetClear(); VetLock();
            vetadd = vetedit = false;
        }

        void LoadVehicleTypes()
        {
            lvType.Items.Clear();
            DataTable dt = new DataTable();
            dt = contVehicleTypes.LoadVehicleTypes();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["vehicletype_ID"].ToString());
                listitem.SubItems.Add(dr["vehicle_type"].ToString());
                lvType.Items.Add(listitem);
            }
        }
    }
}
