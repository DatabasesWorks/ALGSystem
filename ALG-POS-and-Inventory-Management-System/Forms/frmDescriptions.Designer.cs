namespace ALG_POS_and_Inventory_Management_System {
    partial class frmDescriptions {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescriptions));
            this.label23 = new System.Windows.Forms.Label();
            this.txtDescriptionName = new MyTextBox();
            this.lvDescription = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDescriptionID = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpDesc = new System.Windows.Forms.GroupBox();
            this.rdNumeric = new System.Windows.Forms.RadioButton();
            this.rdText = new System.Windows.Forms.RadioButton();
            this.txtDescUnit = new MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.grpDesc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label23.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(12, 148);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(144, 23);
            this.label23.TabIndex = 185;
            this.label23.Text = "Description Type:";
            // 
            // txtDescriptionName
            // 
            this.txtDescriptionName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtDescriptionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescriptionName.Enabled = false;
            this.txtDescriptionName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionName.ForeColor = System.Drawing.Color.White;
            this.txtDescriptionName.Location = new System.Drawing.Point(168, 103);
            this.txtDescriptionName.Name = "txtDescriptionName";
            this.txtDescriptionName.Size = new System.Drawing.Size(221, 25);
            this.txtDescriptionName.TabIndex = 184;
            // 
            // lvDescription
            // 
            this.lvDescription.BackColor = System.Drawing.Color.White;
            this.lvDescription.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader1,
            this.columnHeader16,
            this.columnHeader18,
            this.columnHeader2});
            this.lvDescription.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDescription.ForeColor = System.Drawing.Color.Black;
            this.lvDescription.FullRowSelect = true;
            this.lvDescription.GridLines = true;
            this.lvDescription.Location = new System.Drawing.Point(13, 224);
            this.lvDescription.Name = "lvDescription";
            this.lvDescription.Size = new System.Drawing.Size(435, 276);
            this.lvDescription.TabIndex = 183;
            this.lvDescription.UseCompatibleStateImageBehavior = false;
            this.lvDescription.View = System.Windows.Forms.View.Details;
            this.lvDescription.SelectedIndexChanged += new System.EventHandler(this.lvDescription_SelectedIndexChanged);
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Description ID.";
            this.columnHeader14.Width = 4;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Description Name";
            this.columnHeader16.Width = 201;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Description Type";
            this.columnHeader18.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unit";
            // 
            // lblDescriptionID
            // 
            this.lblDescriptionID.AutoSize = true;
            this.lblDescriptionID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblDescriptionID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionID.ForeColor = System.Drawing.Color.White;
            this.lblDescriptionID.Location = new System.Drawing.Point(7, 70);
            this.lblDescriptionID.Name = "lblDescriptionID";
            this.lblDescriptionID.Size = new System.Drawing.Size(131, 23);
            this.lblDescriptionID.TabIndex = 182;
            this.lblDescriptionID.Text = "Description ID.:";
            this.lblDescriptionID.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label21.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(9, 103);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(153, 23);
            this.label21.TabIndex = 181;
            this.label21.Text = "Description Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(599, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 53);
            this.btnDelete.TabIndex = 193;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(456, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 53);
            this.btnSave.TabIndex = 192;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(529, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 53);
            this.btnClear.TabIndex = 191;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(599, 227);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 53);
            this.btnEdit.TabIndex = 190;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(456, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 53);
            this.btnAdd.TabIndex = 189;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpDesc
            // 
            this.grpDesc.Controls.Add(this.rdNumeric);
            this.grpDesc.Controls.Add(this.rdText);
            this.grpDesc.Location = new System.Drawing.Point(168, 136);
            this.grpDesc.Name = "grpDesc";
            this.grpDesc.Size = new System.Drawing.Size(221, 45);
            this.grpDesc.TabIndex = 194;
            this.grpDesc.TabStop = false;
            // 
            // rdNumeric
            // 
            this.rdNumeric.AutoSize = true;
            this.rdNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNumeric.ForeColor = System.Drawing.Color.White;
            this.rdNumeric.Location = new System.Drawing.Point(125, 12);
            this.rdNumeric.Name = "rdNumeric";
            this.rdNumeric.Size = new System.Drawing.Size(88, 25);
            this.rdNumeric.TabIndex = 195;
            this.rdNumeric.Text = "Numeric";
            this.rdNumeric.UseVisualStyleBackColor = true;
            this.rdNumeric.CheckedChanged += new System.EventHandler(this.rdNumeric_CheckedChanged);
            // 
            // rdText
            // 
            this.rdText.AutoSize = true;
            this.rdText.Checked = true;
            this.rdText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdText.ForeColor = System.Drawing.Color.White;
            this.rdText.Location = new System.Drawing.Point(21, 13);
            this.rdText.Name = "rdText";
            this.rdText.Size = new System.Drawing.Size(54, 25);
            this.rdText.TabIndex = 0;
            this.rdText.TabStop = true;
            this.rdText.Text = "Text";
            this.rdText.UseVisualStyleBackColor = true;
            this.rdText.CheckedChanged += new System.EventHandler(this.rdText_CheckedChanged);
            // 
            // txtDescUnit
            // 
            this.txtDescUnit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtDescUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescUnit.Enabled = false;
            this.txtDescUnit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescUnit.ForeColor = System.Drawing.Color.White;
            this.txtDescUnit.Location = new System.Drawing.Point(162, 187);
            this.txtDescUnit.Name = "txtDescUnit";
            this.txtDescUnit.Size = new System.Drawing.Size(72, 25);
            this.txtDescUnit.TabIndex = 196;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 195;
            this.label1.Text = "Unit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(261, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 197;
            this.label2.Text = "(for numeric types)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 49);
            this.panel1.TabIndex = 198;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(286, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 39);
            this.label9.TabIndex = 24;
            this.label9.Text = "Descriptions";
            // 
            // frmDescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(753, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDesc);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtDescriptionName);
            this.Controls.Add(this.lvDescription);
            this.Controls.Add(this.lblDescriptionID);
            this.Controls.Add(this.label21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDescriptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmDescriptions_Load);
            this.grpDesc.ResumeLayout(false);
            this.grpDesc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label23;
        public MyTextBox txtDescriptionName;
        private System.Windows.Forms.ListView lvDescription;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Label lblDescriptionID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox grpDesc;
        private System.Windows.Forms.RadioButton rdNumeric;
        private System.Windows.Forms.RadioButton rdText;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public MyTextBox txtDescUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}