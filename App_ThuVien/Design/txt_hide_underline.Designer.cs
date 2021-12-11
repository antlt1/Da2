namespace App_ThuVien.Design
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txt_hide_underline));
            this.under_line = new System.Windows.Forms.TextBox();
            this.text = new DevExpress.XtraEditors.ButtonEdit();
            this.img_hide = new DevExpress.XtraEditors.PictureEdit();
            this.img_show = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.text.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_hide.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_show.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // under_line
            // 
            this.under_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.under_line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.under_line.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.under_line.Location = new System.Drawing.Point(0, 33);
            this.under_line.Multiline = true;
            this.under_line.Name = "under_line";
            this.under_line.Size = new System.Drawing.Size(321, 1);
            this.under_line.TabIndex = 6;
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.Location = new System.Drawing.Point(0, -4);
            this.text.Name = "text";
            this.text.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text.Properties.UseSystemPasswordChar = true;
            this.text.Size = new System.Drawing.Size(289, 32);
            this.text.TabIndex = 7;
            this.text.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.text_ButtonClick);
            this.text.EditValueChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // img_hide
            // 
            this.img_hide.EditValue = ((object)(resources.GetObject("img_hide.EditValue")));
            this.img_hide.Location = new System.Drawing.Point(289, -1);
            this.img_hide.Name = "img_hide";
            this.img_hide.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.img_hide.Properties.Caption.Appearance.Options.UseImage = true;
            this.img_hide.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("img_hide.Properties.InitialImageOptions.Image")));
            this.img_hide.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.img_hide.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.img_hide.Size = new System.Drawing.Size(32, 32);
            this.img_hide.TabIndex = 8;
            this.img_hide.Click += new System.EventHandler(this.img_hide_Click);
            // 
            // img_show
            // 
            this.img_show.EditValue = ((object)(resources.GetObject("img_show.EditValue")));
            this.img_show.Location = new System.Drawing.Point(289, -1);
            this.img_show.Name = "img_show";
            this.img_show.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.img_show.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.img_show.Size = new System.Drawing.Size(32, 32);
            this.img_show.TabIndex = 9;
            this.img_show.Click += new System.EventHandler(this.img_show_Click);
            // 
            // txt_hide_underline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.img_show);
            this.Controls.Add(this.img_hide);
            this.Controls.Add(this.text);
            this.Controls.Add(this.under_line);
            this.Name = "txt_hide_underline";
            this.Size = new System.Drawing.Size(321, 34);
            this.Load += new System.EventHandler(this.txt_hide_underline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.text.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_hide.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_show.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox under_line;
        public DevExpress.XtraEditors.ButtonEdit text;
        private DevExpress.XtraEditors.PictureEdit img_hide;
        private DevExpress.XtraEditors.PictureEdit img_show;
    }
}
