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
            this.cboVehicleType = new System.Windows.Forms.ComboBox();
            this.cboServiceName = new System.Windows.Forms.ComboBox();
            this.txtPriceID = new MyTextBox();
            this.lvPrices = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProdPrint = new System.Windows.Forms.Button();
            this.btnProdDelete = new System.Windows.Forms.Button();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.btnProdClear = new System.Windows.Forms.Button();
            this.btnProdEdit = new System.Windows.Forms.Button();
            this.btnProdAdd = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numFee)).BeginInit();
            this.SuspendLayout();
            // 
            // numFee
            // 
            this.numFee.BackColor = System.Drawing.Color.RoyalBlue;
            this.numFee.Enabled = false;
            this.numFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFee.ForeColor = System.Drawing.Color.White;
            this.numFee.Location = new System.Drawing.Point(459, 68);
            this.numFee.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFee.Name = "numFee";
            this.numFee.Size = new System.Drawing.Size(159, 29);
            this.numFee.TabIndex = 152;
            // 
            // cboVehicleType
            // 
            this.cboVehicleType.BackColor = System.Drawing.Color.RoyalBlue;
            this.cboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleType.Enabled = false;
            this.cboVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVehicleType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVehicleType.ForeColor = System.Drawing.Color.White;
            this.cboVehicleType.FormattingEnabled = true;
            this.cboVehicleType.Location = new System.Drawing.Point(155, 109);
            this.cboVehicleType.Name = "cboVehicleType";
            this.cboVehicleType.Size = new System.Drawing.Size(178, 29);
            this.cboVehicleType.TabIndex = 151;
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
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Service ID.";
            this.columnHeader8.Width = 79;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Service Name";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 133;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Vehicle Type";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 118;
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
            // 
            // btnProdDelete
            // 
            this.btnProdDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdDelete.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnProdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdDelete.Enabled = false;
            this.btnProdDelete.FlatAppearance.BorderSize = 0;
            this.btnProdDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdDelete.ForeColor = System.Drawing.Color.White;
            this.btnProdDelete.Location = new System.Drawing.Point(681, 213);
            this.btnProdDelete.Name = "btnProdDelete";
            this.btnProdDelete.Size = new System.Drawing.Size(132, 53);
            this.btnProdDelete.TabIndex = 181;
            this.btnProdDelete.Text = "Delete";
            this.btnProdDelete.UseVisualStyleBackColor = false;
            // 
            // btnProdSave
            // 
            this.btnProdSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdSave.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnProdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdSave.Enabled = false;
            this.btnProdSave.FlatAppearance.BorderSize = 0;
            this.btnProdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdSave.ForeColor = System.Drawing.Color.White;
            this.btnProdSave.Location = new System.Drawing.Point(554, 213);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(121, 53);
            this.btnProdSave.TabIndex = 180;
            this.btnProdSave.Text = "Save";
            this.btnProdSave.UseVisualStyleBackColor = false;
            // 
            // btnProdClear
            // 
            this.btnProdClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdClear.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnProdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdClear.FlatAppearance.BorderSize = 0;
            this.btnProdClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdClear.ForeColor = System.Drawing.Color.White;
            this.btnProdClear.Location = new System.Drawing.Point(614, 268);
            this.btnProdClear.Name = "btnProdClear";
            this.btnProdClear.Size = new System.Drawing.Size(129, 53);
            this.btnProdClear.TabIndex = 179;
            this.btnProdClear.Text = "Clear";
            this.btnProdClear.UseVisualStyleBackColor = false;
            // 
            // btnProdEdit
            // 
            this.btnProdEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdEdit.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnProdEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdEdit.Enabled = false;
            this.btnProdEdit.FlatAppearance.BorderSize = 0;
            this.btnProdEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdEdit.ForeColor = System.Drawing.Color.White;
            this.btnProdEdit.Location = new System.Drawing.Point(681, 161);
            this.btnProdEdit.Name = "btnProdEdit";
            this.btnProdEdit.Size = new System.Drawing.Size(132, 53);
            this.btnProdEdit.TabIndex = 178;
            this.btnProdEdit.Text = "Edit";
            this.btnProdEdit.UseVisualStyleBackColor = false;
            // 
            // btnProdAdd
            // 
            this.btnProdAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdAdd.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnProdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdAdd.FlatAppearance.BorderSize = 0;
            this.btnProdAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdAdd.ForeColor = System.Drawing.Color.White;
            this.btnProdAdd.Location = new System.Drawing.Point(554, 161);
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.Size = new System.Drawing.Size(121, 53);
            this.btnProdAdd.TabIndex = 177;
            this.btnProdAdd.Text = "Add";
            this.btnProdAdd.UseVisualStyleBackColor = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            // 
            // uCServicesServicePrice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btnProdPrint);
            this.Controls.Add(this.btnProdDelete);
            this.Controls.Add(this.btnProdSave);
            this.Controls.Add(this.btnProdClear);
            this.Controls.Add(this.btnProdEdit);
            this.Controls.Add(this.btnProdAdd);
            this.Controls.Add(this.numFee);
            this.Controls.Add(this.cboVehicleType);
            this.Controls.Add(this.cboServiceName);
            this.Controls.Add(this.txtPriceID);
            this.Controls.Add(this.lvPrices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Name = "uCServicesServicePrice";
            this.Size = new System.Drawing.Size(820, 453);
            ((System.ComponentModel.ISupportInitialize)(this.numFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numFee;
        private System.Windows.Forms.ComboBox cboVehicleType;
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
        private System.Windows.Forms.Button btnProdDelete;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.Button btnProdClear;
        private System.Windows.Forms.Button btnProdEdit;
        private System.Windows.Forms.Button btnProdAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
