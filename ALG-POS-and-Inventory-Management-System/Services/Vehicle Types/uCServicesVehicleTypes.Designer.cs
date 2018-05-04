namespace ALG_POS_and_Inventory_Management_System {
    partial class uCServicesVehicleTypes {
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
            this.lvType = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVetDelete = new System.Windows.Forms.Button();
            this.btnVetSave = new System.Windows.Forms.Button();
            this.btnVetClear = new System.Windows.Forms.Button();
            this.btnVetEdit = new System.Windows.Forms.Button();
            this.btnVetAdd = new System.Windows.Forms.Button();
            this.txtTypeName = new MyTextBox();
            this.txtTypeID = new MyTextBox();
            this.SuspendLayout();
            // 
            // lvType
            // 
            this.lvType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvType.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvType.FullRowSelect = true;
            this.lvType.GridLines = true;
            this.lvType.Location = new System.Drawing.Point(37, 153);
            this.lvType.Name = "lvType";
            this.lvType.Size = new System.Drawing.Size(400, 264);
            this.lvType.TabIndex = 138;
            this.lvType.UseCompatibleStateImageBehavior = false;
            this.lvType.View = System.Windows.Forms.View.Details;
            this.lvType.SelectedIndexChanged += new System.EventHandler(this.lvType_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type ID";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vehicle Type";
            this.columnHeader4.Width = 202;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(69, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 137;
            this.label7.Text = "Type ID.:";
            this.label7.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(69, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 136;
            this.label9.Text = "Vehicle Type:";
            // 
            // btnVetDelete
            // 
            this.btnVetDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetDelete.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnVetDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVetDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVetDelete.Enabled = false;
            this.btnVetDelete.FlatAppearance.BorderSize = 0;
            this.btnVetDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVetDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetDelete.ForeColor = System.Drawing.Color.White;
            this.btnVetDelete.Location = new System.Drawing.Point(625, 205);
            this.btnVetDelete.Name = "btnVetDelete";
            this.btnVetDelete.Size = new System.Drawing.Size(132, 53);
            this.btnVetDelete.TabIndex = 186;
            this.btnVetDelete.Text = "Delete";
            this.btnVetDelete.UseVisualStyleBackColor = false;
            this.btnVetDelete.Click += new System.EventHandler(this.btnVetDelete_Click);
            // 
            // btnVetSave
            // 
            this.btnVetSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetSave.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnVetSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVetSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVetSave.Enabled = false;
            this.btnVetSave.FlatAppearance.BorderSize = 0;
            this.btnVetSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVetSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetSave.ForeColor = System.Drawing.Color.White;
            this.btnVetSave.Location = new System.Drawing.Point(498, 205);
            this.btnVetSave.Name = "btnVetSave";
            this.btnVetSave.Size = new System.Drawing.Size(121, 53);
            this.btnVetSave.TabIndex = 185;
            this.btnVetSave.Text = "Save";
            this.btnVetSave.UseVisualStyleBackColor = false;
            this.btnVetSave.Click += new System.EventHandler(this.btnVetSave_Click);
            // 
            // btnVetClear
            // 
            this.btnVetClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetClear.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnVetClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVetClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVetClear.FlatAppearance.BorderSize = 0;
            this.btnVetClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVetClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetClear.ForeColor = System.Drawing.Color.White;
            this.btnVetClear.Location = new System.Drawing.Point(558, 260);
            this.btnVetClear.Name = "btnVetClear";
            this.btnVetClear.Size = new System.Drawing.Size(129, 53);
            this.btnVetClear.TabIndex = 184;
            this.btnVetClear.Text = "Clear";
            this.btnVetClear.UseVisualStyleBackColor = false;
            this.btnVetClear.Click += new System.EventHandler(this.btnVetClear_Click);
            // 
            // btnVetEdit
            // 
            this.btnVetEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetEdit.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnVetEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVetEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVetEdit.Enabled = false;
            this.btnVetEdit.FlatAppearance.BorderSize = 0;
            this.btnVetEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVetEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetEdit.ForeColor = System.Drawing.Color.White;
            this.btnVetEdit.Location = new System.Drawing.Point(625, 153);
            this.btnVetEdit.Name = "btnVetEdit";
            this.btnVetEdit.Size = new System.Drawing.Size(132, 53);
            this.btnVetEdit.TabIndex = 183;
            this.btnVetEdit.Text = "Edit";
            this.btnVetEdit.UseVisualStyleBackColor = false;
            this.btnVetEdit.Click += new System.EventHandler(this.btnVetEdit_Click);
            // 
            // btnVetAdd
            // 
            this.btnVetAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetAdd.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnVetAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVetAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVetAdd.FlatAppearance.BorderSize = 0;
            this.btnVetAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVetAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVetAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetAdd.ForeColor = System.Drawing.Color.White;
            this.btnVetAdd.Location = new System.Drawing.Point(498, 153);
            this.btnVetAdd.Name = "btnVetAdd";
            this.btnVetAdd.Size = new System.Drawing.Size(121, 53);
            this.btnVetAdd.TabIndex = 182;
            this.btnVetAdd.Text = "Add";
            this.btnVetAdd.UseVisualStyleBackColor = false;
            this.btnVetAdd.Click += new System.EventHandler(this.btnVetAdd_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTypeName.Enabled = false;
            this.txtTypeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.ForeColor = System.Drawing.Color.White;
            this.txtTypeName.Location = new System.Drawing.Point(188, 103);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(161, 25);
            this.txtTypeName.TabIndex = 145;
            // 
            // txtTypeID
            // 
            this.txtTypeID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTypeID.Enabled = false;
            this.txtTypeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.ForeColor = System.Drawing.Color.White;
            this.txtTypeID.Location = new System.Drawing.Point(188, 66);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(52, 25);
            this.txtTypeID.TabIndex = 144;
            this.txtTypeID.Visible = false;
            // 
            // uCServicesVehicleTypes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btnVetDelete);
            this.Controls.Add(this.btnVetSave);
            this.Controls.Add(this.btnVetClear);
            this.Controls.Add(this.btnVetEdit);
            this.Controls.Add(this.btnVetAdd);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.lvType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Name = "uCServicesVehicleTypes";
            this.Size = new System.Drawing.Size(820, 453);
            this.Load += new System.EventHandler(this.uCServicesVehicleTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MyTextBox txtTypeName;
        public MyTextBox txtTypeID;
        private System.Windows.Forms.ListView lvType;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVetDelete;
        private System.Windows.Forms.Button btnVetSave;
        private System.Windows.Forms.Button btnVetClear;
        private System.Windows.Forms.Button btnVetEdit;
        private System.Windows.Forms.Button btnVetAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
