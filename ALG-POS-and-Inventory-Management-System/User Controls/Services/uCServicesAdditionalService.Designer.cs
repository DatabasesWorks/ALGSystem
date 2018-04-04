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
            this.addedname = new MyTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.addedprice = new System.Windows.Forms.NumericUpDown();
            this.cboservname = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.addedID = new MyTextBox();
            this.lvadded = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnProdDelete = new System.Windows.Forms.Button();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.btnProdClear = new System.Windows.Forms.Button();
            this.btnProdEdit = new System.Windows.Forms.Button();
            this.btnProdAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addedprice)).BeginInit();
            this.SuspendLayout();
            // 
            // addedname
            // 
            this.addedname.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addedname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addedname.Enabled = false;
            this.addedname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedname.ForeColor = System.Drawing.Color.White;
            this.addedname.Location = new System.Drawing.Point(227, 108);
            this.addedname.Name = "addedname";
            this.addedname.Size = new System.Drawing.Size(178, 25);
            this.addedname.TabIndex = 166;
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
            // addedprice
            // 
            this.addedprice.BackColor = System.Drawing.Color.RoyalBlue;
            this.addedprice.Enabled = false;
            this.addedprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedprice.ForeColor = System.Drawing.Color.White;
            this.addedprice.Location = new System.Drawing.Point(622, 69);
            this.addedprice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.addedprice.Name = "addedprice";
            this.addedprice.Size = new System.Drawing.Size(159, 29);
            this.addedprice.TabIndex = 164;
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
            // addedID
            // 
            this.addedID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addedID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addedID.Enabled = false;
            this.addedID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedID.ForeColor = System.Drawing.Color.White;
            this.addedID.Location = new System.Drawing.Point(227, 32);
            this.addedID.Name = "addedID";
            this.addedID.Size = new System.Drawing.Size(52, 25);
            this.addedID.TabIndex = 162;
            // 
            // lvadded
            // 
            this.lvadded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.btnProdDelete.Location = new System.Drawing.Point(661, 213);
            this.btnProdDelete.Name = "btnProdDelete";
            this.btnProdDelete.Size = new System.Drawing.Size(132, 53);
            this.btnProdDelete.TabIndex = 191;
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
            this.btnProdSave.Location = new System.Drawing.Point(534, 213);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(121, 53);
            this.btnProdSave.TabIndex = 190;
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
            this.btnProdClear.Location = new System.Drawing.Point(594, 268);
            this.btnProdClear.Name = "btnProdClear";
            this.btnProdClear.Size = new System.Drawing.Size(129, 53);
            this.btnProdClear.TabIndex = 189;
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
            this.btnProdEdit.Location = new System.Drawing.Point(661, 161);
            this.btnProdEdit.Name = "btnProdEdit";
            this.btnProdEdit.Size = new System.Drawing.Size(132, 53);
            this.btnProdEdit.TabIndex = 188;
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
            this.btnProdAdd.Location = new System.Drawing.Point(534, 161);
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.Size = new System.Drawing.Size(121, 53);
            this.btnProdAdd.TabIndex = 187;
            this.btnProdAdd.Text = "Add";
            this.btnProdAdd.UseVisualStyleBackColor = false;
            // 
            // uCServicesAdditionalService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btnProdDelete);
            this.Controls.Add(this.btnProdSave);
            this.Controls.Add(this.btnProdClear);
            this.Controls.Add(this.btnProdEdit);
            this.Controls.Add(this.btnProdAdd);
            this.Controls.Add(this.addedname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.addedprice);
            this.Controls.Add(this.cboservname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addedID);
            this.Controls.Add(this.lvadded);
            this.Name = "uCServicesAdditionalService";
            this.Size = new System.Drawing.Size(820, 453);
            ((System.ComponentModel.ISupportInitialize)(this.addedprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MyTextBox addedname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown addedprice;
        private System.Windows.Forms.ComboBox cboservname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public MyTextBox addedID;
        private System.Windows.Forms.ListView lvadded;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnProdDelete;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.Button btnProdClear;
        private System.Windows.Forms.Button btnProdEdit;
        private System.Windows.Forms.Button btnProdAdd;
    }
}
