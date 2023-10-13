namespace TempleManagement
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createADMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pangalilogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPangaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePangaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pangaliLogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spiceficDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPangaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gajanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templeAsertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDAssertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletAssertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAssertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.pangalilogToolStripMenuItem,
            this.gajanaToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.expancesToolStripMenuItem,
            this.templeAsertsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(104, 34);
            this.windowsToolStripMenuItem.Text = "Windows";
            this.windowsToolStripMenuItem.Click += new System.EventHandler(this.spiceficDetailsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createADMINToolStripMenuItem,
            this.aDMINDetailsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(95, 34);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // createADMINToolStripMenuItem
            // 
            this.createADMINToolStripMenuItem.Name = "createADMINToolStripMenuItem";
            this.createADMINToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.createADMINToolStripMenuItem.Text = "Create ADMIN";
            this.createADMINToolStripMenuItem.Click += new System.EventHandler(this.createADMINToolStripMenuItem_Click);
            // 
            // aDMINDetailsToolStripMenuItem
            // 
            this.aDMINDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAdminToolStripMenuItem,
            this.editAdminToolStripMenuItem,
            this.deleteAdminToolStripMenuItem});
            this.aDMINDetailsToolStripMenuItem.Name = "aDMINDetailsToolStripMenuItem";
            this.aDMINDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.aDMINDetailsToolStripMenuItem.Text = "ADMIN details";
            // 
            // viewAdminToolStripMenuItem
            // 
            this.viewAdminToolStripMenuItem.Name = "viewAdminToolStripMenuItem";
            this.viewAdminToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.viewAdminToolStripMenuItem.Text = "View admin";
            this.viewAdminToolStripMenuItem.Click += new System.EventHandler(this.viewAdminToolStripMenuItem_Click);
            // 
            // editAdminToolStripMenuItem
            // 
            this.editAdminToolStripMenuItem.Name = "editAdminToolStripMenuItem";
            this.editAdminToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.editAdminToolStripMenuItem.Text = "Edit admin";
            this.editAdminToolStripMenuItem.Click += new System.EventHandler(this.editAdminToolStripMenuItem_Click);
            // 
            // deleteAdminToolStripMenuItem
            // 
            this.deleteAdminToolStripMenuItem.Name = "deleteAdminToolStripMenuItem";
            this.deleteAdminToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.deleteAdminToolStripMenuItem.Text = "Delete admin";
            this.deleteAdminToolStripMenuItem.Click += new System.EventHandler(this.deleteAdminToolStripMenuItem_Click);
            // 
            // pangalilogToolStripMenuItem
            // 
            this.pangalilogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPangaliToolStripMenuItem,
            this.deletePangaliToolStripMenuItem,
            this.pangaliLogToolStripMenuItem1,
            this.editPangaliToolStripMenuItem});
            this.pangalilogToolStripMenuItem.Name = "pangalilogToolStripMenuItem";
            this.pangalilogToolStripMenuItem.Size = new System.Drawing.Size(127, 34);
            this.pangalilogToolStripMenuItem.Text = "Pangali_log";
            // 
            // createPangaliToolStripMenuItem
            // 
            this.createPangaliToolStripMenuItem.Name = "createPangaliToolStripMenuItem";
            this.createPangaliToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.createPangaliToolStripMenuItem.Text = "Create Pangali";
            // 
            // deletePangaliToolStripMenuItem
            // 
            this.deletePangaliToolStripMenuItem.Name = "deletePangaliToolStripMenuItem";
            this.deletePangaliToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.deletePangaliToolStripMenuItem.Text = "Delete Pangali";
            // 
            // pangaliLogToolStripMenuItem1
            // 
            this.pangaliLogToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spiceficDetailsToolStripMenuItem,
            this.allToolStripMenuItem});
            this.pangaliLogToolStripMenuItem1.Name = "pangaliLogToolStripMenuItem1";
            this.pangaliLogToolStripMenuItem1.Size = new System.Drawing.Size(225, 34);
            this.pangaliLogToolStripMenuItem1.Text = "Pangali Details";
            // 
            // spiceficDetailsToolStripMenuItem
            // 
            this.spiceficDetailsToolStripMenuItem.Name = "spiceficDetailsToolStripMenuItem";
            this.spiceficDetailsToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.spiceficDetailsToolStripMenuItem.Text = "Spicefic Details";
            this.spiceficDetailsToolStripMenuItem.Click += new System.EventHandler(this.spiceficDetailsToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.allToolStripMenuItem.Text = "All Pangali";
            // 
            // editPangaliToolStripMenuItem
            // 
            this.editPangaliToolStripMenuItem.Name = "editPangaliToolStripMenuItem";
            this.editPangaliToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.editPangaliToolStripMenuItem.Text = "Edit pangali";
            // 
            // gajanaToolStripMenuItem
            // 
            this.gajanaToolStripMenuItem.Name = "gajanaToolStripMenuItem";
            this.gajanaToolStripMenuItem.Size = new System.Drawing.Size(88, 34);
            this.gajanaToolStripMenuItem.Text = "Gajana";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEventToolStripMenuItem,
            this.editEventToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(83, 34);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // createEventToolStripMenuItem
            // 
            this.createEventToolStripMenuItem.Name = "createEventToolStripMenuItem";
            this.createEventToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.createEventToolStripMenuItem.Text = "Create Event";
            // 
            // editEventToolStripMenuItem
            // 
            this.editEventToolStripMenuItem.Name = "editEventToolStripMenuItem";
            this.editEventToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.editEventToolStripMenuItem.Text = "Edit Event";
            // 
            // expancesToolStripMenuItem
            // 
            this.expancesToolStripMenuItem.Name = "expancesToolStripMenuItem";
            this.expancesToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.expancesToolStripMenuItem.Text = "TempleExpances";
            // 
            // templeAsertsToolStripMenuItem
            // 
            this.templeAsertsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDAssertsToolStripMenuItem,
            this.deletAssertsToolStripMenuItem,
            this.editAssertsToolStripMenuItem});
            this.templeAsertsToolStripMenuItem.Name = "templeAsertsToolStripMenuItem";
            this.templeAsertsToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.templeAsertsToolStripMenuItem.Text = "Temple Aserts";
            // 
            // aDDAssertsToolStripMenuItem
            // 
            this.aDDAssertsToolStripMenuItem.Name = "aDDAssertsToolStripMenuItem";
            this.aDDAssertsToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.aDDAssertsToolStripMenuItem.Text = "Add asserts";
            // 
            // deletAssertsToolStripMenuItem
            // 
            this.deletAssertsToolStripMenuItem.Name = "deletAssertsToolStripMenuItem";
            this.deletAssertsToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.deletAssertsToolStripMenuItem.Text = "Delete asserts";
            // 
            // editAssertsToolStripMenuItem
            // 
            this.editAssertsToolStripMenuItem.Name = "editAssertsToolStripMenuItem";
            this.editAssertsToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.editAssertsToolStripMenuItem.Text = "Edit asserts";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1198, 566);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pangalilogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPangaliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePangaliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pangaliLogToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gajanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spiceficDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPangaliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createADMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templeAsertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDAssertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletAssertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAssertsToolStripMenuItem;
    }
}