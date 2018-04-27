namespace ALG_POS_and_Inventory_Management_System {
    partial class frmManageSettings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSettings));
            this.label3 = new System.Windows.Forms.Label();
            this.txtTin = new MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusinessName = new MyTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusinessAddress = new MyTextBox();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.numVat = new System.Windows.Forms.NumericUpDown();
            this.numCritStock = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCritStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 162;
            this.label3.Text = "Business Name:";
            // 
            // txtTin
            // 
            this.txtTin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTin.Enabled = false;
            this.txtTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTin.ForeColor = System.Drawing.Color.White;
            this.txtTin.Location = new System.Drawing.Point(143, 67);
            this.txtTin.Name = "txtTin";
            this.txtTin.Size = new System.Drawing.Size(295, 25);
            this.txtTin.TabIndex = 161;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 163;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 165;
            this.label2.Text = "TIN:";
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtBusinessName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusinessName.Enabled = false;
            this.txtBusinessName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusinessName.ForeColor = System.Drawing.Color.White;
            this.txtBusinessName.Location = new System.Drawing.Point(143, 108);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(295, 25);
            this.txtBusinessName.TabIndex = 164;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 169;
            this.label4.Text = "Vat Percent:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 167;
            this.label5.Text = "Business Address:";
            // 
            // txtBusinessAddress
            // 
            this.txtBusinessAddress.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtBusinessAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusinessAddress.Enabled = false;
            this.txtBusinessAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusinessAddress.ForeColor = System.Drawing.Color.White;
            this.txtBusinessAddress.Location = new System.Drawing.Point(153, 152);
            this.txtBusinessAddress.Name = "txtBusinessAddress";
            this.txtBusinessAddress.Size = new System.Drawing.Size(285, 25);
            this.txtBusinessAddress.TabIndex = 166;
            // 
            // btnProdSave
            // 
            this.btnProdSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProdSave.BackgroundImage")));
            this.btnProdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdSave.FlatAppearance.BorderSize = 0;
            this.btnProdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdSave.ForeColor = System.Drawing.Color.White;
            this.btnProdSave.Location = new System.Drawing.Point(287, 280);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(137, 65);
            this.btnProdSave.TabIndex = 196;
            this.btnProdSave.Text = "Save";
            this.btnProdSave.UseVisualStyleBackColor = false;
            this.btnProdSave.Click += new System.EventHandler(this.btnProdSave_Click);
            // 
            // numVat
            // 
            this.numVat.DecimalPlaces = 2;
            this.numVat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.numVat.Location = new System.Drawing.Point(185, 199);
            this.numVat.Name = "numVat";
            this.numVat.Size = new System.Drawing.Size(73, 29);
            this.numVat.TabIndex = 197;
            // 
            // numCritStock
            // 
            this.numCritStock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.numCritStock.Location = new System.Drawing.Point(185, 234);
            this.numCritStock.Name = "numCritStock";
            this.numCritStock.Size = new System.Drawing.Size(73, 29);
            this.numCritStock.TabIndex = 199;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 21);
            this.label6.TabIndex = 198;
            this.label6.Text = "Critical Stock Warning:";
            // 
            // frmManageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(450, 357);
            this.Controls.Add(this.numCritStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numVat);
            this.Controls.Add(this.btnProdSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBusinessAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusinessName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmManageSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCritStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public MyTextBox txtTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public MyTextBox txtBusinessName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public MyTextBox txtBusinessAddress;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.NumericUpDown numVat;
        private System.Windows.Forms.NumericUpDown numCritStock;
        private System.Windows.Forms.Label label6;
    }
}