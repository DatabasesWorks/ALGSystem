namespace ALG_POS_and_Inventory_Management_System {
    partial class frmSales {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lvSales = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowSales = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblVatable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVatPercent = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNumUnsettled = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUnsettledBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 49);
            this.panel1.TabIndex = 249;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(491, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 39);
            this.label9.TabIndex = 182;
            this.label9.Text = "Sales";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM-dd-yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(104, 78);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(175, 32);
            this.dtpStart.TabIndex = 251;
            this.dtpStart.Value = new System.DateTime(2018, 3, 29, 0, 0, 0, 0);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(11, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 21);
            this.label17.TabIndex = 250;
            this.label17.Text = "Start Date:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM-dd-yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(384, 78);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(175, 32);
            this.dtpEnd.TabIndex = 253;
            this.dtpEnd.Value = new System.DateTime(2018, 3, 29, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 252;
            this.label1.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 254;
            this.label2.Text = "User:";
            // 
            // cboUser
            // 
            this.cboUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUser.ForeColor = System.Drawing.Color.White;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(104, 130);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(175, 29);
            this.cboUser.TabIndex = 255;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(713, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 39);
            this.label3.TabIndex = 256;
            this.label3.Text = "Total Sales:";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.White;
            this.lblTotalSales.Location = new System.Drawing.Point(876, 92);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(185, 39);
            this.lblTotalSales.TabIndex = 257;
            this.lblTotalSales.Text = "0.00";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lvSales
            // 
            this.lvSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2});
            this.lvSales.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSales.FullRowSelect = true;
            this.lvSales.GridLines = true;
            this.lvSales.Location = new System.Drawing.Point(26, 179);
            this.lvSales.Name = "lvSales";
            this.lvSales.Size = new System.Drawing.Size(668, 297);
            this.lvSales.TabIndex = 258;
            this.lvSales.UseCompatibleStateImageBehavior = false;
            this.lvSales.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "No.";
            this.columnHeader9.Width = 43;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Date";
            this.columnHeader0.Width = 149;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User Name";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount Received";
            this.columnHeader2.Width = 197;
            // 
            // btnShowSales
            // 
            this.btnShowSales.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowSales.BackgroundImage")));
            this.btnShowSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowSales.FlatAppearance.BorderSize = 0;
            this.btnShowSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSales.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSales.ForeColor = System.Drawing.Color.White;
            this.btnShowSales.Location = new System.Drawing.Point(384, 113);
            this.btnShowSales.Name = "btnShowSales";
            this.btnShowSales.Size = new System.Drawing.Size(146, 59);
            this.btnShowSales.TabIndex = 259;
            this.btnShowSales.Text = "Show Sales";
            this.btnShowSales.UseVisualStyleBackColor = false;
            this.btnShowSales.Click += new System.EventHandler(this.btnShowSales_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(536, 116);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(146, 59);
            this.btnPrint.TabIndex = 260;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // lblVatable
            // 
            this.lblVatable.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatable.ForeColor = System.Drawing.Color.White;
            this.lblVatable.Location = new System.Drawing.Point(876, 148);
            this.lblVatable.Name = "lblVatable";
            this.lblVatable.Size = new System.Drawing.Size(185, 39);
            this.lblVatable.TabIndex = 262;
            this.lblVatable.Text = "0.00";
            this.lblVatable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(708, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 33);
            this.label5.TabIndex = 261;
            this.label5.Text = "Vatable Sales:";
            // 
            // lblVat
            // 
            this.lblVat.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.ForeColor = System.Drawing.Color.White;
            this.lblVat.Location = new System.Drawing.Point(876, 199);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(185, 39);
            this.lblVat.TabIndex = 264;
            this.lblVat.Text = "0.00";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(804, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 39);
            this.label7.TabIndex = 263;
            this.label7.Text = "VAT:";
            // 
            // lblVatPercent
            // 
            this.lblVatPercent.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatPercent.ForeColor = System.Drawing.Color.White;
            this.lblVatPercent.Location = new System.Drawing.Point(876, 250);
            this.lblVatPercent.Name = "lblVatPercent";
            this.lblVatPercent.Size = new System.Drawing.Size(185, 39);
            this.lblVatPercent.TabIndex = 266;
            this.lblVatPercent.Text = "12";
            this.lblVatPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(773, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 39);
            this.label10.TabIndex = 265;
            this.label10.Text = "VAT %:";
            // 
            // lblNumUnsettled
            // 
            this.lblNumUnsettled.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumUnsettled.ForeColor = System.Drawing.Color.White;
            this.lblNumUnsettled.Location = new System.Drawing.Point(879, 349);
            this.lblNumUnsettled.Name = "lblNumUnsettled";
            this.lblNumUnsettled.Size = new System.Drawing.Size(171, 39);
            this.lblNumUnsettled.TabIndex = 268;
            this.lblNumUnsettled.Text = "0";
            this.lblNumUnsettled.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(721, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 67);
            this.label12.TabIndex = 267;
            this.label12.Text = "Unsettled Transactions:";
            // 
            // lblUnsettledBalance
            // 
            this.lblUnsettledBalance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnsettledBalance.ForeColor = System.Drawing.Color.White;
            this.lblUnsettledBalance.Location = new System.Drawing.Point(872, 416);
            this.lblUnsettledBalance.Name = "lblUnsettledBalance";
            this.lblUnsettledBalance.Size = new System.Drawing.Size(177, 39);
            this.lblUnsettledBalance.TabIndex = 270;
            this.lblUnsettledBalance.Text = "0";
            this.lblUnsettledBalance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(720, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 67);
            this.label6.TabIndex = 269;
            this.label6.Text = "Unsettled Balance:";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1073, 499);
            this.Controls.Add(this.lblUnsettledBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNumUnsettled);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblVatPercent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblVatable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnShowSales);
            this.Controls.Add(this.lvSales);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.ListView lvSales;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnShowSales;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblVatable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVatPercent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNumUnsettled;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblUnsettledBalance;
        private System.Windows.Forms.Label label6;
    }
}