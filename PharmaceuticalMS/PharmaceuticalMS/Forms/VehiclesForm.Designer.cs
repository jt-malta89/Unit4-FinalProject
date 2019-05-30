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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclesForm));
            this.lblAddVehicles = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblNumberPlate = new System.Windows.Forms.Label();
            this.lblMakeandModel = new System.Windows.Forms.Label();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMakeModel = new System.Windows.Forms.TextBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtVehicleType = new System.Windows.Forms.TextBox();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.numberPlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
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
            this.btnAdd.Location = new System.Drawing.Point(9, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.TabIndex = 1;
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
            this.txtNumberPlate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "NumberPlate", true));
            this.txtNumberPlate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberPlate.Location = new System.Drawing.Point(161, 76);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(140, 23);
            this.txtNumberPlate.TabIndex = 6;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(Model.Vehicle);
            // 
            // txtMakeModel
            // 
            this.txtMakeModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "MakeModel", true));
            this.txtMakeModel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakeModel.Location = new System.Drawing.Point(161, 105);
            this.txtMakeModel.Name = "txtMakeModel";
            this.txtMakeModel.Size = new System.Drawing.Size(140, 23);
            this.txtMakeModel.TabIndex = 7;
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
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(161, 216);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(237, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AutoGenerateColumns = false;
            this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberPlateDataGridViewTextBoxColumn,
            this.makeModelDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.fuelTypeDataGridViewTextBoxColumn});
            this.dgvVehicles.DataSource = this.vehicleBindingSource;
            this.dgvVehicles.Location = new System.Drawing.Point(313, 53);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.Size = new System.Drawing.Size(261, 193);
            this.dgvVehicles.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(85, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Load";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "MakeModel", true));
            this.txtVehicleType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleType.Location = new System.Drawing.Point(161, 138);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.Size = new System.Drawing.Size(140, 23);
            this.txtVehicleType.TabIndex = 14;
            // 
            // txtFuelType
            // 
            this.txtFuelType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "MakeModel", true));
            this.txtFuelType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuelType.Location = new System.Drawing.Point(161, 167);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(140, 23);
            this.txtFuelType.TabIndex = 15;
            // 
            // numberPlateDataGridViewTextBoxColumn
            // 
            this.numberPlateDataGridViewTextBoxColumn.DataPropertyName = "NumberPlate";
            this.numberPlateDataGridViewTextBoxColumn.HeaderText = "Number Plate";
            this.numberPlateDataGridViewTextBoxColumn.Name = "numberPlateDataGridViewTextBoxColumn";
            this.numberPlateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makeModelDataGridViewTextBoxColumn
            // 
            this.makeModelDataGridViewTextBoxColumn.DataPropertyName = "MakeModel";
            this.makeModelDataGridViewTextBoxColumn.HeaderText = "Make Model";
            this.makeModelDataGridViewTextBoxColumn.Name = "makeModelDataGridViewTextBoxColumn";
            this.makeModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "Vehicle Type";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fuelTypeDataGridViewTextBoxColumn
            // 
            this.fuelTypeDataGridViewTextBoxColumn.DataPropertyName = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.HeaderText = "Fuel Type";
            this.fuelTypeDataGridViewTextBoxColumn.Name = "fuelTypeDataGridViewTextBoxColumn";
            this.fuelTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VehiclesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.txtFuelType);
            this.Controls.Add(this.txtVehicleType);
            this.Controls.Add(this.dgvVehicles);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.lblNumberPlate);
            this.Controls.Add(this.lblMakeandModel);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtMakeModel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddVehicles);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehiclesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtVehicleType;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
    }
}