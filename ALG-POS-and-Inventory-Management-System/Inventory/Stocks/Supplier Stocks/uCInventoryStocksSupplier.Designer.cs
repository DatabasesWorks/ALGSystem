namespace ALG_POS_and_Inventory_Management_System {
    partial class uCInventoryStocksSupplier {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uCInventoryStocksSupplier));
            this.dtpReceive = new System.Windows.Forms.DateTimePicker();
            this.numSSupPrice = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cboSSuppliers = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboSSort = new System.Windows.Forms.ComboBox();
            this.numSQuan = new System.Windows.Forms.NumericUpDown();
            this.btnSRemoveStocks = new System.Windows.Forms.Button();
            this.btnSDeduct = new System.Windows.Forms.Button();
            this.btnRemoveZero = new System.Windows.Forms.Button();
            this.btnSClear = new System.Windows.Forms.Button();
            this.btnSAdd = new System.Windows.Forms.Button();
            this.btnSEdit = new System.Windows.Forms.Button();
            this.btnSSave = new System.Windows.Forms.Button();
            this.btnSChangePrice = new System.Windows.Forms.Button();
            this.btnSPrint = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.numDeduct = new System.Windows.Forms.NumericUpDown();
            this.lvStocks = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboSProductName = new System.Windows.Forms.ComboBox();
            this.cboSProductID = new System.Windows.Forms.ComboBox();
            this.lblStockID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnShowCritical = new System.Windows.Forms.Button();
            this.btnShowAllStocks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSSupPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpReceive
            // 
            this.dtpReceive.CustomFormat = "MM-dd-yyyy";
            this.dtpReceive.Enabled = false;
            this.dtpReceive.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.dtpReceive.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceive.Location = new System.Drawing.Point(132, 135);
            this.dtpReceive.Name = "dtpReceive";
            this.dtpReceive.Size = new System.Drawing.Size(175, 32);
            this.dtpReceive.TabIndex = 244;
            this.dtpReceive.Value = new System.DateTime(2018, 3, 29, 0, 0, 0, 0);
            // 
            // numSSupPrice
            // 
            this.numSSupPrice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.numSSupPrice.DecimalPlaces = 2;
            this.numSSupPrice.Enabled = false;
            this.numSSupPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSSupPrice.ForeColor = System.Drawing.Color.White;
            this.numSSupPrice.Location = new System.Drawing.Point(456, 11);
            this.numSSupPrice.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numSSupPrice.Name = "numSSupPrice";
            this.numSSupPrice.Size = new System.Drawing.Size(165, 29);
            this.numSSupPrice.TabIndex = 242;
            this.numSSupPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(343, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 21);
            this.label25.TabIndex = 241;
            this.label25.Text = "Supplier Price:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(343, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 21);
            this.label22.TabIndex = 240;
            this.label22.Text = "Supplier:";
            // 
            // cboSSuppliers
            // 
            this.cboSSuppliers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboSSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSSuppliers.Enabled = false;
            this.cboSSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSSuppliers.ForeColor = System.Drawing.Color.White;
            this.cboSSuppliers.FormattingEnabled = true;
            this.cboSSuppliers.Location = new System.Drawing.Point(456, 44);
            this.cboSSuppliers.Name = "cboSSuppliers";
            this.cboSSuppliers.Size = new System.Drawing.Size(165, 29);
            this.cboSSuppliers.TabIndex = 239;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(343, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 21);
            this.label18.TabIndex = 238;
            this.label18.Text = "Quantity:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(3, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 21);
            this.label17.TabIndex = 237;
            this.label17.Text = "Receiving Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 21);
            this.label16.TabIndex = 236;
            this.label16.Text = "Stock ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(2, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 21);
            this.label15.TabIndex = 235;
            this.label15.Text = "Product Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 21);
            this.label14.TabIndex = 234;
            this.label14.Text = "Product ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1097, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 21);
            this.label13.TabIndex = 233;
            this.label13.Text = "Sort By:";
            // 
            // cboSSort
            // 
            this.cboSSort.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboSSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSSort.ForeColor = System.Drawing.Color.White;
            this.cboSSort.FormattingEnabled = true;
            this.cboSSort.Items.AddRange(new object[] {
            "Product ID",
            "Product Name",
            "Stock ID"});
            this.cboSSort.Location = new System.Drawing.Point(1101, 44);
            this.cboSSort.Name = "cboSSort";
            this.cboSSort.Size = new System.Drawing.Size(221, 29);
            this.cboSSort.TabIndex = 231;
            this.cboSSort.SelectedIndexChanged += new System.EventHandler(this.cboSSort_SelectedIndexChanged);
            // 
            // numSQuan
            // 
            this.numSQuan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.numSQuan.Enabled = false;
            this.numSQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSQuan.ForeColor = System.Drawing.Color.White;
            this.numSQuan.Location = new System.Drawing.Point(456, 81);
            this.numSQuan.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSQuan.Name = "numSQuan";
            this.numSQuan.Size = new System.Drawing.Size(165, 29);
            this.numSQuan.TabIndex = 229;
            this.numSQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSRemoveStocks
            // 
            this.btnSRemoveStocks.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSRemoveStocks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSRemoveStocks.BackgroundImage")));
            this.btnSRemoveStocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSRemoveStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSRemoveStocks.Enabled = false;
            this.btnSRemoveStocks.FlatAppearance.BorderSize = 0;
            this.btnSRemoveStocks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSRemoveStocks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSRemoveStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSRemoveStocks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRemoveStocks.ForeColor = System.Drawing.Color.White;
            this.btnSRemoveStocks.Location = new System.Drawing.Point(770, 5);
            this.btnSRemoveStocks.Name = "btnSRemoveStocks";
            this.btnSRemoveStocks.Size = new System.Drawing.Size(142, 75);
            this.btnSRemoveStocks.TabIndex = 228;
            this.btnSRemoveStocks.Text = "Remove Stock";
            this.btnSRemoveStocks.UseVisualStyleBackColor = false;
            this.btnSRemoveStocks.Click += new System.EventHandler(this.btnSRemoveStocks_Click);
            // 
            // btnSDeduct
            // 
            this.btnSDeduct.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSDeduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSDeduct.BackgroundImage")));
            this.btnSDeduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSDeduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSDeduct.Enabled = false;
            this.btnSDeduct.FlatAppearance.BorderSize = 0;
            this.btnSDeduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSDeduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSDeduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSDeduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDeduct.ForeColor = System.Drawing.Color.White;
            this.btnSDeduct.Location = new System.Drawing.Point(933, 83);
            this.btnSDeduct.Name = "btnSDeduct";
            this.btnSDeduct.Size = new System.Drawing.Size(124, 65);
            this.btnSDeduct.TabIndex = 227;
            this.btnSDeduct.Text = "Deduct Stocks";
            this.btnSDeduct.UseVisualStyleBackColor = false;
            this.btnSDeduct.Click += new System.EventHandler(this.btnSDeduct_Click);
            // 
            // btnRemoveZero
            // 
            this.btnRemoveZero.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemoveZero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveZero.BackgroundImage")));
            this.btnRemoveZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveZero.FlatAppearance.BorderSize = 0;
            this.btnRemoveZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemoveZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemoveZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveZero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveZero.ForeColor = System.Drawing.Color.White;
            this.btnRemoveZero.Location = new System.Drawing.Point(918, 3);
            this.btnRemoveZero.Name = "btnRemoveZero";
            this.btnRemoveZero.Size = new System.Drawing.Size(152, 77);
            this.btnRemoveZero.TabIndex = 226;
            this.btnRemoveZero.Text = "Remove Empty Stocks";
            this.btnRemoveZero.UseVisualStyleBackColor = false;
            this.btnRemoveZero.Click += new System.EventHandler(this.btnRemoveZero_Click);
            // 
            // btnSClear
            // 
            this.btnSClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSClear.BackgroundImage")));
            this.btnSClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSClear.FlatAppearance.BorderSize = 0;
            this.btnSClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSClear.ForeColor = System.Drawing.Color.White;
            this.btnSClear.Location = new System.Drawing.Point(484, 144);
            this.btnSClear.Name = "btnSClear";
            this.btnSClear.Size = new System.Drawing.Size(137, 53);
            this.btnSClear.TabIndex = 225;
            this.btnSClear.Text = "Clear";
            this.btnSClear.UseVisualStyleBackColor = false;
            this.btnSClear.Click += new System.EventHandler(this.btnSClear_Click);
            // 
            // btnSAdd
            // 
            this.btnSAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSAdd.BackgroundImage")));
            this.btnSAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSAdd.FlatAppearance.BorderSize = 0;
            this.btnSAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAdd.ForeColor = System.Drawing.Color.White;
            this.btnSAdd.Location = new System.Drawing.Point(636, 144);
            this.btnSAdd.Name = "btnSAdd";
            this.btnSAdd.Size = new System.Drawing.Size(127, 68);
            this.btnSAdd.TabIndex = 224;
            this.btnSAdd.Text = "Add New Stocks";
            this.btnSAdd.UseVisualStyleBackColor = false;
            this.btnSAdd.Click += new System.EventHandler(this.btnSAdd_Click);
            // 
            // btnSEdit
            // 
            this.btnSEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSEdit.BackgroundImage")));
            this.btnSEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSEdit.Enabled = false;
            this.btnSEdit.FlatAppearance.BorderSize = 0;
            this.btnSEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEdit.ForeColor = System.Drawing.Color.White;
            this.btnSEdit.Location = new System.Drawing.Point(627, 69);
            this.btnSEdit.Name = "btnSEdit";
            this.btnSEdit.Size = new System.Drawing.Size(137, 53);
            this.btnSEdit.TabIndex = 223;
            this.btnSEdit.Text = "Add To Stocks";
            this.btnSEdit.UseVisualStyleBackColor = false;
            this.btnSEdit.Click += new System.EventHandler(this.btnSEdit_Click);
            // 
            // btnSSave
            // 
            this.btnSSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSSave.BackgroundImage")));
            this.btnSSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSSave.Enabled = false;
            this.btnSSave.FlatAppearance.BorderSize = 0;
            this.btnSSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSave.ForeColor = System.Drawing.Color.White;
            this.btnSSave.Location = new System.Drawing.Point(332, 136);
            this.btnSSave.Name = "btnSSave";
            this.btnSSave.Size = new System.Drawing.Size(146, 69);
            this.btnSSave.TabIndex = 222;
            this.btnSSave.Text = "Save";
            this.btnSSave.UseVisualStyleBackColor = false;
            this.btnSSave.Click += new System.EventHandler(this.btnSSave_Click);
            // 
            // btnSChangePrice
            // 
            this.btnSChangePrice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSChangePrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSChangePrice.BackgroundImage")));
            this.btnSChangePrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSChangePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSChangePrice.Enabled = false;
            this.btnSChangePrice.FlatAppearance.BorderSize = 0;
            this.btnSChangePrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSChangePrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSChangePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSChangePrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSChangePrice.ForeColor = System.Drawing.Color.White;
            this.btnSChangePrice.Location = new System.Drawing.Point(627, 5);
            this.btnSChangePrice.Name = "btnSChangePrice";
            this.btnSChangePrice.Size = new System.Drawing.Size(136, 53);
            this.btnSChangePrice.TabIndex = 221;
            this.btnSChangePrice.Text = "Change Price";
            this.btnSChangePrice.UseVisualStyleBackColor = false;
            this.btnSChangePrice.Click += new System.EventHandler(this.btnSChangePrice_Click);
            // 
            // btnSPrint
            // 
            this.btnSPrint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSPrint.BackgroundImage")));
            this.btnSPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSPrint.FlatAppearance.BorderSize = 0;
            this.btnSPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPrint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPrint.ForeColor = System.Drawing.Color.White;
            this.btnSPrint.Location = new System.Drawing.Point(1170, 81);
            this.btnSPrint.Name = "btnSPrint";
            this.btnSPrint.Size = new System.Drawing.Size(132, 53);
            this.btnSPrint.TabIndex = 220;
            this.btnSPrint.Text = "Print";
            this.btnSPrint.UseVisualStyleBackColor = false;
            this.btnSPrint.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(788, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 21);
            this.label19.TabIndex = 219;
            this.label19.Text = "Deduct:";
            // 
            // numDeduct
            // 
            this.numDeduct.BackColor = System.Drawing.Color.CornflowerBlue;
            this.numDeduct.Enabled = false;
            this.numDeduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDeduct.ForeColor = System.Drawing.Color.White;
            this.numDeduct.Location = new System.Drawing.Point(857, 95);
            this.numDeduct.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDeduct.Name = "numDeduct";
            this.numDeduct.Size = new System.Drawing.Size(70, 29);
            this.numDeduct.TabIndex = 218;
            this.numDeduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lvStocks
            // 
            this.lvStocks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvStocks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStocks.FullRowSelect = true;
            this.lvStocks.GridLines = true;
            this.lvStocks.Location = new System.Drawing.Point(3, 218);
            this.lvStocks.Name = "lvStocks";
            this.lvStocks.Size = new System.Drawing.Size(1319, 301);
            this.lvStocks.TabIndex = 217;
            this.lvStocks.UseCompatibleStateImageBehavior = false;
            this.lvStocks.View = System.Windows.Forms.View.Details;
            this.lvStocks.SelectedIndexChanged += new System.EventHandler(this.lvStocks_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "No.";
            this.columnHeader9.Width = 43;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Stock ID.";
            this.columnHeader0.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product ID.";
            this.columnHeader1.Width = 183;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Stocks";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Remaining Stocks";
            this.columnHeader5.Width = 135;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Receiving Date";
            this.columnHeader6.Width = 151;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Supplier";
            this.columnHeader7.Width = 108;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Supplier Price";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 170;
            // 
            // cboSProductName
            // 
            this.cboSProductName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboSProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSProductName.Enabled = false;
            this.cboSProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSProductName.ForeColor = System.Drawing.Color.White;
            this.cboSProductName.FormattingEnabled = true;
            this.cboSProductName.Location = new System.Drawing.Point(127, 51);
            this.cboSProductName.Name = "cboSProductName";
            this.cboSProductName.Size = new System.Drawing.Size(203, 29);
            this.cboSProductName.TabIndex = 243;
            this.cboSProductName.SelectedIndexChanged += new System.EventHandler(this.cboSProductName_SelectedIndexChanged);
            // 
            // cboSProductID
            // 
            this.cboSProductID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cboSProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSProductID.Enabled = false;
            this.cboSProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSProductID.ForeColor = System.Drawing.Color.White;
            this.cboSProductID.FormattingEnabled = true;
            this.cboSProductID.Location = new System.Drawing.Point(127, 12);
            this.cboSProductID.Name = "cboSProductID";
            this.cboSProductID.Size = new System.Drawing.Size(203, 29);
            this.cboSProductID.TabIndex = 232;
            this.cboSProductID.SelectedIndexChanged += new System.EventHandler(this.cboSProductID_SelectedIndexChanged);
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblStockID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.ForeColor = System.Drawing.Color.White;
            this.lblStockID.Location = new System.Drawing.Point(128, 98);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(78, 21);
            this.lblStockID.TabIndex = 245;
            this.lblStockID.Text = "_Stock ID";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnShowCritical
            // 
            this.btnShowCritical.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowCritical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowCritical.BackgroundImage")));
            this.btnShowCritical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowCritical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCritical.FlatAppearance.BorderSize = 0;
            this.btnShowCritical.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowCritical.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowCritical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCritical.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCritical.ForeColor = System.Drawing.Color.White;
            this.btnShowCritical.Location = new System.Drawing.Point(1167, 148);
            this.btnShowCritical.Name = "btnShowCritical";
            this.btnShowCritical.Size = new System.Drawing.Size(147, 67);
            this.btnShowCritical.TabIndex = 246;
            this.btnShowCritical.Text = "Show Critical Stocks";
            this.btnShowCritical.UseVisualStyleBackColor = false;
            this.btnShowCritical.Click += new System.EventHandler(this.btnShowCritical_Click);
            // 
            // btnShowAllStocks
            // 
            this.btnShowAllStocks.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowAllStocks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowAllStocks.BackgroundImage")));
            this.btnShowAllStocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowAllStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllStocks.FlatAppearance.BorderSize = 0;
            this.btnShowAllStocks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowAllStocks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowAllStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllStocks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllStocks.ForeColor = System.Drawing.Color.White;
            this.btnShowAllStocks.Location = new System.Drawing.Point(1014, 149);
            this.btnShowAllStocks.Name = "btnShowAllStocks";
            this.btnShowAllStocks.Size = new System.Drawing.Size(147, 67);
            this.btnShowAllStocks.TabIndex = 247;
            this.btnShowAllStocks.Text = "Show All Stocks";
            this.btnShowAllStocks.UseVisualStyleBackColor = false;
            this.btnShowAllStocks.Click += new System.EventHandler(this.btnShowAllStocks_Click);
            // 
            // uCInventoryStocksSupplier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.btnShowAllStocks);
            this.Controls.Add(this.btnShowCritical);
            this.Controls.Add(this.lblStockID);
            this.Controls.Add(this.dtpReceive);
            this.Controls.Add(this.cboSProductName);
            this.Controls.Add(this.numSSupPrice);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cboSSuppliers);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboSProductID);
            this.Controls.Add(this.cboSSort);
            this.Controls.Add(this.numSQuan);
            this.Controls.Add(this.btnSRemoveStocks);
            this.Controls.Add(this.btnSDeduct);
            this.Controls.Add(this.btnRemoveZero);
            this.Controls.Add(this.btnSClear);
            this.Controls.Add(this.btnSAdd);
            this.Controls.Add(this.btnSEdit);
            this.Controls.Add(this.btnSSave);
            this.Controls.Add(this.btnSChangePrice);
            this.Controls.Add(this.btnSPrint);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.numDeduct);
            this.Controls.Add(this.lvStocks);
            this.Name = "uCInventoryStocksSupplier";
            this.Size = new System.Drawing.Size(1325, 533);
            this.Load += new System.EventHandler(this.uCInventoryStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSSupPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpReceive;
        private System.Windows.Forms.NumericUpDown numSSupPrice;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cboSSuppliers;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboSSort;
        private System.Windows.Forms.NumericUpDown numSQuan;
        private System.Windows.Forms.Button btnSRemoveStocks;
        private System.Windows.Forms.Button btnSDeduct;
        private System.Windows.Forms.Button btnRemoveZero;
        private System.Windows.Forms.Button btnSClear;
        private System.Windows.Forms.Button btnSAdd;
        private System.Windows.Forms.Button btnSEdit;
        private System.Windows.Forms.Button btnSSave;
        private System.Windows.Forms.Button btnSChangePrice;
        private System.Windows.Forms.Button btnSPrint;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numDeduct;
        private System.Windows.Forms.ListView lvStocks;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cboSProductName;
        private System.Windows.Forms.ComboBox cboSProductID;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnShowCritical;
        private System.Windows.Forms.Button btnShowAllStocks;
    }
}
