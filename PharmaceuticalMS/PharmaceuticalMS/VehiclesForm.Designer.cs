namespace PharmaceuticalMS
{
    partial class VehiclesForm
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
            this.lblAddVehicles = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblNumberPlate = new System.Windows.Forms.Label();
            this.lblMakeandModel = new System.Windows.Forms.Label();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.txtMakeModel = new System.Windows.Forms.TextBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtVehicleType = new System.Windows.Forms.TextBox();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddVehicles
            // 
            this.lblAddVehicles.BackColor = System.Drawing.Color.BurlyWood;
            this.lblAddVehicles.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVehicles.Location = new System.Drawing.Point(0, 0);
            this.lblAddVehicles.Name = "lblAddVehicles";
            this.lblAddVehicles.Size = new System.Drawing.Size(600, 40);
            this.lblAddVehicles.TabIndex = 0;
            this.lblAddVehicles.Text = "Add Vehicles";
            this.lblAddVehicles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(155, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(45, 138);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(94, 19);
            this.lblVehicleType.TabIndex = 8;
            this.lblVehicleType.Text = "Vehicle Type";
            // 
            // lblNumberPlate
            // 
            this.lblNumberPlate.AutoSize = true;
            this.lblNumberPlate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPlate.Location = new System.Drawing.Point(35, 80);
            this.lblNumberPlate.Name = "lblNumberPlate";
            this.lblNumberPlate.Size = new System.Drawing.Size(104, 19);
            this.lblNumberPlate.TabIndex = 9;
            this.lblNumberPlate.Text = "Number Plate";
            // 
            // lblMakeandModel
            // 
            this.lblMakeandModel.AutoSize = true;
            this.lblMakeandModel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeandModel.Location = new System.Drawing.Point(14, 109);
            this.lblMakeandModel.Name = "lblMakeandModel";
            this.lblMakeandModel.Size = new System.Drawing.Size(125, 19);
            this.lblMakeandModel.TabIndex = 10;
            this.lblMakeandModel.Text = "Make and Model";
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberPlate.Location = new System.Drawing.Point(161, 76);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(140, 23);
            this.txtNumberPlate.TabIndex = 0;
            // 
            // txtMakeModel
            // 
            this.txtMakeModel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakeModel.Location = new System.Drawing.Point(161, 105);
            this.txtMakeModel.Name = "txtMakeModel";
            this.txtMakeModel.Size = new System.Drawing.Size(140, 23);
            this.txtMakeModel.TabIndex = 1;
            this.txtMakeModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMakeModel_KeyPress);
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelType.Location = new System.Drawing.Point(65, 167);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(74, 19);
            this.lblFuelType.TabIndex = 12;
            this.lblFuelType.Text = "Fuel Type";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(231, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleType.Location = new System.Drawing.Point(161, 134);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.Size = new System.Drawing.Size(140, 23);
            this.txtVehicleType.TabIndex = 2;
            this.txtVehicleType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVehicleType_KeyPress);
            // 
            // txtFuelType
            // 
            this.txtFuelType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuelType.Location = new System.Drawing.Point(161, 163);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(140, 23);
            this.txtFuelType.TabIndex = 3;
            this.txtFuelType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFuelType_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusDisplay});
            this.statusStrip1.Location = new System.Drawing.Point(0, 249);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusVehicles
            // 
            this.StripStatusDisplay.Name = "StripStatusVehicles";
            this.StripStatusDisplay.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(332, 58);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.Size = new System.Drawing.Size(240, 177);
            this.dgvVehicles.TabIndex = 14;
            this.dgvVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicles_CellClick);
            // 
            // VehiclesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 271);
            this.Controls.Add(this.dgvVehicles);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.lblNumberPlate);
            this.Controls.Add(this.lblMakeandModel);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.txtFuelType);
            this.Controls.Add(this.txtVehicleType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtMakeModel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddVehicles);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VehiclesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VehiclesForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddVehicles;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblNumberPlate;
        private System.Windows.Forms.Label lblMakeandModel;
        private System.Windows.Forms.TextBox txtNumberPlate;
        private System.Windows.Forms.TextBox txtMakeModel;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtVehicleType;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusDisplay;
        private System.Windows.Forms.DataGridView dgvVehicles;
    }
}