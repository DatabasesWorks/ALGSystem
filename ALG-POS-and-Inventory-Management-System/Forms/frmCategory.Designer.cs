namespace ALG_POS_and_Inventory_Management_System {
    partial class frmCategory {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.lvCategory = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.clbDescriptions = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCategoryName = new MyTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCategory
            // 
            this.lvCategory.BackColor = System.Drawing.Color.White;
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader1,
            this.columnHeader16});
            this.lvCategory.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCategory.ForeColor = System.Drawing.Color.Black;
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.GridLines = true;
            this.lvCategory.Location = new System.Drawing.Point(6, 178);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(253, 279);
            this.lvCategory.TabIndex = 183;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.SelectedIndexChanged += new System.EventHandler(this.lvCategory_SelectedIndexChanged);
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Category ID.";
            this.columnHeader14.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Category Name";
            this.columnHeader16.Width = 212;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblCategoryID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryID.ForeColor = System.Drawing.Color.White;
            this.lblCategoryID.Location = new System.Drawing.Point(2, 104);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(96, 19);
            this.lblCategoryID.TabIndex = 182;
            this.lblCategoryID.Text = "Category ID.:";
            this.lblCategoryID.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(1, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(129, 21);
            this.label21.TabIndex = 181;
            this.label21.Text = "Category Name:";
            // 
            // clbDescriptions
            // 
            this.clbDescriptions.Enabled = false;
            this.clbDescriptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbDescriptions.FormattingEnabled = true;
            this.clbDescriptions.Location = new System.Drawing.Point(266, 213);
            this.clbDescriptions.Name = "clbDescriptions";
            this.clbDescriptions.Size = new System.Drawing.Size(230, 244);
            this.clbDescriptions.TabIndex = 194;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 195;
            this.label1.Text = "Category Descriptions:";
            // 
            // btnDesc
            // 
            this.btnDesc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDesc.BackgroundImage")));
            this.btnDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesc.FlatAppearance.BorderSize = 0;
            this.btnDesc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDesc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesc.ForeColor = System.Drawing.Color.White;
            this.btnDesc.Location = new System.Drawing.Point(448, 178);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(48, 34);
            this.btnDesc.TabIndex = 196;
            this.btnDesc.Text = "+";
            this.btnDesc.UseVisualStyleBackColor = false;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(643, 278);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 53);
            this.btnDelete.TabIndex = 201;
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
            this.btnSave.Location = new System.Drawing.Point(500, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 53);
            this.btnSave.TabIndex = 200;
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
            this.btnClear.Location = new System.Drawing.Point(573, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 53);
            this.btnClear.TabIndex = 199;
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
            this.btnEdit.Location = new System.Drawing.Point(643, 226);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 53);
            this.btnEdit.TabIndex = 198;
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
            this.btnAdd.Location = new System.Drawing.Point(500, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 53);
            this.btnAdd.TabIndex = 197;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoryName.Enabled = false;
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.ForeColor = System.Drawing.Color.White;
            this.txtCategoryName.Location = new System.Drawing.Point(135, 121);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(209, 25);
            this.txtCategoryName.TabIndex = 184;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 49);
            this.panel1.TabIndex = 202;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(319, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 39);
            this.label9.TabIndex = 24;
            this.label9.Text = "Categories";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(788, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbDescriptions);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.label21);
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MyTextBox txtCategoryName;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckedListBox clbDescriptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}