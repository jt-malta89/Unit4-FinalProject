namespace PharmaceuticalMS
{
    partial class CreateClientForm
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
            this.lblCreateClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreateClient
            // 
            this.lblCreateClient.AutoSize = true;
            this.lblCreateClient.Location = new System.Drawing.Point(49, 38);
            this.lblCreateClient.Name = "lblCreateClient";
            this.lblCreateClient.Size = new System.Drawing.Size(67, 13);
            this.lblCreateClient.TabIndex = 0;
            this.lblCreateClient.Text = "Create Client";
            // 
            // CreateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblCreateClient);
            this.Name = "CreateClientForm";
            this.Text = "Create Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateClient;
    }
}