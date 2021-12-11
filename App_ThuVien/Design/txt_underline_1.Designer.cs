namespace ThuVien.Design
{
    partial class txt_underline_1
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
            this.under_line = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // under_line
            // 
            this.under_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.under_line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.under_line.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.under_line.Location = new System.Drawing.Point(0, 29);
            this.under_line.Multiline = true;
            this.under_line.Name = "under_line";
            this.under_line.Size = new System.Drawing.Size(346, 1);
            this.under_line.TabIndex = 4;
            // 
            // text
            // 
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text.Font = new System.Drawing.Font("Sylfaen", 13F);
            this.text.ForeColor = System.Drawing.Color.Black;
            this.text.Location = new System.Drawing.Point(0, -6);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(346, 35);
            this.text.TabIndex = 5;
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // txt_underline_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.text);
            this.Controls.Add(this.under_line);
            this.Name = "txt_underline_1";
            this.Size = new System.Drawing.Size(346, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox under_line;
        public System.Windows.Forms.TextBox text;
    }
}
