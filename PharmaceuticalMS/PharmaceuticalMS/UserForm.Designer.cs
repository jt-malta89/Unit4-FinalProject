namespace PharmaceuticalMS
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(204, 761);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOrders.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(13, 113);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(180, 50);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnProducts.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(13, 171);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(180, 50);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogoff.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoff.Image = ((System.Drawing.Image)(resources.GetObject("btnLogoff.Image")));
            this.btnLogoff.Location = new System.Drawing.Point(135, 693);
            this.btnLogoff.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(55, 55);
            this.btnLogoff.TabIndex = 9;
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClients.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(13, 229);
            this.btnClients.Margin = new System.Windows.Forms.Padding(4);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(180, 50);
            this.btnClients.TabIndex = 11;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pLogo.Image = ((System.Drawing.Image)(resources.GetObject("pLogo.Image")));
            this.pLogo.Location = new System.Drawing.Point(36, 4);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(130, 130);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pLogo.TabIndex = 31;
            this.pLogo.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.PictureBox pLogo;
    }
}