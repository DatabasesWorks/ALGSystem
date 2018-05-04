namespace ALG_POS_and_Inventory_Management_System {
    partial class uCServices {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tanControlInventory = new System.Windows.Forms.TabControl();
            this.tabServiceOffered = new System.Windows.Forms.TabPage();
            this.tabServicePrice = new System.Windows.Forms.TabPage();
            this.tabVehicleTypes = new System.Windows.Forms.TabPage();
            this.tabAdditionalChargees = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tanControlInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 62);
            this.panel1.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(469, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 38);
            this.label5.TabIndex = 30;
            this.label5.Text = "Services";
            // 
            // tanControlInventory
            // 
            this.tanControlInventory.Controls.Add(this.tabServiceOffered);
            this.tanControlInventory.Controls.Add(this.tabServicePrice);
            this.tanControlInventory.Controls.Add(this.tabVehicleTypes);
            this.tanControlInventory.Controls.Add(this.tabAdditionalChargees);
            this.tanControlInventory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanControlInventory.Location = new System.Drawing.Point(194, 106);
            this.tanControlInventory.Name = "tanControlInventory";
            this.tanControlInventory.SelectedIndex = 0;
            this.tanControlInventory.Size = new System.Drawing.Size(828, 489);
            this.tanControlInventory.TabIndex = 59;
            // 
            // tabServiceOffered
            // 
            this.tabServiceOffered.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabServiceOffered.Location = new System.Drawing.Point(4, 32);
            this.tabServiceOffered.Name = "tabServiceOffered";
            this.tabServiceOffered.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiceOffered.Size = new System.Drawing.Size(820, 453);
            this.tabServiceOffered.TabIndex = 0;
            this.tabServiceOffered.Text = "Services Offered";
            // 
            // tabServicePrice
            // 
            this.tabServicePrice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabServicePrice.Location = new System.Drawing.Point(4, 32);
            this.tabServicePrice.Name = "tabServicePrice";
            this.tabServicePrice.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicePrice.Size = new System.Drawing.Size(820, 453);
            this.tabServicePrice.TabIndex = 1;
            this.tabServicePrice.Text = "Services Prices";
            // 
            // tabVehicleTypes
            // 
            this.tabVehicleTypes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabVehicleTypes.Location = new System.Drawing.Point(4, 32);
            this.tabVehicleTypes.Name = "tabVehicleTypes";
            this.tabVehicleTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicleTypes.Size = new System.Drawing.Size(820, 453);
            this.tabVehicleTypes.TabIndex = 2;
            this.tabVehicleTypes.Text = "Vehicle Types";
            // 
            // tabAdditionalChargees
            // 
            this.tabAdditionalChargees.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabAdditionalChargees.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabAdditionalChargees.Location = new System.Drawing.Point(4, 32);
            this.tabAdditionalChargees.Name = "tabAdditionalChargees";
            this.tabAdditionalChargees.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdditionalChargees.Size = new System.Drawing.Size(820, 453);
            this.tabAdditionalChargees.TabIndex = 3;
            this.tabAdditionalChargees.Text = "Additional Charges";
            // 
            // uCServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tanControlInventory);
            this.Name = "uCServices";
            this.Size = new System.Drawing.Size(1186, 694);
            this.Load += new System.EventHandler(this.uCServices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tanControlInventory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tanControlInventory;
        private System.Windows.Forms.TabPage tabServiceOffered;
        private System.Windows.Forms.TabPage tabServicePrice;
        private System.Windows.Forms.TabPage tabVehicleTypes;
        private System.Windows.Forms.TabPage tabAdditionalChargees;
    }
}
