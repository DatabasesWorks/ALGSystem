namespace ALG_POS_and_Inventory_Management_System
{
    partial class frmManageCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCust = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCustClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProdPrint = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCustID = new MyTextBox();
            this.txtAddress = new MyTextBox();
            this.txtContact = new MyTextBox();
            this.txtMI = new MyTextBox();
            this.txtGN = new MyTextBox();
            this.txtFN = new MyTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Address";
            this.columnHeader5.Width = 173;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Contact #";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "M.I.";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Given Name";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Family Name";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Customer ID.";
            this.columnHeader1.Width = 0;
            // 
            // lvCust
            // 
            this.lvCust.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader5});
            this.lvCust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCust.FullRowSelect = true;
            this.lvCust.Location = new System.Drawing.Point(11, 170);
            this.lvCust.Name = "lvCust";
            this.lvCust.Size = new System.Drawing.Size(675, 246);
            this.lvCust.TabIndex = 181;
            this.lvCust.UseCompatibleStateImageBehavior = false;
            this.lvCust.View = System.Windows.Forms.View.Details;
            this.lvCust.SelectedIndexChanged += new System.EventHandler(this.lvCust_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 180;
            this.label1.Text = "Customer ID:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(450, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 38);
            this.btnClear.TabIndex = 176;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(415, 169);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(63, 19);
            this.label30.TabIndex = 171;
            this.label30.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(303, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 112;
            this.label3.Text = "MI:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(6, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 19);
            this.label15.TabIndex = 107;
            this.label15.Text = "Family Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 19);
            this.label16.TabIndex = 108;
            this.label16.Text = "Given Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(254, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 19);
            this.label18.TabIndex = 169;
            this.label18.Text = "Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGN);
            this.groupBox1.Controls.Add(this.txtFN);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 87);
            this.groupBox1.TabIndex = 168;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 167;
            this.label4.Text = "Contact #:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(825, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 53);
            this.btnDelete.TabIndex = 193;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(692, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 53);
            this.btnSave.TabIndex = 192;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCustClear
            // 
            this.btnCustClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustClear.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnCustClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustClear.FlatAppearance.BorderSize = 0;
            this.btnCustClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustClear.ForeColor = System.Drawing.Color.White;
            this.btnCustClear.Location = new System.Drawing.Point(754, 314);
            this.btnCustClear.Name = "btnCustClear";
            this.btnCustClear.Size = new System.Drawing.Size(127, 53);
            this.btnCustClear.TabIndex = 191;
            this.btnCustClear.Text = "Clear";
            this.btnCustClear.UseVisualStyleBackColor = false;
            this.btnCustClear.Click += new System.EventHandler(this.btnCustClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(825, 196);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 53);
            this.btnEdit.TabIndex = 190;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(692, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 53);
            this.btnAdd.TabIndex = 189;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(909, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 195;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnProdPrint.Location = new System.Drawing.Point(472, 62);
            this.btnProdPrint.Name = "btnProdPrint";
            this.btnProdPrint.Size = new System.Drawing.Size(163, 68);
            this.btnProdPrint.TabIndex = 194;
            this.btnProdPrint.Text = "Print";
            this.btnProdPrint.UseVisualStyleBackColor = false;
            this.btnProdPrint.Click += new System.EventHandler(this.btnProdPrint_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(727, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 60);
            this.button2.TabIndex = 196;
            this.button2.Text = "View Vechicle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtCustID
            // 
            this.txtCustID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCustID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustID.ForeColor = System.Drawing.Color.White;
            this.txtCustID.Location = new System.Drawing.Point(118, 12);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(129, 25);
            this.txtCustID.TabIndex = 179;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(327, 141);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(251, 25);
            this.txtAddress.TabIndex = 178;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.White;
            this.txtContact.Location = new System.Drawing.Point(93, 133);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(129, 25);
            this.txtContact.TabIndex = 170;
            // 
            // txtMI
            // 
            this.txtMI.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtMI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMI.ForeColor = System.Drawing.Color.White;
            this.txtMI.Location = new System.Drawing.Point(341, 24);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(39, 25);
            this.txtMI.TabIndex = 113;
            // 
            // txtGN
            // 
            this.txtGN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtGN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGN.ForeColor = System.Drawing.Color.White;
            this.txtGN.Location = new System.Drawing.Point(108, 52);
            this.txtGN.Name = "txtGN";
            this.txtGN.Size = new System.Drawing.Size(189, 25);
            this.txtGN.TabIndex = 111;
            // 
            // txtFN
            // 
            this.txtFN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtFN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFN.ForeColor = System.Drawing.Color.White;
            this.txtFN.Location = new System.Drawing.Point(109, 22);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(188, 25);
            this.txtFN.TabIndex = 110;
            // 
            // frmManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(954, 460);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProdPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCustClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lvCust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 270);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageCustomer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmManageCustomer";
            this.Load += new System.EventHandler(this.frmManageCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MyTextBox txtCustID;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvCust;
        private System.Windows.Forms.Label label1;
        public MyTextBox txtAddress;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label30;
        public MyTextBox txtMI;
        private System.Windows.Forms.Label label3;
        public MyTextBox txtGN;
        public MyTextBox txtFN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public MyTextBox txtContact;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCustClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProdPrint;
        private System.Windows.Forms.Button button2;
    }
}