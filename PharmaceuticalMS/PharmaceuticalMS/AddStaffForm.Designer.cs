namespace PharmaceuticalMS
{
    partial class AddStaffForm
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
            this.lblAddStaff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddStaff
            // 
            this.lblAddStaff.AutoSize = true;
            this.lblAddStaff.Location = new System.Drawing.Point(48, 39);
            this.lblAddStaff.Name = "lblAddStaff";
            this.lblAddStaff.Size = new System.Drawing.Size(51, 13);
            this.lblAddStaff.TabIndex = 0;
            this.lblAddStaff.Text = "Add Staff";
            this.lblAddStaff.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 686);
            this.Controls.Add(this.lblAddStaff);
            this.Name = "AddStaffForm";
            this.Text = "Add Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddStaff;
    }
}