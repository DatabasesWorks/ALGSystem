using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALG_POS_and_Inventory_Management_System {
    public partial class frmPosPay : Form {
        private string transID, custID, totalStr, totalDisc, discount, totalItems, totalServices;
        double cash, total, change;
        ContPointOfSale contPos = new ContPointOfSale();
        public frmPosPay() {
            InitializeComponent();
        }
        
        private void frmPosPay_Load(object sender, EventArgs e) {
            numCash.TextChanged += new EventHandler(numCash_TextChanged);
            LoadPosDetail();
        }

        void LoadPosDetail() {
            transID = ContPointOfSale.transID;
            custID = ContPointOfSale.custID;
            lblTotal.Text = totalStr = ContPointOfSale.total.ToString();
            lblTotalAmount.Text = totalDisc = ContPointOfSale.totalDisc.ToString();
            lblDiscount.Text = discount = ContPointOfSale.discount + "%";
            lblTotalItems.Text = totalItems = ContPointOfSale.totalItems.ToString();
            lblTotalService.Text = totalServices = ContPointOfSale.totalServices.ToString();
        }

        private void numCash_ValueChanged(object sender, EventArgs e) {
            decimal itemPrice;
            try {
                this.cash = Double.Parse(numCash.Text);
                this.total = double.Parse(lblTotalAmount.Text);
                double change = cash - total;
                lblChange.Text = (change).ToString();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                //Ignore this , heh heh
            }
        }

        private void numCash_TextChanged(object sender, EventArgs e) {
            decimal itemPrice;
            try {
                this.cash = Double.Parse(numCash.Text);
                this.total = double.Parse(lblTotalAmount.Text);
                double change = cash - total;
                lblChange.Text = (change).ToString();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                //Ignore this , heh heh
            }
        }

        private void btnPay_Click(object sender, EventArgs e) {
            if (Convert.ToDouble(lblChange.Text) < 0 && lblTotalItems.Text=="0") {
                MessageBox.Show("Full payment required when purchasing only products.", "Point of Sale" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if( (Convert.ToDouble(lblTotalAmount.Text)/2) < Convert.ToDouble(lblChange.Text) && lblTotalService.Text != "0") {
                MessageBox.Show("Partial payment must be at least half.", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                //select max+1 from tables where transaction has foreign key

                //assign those keys to a variable
                //insert first to tables where it is foreign key 
                //then insert the same key to transaction table
                ContPointOfSale clspos = new ContPointOfSale();
                ContPointOfSale.paid = numCash.Value;
                contPos.SaveToDb();
            }
        }

    }
}
