namespace ALG_POS_and_Inventory_Management_System {
    partial class uCServicesAdditionalService {
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
            this.label13 = new System.Windows.Forms.Label();
            this.txtaddedprice = new System.Windows.Forms.NumericUpDown();
            this.cboservname = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lvadded = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtaddedname = new MyTextBox();
            this.txtaddedID = new MyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddedprice)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(51, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 19);
            this.label13.TabIndex = 165;
            this.label13.Text = "Additional Fee Name:";
            // 
            // txtaddedprice
            // 
            this.txtaddedprice.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtaddedprice.Enabled = false;
            this.txtaddedprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddedprice.ForeColor = System.Drawing.Color.White;
            this.txtaddedprice.Location = new System.Drawing.Point(622, 69);
            this.txtaddedprice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtaddedprice.Name = "txtaddedprice";
            this.txtaddedprice.Size = new System.Drawing.Size(159, 29);
            this.txtaddedprice.TabIndex = 164;
            // 
            // cboservname
            // 
            this.cboservname.BackColor = System.Drawing.Color.RoyalBlue;
            this.cboservname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboservname.Enabled = false;
            this.cboservname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboservname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboservname.ForeColor = System.Drawing.Color.White;
            this.cboservname.FormattingEnabled = true;
            this.cboservname.Location = new System.Drawing.Point(227, 73);
            this.cboservname.Name = "cboservname";
            this.cboservname.Size = new System.Drawing.Size(178, 29);
            this.cboservname.TabIndex = 163;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(51, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 19);
            this.label10.TabIndex = 161;
            this.label10.Text = "Add. Charge ID.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(430, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 19);
            this.label11.TabIndex = 160;
            this.label11.Text = "Additional Service Fee:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(51, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 19);
            this.label12.TabIndex = 159;
            this.label12.Text = "Service Name:";
            // 
            // lvadded
            // 
            this.lvadded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader12,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvadded.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvadded.FullRowSelect = true;
            this.lvadded.GridLines = true;
            this.lvadded.Location = new System.Drawing.Point(40, 151);
            this.lvadded.Name = "lvadded";
            this.lvadded.Size = new System.Drawing.Size(477, 269);
            this.lvadded.TabIndex = 153;
            this.lvadded.UseCompatibleStateImageBehavior = false;
            this.lvadded.View = System.Windows.Forms.View.Details;
            this.lvadded.SelectedIndexChanged += new System.EventHandler(this.lvadded_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Add. Charge ID";
            this.columnHeader12.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Additinal for";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Additional Fee Name";
            this.columnHeader6.Width = 141;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Additional Fee";
            this.columnHeader7.Width = 136;
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
            this.btnDelete.Location = new System.Drawing.Point(661, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 53);
            this.btnDelete.TabIndex = 191;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSave.Location = new System.Drawing.Point(534, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 53);
            this.btnSave.TabIndex = 190;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(594, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 53);
            this.btnClear.TabIndex = 189;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(661, 161);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 53);
            this.btnEdit.TabIndex = 188;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnProdEdit_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(534, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 53);
            this.btnAdd.TabIndex = 187;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtaddedname
            // 
            this.txtaddedname.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtaddedname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaddedname.Enabled = false;
            this.txtaddedname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddedname.ForeColor = System.Drawing.Color.White;
            this.txtaddedname.Location = new System.Drawing.Point(227, 108);
            this.txtaddedname.Name = "txtaddedname";
            this.txtaddedname.Size = new System.Drawing.Size(178, 25);
            this.txtaddedname.TabIndex = 166;
            // 
            // txtaddedID
            // 
            this.txtaddedID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtaddedID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaddedID.Enabled = false;
            this.txtaddedID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddedID.ForeColor = System.Drawing.Color.White;
            this.txtaddedID.Location = new System.Drawing.Point(227, 32);
            this.txtaddedID.Name = "txtaddedID";
            this.txtaddedID.Size = new System.Drawing.Size(52, 25);
            this.txtaddedID.TabIndex = 162;
            // 
            // uCServicesAdditionalService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtaddedname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtaddedprice);
            this.Controls.Add(this.cboservname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtaddedID);
            this.Controls.Add(this.lvadded);
            this.Name = "uCServicesAdditionalService";
            this.Size = new System.Drawing.Size(820, 453);
            this.Load += new System.EventHandler(this.uCServicesAdditionalService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtaddedprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MyTextBox txtaddedname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown txtaddedprice;
        private System.Windows.Forms.ComboBox cboservname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public MyTextBox txtaddedID;
        private System.Windows.Forms.ListView lvadded;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
