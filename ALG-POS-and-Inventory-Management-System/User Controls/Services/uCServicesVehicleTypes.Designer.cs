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
            this.txtTypeName = new MyTextBox();
            this.txtTypeID = new MyTextBox();
            this.lvType = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnProdDelete = new System.Windows.Forms.Button();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.btnProdClear = new System.Windows.Forms.Button();
            this.btnProdEdit = new System.Windows.Forms.Button();
            this.btnProdAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // 
            // lvType
            // 
            this.lvType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type ID";
            this.columnHeader3.Width = 101;
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
            this.btnProdDelete.Location = new System.Drawing.Point(625, 205);
            this.btnProdDelete.Name = "btnProdDelete";
            this.btnProdDelete.Size = new System.Drawing.Size(132, 53);
            this.btnProdDelete.TabIndex = 186;
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
            this.btnProdSave.Location = new System.Drawing.Point(498, 205);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(121, 53);
            this.btnProdSave.TabIndex = 185;
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
            this.btnProdClear.Location = new System.Drawing.Point(558, 260);
            this.btnProdClear.Name = "btnProdClear";
            this.btnProdClear.Size = new System.Drawing.Size(129, 53);
            this.btnProdClear.TabIndex = 184;
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
            this.btnProdEdit.Location = new System.Drawing.Point(625, 153);
            this.btnProdEdit.Name = "btnProdEdit";
            this.btnProdEdit.Size = new System.Drawing.Size(132, 53);
            this.btnProdEdit.TabIndex = 183;
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
            this.btnProdAdd.Location = new System.Drawing.Point(498, 153);
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.Size = new System.Drawing.Size(121, 53);
            this.btnProdAdd.TabIndex = 182;
            this.btnProdAdd.Text = "Add";
            this.btnProdAdd.UseVisualStyleBackColor = false;
            // 
            // uCServicesVehicleTypes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btnProdDelete);
            this.Controls.Add(this.btnProdSave);
            this.Controls.Add(this.btnProdClear);
            this.Controls.Add(this.btnProdEdit);
            this.Controls.Add(this.btnProdAdd);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.lvType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Name = "uCServicesVehicleTypes";
            this.Size = new System.Drawing.Size(820, 453);
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
        private System.Windows.Forms.Button btnProdDelete;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.Button btnProdClear;
        private System.Windows.Forms.Button btnProdEdit;
        private System.Windows.Forms.Button btnProdAdd;
    }
}
