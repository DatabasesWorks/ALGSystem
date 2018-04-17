namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitCont = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.maintenancePanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnManageEmp = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clerkPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).BeginInit();
            this.splitCont.Panel1.SuspendLayout();
            this.splitCont.Panel2.SuspendLayout();
            this.splitCont.SuspendLayout();
            this.maintenancePanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(1302, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1233, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(63, 46);
            this.btnLogout.TabIndex = 82;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapse.ForeColor = System.Drawing.Color.Black;
            this.btnCollapse.Location = new System.Drawing.Point(1, 35);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(53, 36);
            this.btnCollapse.TabIndex = 3;
            this.btnCollapse.Text = "---";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Visible = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(378, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(833, 41);
            this.label1.TabIndex = 84;
            this.label1.Text = "Point of Sale and Inventory Management System";
            // 
            // splitCont
            // 
            this.splitCont.IsSplitterFixed = true;
            this.splitCont.Location = new System.Drawing.Point(1, 70);
            this.splitCont.Name = "splitCont";
            // 
            // splitCont.Panel1
            // 
            this.splitCont.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitCont.Panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.splitCont.Panel1.Controls.Add(this.button2);
            this.splitCont.Panel1.Controls.Add(this.btnPOS);
            this.splitCont.Panel1.Controls.Add(this.btnServices);
            this.splitCont.Panel1.Controls.Add(this.btnInventory);
            this.splitCont.Panel1.Controls.Add(this.btnReports);
            this.splitCont.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitCont_Panel1_Paint);
            this.splitCont.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitCont_Panel1_MouseMove);
            // 
            // splitCont.Panel2
            // 
            this.splitCont.Panel2.AutoScroll = true;
            this.splitCont.Panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.splitCont.Panel2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1;
            this.splitCont.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitCont.Panel2.Controls.Add(this.maintenancePanel);
            this.splitCont.Size = new System.Drawing.Size(1362, 694);
            this.splitCont.SplitterDistance = 175;
            this.splitCont.SplitterWidth = 1;
            this.splitCont.TabIndex = 135;
            this.splitCont.Visible = false;
            this.splitCont.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitCont_MouseMove);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._222222;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(0, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 102);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.Transparent;
            this.btnPOS.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pos_white;
            this.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.ForeColor = System.Drawing.Color.Transparent;
            this.btnPOS.Location = new System.Drawing.Point(0, 35);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(176, 101);
            this.btnPOS.TabIndex = 12;
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.button6_Click_1);
            this.btnPOS.MouseEnter += new System.EventHandler(this.btnPos_MouseEnter);
            this.btnPOS.MouseLeave += new System.EventHandler(this.btnPos_MouseLeave);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.Transparent;
            this.btnServices.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.services_white;
            this.btnServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.ForeColor = System.Drawing.Color.Transparent;
            this.btnServices.Location = new System.Drawing.Point(0, 437);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(176, 123);
            this.btnServices.TabIndex = 19;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.button4_Click_2);
            this.btnServices.MouseEnter += new System.EventHandler(this.btnServices_MouseEnter);
            this.btnServices.MouseLeave += new System.EventHandler(this.btnServices_MouseLeave);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1212;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.ForeColor = System.Drawing.Color.Transparent;
            this.btnInventory.Location = new System.Drawing.Point(0, 162);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(176, 113);
            this.btnInventory.TabIndex = 13;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.button2_Click_1);
            this.btnInventory.MouseEnter += new System.EventHandler(this.btnInventory_MouseEnter);
            this.btnInventory.MouseLeave += new System.EventHandler(this.btnInventory_MouseLeave);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1231231;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.Transparent;
            this.btnReports.Location = new System.Drawing.Point(0, 314);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(176, 107);
            this.btnReports.TabIndex = 18;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.button3_Click_1);
            this.btnReports.MouseEnter += new System.EventHandler(this.btnReports_MouseEnter);
            this.btnReports.MouseLeave += new System.EventHandler(this.btnReports_MouseLeave);
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
            this.maintenancePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.maintenancePanel_Paint);
            this.maintenancePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.maintenancePanel_MouseMove);
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
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // btnManageEmp
            // 
            this.btnManageEmp.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnManageEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEmp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmp.ForeColor = System.Drawing.Color.White;
            this.btnManageEmp.Location = new System.Drawing.Point(451, 32);
            this.btnManageEmp.Name = "btnManageEmp";
            this.btnManageEmp.Size = new System.Drawing.Size(213, 113);
            this.btnManageEmp.TabIndex = 129;
            this.btnManageEmp.Text = "Manage Employee Information";
            this.btnManageEmp.UseVisualStyleBackColor = false;
            this.btnManageEmp.Click += new System.EventHandler(this.btnManageEmp_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.ForeColor = System.Drawing.Color.White;
            this.btnLogs.Location = new System.Drawing.Point(451, 192);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(213, 113);
            this.btnLogs.TabIndex = 130;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(143, 194);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(213, 113);
            this.btnCustomer.TabIndex = 128;
            this.btnCustomer.Text = "Customer Record";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(143, 32);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(213, 113);
            this.btnManageUsers.TabIndex = 127;
            this.btnManageUsers.Text = "Manage Users";
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
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(221, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // clerkPanel
            // 
            this.clerkPanel.AutoScroll = true;
            this.clerkPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clerkPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clerkPanel.BackgroundImage")));
            this.clerkPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clerkPanel.Location = new System.Drawing.Point(-1, 72);
            this.clerkPanel.Name = "clerkPanel";
            this.clerkPanel.Size = new System.Drawing.Size(1366, 692);
            this.clerkPanel.TabIndex = 83;
            this.clerkPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clerkPanel_MouseMove);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitCont);
            this.Controls.Add(this.clerkPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.splitCont.Panel1.ResumeLayout(false);
            this.splitCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).EndInit();
            this.splitCont.ResumeLayout(false);
            this.maintenancePanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Panel clerkPanel;
        public System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitCont;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel maintenancePanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnManageEmp;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}