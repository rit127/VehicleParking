namespace VehicleParking
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleParkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.vehicleParkingToolStripMenuItem,
            this.logsHistoryToolStripMenuItem,
            this.userControllerToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.eXToolStripMenuItem,
            this.settingToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.Image = global::VehicleParking.Properties.Resources.documenten;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // logoutToolStripMenuItem
            // 
            resources.ApplyResources(this.logoutToolStripMenuItem, "logoutToolStripMenuItem");
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // vehicleParkingToolStripMenuItem
            // 
            resources.ApplyResources(this.vehicleParkingToolStripMenuItem, "vehicleParkingToolStripMenuItem");
            this.vehicleParkingToolStripMenuItem.Image = global::VehicleParking.Properties.Resources._1d1ae63570ea78b7b8b6fac1e179e7a0_scooter;
            this.vehicleParkingToolStripMenuItem.Name = "vehicleParkingToolStripMenuItem";
            this.vehicleParkingToolStripMenuItem.Click += new System.EventHandler(this.vehicleParkingToolStripMenuItem_Click);
            // 
            // logsHistoryToolStripMenuItem
            // 
            resources.ApplyResources(this.logsHistoryToolStripMenuItem, "logsHistoryToolStripMenuItem");
            this.logsHistoryToolStripMenuItem.Image = global::VehicleParking.Properties.Resources.loggly_icon_search;
            this.logsHistoryToolStripMenuItem.Name = "logsHistoryToolStripMenuItem";
            // 
            // userControllerToolStripMenuItem
            // 
            resources.ApplyResources(this.userControllerToolStripMenuItem, "userControllerToolStripMenuItem");
            this.userControllerToolStripMenuItem.Image = global::VehicleParking.Properties.Resources.man;
            this.userControllerToolStripMenuItem.Name = "userControllerToolStripMenuItem";
            this.userControllerToolStripMenuItem.Click += new System.EventHandler(this.userControllerToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            resources.ApplyResources(this.reportToolStripMenuItem, "reportToolStripMenuItem");
            this.reportToolStripMenuItem.Image = global::VehicleParking.Properties.Resources.report;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            // 
            // eXToolStripMenuItem
            // 
            this.eXToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.eXToolStripMenuItem, "eXToolStripMenuItem");
            this.eXToolStripMenuItem.Image = global::VehicleParking.Properties.Resources.Graphicloads_100_Flat_2_Inside_logout;
            this.eXToolStripMenuItem.Name = "eXToolStripMenuItem";
            // 
            // settingToolStripMenuItem
            // 
            resources.ApplyResources(this.settingToolStripMenuItem, "settingToolStripMenuItem");
            this.settingToolStripMenuItem.Image = global::VehicleParking.Properties.Resources.Settings_icon;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            // 
            // menuStrip2
            // 
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.dateToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip2.Name = "menuStrip2";
            // 
            // userToolStripMenuItem
            // 
            resources.ApplyResources(this.userToolStripMenuItem, "userToolStripMenuItem");
            this.userToolStripMenuItem.Image = global::VehicleParking.Properties.Resources.male_circle_512;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.dateToolStripMenuItem, "dateToolStripMenuItem");
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // frmMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainForm";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logsHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userControllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleParkingToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}