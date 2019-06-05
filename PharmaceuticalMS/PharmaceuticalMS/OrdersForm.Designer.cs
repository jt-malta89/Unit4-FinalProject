namespace PharmaceuticalMS
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private void InitializeComponent()
        {
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblProductBarcode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusVehicles = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.lblLoginAccount = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dataGridOrderProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboPharmacies = new System.Windows.Forms.ComboBox();
            this.comboProducts = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrders
            // 
            this.lblOrders.BackColor = System.Drawing.Color.BurlyWood;
            this.lblOrders.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOrders.Location = new System.Drawing.Point(0, 0);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(1035, 60);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "Orders";
            this.lblOrders.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.Location = new System.Drawing.Point(501, 63);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(197, 19);
            this.lblVehicle.TabIndex = 8;
            this.lblVehicle.Text = "Products Assigned to Order";
            // 
            // lblProductBarcode
            // 
            this.lblProductBarcode.AutoSize = true;
            this.lblProductBarcode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductBarcode.Location = new System.Drawing.Point(771, 388);
            this.lblProductBarcode.Name = "lblProductBarcode";
            this.lblProductBarcode.Size = new System.Drawing.Size(65, 19);
            this.lblProductBarcode.TabIndex = 9;
            this.lblProductBarcode.Text = "Barcode";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(556, 389);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(73, 19);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Order No";
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCard.Location = new System.Drawing.Point(2, 109);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(73, 19);
            this.lblIDCard.TabIndex = 13;
            this.lblIDCard.Text = "Order No";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCard.Location = new System.Drawing.Point(86, 105);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(130, 23);
            this.txtIDCard.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(527, 408);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(70, 30);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusVehicles});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusVehicles
            // 
            this.StripStatusVehicles.Name = "StripStatusVehicles";
            this.StripStatusVehicles.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(826, 456);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(750, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(222, 82);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.Size = new System.Drawing.Size(263, 123);
            this.dgvStaff.TabIndex = 19;
            // 
            // lblLoginAccount
            // 
            this.lblLoginAccount.AutoSize = true;
            this.lblLoginAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAccount.Location = new System.Drawing.Point(12, 344);
            this.lblLoginAccount.Name = "lblLoginAccount";
            this.lblLoginAccount.Size = new System.Drawing.Size(70, 19);
            this.lblLoginAccount.TabIndex = 21;
            this.lblLoginAccount.Text = "Products";
            // 
            // lblEdit
            // 
            this.lblEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblEdit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(902, 456);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(70, 30);
            this.lblEdit.TabIndex = 11;
            this.lblEdit.Text = "Edit";
            this.lblEdit.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(264, 211);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 23);
            this.txtSearch.TabIndex = 12;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(138, 215);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(120, 19);
            this.lblSearch.TabIndex = 22;
            this.lblSearch.Text = "Search by Order";
            // 
            // dataGridOrderProducts
            // 
            this.dataGridOrderProducts.AllowUserToAddRows = false;
            this.dataGridOrderProducts.AllowUserToDeleteRows = false;
            this.dataGridOrderProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderProducts.Location = new System.Drawing.Point(505, 85);
            this.dataGridOrderProducts.Name = "dataGridOrderProducts";
            this.dataGridOrderProducts.ReadOnly = true;
            this.dataGridOrderProducts.Size = new System.Drawing.Size(467, 267);
            this.dataGridOrderProducts.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Create Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pharmacies";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(415, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(339, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 30);
            this.button2.TabIndex = 29;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(263, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 30);
            this.button3.TabIndex = 28;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(635, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 23);
            this.textBox1.TabIndex = 32;
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductBarcode.Location = new System.Drawing.Point(842, 384);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.ReadOnly = true;
            this.txtProductBarcode.Size = new System.Drawing.Size(130, 23);
            this.txtProductBarcode.TabIndex = 33;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDescription.Location = new System.Drawing.Point(635, 414);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.ReadOnly = true;
            this.txtProductDescription.Size = new System.Drawing.Size(130, 23);
            this.txtProductDescription.TabIndex = 34;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQuantity.Location = new System.Drawing.Point(842, 413);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(130, 23);
            this.txtProductQuantity.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Assign Products";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(531, 418);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(98, 19);
            this.lblProductDescription.TabIndex = 37;
            this.lblProductDescription.Text = "Product Title";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.Location = new System.Drawing.Point(767, 417);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(69, 19);
            this.lblProductQuantity.TabIndex = 38;
            this.lblProductQuantity.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(628, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Search by Order";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(751, 355);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(221, 23);
            this.textBox5.TabIndex = 39;
            // 
            // comboPharmacies
            // 
            this.comboPharmacies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPharmacies.FormattingEnabled = true;
            this.comboPharmacies.Location = new System.Drawing.Point(10, 305);
            this.comboPharmacies.Name = "comboPharmacies";
            this.comboPharmacies.Size = new System.Drawing.Size(240, 23);
            this.comboPharmacies.TabIndex = 41;
            this.comboPharmacies.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboProducts
            // 
            this.comboProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProducts.FormattingEnabled = true;
            this.comboProducts.Location = new System.Drawing.Point(10, 366);
            this.comboProducts.Name = "comboProducts";
            this.comboProducts.Size = new System.Drawing.Size(248, 23);
            this.comboProducts.TabIndex = 42;
            this.comboProducts.SelectedIndexChanged += new System.EventHandler(this.comboProducts_SelectedIndexChanged);
            // 
            // OrdersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.comboProducts);
            this.Controls.Add(this.comboPharmacies);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductBarcode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridOrderProducts);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblLoginAccount);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblProductBarcode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblIDCard);
            this.Controls.Add(this.txtIDCard);
            this.Controls.Add(this.lblOrders);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblProductBarcode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusVehicles;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label lblLoginAccount;
        private System.Windows.Forms.Button lblEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dataGridOrderProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtProductBarcode;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboPharmacies;
        private System.Windows.Forms.ComboBox comboProducts;
    }
}