namespace ALG_POS_and_Inventory_Management_System
{
    partial class frmVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicle));
            this.lvVehicle = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProdPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCustClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboVehicleType = new System.Windows.Forms.ComboBox();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.txtCustID = new MyTextBox();
            this.txtColor = new MyTextBox();
            this.txtPlateNo = new MyTextBox();
            this.txtModel = new MyTextBox();
            this.SuspendLayout();
            // 
            // lvVehicle
            // 
            this.lvVehicle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader5,
            this.columnHeader8});
            resources.ApplyResources(this.lvVehicle, "lvVehicle");
            this.lvVehicle.FullRowSelect = true;
            this.lvVehicle.Name = "lvVehicle";
            this.lvVehicle.UseCompatibleStateImageBehavior = false;
            this.lvVehicle.View = System.Windows.Forms.View.Details;
            this.lvVehicle.SelectedIndexChanged += new System.EventHandler(this.lvVehicle_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnProdPrint
            // 
            this.btnProdPrint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdPrint.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            resources.ApplyResources(this.btnProdPrint, "btnProdPrint");
            this.btnProdPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdPrint.FlatAppearance.BorderSize = 0;
            this.btnProdPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdPrint.ForeColor = System.Drawing.Color.White;
            this.btnProdPrint.Name = "btnProdPrint";
            this.btnProdPrint.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCustClear
            // 
            this.btnCustClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustClear.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            resources.ApplyResources(this.btnCustClear, "btnCustClear");
            this.btnCustClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustClear.FlatAppearance.BorderSize = 0;
            this.btnCustClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustClear.ForeColor = System.Drawing.Color.White;
            this.btnCustClear.Name = "btnCustClear";
            this.btnCustClear.UseVisualStyleBackColor = false;
            this.btnCustClear.Click += new System.EventHandler(this.btnCustClear_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.BackgroundImage = global::ALG_POS_and_Inventory_Management_System.Properties.Resources.rounded_rectangle;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboVehicleType
            // 
            this.cboVehicleType.BackColor = System.Drawing.Color.RoyalBlue;
            this.cboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboVehicleType, "cboVehicleType");
            this.cboVehicleType.ForeColor = System.Drawing.Color.White;
            this.cboVehicleType.FormattingEnabled = true;
            this.cboVehicleType.Items.AddRange(new object[] {
            resources.GetString("cboVehicleType.Items"),
            resources.GetString("cboVehicleType.Items1"),
            resources.GetString("cboVehicleType.Items2")});
            this.cboVehicleType.Name = "cboVehicleType";
            // 
            // cboBrand
            // 
            this.cboBrand.BackColor = System.Drawing.Color.RoyalBlue;
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboBrand, "cboBrand");
            this.cboBrand.ForeColor = System.Drawing.Color.White;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Items.AddRange(new object[] {
            resources.GetString("cboBrand.Items"),
            resources.GetString("cboBrand.Items1"),
            resources.GetString("cboBrand.Items2")});
            this.cboBrand.Name = "cboBrand";
            // 
            // txtCustID
            // 
            this.txtCustID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCustID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtCustID, "txtCustID");
            this.txtCustID.ForeColor = System.Drawing.Color.White;
            this.txtCustID.Name = "txtCustID";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtColor, "txtColor");
            this.txtColor.ForeColor = System.Drawing.Color.White;
            this.txtColor.Name = "txtColor";
            this.txtColor.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtPlateNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtPlateNo, "txtPlateNo");
            this.txtPlateNo.ForeColor = System.Drawing.Color.White;
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.TextChanged += new System.EventHandler(this.myTextBox1_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtModel, "txtModel");
            this.txtModel.ForeColor = System.Drawing.Color.White;
            this.txtModel.Name = "txtModel";
            // 
            // frmVehicle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.cboVehicleType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProdPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCustClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lvVehicle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlateNo);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVehicle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProdPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCustClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        public MyTextBox txtCustID;
        private System.Windows.Forms.ListView lvVehicle;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        public MyTextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public MyTextBox txtPlateNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        public MyTextBox txtModel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboVehicleType;
        private System.Windows.Forms.ComboBox cboBrand;
    }
}