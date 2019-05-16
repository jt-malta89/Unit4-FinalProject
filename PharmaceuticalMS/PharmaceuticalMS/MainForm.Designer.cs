namespace PharmaceuticalMS
{
    partial class MainForm
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
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStores = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrders,
            this.tsmiSales,
            this.tsmiStores,
            this.tsmiClient,
            this.tsmiStaff,
            this.tsmiOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiclesToolStripMenuItem,
            this.tsmiClose});
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(61, 20);
            this.tsmiOptions.Text = "Options";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(180, 22);
            this.tsmiClose.Text = "Close";
            // 
            // tsmiClient
            // 
            this.tsmiClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddClient});
            this.tsmiClient.Name = "tsmiClient";
            this.tsmiClient.Size = new System.Drawing.Size(50, 20);
            this.tsmiClient.Text = "Client";
            // 
            // tsmiAddClient
            // 
            this.tsmiAddClient.Name = "tsmiAddClient";
            this.tsmiAddClient.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddClient.Text = "Add Client";
            this.tsmiAddClient.Click += new System.EventHandler(this.tsmiAddClient_Click);
            // 
            // tsmiStaff
            // 
            this.tsmiStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStaff});
            this.tsmiStaff.Name = "tsmiStaff";
            this.tsmiStaff.Size = new System.Drawing.Size(43, 20);
            this.tsmiStaff.Text = "Staff";
            // 
            // tsmiAddStaff
            // 
            this.tsmiAddStaff.Name = "tsmiAddStaff";
            this.tsmiAddStaff.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddStaff.Text = "Add Staff";
            this.tsmiAddStaff.Click += new System.EventHandler(this.tsmiAddStaff_Click);
            // 
            // tsmiOrders
            // 
            this.tsmiOrders.Name = "tsmiOrders";
            this.tsmiOrders.Size = new System.Drawing.Size(54, 20);
            this.tsmiOrders.Text = "Orders";
            // 
            // tsmiSales
            // 
            this.tsmiSales.Name = "tsmiSales";
            this.tsmiSales.Size = new System.Drawing.Size(45, 20);
            this.tsmiSales.Text = "Sales";
            // 
            // tsmiStores
            // 
            this.tsmiStores.Name = "tsmiStores";
            this.tsmiStores.Size = new System.Drawing.Size(51, 20);
            this.tsmiStores.Text = "Stores";
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVehiclesToolStripMenuItem,
            this.editVehiclesToolStripMenuItem,
            this.searchVehiclesToolStripMenuItem,
            this.deleteVehiclesToolStripMenuItem});
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vehiclesToolStripMenuItem.Text = "Vehicles ";
            // 
            // newVehiclesToolStripMenuItem
            // 
            this.newVehiclesToolStripMenuItem.Name = "newVehiclesToolStripMenuItem";
            this.newVehiclesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newVehiclesToolStripMenuItem.Text = "New Vehicles";
            // 
            // editVehiclesToolStripMenuItem
            // 
            this.editVehiclesToolStripMenuItem.Name = "editVehiclesToolStripMenuItem";
            this.editVehiclesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editVehiclesToolStripMenuItem.Text = "Edit Vehicles";
            // 
            // searchVehiclesToolStripMenuItem
            // 
            this.searchVehiclesToolStripMenuItem.Name = "searchVehiclesToolStripMenuItem";
            this.searchVehiclesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchVehiclesToolStripMenuItem.Text = "Search Vehicles";
            // 
            // deleteVehiclesToolStripMenuItem
            // 
            this.deleteVehiclesToolStripMenuItem.Name = "deleteVehiclesToolStripMenuItem";
            this.deleteVehiclesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteVehiclesToolStripMenuItem.Text = "Delete Vehicles";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PharmaceuticalMS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrders;
        private System.Windows.Forms.ToolStripMenuItem tsmiSales;
        private System.Windows.Forms.ToolStripMenuItem tsmiStores;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddClient;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVehiclesToolStripMenuItem;
    }
}