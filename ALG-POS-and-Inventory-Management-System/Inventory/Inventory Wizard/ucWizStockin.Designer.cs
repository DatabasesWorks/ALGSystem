namespace ALG_POS_and_Inventory_Management_System {
    partial class ucWizStockin {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucWizStockin));
            this.lblStockID = new System.Windows.Forms.Label();
            this.dtpReceive = new System.Windows.Forms.DateTimePicker();
            this.cboSProductName = new System.Windows.Forms.ComboBox();
            this.numSSupPrice = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cboSSuppliers = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboSProductID = new System.Windows.Forms.ComboBox();
            this.numSQuan = new System.Windows.Forms.NumericUpDown();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.btnPriceClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSSupPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblStockID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.ForeColor = System.Drawing.Color.White;
            this.lblStockID.Location = new System.Drawing.Point(280, 103);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(105, 23);
            this.lblStockID.TabIndex = 275;
            this.lblStockID.Text = "_Stock ID";
            // 
            // dtpReceive
            // 
            this.dtpReceive.CustomFormat = "MM-dd-yyyy";
            this.dtpReceive.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReceive.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceive.Location = new System.Drawing.Point(281, 139);
            this.dtpReceive.Name = "dtpReceive";
            this.dtpReceive.Size = new System.Drawing.Size(201, 31);
            this.dtpReceive.TabIndex = 274;
            this.dtpReceive.Value = new System.DateTime(2018, 3, 29, 0, 0, 0, 0);
            // 
            // cboSProductName
            // 
            this.cboSProductName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboSProductName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboSProductName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSProductName.ForeColor = System.Drawing.Color.White;
            this.cboSProductName.FormattingEnabled = true;
            this.cboSProductName.Location = new System.Drawing.Point(279, 56);
            this.cboSProductName.Name = "cboSProductName";
            this.cboSProductName.Size = new System.Drawing.Size(203, 31);
            this.cboSProductName.TabIndex = 273;
            this.cboSProductName.SelectedIndexChanged += new System.EventHandler(this.cboSProductName_SelectedIndexChanged);
            // 
            // numSSupPrice
            // 
            this.numSSupPrice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.numSSupPrice.DecimalPlaces = 2;
            this.numSSupPrice.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSSupPrice.ForeColor = System.Drawing.Color.White;
            this.numSSupPrice.Location = new System.Drawing.Point(284, 192);
            this.numSSupPrice.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numSSupPrice.Name = "numSSupPrice";
            this.numSSupPrice.Size = new System.Drawing.Size(198, 31);
            this.numSSupPrice.TabIndex = 272;
            this.numSSupPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label25.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(113, 192);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(152, 23);
            this.label25.TabIndex = 271;
            this.label25.Text = "Supplier Price:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label22.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(116, 233);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 23);
            this.label22.TabIndex = 270;
            this.label22.Text = "Supplier:";
            // 
            // cboSSuppliers
            // 
            this.cboSSuppliers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboSSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboSSuppliers.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSSuppliers.ForeColor = System.Drawing.Color.White;
            this.cboSSuppliers.FormattingEnabled = true;
            this.cboSSuppliers.Location = new System.Drawing.Point(281, 233);
            this.cboSSuppliers.Name = "cboSSuppliers";
            this.cboSSuppliers.Size = new System.Drawing.Size(201, 31);
            this.cboSSuppliers.TabIndex = 269;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label18.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(116, 280);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 268;
            this.label18.Text = "Quantity:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label17.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(113, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 23);
            this.label17.TabIndex = 267;
            this.label17.Text = "Receiving Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label16.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(113, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 23);
            this.label16.TabIndex = 266;
            this.label16.Text = "Stock ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label15.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(112, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 23);
            this.label15.TabIndex = 265;
            this.label15.Text = "Product Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(113, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 23);
            this.label14.TabIndex = 264;
            this.label14.Text = "Product ID:";
            // 
            // cboSProductID
            // 
            this.cboSProductID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboSProductID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboSProductID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSProductID.ForeColor = System.Drawing.Color.White;
            this.cboSProductID.FormattingEnabled = true;
            this.cboSProductID.Location = new System.Drawing.Point(279, 17);
            this.cboSProductID.Name = "cboSProductID";
            this.cboSProductID.Size = new System.Drawing.Size(203, 31);
            this.cboSProductID.TabIndex = 263;
            this.cboSProductID.SelectedIndexChanged += new System.EventHandler(this.cboSProductID_SelectedIndexChanged);
            // 
            // numSQuan
            // 
            this.numSQuan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.numSQuan.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSQuan.ForeColor = System.Drawing.Color.White;
            this.numSQuan.Location = new System.Drawing.Point(279, 280);
            this.numSQuan.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSQuan.Name = "numSQuan";
            this.numSQuan.Size = new System.Drawing.Size(203, 31);
            this.numSQuan.TabIndex = 262;
            this.numSQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnProdSave
            // 
            this.btnProdSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProdSave.BackgroundImage")));
            this.btnProdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdSave.FlatAppearance.BorderSize = 0;
            this.btnProdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdSave.ForeColor = System.Drawing.Color.White;
            this.btnProdSave.Location = new System.Drawing.Point(189, 317);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(146, 69);
            this.btnProdSave.TabIndex = 276;
            this.btnProdSave.Text = "Save";
            this.btnProdSave.UseVisualStyleBackColor = false;
            this.btnProdSave.Click += new System.EventHandler(this.btnProdSave_Click);
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
            this.btnPriceClear.Location = new System.Drawing.Point(345, 315);
            this.btnPriceClear.Name = "btnPriceClear";
            this.btnPriceClear.Size = new System.Drawing.Size(146, 69);
            this.btnPriceClear.TabIndex = 280;
            this.btnPriceClear.Text = "Clear";
            this.btnPriceClear.UseVisualStyleBackColor = false;
            this.btnPriceClear.Click += new System.EventHandler(this.btnPriceClear_Click);
            // 
            // ucWizStockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btnPriceClear);
            this.Controls.Add(this.btnProdSave);
            this.Controls.Add(this.lblStockID);
            this.Controls.Add(this.dtpReceive);
            this.Controls.Add(this.cboSProductName);
            this.Controls.Add(this.numSSupPrice);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cboSSuppliers);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboSProductID);
            this.Controls.Add(this.numSQuan);
            this.Name = "ucWizStockin";
            this.Size = new System.Drawing.Size(640, 393);
            this.Load += new System.EventHandler(this.ucWizStockin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSSupPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.DateTimePicker dtpReceive;
        private System.Windows.Forms.ComboBox cboSProductName;
        private System.Windows.Forms.NumericUpDown numSSupPrice;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cboSSuppliers;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboSProductID;
        private System.Windows.Forms.NumericUpDown numSQuan;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.Button btnPriceClear;
    }
}
