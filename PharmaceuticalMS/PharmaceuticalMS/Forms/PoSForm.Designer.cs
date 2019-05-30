namespace PharmaceuticalMS
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.lblPointofSale = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPointofSale
            // 
            this.lblPointofSale.BackColor = System.Drawing.Color.BurlyWood;
            this.lblPointofSale.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointofSale.Location = new System.Drawing.Point(0, 0);
            this.lblPointofSale.Name = "lblPointofSale";
            this.lblPointofSale.Size = new System.Drawing.Size(1035, 60);
            this.lblPointofSale.TabIndex = 0;
            this.lblPointofSale.Text = "Point of Sale";
            this.lblPointofSale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SalesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1034, 706);
            this.Controls.Add(this.lblPointofSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPointofSale;
    }
}