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
    public partial class frmLogin : Form
    {
       public clsUser user = new clsUser();
       clsLogs log = new clsLogs();
        string dt = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            dt = System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            // txtPW.isPassword = true;
            txtUN.Focus();
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                txtPW.PasswordChar ='\0' ;
            }
            else
            {
                txtPW.PasswordChar = '•';
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = System.DateTime.Now.ToString();
        }

        private void txtPW_OnValueChanged(object sender, EventArgs e)
        {
            //txtPW1.isPassword = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //txtUN.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            string un = txtUN.Text;
            string pw = txtPW.Text;
            string[] result;
            //to do: filter the input

            //to do: byte[] data = System.Text.Encoding.UTF8.GetBytes ("stRhong%pword");
            //       byte[] hash = SHA256.Create().ComputeHash(data);
            //The GetBytes method on an Encoding object converts a string to a byte array; the GetString method converts it back. An Encoding object cannot, however, convert an encrypted or hashed byte array to a string, because scrambled data usually violates text encoding rules.Instead, use Convert .ToBase64String and Convert.FromBase64String : these convert between any byte array and a legal(and XML - friendly) string.
            //byte[] data = System.Text.Encoding.UTF8.GetBytes(pw);
            //byte[] hash = SHA256.Create().ComputeHash(data);

            classDatabaseConnect dbConnObj = new classDatabaseConnect();
            result = dbConnObj.authenticate(un,pw);
            if (result == null)
                MessageBox.Show("Please provide a valid credential","Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if(result[3] == "True")
                MessageBox.Show("User is logged-in in other computer","Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                user.SetUserID(result[0]);
                user.SetGName(result[1]);
                user.SetPrivelge(result[2]);
                user.SetLoginStatus(result[3]);
                string q = "UPDATE users SET login_status=1 WHERE userID='" + user.GetUserID() + "'";
                dbConnObj.ManipulateData(q);
                MessageBox.Show("Welcome " + user.GetGName(),"Login",MessageBoxButtons.OK,MessageBoxIcon.Information);

                
                string uid = user.GetUserID();
                log.userLogin(uid, dt, "Logged In");
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }

        private void frmLogin_DoubleClick(object sender, EventArgs e)
        {
            frmAddress frm = new frmAddress();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
