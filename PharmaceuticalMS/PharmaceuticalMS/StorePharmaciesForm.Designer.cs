namespace PharmaceuticalMS
{
    partial class StorePharmaciesForm
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
            this.lblStoreandPharmacies = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDeletePhar = new System.Windows.Forms.Button();
            this.btnAddPhar = new System.Windows.Forms.Button();
            this.txtPharAddress = new System.Windows.Forms.TextBox();
            this.txtPharName = new System.Windows.Forms.TextBox();
            this.lblPharAddress = new System.Windows.Forms.Label();
            this.lblPharName = new System.Windows.Forms.Label();
            this.dgvPharmacy = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvStore = new System.Windows.Forms.DataGridView();
            this.txtStorAddress = new System.Windows.Forms.TextBox();
            this.txtStorName = new System.Windows.Forms.TextBox();
            this.lblStorAddress = new System.Windows.Forms.Label();
            this.lblStorName = new System.Windows.Forms.Label();
            this.btnDeleteStore = new System.Windows.Forms.Button();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPharmacy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStoreandPharmacies
            // 
            this.lblStoreandPharmacies.BackColor = System.Drawing.Color.BurlyWood;
            this.lblStoreandPharmacies.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreandPharmacies.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStoreandPharmacies.Location = new System.Drawing.Point(0, 0);
            this.lblStoreandPharmacies.Name = "lblStoreandPharmacies";
            this.lblStoreandPharmacies.Size = new System.Drawing.Size(595, 60);
            this.lblStoreandPharmacies.TabIndex = 1;
            this.lblStoreandPharmacies.Text = "Store and Pharmacies";
            this.lblStoreandPharmacies.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusDisplay
            // 
            this.StripStatusDisplay.Name = "StripStatusDisplay";
            this.StripStatusDisplay.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDeletePhar
            // 
            this.btnDeletePhar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeletePhar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePhar.Location = new System.Drawing.Point(488, 398);
            this.btnDeletePhar.Name = "btnDeletePhar";
            this.btnDeletePhar.Size = new System.Drawing.Size(70, 30);
            this.btnDeletePhar.TabIndex = 10;
            this.btnDeletePhar.Text = "Delete";
            this.btnDeletePhar.UseVisualStyleBackColor = false;
            this.btnDeletePhar.Click += new System.EventHandler(this.btnDeletePhar_Click);
            // 
            // btnAddPhar
            // 
            this.btnAddPhar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddPhar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhar.Location = new System.Drawing.Point(412, 398);
            this.btnAddPhar.Name = "btnAddPhar";
            this.btnAddPhar.Size = new System.Drawing.Size(70, 30);
            this.btnAddPhar.TabIndex = 9;
            this.btnAddPhar.Text = "Add";
            this.btnAddPhar.UseVisualStyleBackColor = false;
            this.btnAddPhar.Click += new System.EventHandler(this.btnAddPhar_Click);
            // 
            // txtPharAddress
            // 
            this.txtPharAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPharAddress.Location = new System.Drawing.Point(428, 285);
            this.txtPharAddress.Multiline = true;
            this.txtPharAddress.Name = "txtPharAddress";
            this.txtPharAddress.Size = new System.Drawing.Size(130, 80);
            this.txtPharAddress.TabIndex = 25;
            // 
            // txtPharName
            // 
            this.txtPharName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPharName.Location = new System.Drawing.Point(428, 256);
            this.txtPharName.Name = "txtPharName";
            this.txtPharName.Size = new System.Drawing.Size(130, 23);
            this.txtPharName.TabIndex = 24;
            this.txtPharName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPharName_KeyPress);
            // 
            // lblPharAddress
            // 
            this.lblPharAddress.AutoSize = true;
            this.lblPharAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharAddress.Location = new System.Drawing.Point(303, 285);
            this.lblPharAddress.Name = "lblPharAddress";
            this.lblPharAddress.Size = new System.Drawing.Size(63, 19);
            this.lblPharAddress.TabIndex = 26;
            this.lblPharAddress.Text = "Address";
            // 
            // lblPharName
            // 
            this.lblPharName.AutoSize = true;
            this.lblPharName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharName.Location = new System.Drawing.Point(303, 260);
            this.lblPharName.Name = "lblPharName";
            this.lblPharName.Size = new System.Drawing.Size(49, 19);
            this.lblPharName.TabIndex = 27;
            this.lblPharName.Text = "Name";
            // 
            // dgvPharmacy
            // 
            this.dgvPharmacy.AllowUserToAddRows = false;
            this.dgvPharmacy.AllowUserToDeleteRows = false;
            this.dgvPharmacy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPharmacy.Location = new System.Drawing.Point(308, 91);
            this.dgvPharmacy.Name = "dgvPharmacy";
            this.dgvPharmacy.ReadOnly = true;
            this.dgvPharmacy.Size = new System.Drawing.Size(250, 150);
            this.dgvPharmacy.TabIndex = 31;
            this.dgvPharmacy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPharmacy_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Pharmacy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "Store";
            // 
            // dgvStore
            // 
            this.dgvStore.AllowUserToAddRows = false;
            this.dgvStore.AllowUserToDeleteRows = false;
            this.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStore.Location = new System.Drawing.Point(12, 91);
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.ReadOnly = true;
            this.dgvStore.Size = new System.Drawing.Size(250, 150);
            this.dgvStore.TabIndex = 44;
            this.dgvStore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStore_CellClick);
            // 
            // txtStorAddress
            // 
            this.txtStorAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStorAddress.Location = new System.Drawing.Point(132, 285);
            this.txtStorAddress.Multiline = true;
            this.txtStorAddress.Name = "txtStorAddress";
            this.txtStorAddress.Size = new System.Drawing.Size(130, 80);
            this.txtStorAddress.TabIndex = 40;
            // 
            // txtStorName
            // 
            this.txtStorName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStorName.Location = new System.Drawing.Point(132, 256);
            this.txtStorName.Name = "txtStorName";
            this.txtStorName.Size = new System.Drawing.Size(130, 23);
            this.txtStorName.TabIndex = 39;
            this.txtStorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStorName_KeyPress);
            // 
            // lblStorAddress
            // 
            this.lblStorAddress.AutoSize = true;
            this.lblStorAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorAddress.Location = new System.Drawing.Point(7, 285);
            this.lblStorAddress.Name = "lblStorAddress";
            this.lblStorAddress.Size = new System.Drawing.Size(63, 19);
            this.lblStorAddress.TabIndex = 41;
            this.lblStorAddress.Text = "Address";
            // 
            // lblStorName
            // 
            this.lblStorName.AutoSize = true;
            this.lblStorName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorName.Location = new System.Drawing.Point(7, 260);
            this.lblStorName.Name = "lblStorName";
            this.lblStorName.Size = new System.Drawing.Size(49, 19);
            this.lblStorName.TabIndex = 42;
            this.lblStorName.Text = "Name";
            // 
            // btnDeleteStore
            // 
            this.btnDeleteStore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteStore.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStore.Location = new System.Drawing.Point(192, 398);
            this.btnDeleteStore.Name = "btnDeleteStore";
            this.btnDeleteStore.Size = new System.Drawing.Size(70, 30);
            this.btnDeleteStore.TabIndex = 34;
            this.btnDeleteStore.Text = "Delete";
            this.btnDeleteStore.UseVisualStyleBackColor = false;
            this.btnDeleteStore.Click += new System.EventHandler(this.btnDeleteStore_Click);
            // 
            // btnAddStore
            // 
            this.btnAddStore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddStore.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStore.Location = new System.Drawing.Point(116, 398);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(70, 30);
            this.btnAddStore.TabIndex = 33;
            this.btnAddStore.Text = "Add";
            this.btnAddStore.UseVisualStyleBackColor = false;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // StorePharmaciesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvStore);
            this.Controls.Add(this.txtStorAddress);
            this.Controls.Add(this.txtStorName);
            this.Controls.Add(this.lblStorAddress);
            this.Controls.Add(this.lblStorName);
            this.Controls.Add(this.btnDeleteStore);
            this.Controls.Add(this.btnAddStore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPharmacy);
            this.Controls.Add(this.txtPharAddress);
            this.Controls.Add(this.txtPharName);
            this.Controls.Add(this.lblPharAddress);
            this.Controls.Add(this.lblPharName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDeletePhar);
            this.Controls.Add(this.btnAddPhar);
            this.Controls.Add(this.lblStoreandPharmacies);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StorePharmaciesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StorePharmaciesForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPharmacy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblStoreandPharmacies;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusDisplay;
        private System.Windows.Forms.Button btnDeletePhar;
        private System.Windows.Forms.Button btnAddPhar;
        private System.Windows.Forms.TextBox txtPharAddress;
        private System.Windows.Forms.TextBox txtPharName;
        private System.Windows.Forms.Label lblPharAddress;
        private System.Windows.Forms.Label lblPharName;
        private System.Windows.Forms.DataGridView dgvPharmacy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStore;
        private System.Windows.Forms.TextBox txtStorAddress;
        private System.Windows.Forms.TextBox txtStorName;
        private System.Windows.Forms.Label lblStorAddress;
        private System.Windows.Forms.Label lblStorName;
        private System.Windows.Forms.Button btnDeleteStore;
        private System.Windows.Forms.Button btnAddStore;
    }
}