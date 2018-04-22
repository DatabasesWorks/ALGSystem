namespace ALG_POS_and_Inventory_Management_System {
    partial class uCInventory {
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
            this.tabInventory = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.tabStocks = new System.Windows.Forms.TabPage();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.tabProductPrice = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabInventory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.tabProducts);
            this.tabInventory.Controls.Add(this.tabStocks);
            this.tabInventory.Controls.Add(this.tabSuppliers);
            this.tabInventory.Controls.Add(this.tabProductPrice);
            this.tabInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInventory.Location = new System.Drawing.Point(11, 59);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.SelectedIndex = 0;
            this.tabInventory.Size = new System.Drawing.Size(1333, 571);
            this.tabInventory.TabIndex = 56;
            this.tabInventory.SelectedIndexChanged += new System.EventHandler(this.tabInventory_SelectedIndexChanged);
            this.tabInventory.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabInventory_Selected);
            // 
            // tabProducts
            // 
            this.tabProducts.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabProducts.Location = new System.Drawing.Point(4, 34);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(1325, 533);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "Products";
            // 
            // tabStocks
            // 
            this.tabStocks.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabStocks.Location = new System.Drawing.Point(4, 34);
            this.tabStocks.Name = "tabStocks";
            this.tabStocks.Padding = new System.Windows.Forms.Padding(3);
            this.tabStocks.Size = new System.Drawing.Size(1325, 533);
            this.tabStocks.TabIndex = 1;
            this.tabStocks.Text = "Stocks";
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabSuppliers.Location = new System.Drawing.Point(4, 34);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppliers.Size = new System.Drawing.Size(1325, 533);
            this.tabSuppliers.TabIndex = 2;
            this.tabSuppliers.Text = "Suppliers";
            // 
            // tabProductPrice
            // 
            this.tabProductPrice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabProductPrice.ForeColor = System.Drawing.Color.White;
            this.tabProductPrice.Location = new System.Drawing.Point(4, 34);
            this.tabProductPrice.Name = "tabProductPrice";
            this.tabProductPrice.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductPrice.Size = new System.Drawing.Size(1325, 533);
            this.tabProductPrice.TabIndex = 3;
            this.tabProductPrice.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(521, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 39);
            this.label5.TabIndex = 31;
            this.label5.Text = "Inventory Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(11, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 52);
            this.panel1.TabIndex = 55;
            // 
            // uCInventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.tabInventory);
            this.Controls.Add(this.panel1);
            this.Name = "uCInventory";
            this.Size = new System.Drawing.Size(1366, 649);
            this.Load += new System.EventHandler(this.uCInventory_Load);
            this.tabInventory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInventory;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabStocks;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.TabPage tabProductPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}
