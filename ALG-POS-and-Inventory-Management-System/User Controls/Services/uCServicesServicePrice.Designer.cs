namespace ALG_POS_and_Inventory_Management_System {
    partial class uCServicesServicePrice {
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
            this.numFee = new System.Windows.Forms.NumericUpDown();
            this.cboServiceName = new System.Windows.Forms.ComboBox();
            this.lvPrices = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProdPrint = new System.Windows.Forms.Button();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPSave = new System.Windows.Forms.Button();
            this.btnPClear = new System.Windows.Forms.Button();
            this.btnPEdit = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.ccbVehicleType = new CheckComboBoxTest.CheckedComboBox();
            this.txtPriceID = new MyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFee)).BeginInit();
            this.SuspendLayout();
            // 
            // numFee
            // 
            this.numFee.BackColor = System.Drawing.Color.RoyalBlue;
            this.numFee.DecimalPlaces = 2;
            this.numFee.Enabled = false;
            this.numFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFee.ForeColor = System.Drawing.Color.White;
            this.numFee.Location = new System.Drawing.Point(459, 69);
            this.numFee.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFee.Name = "numFee";
            this.numFee.Size = new System.Drawing.Size(159, 29);
            this.numFee.TabIndex = 152;
            this.numFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboServiceName
            // 
            this.cboServiceName.BackColor = System.Drawing.Color.RoyalBlue;
            this.cboServiceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServiceName.Enabled = false;
            this.cboServiceName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboServiceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServiceName.ForeColor = System.Drawing.Color.White;
            this.cboServiceName.FormattingEnabled = true;
            this.cboServiceName.Location = new System.Drawing.Point(155, 68);
            this.cboServiceName.Name = "cboServiceName";
            this.cboServiceName.Size = new System.Drawing.Size(178, 29);
            this.cboServiceName.TabIndex = 150;
            this.cboServiceName.SelectedIndexChanged += new System.EventHandler(this.cboServiceName_SelectedIndexChanged);
            // 
            // lvPrices
            // 
            this.lvPrices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader10});
            this.lvPrices.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPrices.FullRowSelect = true;
            this.lvPrices.GridLines = true;
            this.lvPrices.Location = new System.Drawing.Point(18, 152);
            this.lvPrices.Name = "lvPrices";
            this.lvPrices.Size = new System.Drawing.Size(525, 261);
            this.lvPrices.TabIndex = 143;
            this.lvPrices.UseCompatibleStateImageBehavior = false;
            this.lvPrices.View = System.Windows.Forms.View.Details;
            this.lvPrices.SelectedIndexChanged += new System.EventHandler(this.lvPrices_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Service ID.";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Service Name";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 149;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Vehicle Type";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 136;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Service Fee";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 172;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 142;
            this.label3.Text = "Vehicle Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 141;
            this.label2.Text = "Service Price ID.:";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(352, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 140;
            this.label4.Text = "Service Fee:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 139;
            this.label6.Text = "Service Name:";
            // 
            // btnProdPrint
            // 
            this.btnProdPrint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdPrint.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnProdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdPrint.FlatAppearance.BorderSize = 0;
            this.btnProdPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdPrint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdPrint.ForeColor = System.Drawing.Color.White;
            this.btnProdPrint.Location = new System.Drawing.Point(659, 57);
            this.btnProdPrint.Name = "btnProdPrint";
            this.btnProdPrint.Size = new System.Drawing.Size(137, 53);
            this.btnProdPrint.TabIndex = 182;
            this.btnProdPrint.Text = "Print";
            this.btnProdPrint.UseVisualStyleBackColor = false;
            this.btnProdPrint.Click += new System.EventHandler(this.btnProdPrint_Click);
            // 
            // btnPDelete
            // 
            this.btnPDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPDelete.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnPDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDelete.Enabled = false;
            this.btnPDelete.FlatAppearance.BorderSize = 0;
            this.btnPDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDelete.ForeColor = System.Drawing.Color.White;
            this.btnPDelete.Location = new System.Drawing.Point(681, 213);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(132, 53);
            this.btnPDelete.TabIndex = 181;
            this.btnPDelete.Text = "Delete";
            this.btnPDelete.UseVisualStyleBackColor = false;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPSave
            // 
            this.btnPSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPSave.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnPSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPSave.Enabled = false;
            this.btnPSave.FlatAppearance.BorderSize = 0;
            this.btnPSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSave.ForeColor = System.Drawing.Color.White;
            this.btnPSave.Location = new System.Drawing.Point(554, 213);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(121, 53);
            this.btnPSave.TabIndex = 180;
            this.btnPSave.Text = "Save";
            this.btnPSave.UseVisualStyleBackColor = false;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // btnPClear
            // 
            this.btnPClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPClear.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnPClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPClear.FlatAppearance.BorderSize = 0;
            this.btnPClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPClear.ForeColor = System.Drawing.Color.White;
            this.btnPClear.Location = new System.Drawing.Point(614, 268);
            this.btnPClear.Name = "btnPClear";
            this.btnPClear.Size = new System.Drawing.Size(129, 53);
            this.btnPClear.TabIndex = 179;
            this.btnPClear.Text = "Clear";
            this.btnPClear.UseVisualStyleBackColor = false;
            this.btnPClear.Click += new System.EventHandler(this.btnProdClear_Click);
            // 
            // btnPEdit
            // 
            this.btnPEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPEdit.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnPEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPEdit.Enabled = false;
            this.btnPEdit.FlatAppearance.BorderSize = 0;
            this.btnPEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPEdit.ForeColor = System.Drawing.Color.White;
            this.btnPEdit.Location = new System.Drawing.Point(681, 161);
            this.btnPEdit.Name = "btnPEdit";
            this.btnPEdit.Size = new System.Drawing.Size(132, 53);
            this.btnPEdit.TabIndex = 178;
            this.btnPEdit.Text = "Edit";
            this.btnPEdit.UseVisualStyleBackColor = false;
            this.btnPEdit.Click += new System.EventHandler(this.btnPEdit_Click);
            // 
            // btnPAdd
            // 
            this.btnPAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPAdd.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnPAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPAdd.FlatAppearance.BorderSize = 0;
            this.btnPAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAdd.ForeColor = System.Drawing.Color.White;
            this.btnPAdd.Location = new System.Drawing.Point(554, 161);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(121, 53);
            this.btnPAdd.TabIndex = 177;
            this.btnPAdd.Text = "Set Price";
            this.btnPAdd.UseVisualStyleBackColor = false;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // ccbVehicleType
            // 
            this.ccbVehicleType.BackColor = System.Drawing.Color.RoyalBlue;
            this.ccbVehicleType.CheckOnClick = true;
            this.ccbVehicleType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ccbVehicleType.DropDownHeight = 1;
            this.ccbVehicleType.Enabled = false;
            this.ccbVehicleType.Font = new System.Drawing.Font("Calibri", 13F);
            this.ccbVehicleType.FormattingEnabled = true;
            this.ccbVehicleType.IntegralHeight = false;
            this.ccbVehicleType.Location = new System.Drawing.Point(155, 106);
            this.ccbVehicleType.Name = "ccbVehicleType";
            this.ccbVehicleType.Size = new System.Drawing.Size(178, 30);
            this.ccbVehicleType.TabIndex = 183;
            this.ccbVehicleType.ValueSeparator = ", ";
            this.ccbVehicleType.DropDownClosed += new System.EventHandler(this.ccbVehicleType_DropDownClosed);
            // 
            // txtPriceID
            // 
            this.txtPriceID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtPriceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceID.Enabled = false;
            this.txtPriceID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceID.ForeColor = System.Drawing.Color.White;
            this.txtPriceID.Location = new System.Drawing.Point(155, 36);
            this.txtPriceID.Name = "txtPriceID";
            this.txtPriceID.Size = new System.Drawing.Size(52, 25);
            this.txtPriceID.TabIndex = 149;
            this.txtPriceID.Visible = false;
            // 
            // uCServicesServicePrice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.ccbVehicleType);
            this.Controls.Add(this.btnProdPrint);
            this.Controls.Add(this.btnPDelete);
            this.Controls.Add(this.btnPSave);
            this.Controls.Add(this.btnPClear);
            this.Controls.Add(this.btnPEdit);
            this.Controls.Add(this.btnPAdd);
            this.Controls.Add(this.numFee);
            this.Controls.Add(this.cboServiceName);
            this.Controls.Add(this.txtPriceID);
            this.Controls.Add(this.lvPrices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Name = "uCServicesServicePrice";
            this.Size = new System.Drawing.Size(820, 453);
            this.Load += new System.EventHandler(this.uCServicesServicePrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numFee;
        private System.Windows.Forms.ComboBox cboServiceName;
        public MyTextBox txtPriceID;
        private System.Windows.Forms.ListView lvPrices;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProdPrint;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPSave;
        private System.Windows.Forms.Button btnPClear;
        private System.Windows.Forms.Button btnPEdit;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private CheckComboBoxTest.CheckedComboBox ccbVehicleType;
    }
}
