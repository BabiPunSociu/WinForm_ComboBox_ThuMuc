﻿namespace Bai7Trang67
{
    partial class Form1
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
			this.cboThuMuc = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// cboThuMuc
			// 
			this.cboThuMuc.FormattingEnabled = true;
			this.cboThuMuc.Location = new System.Drawing.Point(45, 28);
			this.cboThuMuc.Name = "cboThuMuc";
			this.cboThuMuc.Size = new System.Drawing.Size(712, 24);
			this.cboThuMuc.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cboThuMuc);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "combo_ Bài 7 Trang 67";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboThuMuc;
    }
}

