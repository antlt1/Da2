﻿namespace App_ThuVien.Design
{
    partial class txt_hide_underline
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text = new System.Windows.Forms.TextBox();
            this.under_line = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text.Font = new System.Drawing.Font("Sylfaen", 13F);
            this.text.ForeColor = System.Drawing.Color.Black;
            this.text.Location = new System.Drawing.Point(0, 2);
            this.text.Name = "text";
            this.text.PasswordChar = '*';
            this.text.Size = new System.Drawing.Size(321, 35);
            this.text.TabIndex = 7;
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // under_line
            // 
            this.under_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.under_line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.under_line.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.under_line.Location = new System.Drawing.Point(0, 37);
            this.under_line.Multiline = true;
            this.under_line.Name = "under_line";
            this.under_line.Size = new System.Drawing.Size(321, 1);
            this.under_line.TabIndex = 6;
            // 
            // txt_hide_underline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.text);
            this.Controls.Add(this.under_line);
            this.Name = "txt_hide_underline";
            this.Size = new System.Drawing.Size(321, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox under_line;
    }
}
