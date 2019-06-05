namespace PharmaceuticalMS
{
    partial class ProductsForm
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
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblCategor = new System.Windows.Forms.Label();
            this.lblQuantityNotification = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusVehicles = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblStor = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtQuantityNotification = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.dgvStore = new System.Windows.Forms.DataGridView();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducts
            // 
            this.lblProducts.BackColor = System.Drawing.Color.BurlyWood;
            this.lblProducts.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblProducts.Location = new System.Drawing.Point(0, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(1035, 60);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products";
            this.lblProducts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCategor
            // 
            this.lblCategor.AutoSize = true;
            this.lblCategor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategor.Location = new System.Drawing.Point(10, 346);
            this.lblCategor.Name = "lblCategor";
            this.lblCategor.Size = new System.Drawing.Size(70, 19);
            this.lblCategor.TabIndex = 8;
            this.lblCategor.Text = "Category";
            // 
            // lblQuantityNotification
            // 
            this.lblQuantityNotification.AutoSize = true;
            this.lblQuantityNotification.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityNotification.Location = new System.Drawing.Point(8, 317);
            this.lblQuantityNotification.Name = "lblQuantityNotification";
            this.lblQuantityNotification.Size = new System.Drawing.Size(153, 19);
            this.lblQuantityNotification.TabIndex = 9;
            this.lblQuantityNotification.Text = "Quantity Notification";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(10, 284);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 19);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(10, 255);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 19);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(10, 169);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 19);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.Location = new System.Drawing.Point(10, 111);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(65, 19);
            this.lblBarcode.TabIndex = 13;
            this.lblBarcode.Text = "Barcode";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 140);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 19);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Title";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(167, 255);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 23);
            this.txtPrice.TabIndex = 2;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(168, 111);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(130, 23);
            this.txtBarcode.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(167, 140);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(130, 23);
            this.txtTitle.TabIndex = 1;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(974, 22);
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
            this.btnDelete.Location = new System.Drawing.Point(817, 536);
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
            this.btnAdd.Location = new System.Drawing.Point(741, 536);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(307, 92);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(659, 225);
            this.dgvProducts.TabIndex = 19;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(167, 284);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(130, 23);
            this.txtQuantity.TabIndex = 3;
            // 
            // lblStor
            // 
            this.lblStor.AutoSize = true;
            this.lblStor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStor.Location = new System.Drawing.Point(10, 375);
            this.lblStor.Name = "lblStor";
            this.lblStor.Size = new System.Drawing.Size(46, 19);
            this.lblStor.TabIndex = 21;
            this.lblStor.Text = "Store";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(167, 169);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(130, 80);
            this.txtDescription.TabIndex = 4;
            // 
            // lblEdit
            // 
            this.lblEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblEdit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(893, 536);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(70, 30);
            this.lblEdit.TabIndex = 11;
            this.lblEdit.Text = "Edit";
            this.lblEdit.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(744, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 23);
            this.txtSearch.TabIndex = 12;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(602, 67);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(136, 19);
            this.lblSearch.TabIndex = 22;
            this.lblSearch.Text = "Search by Barcode";
            // 
            // txtQuantityNotification
            // 
            this.txtQuantityNotification.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityNotification.Location = new System.Drawing.Point(167, 313);
            this.txtQuantityNotification.Name = "txtQuantityNotification";
            this.txtQuantityNotification.Size = new System.Drawing.Size(130, 23);
            this.txtQuantityNotification.TabIndex = 23;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(167, 342);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(130, 23);
            this.txtCategory.TabIndex = 24;
            // 
            // txtStore
            // 
            this.txtStore.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStore.Location = new System.Drawing.Point(167, 371);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(130, 23);
            this.txtStore.TabIndex = 25;
            // 
            // dgvStore
            // 
            this.dgvStore.AllowUserToAddRows = false;
            this.dgvStore.AllowUserToDeleteRows = false;
            this.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStore.Location = new System.Drawing.Point(529, 361);
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.ReadOnly = true;
            this.dgvStore.Size = new System.Drawing.Size(220, 155);
            this.dgvStore.TabIndex = 26;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(303, 361);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.Size = new System.Drawing.Size(220, 155);
            this.dgvCategory.TabIndex = 27;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(303, 339);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(70, 19);
            this.lblCategory.TabIndex = 28;
            this.lblCategory.Text = "Category";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStore.Location = new System.Drawing.Point(525, 339);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(46, 19);
            this.lblStore.TabIndex = 29;
            this.lblStore.Text = "Store";
            // 
            // ProductsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(974, 591);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.dgvStore);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtQuantityNotification);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblStor);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCategor);
            this.Controls.Add(this.lblQuantityNotification);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblProducts);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblCategor;
        private System.Windows.Forms.Label lblQuantityNotification;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusVehicles;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblStor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button lblEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtQuantityNotification;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.DataGridView dgvStore;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStore;
    }
}