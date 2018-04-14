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
    public partial class uCManageEmployeeInfo : UserControl {
        ContManageEmployee contEmployee = new ContManageEmployee();
        bool empadd = false, empedit = false;
        string tempOldName;
        string Fullname;
        public uCManageEmployeeInfo() {
            InitializeComponent();
        }
        private void EmpLock()
        {
            txtEmpNo.Enabled = txtGN.Enabled = txtFN.Enabled = txtMI.Enabled = txtAddress.Enabled = txtPosition.Enabled = false;
        }
        private void EmpUnLock()
        {
            txtEmpNo.Enabled = txtGN.Enabled = txtFN.Enabled = txtMI.Enabled = txtAddress.Enabled = txtPosition.Enabled = true;
        }
        private void EmpClear()
        {
            txtEmpNo.Text = txtGN.Text = txtFN.Text = txtMI.Text = txtAddress.Text = txtPosition.Text = "";
            empadd = empedit = false;
        }

        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            btnEmpEdit.Enabled = false; btnEmpSave.Enabled = true; empedit = true; btnEmpDelete.Enabled = false; EmpUnLock(); txtEmpNo.Enabled = false;
            Fullname = txtGN.Text + txtMI.Text + txtFN.Text;
            tempOldName = Fullname;
        }

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Employee?", "Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (contEmployee.IsDeleteEmployees(txtEmpNo.Text))
                {
                    // ======= logs
                    //string sprodid = stock.product_ID;
                    //string uid = user.GetUserID();
                    //log.deleteSupplier(uid, date, sprodid, "Delete Supplier");
                    btnEmpClear.PerformClick();

                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        void LoadEmployee()
        {
            lvEmp.Items.Clear();
            DataTable dt = new DataTable();
            dt = contEmployee.LoadEmployees();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(dr["emp_ID"].ToString());
                listitem.SubItems.Add(dr["emp_fName"].ToString());
                listitem.SubItems.Add(dr["emp_gName"].ToString());
                listitem.SubItems.Add(dr["emp_mInitial"].ToString());
                listitem.SubItems.Add(dr["emp_Position"].ToString());
                listitem.SubItems.Add(dr["emp_Address"].ToString());
                lvEmp.Items.Add(listitem);
            }
        }
        private void btnEmpClear_Click(object sender, EventArgs e)
        {
            LoadEmployee(); btnEmpSave.Enabled = false; btnEmpAdd.Enabled = true; btnEmpEdit.Enabled = false; btnEmpDelete.Enabled = false; EmpClear(); EmpLock();
            empadd = empedit = false;
        }

        private void uCManageEmployeeInfo_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void lvEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmp.SelectedItems.Count > 0)
            {
                ListViewItem item = lvEmp.SelectedItems[0];
                txtEmpNo.Text = item.SubItems[1].Text;
                txtFN.Text = item.SubItems[2].Text;
                txtGN.Text = item.SubItems[3].Text;
                txtMI.Text = item.SubItems[4].Text;
                txtPosition.Text = item.SubItems[5].Text;
                txtAddress.Text = item.SubItems[6].Text;
                btnEmpAdd.Enabled = false; btnEmpEdit.Enabled = true; btnEmpDelete.Enabled = true; btnEmpSave.Enabled = false; empadd = false; empedit = false; EmpLock();
            }
        }

        private void btnEmpSave_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text.Trim() == "" || txtFN.Text.Trim() == "" || txtGN.Text.Trim() == "" || txtMI.Text.Trim() == "" || txtPosition.Text.Trim() == "" || txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please fill-up all fields", "Employee");
            }
            else
            {
                if (empadd)
                {
                    if (contEmployee.IsInsertEmployees(Fullname, txtFN.Text, txtGN.Text, txtMI.Text, txtPosition.Text, txtAddress.Text))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.addSupplier(uid, date, sprodid, "Added Supplier ");
                        btnEmpClear.PerformClick();
                    }
                }
                else if (empedit)
                {
                    if (contEmployee.IsUpdateEmployees(Fullname, txtFN.Text, txtGN.Text, txtMI.Text, txtPosition.Text, txtAddress.Text, tempOldName))
                    {
                        //===== logs
                        //string sprodid = stock.product_ID;
                        //string uid = user.GetUserID();
                        //log.editSupplier(uid, date, sprodid, "Added Supplier ");
                        btnEmpClear.PerformClick();
                    }
                }
            }
        }

        private void btnProdAdd_Click(object sender, EventArgs e)
        {
            btnEmpAdd.Enabled = false; btnEmpSave.Enabled = true; EmpUnLock(); empadd = true; txtEmpNo.Enabled = false;
        }
    }
}
