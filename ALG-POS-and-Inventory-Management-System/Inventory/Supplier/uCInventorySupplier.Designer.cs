namespace ALG_POS_and_Inventory_Management_System {
    partial class uCInventorySupplier {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uCInventorySupplier));
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lvSupplier = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSupDelete = new System.Windows.Forms.Button();
            this.btnSupSave = new System.Windows.Forms.Button();
            this.btnSupClear = new System.Windows.Forms.Button();
            this.btnSupEdit = new System.Windows.Forms.Button();
            this.btnSupAdd = new System.Windows.Forms.Button();
            this.txtSupplierContact = new MyTextBox();
            this.txtSupplierAddress = new MyTextBox();
            this.txtSupplierName = new MyTextBox();
            this.SuspendLayout();
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label24.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(292, 147);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(127, 19);
            this.label24.TabIndex = 155;
            this.label24.Text = "Supplier Contact:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(292, 101);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(128, 19);
            this.label23.TabIndex = 153;
            this.label23.Text = "Supplier Address:";
            // 
            // lvSupplier
            // 
            this.lvSupplier.BackColor = System.Drawing.Color.White;
            this.lvSupplier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader1,
            this.columnHeader16,
            this.columnHeader18,
            this.columnHeader19});
            this.lvSupplier.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSupplier.ForeColor = System.Drawing.Color.Black;
            this.lvSupplier.FullRowSelect = true;
            this.lvSupplier.GridLines = true;
            this.lvSupplier.Location = new System.Drawing.Point(298, 190);
            this.lvSupplier.Name = "lvSupplier";
            this.lvSupplier.Size = new System.Drawing.Size(551, 279);
            this.lvSupplier.TabIndex = 145;
            this.lvSupplier.UseCompatibleStateImageBehavior = false;
            this.lvSupplier.View = System.Windows.Forms.View.Details;
            this.lvSupplier.SelectedIndexChanged += new System.EventHandler(this.lvSupplier_SelectedIndexChanged);
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Supplier ID.";
            this.columnHeader14.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Supplier Name";
            this.columnHeader16.Width = 194;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Supplier Address";
            this.columnHeader18.Width = 178;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Supplier Contact:";
            this.columnHeader19.Width = 132;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblSupplierID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.ForeColor = System.Drawing.Color.White;
            this.lblSupplierID.Location = new System.Drawing.Point(292, 17);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(92, 19);
            this.lblSupplierID.TabIndex = 144;
            this.lblSupplierID.Text = "Supplier ID.:";
            this.lblSupplierID.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(292, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 19);
            this.label21.TabIndex = 143;
            this.label21.Text = "Supplier Name:";
            // 
            // btnSupDelete
            // 
            this.btnSupDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupDelete.BackgroundImage")));
            this.btnSupDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupDelete.Enabled = false;
            this.btnSupDelete.FlatAppearance.BorderSize = 0;
            this.btnSupDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupDelete.ForeColor = System.Drawing.Color.White;
            this.btnSupDelete.Location = new System.Drawing.Point(998, 242);
            this.btnSupDelete.Name = "btnSupDelete";
            this.btnSupDelete.Size = new System.Drawing.Size(137, 53);
            this.btnSupDelete.TabIndex = 180;
            this.btnSupDelete.Text = "Delete";
            this.btnSupDelete.UseVisualStyleBackColor = false;
            this.btnSupDelete.Click += new System.EventHandler(this.btnSupDelete_Click);
            // 
            // btnSupSave
            // 
            this.btnSupSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupSave.BackgroundImage")));
            this.btnSupSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupSave.Enabled = false;
            this.btnSupSave.FlatAppearance.BorderSize = 0;
            this.btnSupSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupSave.ForeColor = System.Drawing.Color.White;
            this.btnSupSave.Location = new System.Drawing.Point(855, 242);
            this.btnSupSave.Name = "btnSupSave";
            this.btnSupSave.Size = new System.Drawing.Size(137, 53);
            this.btnSupSave.TabIndex = 179;
            this.btnSupSave.Text = "Save";
            this.btnSupSave.UseVisualStyleBackColor = false;
            this.btnSupSave.Click += new System.EventHandler(this.btnSupSave_Click);
            // 
            // btnSupClear
            // 
            this.btnSupClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupClear.BackgroundImage")));
            this.btnSupClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupClear.FlatAppearance.BorderSize = 0;
            this.btnSupClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupClear.ForeColor = System.Drawing.Color.White;
            this.btnSupClear.Location = new System.Drawing.Point(928, 297);
            this.btnSupClear.Name = "btnSupClear";
            this.btnSupClear.Size = new System.Drawing.Size(137, 53);
            this.btnSupClear.TabIndex = 178;
            this.btnSupClear.Text = "Clear";
            this.btnSupClear.UseVisualStyleBackColor = false;
            this.btnSupClear.Click += new System.EventHandler(this.btnSupClear_Click);
            // 
            // btnSupEdit
            // 
            this.btnSupEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupEdit.BackgroundImage")));
            this.btnSupEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupEdit.Enabled = false;
            this.btnSupEdit.FlatAppearance.BorderSize = 0;
            this.btnSupEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupEdit.ForeColor = System.Drawing.Color.White;
            this.btnSupEdit.Location = new System.Drawing.Point(998, 190);
            this.btnSupEdit.Name = "btnSupEdit";
            this.btnSupEdit.Size = new System.Drawing.Size(137, 53);
            this.btnSupEdit.TabIndex = 177;
            this.btnSupEdit.Text = "Edit";
            this.btnSupEdit.UseVisualStyleBackColor = false;
            this.btnSupEdit.Click += new System.EventHandler(this.btnSupEdit_Click);
            // 
            // btnSupAdd
            // 
            this.btnSupAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupAdd.BackgroundImage")));
            this.btnSupAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupAdd.FlatAppearance.BorderSize = 0;
            this.btnSupAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupAdd.ForeColor = System.Drawing.Color.White;
            this.btnSupAdd.Location = new System.Drawing.Point(855, 190);
            this.btnSupAdd.Name = "btnSupAdd";
            this.btnSupAdd.Size = new System.Drawing.Size(137, 53);
            this.btnSupAdd.TabIndex = 176;
            this.btnSupAdd.Text = "Add";
            this.btnSupAdd.UseVisualStyleBackColor = false;
            this.btnSupAdd.Click += new System.EventHandler(this.btnSupAdd_Click);
            // 
            // txtSupplierContact
            // 
            this.txtSupplierContact.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtSupplierContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplierContact.Enabled = false;
            this.txtSupplierContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierContact.ForeColor = System.Drawing.Color.White;
            this.txtSupplierContact.Location = new System.Drawing.Point(426, 145);
            this.txtSupplierContact.Name = "txtSupplierContact";
            this.txtSupplierContact.Size = new System.Drawing.Size(160, 25);
            this.txtSupplierContact.TabIndex = 156;
            this.txtSupplierContact.TextChanged += new System.EventHandler(this.txtSupplierContact_TextChanged);
            this.txtSupplierContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierContact_KeyPress);
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtSupplierAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplierAddress.Enabled = false;
            this.txtSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAddress.ForeColor = System.Drawing.Color.White;
            this.txtSupplierAddress.Location = new System.Drawing.Point(426, 101);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(160, 25);
            this.txtSupplierAddress.TabIndex = 154;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.ForeColor = System.Drawing.Color.White;
            this.txtSupplierName.Location = new System.Drawing.Point(426, 62);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(160, 25);
            this.txtSupplierName.TabIndex = 152;
            // 
            // uCInventorySupplier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btnSupDelete);
            this.Controls.Add(this.btnSupSave);
            this.Controls.Add(this.btnSupClear);
            this.Controls.Add(this.btnSupEdit);
            this.Controls.Add(this.btnSupAdd);
            this.Controls.Add(this.txtSupplierContact);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.lvSupplier);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.label21);
            this.Name = "uCInventorySupplier";
            this.Size = new System.Drawing.Size(1325, 533);
            this.Load += new System.EventHandler(this.uCInventorySupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MyTextBox txtSupplierContact;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        public MyTextBox txtSupplierAddress;
        public MyTextBox txtSupplierName;
        private System.Windows.Forms.ListView lvSupplier;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSupDelete;
        private System.Windows.Forms.Button btnSupSave;
        private System.Windows.Forms.Button btnSupClear;
        private System.Windows.Forms.Button btnSupEdit;
        private System.Windows.Forms.Button btnSupAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
