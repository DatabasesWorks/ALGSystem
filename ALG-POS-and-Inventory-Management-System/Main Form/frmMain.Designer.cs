﻿namespace ALG_POS_and_Inventory_Management_System {
    partial class frmMain {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitCont = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogsAndMaintenance = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.maintenancePanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnManageEmp = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.clerkPanel = new System.Windows.Forms.Panel();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.picWarning = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.timerCritStock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).BeginInit();
            this.splitCont.Panel1.SuspendLayout();
            this.splitCont.Panel2.SuspendLayout();
            this.splitCont.SuspendLayout();
            this.maintenancePanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1219, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(63, 46);
            this.btnLogout.TabIndex = 84;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Snow;
            this.btnClose.Location = new System.Drawing.Point(1288, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 46);
            this.btnClose.TabIndex = 83;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(833, 41);
            this.label1.TabIndex = 86;
            this.label1.Text = "Point of Sale and Inventory Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // splitCont
            // 
            this.splitCont.IsSplitterFixed = true;
            this.splitCont.Location = new System.Drawing.Point(2, 73);
            this.splitCont.Name = "splitCont";
            // 
            // splitCont.Panel1
            // 
            this.splitCont.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitCont.Panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.splitCont.Panel1.Controls.Add(this.panel1);
            this.splitCont.Panel1.Controls.Add(this.btnLogsAndMaintenance);
            this.splitCont.Panel1.Controls.Add(this.btnPOS);
            this.splitCont.Panel1.Controls.Add(this.btnServices);
            this.splitCont.Panel1.Controls.Add(this.btnInventory);
            // 
            // splitCont.Panel2
            // 
            this.splitCont.Panel2.AutoScroll = true;
            this.splitCont.Panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.splitCont.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitCont.Panel2.Controls.Add(this.maintenancePanel);
            this.splitCont.Size = new System.Drawing.Size(1362, 694);
            this.splitCont.SplitterDistance = 175;
            this.splitCont.SplitterWidth = 1;
            this.splitCont.TabIndex = 138;
            this.splitCont.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(72, 596);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 22);
            this.panel1.TabIndex = 22;
            // 
            // btnLogsAndMaintenance
            // 
            this.btnLogsAndMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.btnLogsAndMaintenance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogsAndMaintenance.BackgroundImage")));
            this.btnLogsAndMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogsAndMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogsAndMaintenance.FlatAppearance.BorderSize = 0;
            this.btnLogsAndMaintenance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogsAndMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogsAndMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogsAndMaintenance.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogsAndMaintenance.Location = new System.Drawing.Point(-2, 556);
            this.btnLogsAndMaintenance.Name = "btnLogsAndMaintenance";
            this.btnLogsAndMaintenance.Size = new System.Drawing.Size(176, 102);
            this.btnLogsAndMaintenance.TabIndex = 21;
            this.btnLogsAndMaintenance.UseVisualStyleBackColor = false;
            this.btnLogsAndMaintenance.Click += new System.EventHandler(this.btnLogsAndMaintenance_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.Transparent;
            this.btnPOS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPOS.BackgroundImage")));
            this.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.ForeColor = System.Drawing.Color.Transparent;
            this.btnPOS.Location = new System.Drawing.Point(0, 69);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(176, 101);
            this.btnPOS.TabIndex = 12;
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.Transparent;
            this.btnServices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServices.BackgroundImage")));
            this.btnServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.ForeColor = System.Drawing.Color.Transparent;
            this.btnServices.Location = new System.Drawing.Point(0, 387);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(176, 123);
            this.btnServices.TabIndex = 19;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInventory.BackgroundImage")));
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.ForeColor = System.Drawing.Color.Transparent;
            this.btnInventory.Location = new System.Drawing.Point(-3, 220);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(176, 113);
            this.btnInventory.TabIndex = 13;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // maintenancePanel
            // 
            this.maintenancePanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maintenancePanel.Controls.Add(this.panel9);
            this.maintenancePanel.Controls.Add(this.pnlTitle);
            this.maintenancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintenancePanel.Location = new System.Drawing.Point(0, 0);
            this.maintenancePanel.Name = "maintenancePanel";
            this.maintenancePanel.Size = new System.Drawing.Size(1186, 694);
            this.maintenancePanel.TabIndex = 135;
            this.maintenancePanel.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel9.Controls.Add(this.btnManageEmp);
            this.panel9.Controls.Add(this.btnLogs);
            this.panel9.Controls.Add(this.btnCustomer);
            this.panel9.Controls.Add(this.btnManageUsers);
            this.panel9.Location = new System.Drawing.Point(200, 188);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(789, 354);
            this.panel9.TabIndex = 134;
            // 
            // btnManageEmp
            // 
            this.btnManageEmp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnManageEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageEmp.BackgroundImage")));
            this.btnManageEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageEmp.FlatAppearance.BorderSize = 0;
            this.btnManageEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnManageEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnManageEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEmp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmp.ForeColor = System.Drawing.Color.White;
            this.btnManageEmp.Location = new System.Drawing.Point(460, 32);
            this.btnManageEmp.Name = "btnManageEmp";
            this.btnManageEmp.Size = new System.Drawing.Size(187, 154);
            this.btnManageEmp.TabIndex = 129;
            this.btnManageEmp.UseVisualStyleBackColor = false;
            this.btnManageEmp.Click += new System.EventHandler(this.btnManageEmp_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogs.BackgroundImage")));
            this.btnLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.ForeColor = System.Drawing.Color.White;
            this.btnLogs.Location = new System.Drawing.Point(460, 178);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(215, 162);
            this.btnLogs.TabIndex = 130;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.BackgroundImage")));
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(153, 175);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(199, 165);
            this.btnCustomer.TabIndex = 128;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnManageUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.BackgroundImage")));
            this.btnManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnManageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(143, 30);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(200, 158);
            this.btnManageUsers.TabIndex = 127;
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTitle.Controls.Add(this.label5);
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1187, 63);
            this.pnlTitle.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(436, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 38);
            this.label5.TabIndex = 30;
            this.label5.Text = "Logs and Maintenance";
            // 
            // clerkPanel
            // 
            this.clerkPanel.AutoScroll = true;
            this.clerkPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clerkPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clerkPanel.BackgroundImage")));
            this.clerkPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clerkPanel.Location = new System.Drawing.Point(0, 72);
            this.clerkPanel.Name = "clerkPanel";
            this.clerkPanel.Size = new System.Drawing.Size(1366, 692);
            this.clerkPanel.TabIndex = 139;
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapse.ForeColor = System.Drawing.Color.Black;
            this.btnCollapse.Location = new System.Drawing.Point(0, 38);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(53, 36);
            this.btnCollapse.TabIndex = 140;
            this.btnCollapse.Text = "---";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Visible = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // picWarning
            // 
            this.picWarning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWarning.Image = ((System.Drawing.Image)(resources.GetObject("picWarning.Image")));
            this.picWarning.Location = new System.Drawing.Point(85, 12);
            this.picWarning.Name = "picWarning";
            this.picWarning.Size = new System.Drawing.Size(73, 62);
            this.picWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWarning.TabIndex = 141;
            this.picWarning.TabStop = false;
            this.picWarning.Visible = false;
            this.picWarning.Click += new System.EventHandler(this.picWarning_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarning.Location = new System.Drawing.Point(133, 9);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(25, 29);
            this.lblWarning.TabIndex = 142;
            this.lblWarning.Text = "0";
            this.lblWarning.Visible = false;
            // 
            // timerCritStock
            // 
            this.timerCritStock.Enabled = true;
            this.timerCritStock.Interval = 3000;
            this.timerCritStock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.splitCont);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.clerkPanel);
            this.Controls.Add(this.picWarning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitCont.Panel1.ResumeLayout(false);
            this.splitCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).EndInit();
            this.splitCont.ResumeLayout(false);
            this.maintenancePanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitCont;
        private System.Windows.Forms.Button btnLogsAndMaintenance;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel maintenancePanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnManageEmp;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel clerkPanel;
        public System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.PictureBox picWarning;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Timer timerCritStock;
        private System.Windows.Forms.Panel panel1;
    }
}