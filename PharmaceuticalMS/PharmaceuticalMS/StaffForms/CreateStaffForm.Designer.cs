﻿namespace PharmaceuticalMS
{
    partial class CreateStaffForm
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
            this.lblCreateStaff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreateStaff
            // 
            this.lblCreateStaff.AutoSize = true;
            this.lblCreateStaff.Location = new System.Drawing.Point(48, 39);
            this.lblCreateStaff.Name = "lblCreateStaff";
            this.lblCreateStaff.Size = new System.Drawing.Size(63, 13);
            this.lblCreateStaff.TabIndex = 0;
            this.lblCreateStaff.Text = "Create Staff";
            this.lblCreateStaff.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblCreateStaff);
            this.Name = "CreateStaffForm";
            this.Text = "Create Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateStaff;
    }
}