namespace ALG_POS_and_Inventory_Management_System {
    partial class uCServicesServiceOffered {
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
            this.txtServiceName = new MyTextBox();
            this.txtServiceID = new MyTextBox();
            this.lvServices = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProdDelete = new System.Windows.Forms.Button();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.btnProdClear = new System.Windows.Forms.Button();
            this.btnProdEdit = new System.Windows.Forms.Button();
            this.btnProdAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServiceName
            // 
            this.txtServiceName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtServiceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceName.Enabled = false;
            this.txtServiceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.ForeColor = System.Drawing.Color.White;
            this.txtServiceName.Location = new System.Drawing.Point(224, 102);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(160, 25);
            this.txtServiceName.TabIndex = 138;
            // 
            // txtServiceID
            // 
            this.txtServiceID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtServiceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceID.Enabled = false;
            this.txtServiceID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceID.ForeColor = System.Drawing.Color.White;
            this.txtServiceID.Location = new System.Drawing.Point(224, 65);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(160, 25);
            this.txtServiceID.TabIndex = 132;
            // 
            // lvServices
            // 
            this.lvServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvServices.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvServices.FullRowSelect = true;
            this.lvServices.GridLines = true;
            this.lvServices.Location = new System.Drawing.Point(48, 149);
            this.lvServices.Name = "lvServices";
            this.lvServices.Size = new System.Drawing.Size(404, 280);
            this.lvServices.TabIndex = 131;
            this.lvServices.UseCompatibleStateImageBehavior = false;
            this.lvServices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Service ID.";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Service Name";
            this.columnHeader2.Width = 221;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(96, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 130;
            this.label8.Text = "Service ID.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 129;
            this.label1.Text = "Service Name:";
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
            this.btnProdDelete.Location = new System.Drawing.Point(632, 208);
            this.btnProdDelete.Name = "btnProdDelete";
            this.btnProdDelete.Size = new System.Drawing.Size(137, 53);
            this.btnProdDelete.TabIndex = 180;
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
            this.btnProdSave.Location = new System.Drawing.Point(489, 208);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(137, 53);
            this.btnProdSave.TabIndex = 179;
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
            this.btnProdClear.Location = new System.Drawing.Point(562, 263);
            this.btnProdClear.Name = "btnProdClear";
            this.btnProdClear.Size = new System.Drawing.Size(137, 53);
            this.btnProdClear.TabIndex = 178;
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
            this.btnProdEdit.Location = new System.Drawing.Point(632, 156);
            this.btnProdEdit.Name = "btnProdEdit";
            this.btnProdEdit.Size = new System.Drawing.Size(137, 53);
            this.btnProdEdit.TabIndex = 177;
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
            this.btnProdAdd.Location = new System.Drawing.Point(489, 156);
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.Size = new System.Drawing.Size(137, 53);
            this.btnProdAdd.TabIndex = 176;
            this.btnProdAdd.Text = "Add";
            this.btnProdAdd.UseVisualStyleBackColor = false;
            // 
            // uCServicesServiceOffered
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btnProdDelete);
            this.Controls.Add(this.btnProdSave);
            this.Controls.Add(this.btnProdClear);
            this.Controls.Add(this.btnProdEdit);
            this.Controls.Add(this.btnProdAdd);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.lvServices);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "uCServicesServiceOffered";
            this.Size = new System.Drawing.Size(820, 453);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MyTextBox txtServiceName;
        public MyTextBox txtServiceID;
        private System.Windows.Forms.ListView lvServices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProdDelete;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.Button btnProdClear;
        private System.Windows.Forms.Button btnProdEdit;
        private System.Windows.Forms.Button btnProdAdd;
    }
}
