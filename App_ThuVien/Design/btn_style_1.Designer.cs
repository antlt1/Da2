namespace App_ThuVien.Design
{
    partial class btn_style_1
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
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.SpringGreen;
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(95, 42);
            this.btn.TabIndex = 12;
            this.btn.Text = "text_btn";
            this.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_style_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn);
            this.Name = "btn_style_1";
            this.Size = new System.Drawing.Size(95, 42);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn;
    }
}
