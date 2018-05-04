using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALG_POS_and_Inventory_Management_System
{
    
    public partial class frmVehicle : Form
    {
        ContCustomerVehicle contVcl = new ContCustomerVehicle();
        bool vcladd = false, vcledit = false;
        string tempOldName;
        string custID;
        public frmVehicle()
        {
            InitializeComponent();
        }

        private void VclLock()
        {
            txtPlateNo.Enabled = txtModel.Enabled = txtColor.Enabled = cboBrand.Enabled = cboVehicleType.Enabled =false;
        }
        private void VclUnLock()
        {
            txtPlateNo.Enabled = txtModel.Enabled = txtColor.Enabled = cboBrand.Enabled = cboVehicleType.Enabled = true;
        }
        private void VclClear()
        {
            txtPlateNo.Text = txtModel.Text = txtColor.Text = cboBrand.Text = cboVehicleType.Text = "";
            vcledit = vcladd = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void myTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false; btnSave.Enabled = true; vcledit = true; btnDelete.Enabled = false; VclUnLock(); txtCustID.Enabled = false; vcladd = false; txtPlateNo.Enabled = false;
            tempOldName = txtPlateNo.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Customer Vehicle?", "Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (contVcl.IsDeleteCustomerVehicle(txtPlateNo.Text))
                {
                    // ======= logs
                    //string sprodid = stock.product_ID;
                    //string uid = user.GetUserID();
                    //log.deleteSupplier(uid, date, sprodid, "Delete Supplier");
                    btnCustClear.PerformClick();

                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        void LoadCustomerVehicle()
        {
            lvVehicle.Items.Clear();
            DataTable dt = new DataTable();
            dt = contVcl.LoadCustomerVehicle(custID);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["plate_no"].ToString());
                listitem.SubItems.Add(dr["cust_ID"].ToString());
                listitem.SubItems.Add(dr["(SELECT vehicle_type FROM vehicle_types WHERE vehicle_types.vehicletype_ID = customer_vehicle.vehicletype_ID)"].ToString());
                listitem.SubItems.Add(dr["(SELECT vehicle_brand_name FROM vehicle_brands WHERE vehicle_brands.vehicle_brand_ID = customer_vehicle.vehicle_brand_ID)"].ToString());
                listitem.SubItems.Add(dr["color"].ToString());
                listitem.SubItems.Add(dr["model"].ToString());
                lvVehicle.Items.Add(listitem);
            }
        }

        void LoadVehicle()
        {
            List<string> list = new List<string>();
            list = contVcl.LoadVehicle();
            cboVehicleType.Items.Clear();
            foreach (string item in list)
            {
                cboVehicleType.Items.Add(item);
            }
        }

        void LoadBrand()
        {
            List<string> list = new List<string>();
            list = contVcl.LoadBrand();
            cboBrand.Items.Clear();
            foreach (string item in list)
            {
                cboBrand.Items.Add(item);
            }
        }


        private void btnCustClear_Click_1(object sender, EventArgs e)
        {
            LoadCustomerVehicle(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; VclClear(); VclLock(); LoadBrand(); LoadVehicle();
            vcladd = vcledit = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPlateNo.Text.Trim() == "" || txtColor.Text.Trim() == "" || txtModel.Text.Trim() == "" || cboBrand.Text.Trim() == "" || cboVehicleType.Text.Trim() == "")
            {
                MessageBox.Show("Please fill-up all fields", "Customer");
            }
            else
            {
                if (vcladd)
                {

                    if (contVcl.IsInsertCustomerVehicle(txtPlateNo.Text, txtCustID.Text, cboVehicleType.Text, cboBrand.Text, txtColor.Text, txtModel.Text))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.addSupplier(uid, date, sprodid, "Added Supplier ");
                        btnCustClear.PerformClick();
                    }
                }
                else if (vcledit)
                {
                    if (contVcl.IsUpdateCustomerVehicle(txtPlateNo.Text, cboVehicleType.Text, cboBrand.Text, txtColor.Text, txtModel.Text, tempOldName))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.editSupplier(uid, date, sprodid, "Added Supplier ");
                        btnCustClear.PerformClick();
                    }
                }
            }
        }

        private void lvVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVehicle.SelectedItems.Count > 0)
            {
                ListViewItem item = lvVehicle.SelectedItems[0];
                txtPlateNo.Text = item.SubItems[1].Text;
                txtCustID.Text = item.SubItems[2].Text;
                cboVehicleType.Text = item.SubItems[3].Text;
                cboBrand.Text = item.SubItems[4].Text;
                txtColor.Text = item.SubItems[5].Text;
                txtModel.Text = item.SubItems[6].Text;
                btnAdd.Enabled = false; btnEdit.Enabled = true; btnDelete.Enabled = true; btnSave.Enabled = false; vcladd = false; vcledit = false; VclLock();
            }
        }

        private void frmVehicle_Load(object sender, EventArgs e)
        {
            txtCustID.Text = frmManageCustomer.custID;
            custID = txtCustID.Text;
            LoadBrand();
            LoadCustomerVehicle();
            LoadVehicle();
            VclLock();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnAddBrand_Click(object sender, EventArgs e) {
            frmVehicleBrands vehicleBrand = new frmVehicleBrands();
            vehicleBrand.ShowDialog();
            LoadBrand();
        }

        private void btnAddVehicleType_Click(object sender, EventArgs e) {
            frmCustVehicleType custVtype = new frmCustVehicleType();
            custVtype.ShowDialog();
            LoadVehicle();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false; btnSave.Enabled = true; VclUnLock(); vcladd = true; txtCustID.Enabled = false; vcledit = false;
        }
    }
}
