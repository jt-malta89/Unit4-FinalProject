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
            this.lblAssignProducts = new System.Windows.Forms.Label();
            this.lblProductBarcode = new System.Windows.Forms.Label();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblLoginAccount = new System.Windows.Forms.Label();
            this.dataGridOrderProducts = new System.Windows.Forms.DataGridView();
            this.lblCreatedOrders = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.comboPharmacies = new System.Windows.Forms.ComboBox();
            this.comboProducts = new System.Windows.Forms.ComboBox();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblCreateOrder = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrders
            // 
            this.lblOrders.BackColor = System.Drawing.Color.BurlyWood;
            this.lblOrders.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOrders.Location = new System.Drawing.Point(0, 0);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(670, 60);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "Orders";
            this.lblOrders.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAssignProducts
            // 
            this.lblAssignProducts.AutoSize = true;
            this.lblAssignProducts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignProducts.Location = new System.Drawing.Point(0, 212);
            this.lblAssignProducts.Name = "lblAssignProducts";
            this.lblAssignProducts.Size = new System.Drawing.Size(201, 19);
            this.lblAssignProducts.TabIndex = 8;
            this.lblAssignProducts.Text = "Assigned Products  to Order";
            // 
            // lblProductBarcode
            // 
            this.lblProductBarcode.AutoSize = true;
            this.lblProductBarcode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductBarcode.Location = new System.Drawing.Point(356, 128);
            this.lblProductBarcode.Name = "lblProductBarcode";
            this.lblProductBarcode.Size = new System.Drawing.Size(65, 19);
            this.lblProductBarcode.TabIndex = 9;
            this.lblProductBarcode.Text = "Barcode";
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCard.Location = new System.Drawing.Point(101, 99);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(73, 19);
            this.lblIDCard.TabIndex = 13;
            this.lblIDCard.Text = "Order No";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(180, 95);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(130, 23);
            this.txtOrderID.TabIndex = 0;
            this.txtOrderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderID_KeyPress);
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
            this.StripStatusDisplay});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusDisplay
            // 
            this.StripStatusDisplay.Name = "StripStatusDisplay";
            this.StripStatusDisplay.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(587, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(587, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(335, 234);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(325, 180);
            this.dgvOrders.TabIndex = 19;
            // 
            // lblLoginAccount
            // 
            this.lblLoginAccount.AutoSize = true;
            this.lblLoginAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAccount.Location = new System.Drawing.Point(104, 157);
            this.lblLoginAccount.Name = "lblLoginAccount";
            this.lblLoginAccount.Size = new System.Drawing.Size(70, 19);
            this.lblLoginAccount.TabIndex = 21;
            this.lblLoginAccount.Text = "Products";
            // 
            // dataGridOrderProducts
            // 
            this.dataGridOrderProducts.AllowUserToAddRows = false;
            this.dataGridOrderProducts.AllowUserToDeleteRows = false;
            this.dataGridOrderProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderProducts.Location = new System.Drawing.Point(4, 234);
            this.dataGridOrderProducts.Name = "dataGridOrderProducts";
            this.dataGridOrderProducts.ReadOnly = true;
            this.dataGridOrderProducts.Size = new System.Drawing.Size(325, 180);
            this.dataGridOrderProducts.TabIndex = 23;
            // 
            // lblCreatedOrders
            // 
            this.lblCreatedOrders.AutoSize = true;
            this.lblCreatedOrders.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedOrders.Location = new System.Drawing.Point(349, 212);
            this.lblCreatedOrders.Name = "lblCreatedOrders";
            this.lblCreatedOrders.Size = new System.Drawing.Size(112, 19);
            this.lblCreatedOrders.TabIndex = 25;
            this.lblCreatedOrders.Text = "Created Orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pharmacies";
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductBarcode.Location = new System.Drawing.Point(427, 124);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.ReadOnly = true;
            this.txtProductBarcode.Size = new System.Drawing.Size(130, 23);
            this.txtProductBarcode.TabIndex = 33;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDescription.Location = new System.Drawing.Point(427, 95);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.ReadOnly = true;
            this.txtProductDescription.Size = new System.Drawing.Size(130, 23);
            this.txtProductDescription.TabIndex = 34;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(323, 99);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(98, 19);
            this.lblProductDescription.TabIndex = 37;
            this.lblProductDescription.Text = "Product Title";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.Location = new System.Drawing.Point(352, 157);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(69, 19);
            this.lblProductQuantity.TabIndex = 38;
            this.lblProductQuantity.Text = "Quantity";
            // 
            // comboPharmacies
            // 
            this.comboPharmacies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPharmacies.FormattingEnabled = true;
            this.comboPharmacies.Location = new System.Drawing.Point(180, 124);
            this.comboPharmacies.Name = "comboPharmacies";
            this.comboPharmacies.Size = new System.Drawing.Size(130, 23);
            this.comboPharmacies.TabIndex = 41;
            // 
            // comboProducts
            // 
            this.comboProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProducts.FormattingEnabled = true;
            this.comboProducts.Location = new System.Drawing.Point(180, 153);
            this.comboProducts.Name = "comboProducts";
            this.comboProducts.Size = new System.Drawing.Size(130, 23);
            this.comboProducts.TabIndex = 42;
            this.comboProducts.SelectedIndexChanged += new System.EventHandler(this.comboProducts_SelectedIndexChanged);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveOrder.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.Location = new System.Drawing.Point(10, 437);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(650, 30);
            this.btnSaveOrder.TabIndex = 43;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(427, 153);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(130, 23);
            this.numericUpDownQuantity.TabIndex = 44;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // lblCreateOrder
            // 
            this.lblCreateOrder.AutoSize = true;
            this.lblCreateOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateOrder.Location = new System.Drawing.Point(12, 77);
            this.lblCreateOrder.Name = "lblCreateOrder";
            this.lblCreateOrder.Size = new System.Drawing.Size(97, 19);
            this.lblCreateOrder.TabIndex = 45;
            this.lblCreateOrder.Text = "Create Order";
            // 
            // OrdersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(669, 491);
            this.Controls.Add(this.lblCreateOrder);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.comboProducts);
            this.Controls.Add(this.comboPharmacies);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductBarcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCreatedOrders);
            this.Controls.Add(this.dataGridOrderProducts);
            this.Controls.Add(this.lblLoginAccount);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAssignProducts);
            this.Controls.Add(this.lblProductBarcode);
            this.Controls.Add(this.lblIDCard);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrders);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblAssignProducts;
        private System.Windows.Forms.Label lblProductBarcode;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblLoginAccount;
        private System.Windows.Forms.DataGridView dataGridOrderProducts;
        private System.Windows.Forms.Label lblCreatedOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductBarcode;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.ComboBox comboPharmacies;
        private System.Windows.Forms.ComboBox comboProducts;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label lblCreateOrder;
    }
}