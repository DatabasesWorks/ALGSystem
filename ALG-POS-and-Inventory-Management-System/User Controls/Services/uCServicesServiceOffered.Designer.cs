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
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServDelete = new System.Windows.Forms.Button();
            this.btnServSave = new System.Windows.Forms.Button();
            this.btnServClear = new System.Windows.Forms.Button();
            this.btnServEdit = new System.Windows.Forms.Button();
            this.btnServAdd = new System.Windows.Forms.Button();
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
            this.columnHeader3,
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
            this.lvServices.SelectedIndexChanged += new System.EventHandler(this.lvServices_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No.";
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
            // btnServDelete
            // 
            this.btnServDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServDelete.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnServDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServDelete.Enabled = false;
            this.btnServDelete.FlatAppearance.BorderSize = 0;
            this.btnServDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServDelete.ForeColor = System.Drawing.Color.White;
            this.btnServDelete.Location = new System.Drawing.Point(632, 208);
            this.btnServDelete.Name = "btnServDelete";
            this.btnServDelete.Size = new System.Drawing.Size(137, 53);
            this.btnServDelete.TabIndex = 180;
            this.btnServDelete.Text = "Delete";
            this.btnServDelete.UseVisualStyleBackColor = false;
            this.btnServDelete.Click += new System.EventHandler(this.btnServDelete_Click);
            // 
            // btnServSave
            // 
            this.btnServSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServSave.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnServSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServSave.Enabled = false;
            this.btnServSave.FlatAppearance.BorderSize = 0;
            this.btnServSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServSave.ForeColor = System.Drawing.Color.White;
            this.btnServSave.Location = new System.Drawing.Point(489, 208);
            this.btnServSave.Name = "btnServSave";
            this.btnServSave.Size = new System.Drawing.Size(137, 53);
            this.btnServSave.TabIndex = 179;
            this.btnServSave.Text = "Save";
            this.btnServSave.UseVisualStyleBackColor = false;
            this.btnServSave.Click += new System.EventHandler(this.btnServSave_Click);
            // 
            // btnServClear
            // 
            this.btnServClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServClear.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnServClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServClear.FlatAppearance.BorderSize = 0;
            this.btnServClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServClear.ForeColor = System.Drawing.Color.White;
            this.btnServClear.Location = new System.Drawing.Point(562, 263);
            this.btnServClear.Name = "btnServClear";
            this.btnServClear.Size = new System.Drawing.Size(137, 53);
            this.btnServClear.TabIndex = 178;
            this.btnServClear.Text = "Clear";
            this.btnServClear.UseVisualStyleBackColor = false;
            this.btnServClear.Click += new System.EventHandler(this.btnServClear_Click);
            // 
            // btnServEdit
            // 
            this.btnServEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServEdit.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnServEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServEdit.Enabled = false;
            this.btnServEdit.FlatAppearance.BorderSize = 0;
            this.btnServEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServEdit.ForeColor = System.Drawing.Color.White;
            this.btnServEdit.Location = new System.Drawing.Point(632, 156);
            this.btnServEdit.Name = "btnServEdit";
            this.btnServEdit.Size = new System.Drawing.Size(137, 53);
            this.btnServEdit.TabIndex = 177;
            this.btnServEdit.Text = "Edit";
            this.btnServEdit.UseVisualStyleBackColor = false;
            this.btnServEdit.Click += new System.EventHandler(this.btnServEdit_Click);
            // 
            // btnServAdd
            // 
            this.btnServAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServAdd.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnServAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServAdd.FlatAppearance.BorderSize = 0;
            this.btnServAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnServAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServAdd.ForeColor = System.Drawing.Color.White;
            this.btnServAdd.Location = new System.Drawing.Point(489, 156);
            this.btnServAdd.Name = "btnServAdd";
            this.btnServAdd.Size = new System.Drawing.Size(137, 53);
            this.btnServAdd.TabIndex = 176;
            this.btnServAdd.Text = "Add";
            this.btnServAdd.UseVisualStyleBackColor = false;
            this.btnServAdd.Click += new System.EventHandler(this.btnServAdd_Click);
            // 
            // uCServicesServiceOffered
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btnServDelete);
            this.Controls.Add(this.btnServSave);
            this.Controls.Add(this.btnServClear);
            this.Controls.Add(this.btnServEdit);
            this.Controls.Add(this.btnServAdd);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.lvServices);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "uCServicesServiceOffered";
            this.Size = new System.Drawing.Size(820, 453);
            this.Load += new System.EventHandler(this.uCServicesServiceOffered_Load);
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
        private System.Windows.Forms.Button btnServDelete;
        private System.Windows.Forms.Button btnServSave;
        private System.Windows.Forms.Button btnServClear;
        private System.Windows.Forms.Button btnServEdit;
        private System.Windows.Forms.Button btnServAdd;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
