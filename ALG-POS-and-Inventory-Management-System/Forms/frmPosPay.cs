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
        decimal cash, total, change;
        public static bool isOngoing = false;

        private void btnPayFull_Click(object sender, EventArgs e) {
            numCash.Value = Convert.ToDecimal(lblTotalAmount.Text) - Convert.ToDecimal(lblPaid.Text);
        }

        private void btnPayPartial_Click(object sender, EventArgs e) {
            numCash.Value = Convert.ToDecimal(lblTotalAmount.Text) / 2;
        }

        ContPointOfSale contPos = new ContPointOfSale();
        public frmPosPay() {
            InitializeComponent();
        }

        private void frmPosPay_Load(object sender, EventArgs e) {
            LoadPosDetail();
            if (lblPaid.Text != "0.00" && lblBalance.Text != "0.00") 
                btnPayPartial.Visible = false;
            else if (lblPaid.Text != "0.00")
                btnPayPartial.Visible = false;
            else if (lblTotalService.Text != "0.00" )
                btnPayPartial.Visible = true;

            numCash.TextChanged += new EventHandler(numCash_TextChanged);
            
        }

        void LoadPosDetail() {
            transID = ContPointOfSale.transID;
            custID = ContPointOfSale.custID;
            lblTotal.Text = totalStr = ContPointOfSale.totalAmount.ToString();
            lblTotalAmount.Text = totalDisc = ContPointOfSale.totalDisc.ToString();
            lblDiscount.Text = discount = ContPointOfSale.discount + "%";
            lblTotalItems.Text = totalItems = ContPointOfSale.totalItems.ToString();
            lblTotalService.Text = totalServices = ContPointOfSale.totalServices.ToString();
            lblBalance.Text = ContPointOfSale.balance.ToString();
            lblPaid.Text = ContPointOfSale.paid.ToString();
        }
        void ComputeChange() {
            decimal itemPrice;
            try {
                this.cash = decimal.Parse(numCash.Text);
                this.total = decimal.Parse(lblTotalAmount.Text) - decimal.Parse(lblPaid.Text);
                decimal change = cash - total;
                if (numCash.Value < total) {
                    lblBalance.Text = Math.Abs(total - cash).ToString();
                    lblChange.Text = "0";
                } else if (numCash.Value > total) {
                    lblChange.Text = (change).ToString();
                    lblBalance.Text = "0";
                } else if (numCash.Value == total)
                    lblChange.Text = lblBalance.Text = "0";

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                //Ignore this , heh heh
            }
        }
        private void numCash_ValueChanged(object sender, EventArgs e) {
            ComputeChange();
        }
        
        private void numCash_TextChanged(object sender, EventArgs e) {
            if(numCash.Value <= numCash.Maximum)
                ComputeChange();
        }

        private void btnPay_Click(object sender, EventArgs e) {
            if ( (numCash.Value == 0 || Convert.ToDouble(lblBalance.Text) > 0) && lblTotalService.Text == "0.00") {
                MessageBox.Show("Full payment required when purchasing only products.", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if ( (Convert.ToDouble(lblTotalAmount.Text)/2) < Convert.ToDouble(lblBalance.Text) && lblTotalService.Text != "0.00") {
                MessageBox.Show("Partial payment must be at least half.", "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                //select max+1 from tables where transaction has foreign key

                //assign those keys to a variable
                //insert first to tables where it is foreign key 
                //then insert the same key to transaction table
                ContPointOfSale clspos = new ContPointOfSale();
                ContPointOfSale.paid = Convert.ToDecimal(lblPaid.Text);
                ContPointOfSale.cash = numCash.Value;
                ContPointOfSale.balance = Convert.ToDecimal(lblBalance.Text);
                if (isOngoing)
                    contPos.UpdateToDb();
                else
                    contPos.SaveToDb();
                this.Close();
            }
        }

    }
}
