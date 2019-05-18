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
            this.tsmiFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateStores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyStores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVehicles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateVehicles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyVehicles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStreet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateStreet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyStreet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocality = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateLocality = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyLocality = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPostCode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreatePostCode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyPostCode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJobTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateJobTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyJobTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pharmaciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItems = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchStaffTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreatePharmacie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyPharmacie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrders,
            this.tsmiSales,
            this.tsmiItems,
            this.tsmiClients,
            this.tsmiStaff,
            this.tsmiFeatures});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFeatures
            // 
            this.tsmiFeatures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pharmaciesToolStripMenuItem,
            this.tsmiStores,
            this.tsmiVehicles,
            this.tsmiStreet,
            this.tsmiLocality,
            this.tsmiPostCode,
            this.tsmiJobTitle,
            this.tsmiLogin,
            this.tsmiLogout,
            this.tsmiClose});
            this.tsmiFeatures.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiFeatures.Name = "tsmiFeatures";
            this.tsmiFeatures.Size = new System.Drawing.Size(74, 22);
            this.tsmiFeatures.Text = "Features";
            // 
            // tsmiStores
            // 
            this.tsmiStores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateStores,
            this.tsmiModifyStores});
            this.tsmiStores.Name = "tsmiStores";
            this.tsmiStores.Size = new System.Drawing.Size(180, 22);
            this.tsmiStores.Text = "Stores";
            // 
            // tsmiCreateStores
            // 
            this.tsmiCreateStores.Name = "tsmiCreateStores";
            this.tsmiCreateStores.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreateStores.Text = "Create Store";
            this.tsmiCreateStores.Click += new System.EventHandler(this.createStoresToolStripMenuItem_Click);
            // 
            // tsmiModifyStores
            // 
            this.tsmiModifyStores.Name = "tsmiModifyStores";
            this.tsmiModifyStores.Size = new System.Drawing.Size(180, 22);
            this.tsmiModifyStores.Text = "Modify Store";
            // 
            // tsmiVehicles
            // 
            this.tsmiVehicles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateVehicles,
            this.tsmiModifyVehicles});
            this.tsmiVehicles.Name = "tsmiVehicles";
            this.tsmiVehicles.Size = new System.Drawing.Size(180, 22);
            this.tsmiVehicles.Text = "Vehicles";
            // 
            // tsmiCreateVehicles
            // 
            this.tsmiCreateVehicles.Name = "tsmiCreateVehicles";
            this.tsmiCreateVehicles.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreateVehicles.Text = "Create Vehicle";
            // 
            // tsmiModifyVehicles
            // 
            this.tsmiModifyVehicles.Name = "tsmiModifyVehicles";
            this.tsmiModifyVehicles.Size = new System.Drawing.Size(180, 22);
            this.tsmiModifyVehicles.Text = "Modify Vehicle";
            // 
            // tsmiStreet
            // 
            this.tsmiStreet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateStreet,
            this.tsmiModifyStreet});
            this.tsmiStreet.Name = "tsmiStreet";
            this.tsmiStreet.Size = new System.Drawing.Size(180, 22);
            this.tsmiStreet.Text = "Street";
            // 
            // tsmiCreateStreet
            // 
            this.tsmiCreateStreet.Name = "tsmiCreateStreet";
            this.tsmiCreateStreet.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreateStreet.Text = "Create Street";
            // 
            // tsmiModifyStreet
            // 
            this.tsmiModifyStreet.Name = "tsmiModifyStreet";
            this.tsmiModifyStreet.Size = new System.Drawing.Size(180, 22);
            this.tsmiModifyStreet.Text = "Modify Street";
            // 
            // tsmiLocality
            // 
            this.tsmiLocality.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateLocality,
            this.tsmiModifyLocality});
            this.tsmiLocality.Name = "tsmiLocality";
            this.tsmiLocality.Size = new System.Drawing.Size(180, 22);
            this.tsmiLocality.Text = "Locality";
            // 
            // tsmiCreateLocality
            // 
            this.tsmiCreateLocality.Name = "tsmiCreateLocality";
            this.tsmiCreateLocality.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreateLocality.Text = "Create Locality";
            // 
            // tsmiModifyLocality
            // 
            this.tsmiModifyLocality.Name = "tsmiModifyLocality";
            this.tsmiModifyLocality.Size = new System.Drawing.Size(180, 22);
            this.tsmiModifyLocality.Text = "Modify Locality";
            // 
            // tsmiPostCode
            // 
            this.tsmiPostCode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreatePostCode,
            this.tsmiModifyPostCode});
            this.tsmiPostCode.Name = "tsmiPostCode";
            this.tsmiPostCode.Size = new System.Drawing.Size(180, 22);
            this.tsmiPostCode.Text = "Post Code";
            // 
            // tsmiCreatePostCode
            // 
            this.tsmiCreatePostCode.Name = "tsmiCreatePostCode";
            this.tsmiCreatePostCode.Size = new System.Drawing.Size(186, 22);
            this.tsmiCreatePostCode.Text = "Create Post Code";
            // 
            // tsmiModifyPostCode
            // 
            this.tsmiModifyPostCode.Name = "tsmiModifyPostCode";
            this.tsmiModifyPostCode.Size = new System.Drawing.Size(186, 22);
            this.tsmiModifyPostCode.Text = "Modify Post Code";
            // 
            // tsmiJobTitle
            // 
            this.tsmiJobTitle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateJobTitle,
            this.tsmiModifyJobTitle});
            this.tsmiJobTitle.Name = "tsmiJobTitle";
            this.tsmiJobTitle.Size = new System.Drawing.Size(180, 22);
            this.tsmiJobTitle.Text = "Job Title";
            // 
            // tsmiCreateJobTitle
            // 
            this.tsmiCreateJobTitle.Name = "tsmiCreateJobTitle";
            this.tsmiCreateJobTitle.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreateJobTitle.Text = "Create Job Title";
            // 
            // tsmiModifyJobTitle
            // 
            this.tsmiModifyJobTitle.Name = "tsmiModifyJobTitle";
            this.tsmiModifyJobTitle.Size = new System.Drawing.Size(180, 22);
            this.tsmiModifyJobTitle.Text = "Modify Job Title";
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateLogin,
            this.tsmiModifyLogin});
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(180, 22);
            this.tsmiLogin.Text = "Login";
            // 
            // tsmiCreateLogin
            // 
            this.tsmiCreateLogin.Name = "tsmiCreateLogin";
            this.tsmiCreateLogin.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreateLogin.Text = "Create Login";
            // 
            // tsmiModifyLogin
            // 
            this.tsmiModifyLogin.Name = "tsmiModifyLogin";
            this.tsmiModifyLogin.Size = new System.Drawing.Size(180, 22);
            this.tsmiModifyLogin.Text = "Modify Login";
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(180, 22);
            this.tsmiLogout.Text = "Logout";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(180, 22);
            this.tsmiClose.Text = "Close";
            // 
            // pharmaciesToolStripMenuItem
            // 
            this.pharmaciesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreatePharmacie,
            this.tsmiModifyPharmacie});
            this.pharmaciesToolStripMenuItem.Name = "pharmaciesToolStripMenuItem";
            this.pharmaciesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pharmaciesToolStripMenuItem.Text = "Pharmacies";
            // 
            // tsmiOrders
            // 
            this.tsmiOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateOrder,
            this.tsmiModifyOrder,
            this.tsmiSearchOrder,
            this.tsmiDeleteOrder});
            this.tsmiOrders.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsmiOrders.Name = "tsmiOrders";
            this.tsmiOrders.Size = new System.Drawing.Size(62, 22);
            this.tsmiOrders.Text = "Orders";
            // 
            // tsmiCreateOrder
            // 
            this.tsmiCreateOrder.Name = "tsmiCreateOrder";
            this.tsmiCreateOrder.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreateOrder.Text = "Create Order";
            // 
            // tsmiModifyOrder
            // 
            this.tsmiModifyOrder.Name = "tsmiModifyOrder";
            this.tsmiModifyOrder.Size = new System.Drawing.Size(180, 22);
            this.tsmiModifyOrder.Text = "Modify Order";
            // 
            // tsmiSearchOrder
            // 
            this.tsmiSearchOrder.Name = "tsmiSearchOrder";
            this.tsmiSearchOrder.Size = new System.Drawing.Size(180, 22);
            this.tsmiSearchOrder.Text = "Search Order";
            // 
            // tsmiDeleteOrder
            // 
            this.tsmiDeleteOrder.Name = "tsmiDeleteOrder";
            this.tsmiDeleteOrder.Size = new System.Drawing.Size(180, 22);
            this.tsmiDeleteOrder.Text = "Delete Order";
            // 
            // tsmiSales
            // 
            this.tsmiSales.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsmiSales.Name = "tsmiSales";
            this.tsmiSales.Size = new System.Drawing.Size(52, 22);
            this.tsmiSales.Text = "Sales";
            // 
            // tsmiItems
            // 
            this.tsmiItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateItem,
            this.tsmiModifyItem,
            this.tsmiSearchItem,
            this.tsmiDeleteItem});
            this.tsmiItems.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsmiItems.Name = "tsmiItems";
            this.tsmiItems.Size = new System.Drawing.Size(55, 22);
            this.tsmiItems.Text = "Items";
            // 
            // tsmiClients
            // 
            this.tsmiClients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateClient,
            this.tsmiModifyClient,
            this.tsmiSearchClient,
            this.tsmiDeleteClient});
            this.tsmiClients.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsmiClients.Name = "tsmiClients";
            this.tsmiClients.Size = new System.Drawing.Size(63, 22);
            this.tsmiClients.Text = "Clients";
            // 
            // tsmiCreateClient
            // 
            this.tsmiCreateClient.Name = "tsmiCreateClient";
            this.tsmiCreateClient.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreateClient.Text = "Create Client";
            this.tsmiCreateClient.Click += new System.EventHandler(this.tsmiAddClient_Click);
            // 
            // tsmiStaff
            // 
            this.tsmiStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateStaff,
            this.tsmiModifyStaff,
            this.tsmiSearchStaffTool,
            this.tsmiDeleteStaff});
            this.tsmiStaff.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsmiStaff.Name = "tsmiStaff";
            this.tsmiStaff.Size = new System.Drawing.Size(48, 22);
            this.tsmiStaff.Text = "Staff";
            // 
            // tsmiCreateStaff
            // 
            this.tsmiCreateStaff.Name = "tsmiCreateStaff";
            this.tsmiCreateStaff.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreateStaff.Text = "Create Staff";
            this.tsmiCreateStaff.Click += new System.EventHandler(this.tsmiAddStaff_Click);
            // 
            // tsmiModifyStaff
            // 
            this.tsmiModifyStaff.Name = "tsmiModifyStaff";
            this.tsmiModifyStaff.Size = new System.Drawing.Size(180, 22);
            this.tsmiModifyStaff.Text = "Modify Staff";
            // 
            // tsmiSearchStaffTool
            // 
            this.tsmiSearchStaffTool.Name = "tsmiSearchStaffTool";
            this.tsmiSearchStaffTool.Size = new System.Drawing.Size(180, 22);
            this.tsmiSearchStaffTool.Text = "Search Staff";
            // 
            // tsmiDeleteStaff
            // 
            this.tsmiDeleteStaff.Name = "tsmiDeleteStaff";
            this.tsmiDeleteStaff.Size = new System.Drawing.Size(180, 22);
            this.tsmiDeleteStaff.Text = "Delete Staff";
            // 
            // tsmiCreatePharmacie
            // 
            this.tsmiCreatePharmacie.Name = "tsmiCreatePharmacie";
            this.tsmiCreatePharmacie.Size = new System.Drawing.Size(189, 22);
            this.tsmiCreatePharmacie.Text = "Create Pharmacie";
            // 
            // tsmiModifyPharmacie
            // 
            this.tsmiModifyPharmacie.Name = "tsmiModifyPharmacie";
            this.tsmiModifyPharmacie.Size = new System.Drawing.Size(189, 22);
            this.tsmiModifyPharmacie.Text = "Modify Pharmacie";
            // 
            // tsmiModifyClient
            // 
            this.tsmiModifyClient.Name = "tsmiModifyClient";
            this.tsmiModifyClient.Size = new System.Drawing.Size(180, 22);
            this.tsmiModifyClient.Text = "Modify Client";
            // 
            // tsmiSearchClient
            // 
            this.tsmiSearchClient.Name = "tsmiSearchClient";
            this.tsmiSearchClient.Size = new System.Drawing.Size(180, 22);
            this.tsmiSearchClient.Text = "Search Client";
            // 
            // tsmiDeleteClient
            // 
            this.tsmiDeleteClient.Name = "tsmiDeleteClient";
            this.tsmiDeleteClient.Size = new System.Drawing.Size(180, 22);
            this.tsmiDeleteClient.Text = "Delete Client";
            // 
            // tsmiCreateItem
            // 
            this.tsmiCreateItem.Name = "tsmiCreateItem";
            this.tsmiCreateItem.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreateItem.Text = "Create Item";
            // 
            // tsmiModifyItem
            // 
            this.tsmiModifyItem.Name = "tsmiModifyItem";
            this.tsmiModifyItem.Size = new System.Drawing.Size(180, 22);
            this.tsmiModifyItem.Text = "Modify Item";
            // 
            // tsmiSearchItem
            // 
            this.tsmiSearchItem.Name = "tsmiSearchItem";
            this.tsmiSearchItem.Size = new System.Drawing.Size(180, 22);
            this.tsmiSearchItem.Text = "Search Item";
            // 
            // tsmiDeleteItem
            // 
            this.tsmiDeleteItem.Name = "tsmiDeleteItem";
            this.tsmiDeleteItem.Size = new System.Drawing.Size(180, 22);
            this.tsmiDeleteItem.Text = "Delete Item";
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
        private System.Windows.Forms.ToolStripMenuItem tsmiClients;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiFeatures;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiStreet;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocality;
        private System.Windows.Forms.ToolStripMenuItem tsmiPostCode;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrders;
        private System.Windows.Forms.ToolStripMenuItem tsmiSales;
        private System.Windows.Forms.ToolStripMenuItem tsmiItems;
        private System.Windows.Forms.ToolStripMenuItem tsmiJobTitle;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiStores;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateStores;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyStores;
        private System.Windows.Forms.ToolStripMenuItem tsmiVehicles;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateVehicles;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyVehicles;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateStreet;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyStreet;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateLocality;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyLocality;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatePostCode;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyPostCode;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateJobTitle;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyJobTitle;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyLogin;
        private System.Windows.Forms.ToolStripMenuItem pharmaciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchStaffTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatePharmacie;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyPharmacie;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteClient;
    }
}