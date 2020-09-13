namespace Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Salary = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngCơBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminManager = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.departmentManagerToolStripMenuItem,
            this.positionManagerToolStripMenuItem,
            this.Salary,
            this.lươngCơBảnToolStripMenuItem,
            this.adminManager});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1261, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.homeToolStripMenuItem.Tag = "1";
            this.homeToolStripMenuItem.Text = "Trang chủ";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // departmentManagerToolStripMenuItem
            // 
            this.departmentManagerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("departmentManagerToolStripMenuItem.Image")));
            this.departmentManagerToolStripMenuItem.Name = "departmentManagerToolStripMenuItem";
            this.departmentManagerToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.departmentManagerToolStripMenuItem.Text = "Quản Lý Phòng ban";
            this.departmentManagerToolStripMenuItem.Click += new System.EventHandler(this.departmentManagerToolStripMenuItem_Click);
            // 
            // positionManagerToolStripMenuItem
            // 
            this.positionManagerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("positionManagerToolStripMenuItem.Image")));
            this.positionManagerToolStripMenuItem.Name = "positionManagerToolStripMenuItem";
            this.positionManagerToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.positionManagerToolStripMenuItem.Text = "Quản lý Chức vụ";
            this.positionManagerToolStripMenuItem.Click += new System.EventHandler(this.positionManagerToolStripMenuItem_Click);
            // 
            // Salary
            // 
            this.Salary.Image = ((System.Drawing.Image)(resources.GetObject("Salary.Image")));
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(112, 24);
            this.Salary.Text = "Tính lương";
            this.Salary.Click += new System.EventHandler(this.Salary_Click);
            // 
            // lươngCơBảnToolStripMenuItem
            // 
            this.lươngCơBảnToolStripMenuItem.Image = global::Shop.Properties.Resources.hire;
            this.lươngCơBảnToolStripMenuItem.Name = "lươngCơBảnToolStripMenuItem";
            this.lươngCơBảnToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.lươngCơBảnToolStripMenuItem.Text = "Lương Cơ Bản";
            this.lươngCơBảnToolStripMenuItem.Click += new System.EventHandler(this.lươngCơBảnToolStripMenuItem_Click);
            // 
            // adminManager
            // 
            this.adminManager.Image = ((System.Drawing.Image)(resources.GetObject("adminManager.Image")));
            this.adminManager.Name = "adminManager";
            this.adminManager.Size = new System.Drawing.Size(211, 24);
            this.adminManager.Text = "Quản Lý Tải Khoản Admin";
            this.adminManager.Click += new System.EventHandler(this.adminManager_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Salary;
        private System.Windows.Forms.ToolStripMenuItem lươngCơBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminManager;
    }
}



