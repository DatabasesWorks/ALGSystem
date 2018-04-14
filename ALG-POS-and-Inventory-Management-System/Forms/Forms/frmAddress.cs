using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAddress : Form
    {
        public frmAddress()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.address = txtAddress.Text;
                Properties.Settings.Default.Save();
                classDatabaseConnect dbcon = new classDatabaseConnect();
                if (dbcon.connectDatabase())
                    MessageBox.Show("Server IP Address set.", "Database Address");
                else
                    MessageBox.Show("Server IP Address not found", "Database Address");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frmAddress_Load(object sender, EventArgs e)
        {
            txtAddress.Text = Properties.Settings.Default.address;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
