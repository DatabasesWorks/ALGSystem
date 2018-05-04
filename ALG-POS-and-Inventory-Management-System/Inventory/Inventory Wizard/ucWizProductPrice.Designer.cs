namespace ALG_POS_and_Inventory_Management_System {
    partial class ucWizProductPrice {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucWizProductPrice));
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboProductID = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.lblPriceDiscounted = new System.Windows.Forms.Label();
            this.lblPriceDiscount = new System.Windows.Forms.Label();
            this.lblPriceProductPrice = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numPriceDiscount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numPriceSelling = new System.Windows.Forms.NumericUpDown();
            this.btnPriceClear = new System.Windows.Forms.Button();
            this.btnPriceSetPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceSelling)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProductName
            // 
            this.cboProductName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboProductName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductName.ForeColor = System.Drawing.Color.White;
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(262, 49);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(203, 31);
            this.cboProductName.TabIndex = 283;
            this.cboProductName.SelectedIndexChanged += new System.EventHandler(this.cboProductName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(116, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 23);
            this.label5.TabIndex = 282;
            this.label5.Text = "Product Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(116, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 281;
            this.label9.Text = "Product ID:";
            // 
            // cboProductID
            // 
            this.cboProductID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboProductID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductID.ForeColor = System.Drawing.Color.White;
            this.cboProductID.FormattingEnabled = true;
            this.cboProductID.Location = new System.Drawing.Point(262, 11);
            this.cboProductID.Name = "cboProductID";
            this.cboProductID.Size = new System.Drawing.Size(203, 31);
            this.cboProductID.TabIndex = 280;
            this.cboProductID.SelectedIndexChanged += new System.EventHandler(this.cboProductID_SelectedIndexChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(391, 223);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(30, 23);
            this.label40.TabIndex = 277;
            this.label40.Text = "%";
            // 
            // lblPriceDiscounted
            // 
            this.lblPriceDiscounted.AutoSize = true;
            this.lblPriceDiscounted.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceDiscounted.ForeColor = System.Drawing.Color.White;
            this.lblPriceDiscounted.Location = new System.Drawing.Point(332, 253);
            this.lblPriceDiscounted.Name = "lblPriceDiscounted";
            this.lblPriceDiscounted.Size = new System.Drawing.Size(53, 23);
            this.lblPriceDiscounted.TabIndex = 276;
            this.lblPriceDiscounted.Text = "0.00";
            // 
            // lblPriceDiscount
            // 
            this.lblPriceDiscount.AutoSize = true;
            this.lblPriceDiscount.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceDiscount.ForeColor = System.Drawing.Color.White;
            this.lblPriceDiscount.Location = new System.Drawing.Point(332, 193);
            this.lblPriceDiscount.Name = "lblPriceDiscount";
            this.lblPriceDiscount.Size = new System.Drawing.Size(53, 23);
            this.lblPriceDiscount.TabIndex = 275;
            this.lblPriceDiscount.Text = "0.00";
            // 
            // lblPriceProductPrice
            // 
            this.lblPriceProductPrice.AutoSize = true;
            this.lblPriceProductPrice.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceProductPrice.ForeColor = System.Drawing.Color.White;
            this.lblPriceProductPrice.Location = new System.Drawing.Point(332, 163);
            this.lblPriceProductPrice.Name = "lblPriceProductPrice";
            this.lblPriceProductPrice.Size = new System.Drawing.Size(53, 23);
            this.lblPriceProductPrice.TabIndex = 274;
            this.lblPriceProductPrice.Text = "0.00";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(116, 248);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(179, 23);
            this.label34.TabIndex = 273;
            this.label34.Text = "Discounted Price:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(116, 209);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(103, 23);
            this.label32.TabIndex = 272;
            this.label32.Text = "Discount:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(116, 170);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(144, 23);
            this.label33.TabIndex = 271;
            this.label33.Text = "Product Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(116, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 270;
            this.label8.Text = "Discount:";
            // 
            // numPriceDiscount
            // 
            this.numPriceDiscount.BackColor = System.Drawing.Color.RoyalBlue;
            this.numPriceDiscount.DecimalPlaces = 2;
            this.numPriceDiscount.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriceDiscount.ForeColor = System.Drawing.Color.White;
            this.numPriceDiscount.Location = new System.Drawing.Point(262, 125);
            this.numPriceDiscount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numPriceDiscount.Name = "numPriceDiscount";
            this.numPriceDiscount.Size = new System.Drawing.Size(72, 31);
            this.numPriceDiscount.TabIndex = 269;
            this.numPriceDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPriceDiscount.ValueChanged += new System.EventHandler(this.numPriceDiscount_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(116, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 23);
            this.label10.TabIndex = 268;
            this.label10.Text = "Selling Price:";
            // 
            // numPriceSelling
            // 
            this.numPriceSelling.BackColor = System.Drawing.Color.RoyalBlue;
            this.numPriceSelling.DecimalPlaces = 2;
            this.numPriceSelling.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriceSelling.ForeColor = System.Drawing.Color.White;
            this.numPriceSelling.Location = new System.Drawing.Point(262, 87);
            this.numPriceSelling.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPriceSelling.Name = "numPriceSelling";
            this.numPriceSelling.Size = new System.Drawing.Size(203, 31);
            this.numPriceSelling.TabIndex = 267;
            this.numPriceSelling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPriceSelling.ValueChanged += new System.EventHandler(this.numPriceSelling_ValueChanged);
            // 
            // btnPriceClear
            // 
            this.btnPriceClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPriceClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPriceClear.BackgroundImage")));
            this.btnPriceClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPriceClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceClear.FlatAppearance.BorderSize = 0;
            this.btnPriceClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPriceClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPriceClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceClear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriceClear.ForeColor = System.Drawing.Color.White;
            this.btnPriceClear.Location = new System.Drawing.Point(298, 292);
            this.btnPriceClear.Name = "btnPriceClear";
            this.btnPriceClear.Size = new System.Drawing.Size(146, 69);
            this.btnPriceClear.TabIndex = 279;
            this.btnPriceClear.Text = "Clear";
            this.btnPriceClear.UseVisualStyleBackColor = false;
            this.btnPriceClear.Click += new System.EventHandler(this.btnPriceClear_Click);
            // 
            // btnPriceSetPrice
            // 
            this.btnPriceSetPrice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPriceSetPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPriceSetPrice.BackgroundImage")));
            this.btnPriceSetPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPriceSetPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceSetPrice.FlatAppearance.BorderSize = 0;
            this.btnPriceSetPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPriceSetPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPriceSetPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceSetPrice.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriceSetPrice.ForeColor = System.Drawing.Color.White;
            this.btnPriceSetPrice.Location = new System.Drawing.Point(130, 292);
            this.btnPriceSetPrice.Name = "btnPriceSetPrice";
            this.btnPriceSetPrice.Size = new System.Drawing.Size(146, 69);
            this.btnPriceSetPrice.TabIndex = 278;
            this.btnPriceSetPrice.Text = "Set Price";
            this.btnPriceSetPrice.UseVisualStyleBackColor = false;
            this.btnPriceSetPrice.Click += new System.EventHandler(this.btnPriceSetPrice_Click);
            // 
            // ucWizProductPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.cboProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboProductID);
            this.Controls.Add(this.btnPriceClear);
            this.Controls.Add(this.btnPriceSetPrice);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.lblPriceDiscounted);
            this.Controls.Add(this.lblPriceDiscount);
            this.Controls.Add(this.lblPriceProductPrice);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numPriceDiscount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numPriceSelling);
            this.Name = "ucWizProductPrice";
            this.Size = new System.Drawing.Size(640, 393);
            this.Load += new System.EventHandler(this.ucWizProductPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPriceDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceSelling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboProductID;
        private System.Windows.Forms.Button btnPriceClear;
        private System.Windows.Forms.Button btnPriceSetPrice;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lblPriceDiscounted;
        private System.Windows.Forms.Label lblPriceDiscount;
        private System.Windows.Forms.Label lblPriceProductPrice;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPriceDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPriceSelling;
    }
}
