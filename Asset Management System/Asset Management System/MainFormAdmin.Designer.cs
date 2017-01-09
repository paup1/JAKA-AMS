namespace Asset_Management_System
{
    partial class MainFormAdmin
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
            this.btnBarcodeWin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.assetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllAssetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAssetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAssetTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateDepriciationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcodeGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairLogdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depreciationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucViewAssets1 = new Asset_Management_System.UCViewAssets();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBarcodeWin
            // 
            this.btnBarcodeWin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBarcodeWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarcodeWin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBarcodeWin.Location = new System.Drawing.Point(719, 0);
            this.btnBarcodeWin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBarcodeWin.Name = "btnBarcodeWin";
            this.btnBarcodeWin.Size = new System.Drawing.Size(79, 28);
            this.btnBarcodeWin.TabIndex = 1;
            this.btnBarcodeWin.Text = "Barcode";
            this.btnBarcodeWin.UseVisualStyleBackColor = false;
            this.btnBarcodeWin.Click += new System.EventHandler(this.btnBarcodeWin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(804, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 28);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetsToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.userLogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(890, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // assetsToolStripMenuItem
            // 
            this.assetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllAssetsToolStripMenuItem,
            this.viewByToolStripMenuItem,
            this.newAssetToolStripMenuItem,
            this.newAssetTypeToolStripMenuItem,
            this.calculateDepriciationToolStripMenuItem,
            this.barcodeGeneratorToolStripMenuItem,
            this.assetTrackerToolStripMenuItem});
            this.assetsToolStripMenuItem.Name = "assetsToolStripMenuItem";
            this.assetsToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.assetsToolStripMenuItem.Text = "Assets";
            // 
            // viewAllAssetsToolStripMenuItem
            // 
            this.viewAllAssetsToolStripMenuItem.Name = "viewAllAssetsToolStripMenuItem";
            this.viewAllAssetsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.viewAllAssetsToolStripMenuItem.Text = "View all";
            // 
            // viewByToolStripMenuItem
            // 
            this.viewByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.typeToolStripMenuItem});
            this.viewByToolStripMenuItem.Name = "viewByToolStripMenuItem";
            this.viewByToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.viewByToolStripMenuItem.Text = "View by";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // newAssetToolStripMenuItem
            // 
            this.newAssetToolStripMenuItem.Name = "newAssetToolStripMenuItem";
            this.newAssetToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.newAssetToolStripMenuItem.Text = "New Asset";
            this.newAssetToolStripMenuItem.Click += new System.EventHandler(this.newAssetToolStripMenuItem_Click);
            // 
            // newAssetTypeToolStripMenuItem
            // 
            this.newAssetTypeToolStripMenuItem.Name = "newAssetTypeToolStripMenuItem";
            this.newAssetTypeToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.newAssetTypeToolStripMenuItem.Text = "New Asset Type";
            // 
            // calculateDepriciationToolStripMenuItem
            // 
            this.calculateDepriciationToolStripMenuItem.Name = "calculateDepriciationToolStripMenuItem";
            this.calculateDepriciationToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.calculateDepriciationToolStripMenuItem.Text = "Calculate Depreciation";
            // 
            // barcodeGeneratorToolStripMenuItem
            // 
            this.barcodeGeneratorToolStripMenuItem.Name = "barcodeGeneratorToolStripMenuItem";
            this.barcodeGeneratorToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.barcodeGeneratorToolStripMenuItem.Text = "Barcode Generator";
            this.barcodeGeneratorToolStripMenuItem.Click += new System.EventHandler(this.barcodeGeneratorToolStripMenuItem_Click);
            // 
            // assetTrackerToolStripMenuItem
            // 
            this.assetTrackerToolStripMenuItem.Name = "assetTrackerToolStripMenuItem";
            this.assetTrackerToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.assetTrackerToolStripMenuItem.Text = "Asset Tracker";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem,
            this.repairLogdToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.checkInToolStripMenuItem.Text = "Check In";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            // 
            // repairLogdToolStripMenuItem
            // 
            this.repairLogdToolStripMenuItem.Name = "repairLogdToolStripMenuItem";
            this.repairLogdToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.repairLogdToolStripMenuItem.Text = "Repair logs";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customReportsToolStripMenuItem,
            this.standardReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // customReportsToolStripMenuItem
            // 
            this.customReportsToolStripMenuItem.Name = "customReportsToolStripMenuItem";
            this.customReportsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.customReportsToolStripMenuItem.Text = "Custom Reports";
            // 
            // standardReportsToolStripMenuItem
            // 
            this.standardReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assetToolStripMenuItem,
            this.depreciationToolStripMenuItem,
            this.checkOutToolStripMenuItem1});
            this.standardReportsToolStripMenuItem.Name = "standardReportsToolStripMenuItem";
            this.standardReportsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.standardReportsToolStripMenuItem.Text = "Standard Reports";
            // 
            // assetToolStripMenuItem
            // 
            this.assetToolStripMenuItem.Name = "assetToolStripMenuItem";
            this.assetToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.assetToolStripMenuItem.Text = "Asset";
            // 
            // depreciationToolStripMenuItem
            // 
            this.depreciationToolStripMenuItem.Name = "depreciationToolStripMenuItem";
            this.depreciationToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.depreciationToolStripMenuItem.Text = "Depreciation";
            // 
            // checkOutToolStripMenuItem1
            // 
            this.checkOutToolStripMenuItem1.Name = "checkOutToolStripMenuItem1";
            this.checkOutToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.checkOutToolStripMenuItem1.Text = "Check out";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllToolStripMenuItem,
            this.newUserToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.viewAllToolStripMenuItem.Text = "View all";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.newUserToolStripMenuItem.Text = "New User";
            // 
            // userLogToolStripMenuItem
            // 
            this.userLogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.userLogToolStripMenuItem.Name = "userLogToolStripMenuItem";
            this.userLogToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.userLogToolStripMenuItem.Text = "User log";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // ucViewAssets1
            // 
            this.ucViewAssets1.Location = new System.Drawing.Point(155, 199);
            this.ucViewAssets1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucViewAssets1.Name = "ucViewAssets1";
            this.ucViewAssets1.Size = new System.Drawing.Size(463, 182);
            this.ucViewAssets1.TabIndex = 0;
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(890, 496);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBarcodeWin);
            this.Controls.Add(this.ucViewAssets1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormAdmin_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCViewAssets ucViewAssets1;
        private System.Windows.Forms.Button btnBarcodeWin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem assetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllAssetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAssetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAssetTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateDepriciationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcodeGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetTrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairLogdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depreciationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem1;
    }
}