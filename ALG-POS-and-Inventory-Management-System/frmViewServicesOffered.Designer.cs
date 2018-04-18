namespace ALG_POS_and_Inventory_Management_System {
    partial class frmViewServicesOffered {
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
            this.label9 = new System.Windows.Forms.Label();
            this.lvServices = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lvVehicleType = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvAddedservice = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(197, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 39);
            this.label9.TabIndex = 24;
            this.label9.Text = "Services Offered";
            // 
            // lvServices
            // 
            this.lvServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader5,
            this.columnHeader1});
            this.lvServices.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvServices.FullRowSelect = true;
            this.lvServices.GridLines = true;
            this.lvServices.LabelWrap = false;
            this.lvServices.Location = new System.Drawing.Point(7, 86);
            this.lvServices.Name = "lvServices";
            this.lvServices.Size = new System.Drawing.Size(221, 261);
            this.lvServices.TabIndex = 188;
            this.lvServices.UseCompatibleStateImageBehavior = false;
            this.lvServices.View = System.Windows.Forms.View.Details;
            this.lvServices.SelectedIndexChanged += new System.EventHandler(this.lvServices_SelectedIndexChanged);
            this.lvServices.Click += new System.EventHandler(this.lvServices_Click);
            this.lvServices.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvServices_KeyDown);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "No.";
            this.columnHeader12.Width = 39;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Service Name";
            this.columnHeader1.Width = 177;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 189;
            this.label1.Text = "Services:";
            // 
            // lvVehicleType
            // 
            this.lvVehicleType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.lvVehicleType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVehicleType.FullRowSelect = true;
            this.lvVehicleType.GridLines = true;
            this.lvVehicleType.LabelWrap = false;
            this.lvVehicleType.Location = new System.Drawing.Point(234, 86);
            this.lvVehicleType.Name = "lvVehicleType";
            this.lvVehicleType.Size = new System.Drawing.Size(218, 261);
            this.lvVehicleType.TabIndex = 190;
            this.lvVehicleType.UseCompatibleStateImageBehavior = false;
            this.lvVehicleType.View = System.Windows.Forms.View.Details;
            this.lvVehicleType.SelectedIndexChanged += new System.EventHandler(this.lvVehicleType_SelectedIndexChanged);
            this.lvVehicleType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvVehicleType_KeyDown);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No.";
            this.columnHeader2.Width = 39;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vehicle Type";
            this.columnHeader3.Width = 175;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 191;
            this.label2.Text = "Vehicle Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(513, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 192;
            this.label3.Text = "Services Fee:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 0;
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblServicePrice.ForeColor = System.Drawing.Color.White;
            this.lblServicePrice.Location = new System.Drawing.Point(569, 110);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(116, 24);
            this.lblServicePrice.TabIndex = 193;
            this.lblServicePrice.Text = "0.00";
            this.lblServicePrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(463, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 195;
            this.label4.Text = "Added Services:";
            // 
            // lvAddedservice
            // 
            this.lvAddedservice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvAddedservice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAddedservice.FullRowSelect = true;
            this.lvAddedservice.GridLines = true;
            this.lvAddedservice.LabelWrap = false;
            this.lvAddedservice.Location = new System.Drawing.Point(467, 232);
            this.lvAddedservice.Name = "lvAddedservice";
            this.lvAddedservice.Size = new System.Drawing.Size(276, 113);
            this.lvAddedservice.TabIndex = 194;
            this.lvAddedservice.UseCompatibleStateImageBehavior = false;
            this.lvAddedservice.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "No.";
            this.columnHeader6.Width = 39;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Added Service Name";
            this.columnHeader8.Width = 140;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Price";
            this.columnHeader9.Width = 86;
            // 
            // frmViewServicesOffered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(780, 357);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvAddedservice);
            this.Controls.Add(this.lblServicePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvVehicleType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvServices);
            this.Controls.Add(this.label9);
            this.Name = "frmViewServicesOffered";
            this.Text = "frmViewServicesOffered";
            this.Load += new System.EventHandler(this.frmViewServicesOffered_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvServices;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvVehicleType;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvAddedservice;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}