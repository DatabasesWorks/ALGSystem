namespace ALG_POS_and_Inventory_Management_System {
    partial class frmInventoryWizard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryWizard));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlWizard = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnProductPrice = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Controls.Add(this.pnlWizard);
            this.pnlMain.Controls.Add(this.pictureBox3);
            this.pnlMain.Controls.Add(this.pictureBox2);
            this.pnlMain.Controls.Add(this.btnProductPrice);
            this.pnlMain.Controls.Add(this.btnStockIn);
            this.pnlMain.Controls.Add(this.btnProducts);
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(640, 620);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlWizard
            // 
            this.pnlWizard.Location = new System.Drawing.Point(0, 141);
            this.pnlWizard.Name = "pnlWizard";
            this.pnlWizard.Size = new System.Drawing.Size(640, 393);
            this.pnlWizard.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(376, 556);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(205, 556);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnProductPrice
            // 
            this.btnProductPrice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProductPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductPrice.FlatAppearance.BorderSize = 0;
            this.btnProductPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnProductPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProductPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductPrice.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductPrice.ForeColor = System.Drawing.Color.Snow;
            this.btnProductPrice.Location = new System.Drawing.Point(425, 559);
            this.btnProductPrice.Name = "btnProductPrice";
            this.btnProductPrice.Size = new System.Drawing.Size(200, 53);
            this.btnProductPrice.TabIndex = 6;
            this.btnProductPrice.Text = "Product Price";
            this.btnProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductPrice.UseVisualStyleBackColor = false;
            this.btnProductPrice.Click += new System.EventHandler(this.btnProductPrice_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockIn.FlatAppearance.BorderSize = 0;
            this.btnStockIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnStockIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockIn.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.ForeColor = System.Drawing.Color.Snow;
            this.btnStockIn.Location = new System.Drawing.Point(250, 557);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(124, 53);
            this.btnStockIn.TabIndex = 4;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockIn.UseVisualStyleBackColor = false;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnProducts.Location = new System.Drawing.Point(12, 557);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(197, 53);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "New Product";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Wizard";
            // 
            // frmInventoryWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 620);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInventoryWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Wizard";
            this.Load += new System.EventHandler(this.frmInventoryWizard_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlWizard;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnProductPrice;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}