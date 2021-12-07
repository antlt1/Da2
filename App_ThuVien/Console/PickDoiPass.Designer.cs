namespace App_ThuVien.Console
{
    partial class PickDoiPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickDoiPass));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_OldPassword = new DevExpress.XtraEditors.TextEdit();
            this.txt_NewPassword = new DevExpress.XtraEditors.TextEdit();
            this.txt_NewPassword1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_changer = new DevExpress.XtraEditors.SimpleButton();
            this.lb_status = new DevExpress.XtraEditors.LabelControl();
            this.pic_OldPassword = new DevExpress.XtraEditors.PictureEdit();
            this.pic_NewPassword = new DevExpress.XtraEditors.PictureEdit();
            this.pic_NewPassword1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_OldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPassword1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NewPassword1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.pic_NewPassword1);
            this.groupControl1.Controls.Add(this.pic_NewPassword);
            this.groupControl1.Controls.Add(this.pic_OldPassword);
            this.groupControl1.Controls.Add(this.lb_status);
            this.groupControl1.Controls.Add(this.btn_changer);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl3);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_NewPassword1);
            this.groupControl1.Controls.Add(this.txt_NewPassword);
            this.groupControl1.Controls.Add(this.txt_OldPassword);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(472, 325);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Đổi mật khẩu";
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.Location = new System.Drawing.Point(116, 38);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_OldPassword.Properties.UseSystemPasswordChar = true;
            this.txt_OldPassword.Size = new System.Drawing.Size(314, 26);
            this.txt_OldPassword.TabIndex = 0;
            this.txt_OldPassword.EditValueChanged += new System.EventHandler(this.txt_OldPassword_EditValueChanged);
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Location = new System.Drawing.Point(116, 110);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_NewPassword.Properties.UseSystemPasswordChar = true;
            this.txt_NewPassword.Size = new System.Drawing.Size(314, 26);
            this.txt_NewPassword.TabIndex = 1;
            this.txt_NewPassword.EditValueChanged += new System.EventHandler(this.txt_OldPassword_EditValueChanged);
            // 
            // txt_NewPassword1
            // 
            this.txt_NewPassword1.Location = new System.Drawing.Point(116, 181);
            this.txt_NewPassword1.Name = "txt_NewPassword1";
            this.txt_NewPassword1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_NewPassword1.Properties.UseSystemPasswordChar = true;
            this.txt_NewPassword1.Size = new System.Drawing.Size(314, 26);
            this.txt_NewPassword1.TabIndex = 2;
            this.txt_NewPassword1.EditValueChanged += new System.EventHandler(this.txt_OldPassword_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(1, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mật khẩu cũ :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mật khẩu mới :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 184);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nhập lại :";
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(109, 63);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(314, 1);
            this.panelControl1.TabIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(109, 206);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(314, 1);
            this.panelControl2.TabIndex = 7;
            // 
            // panelControl3
            // 
            this.panelControl3.Location = new System.Drawing.Point(109, 135);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(314, 1);
            this.panelControl3.TabIndex = 7;
            // 
            // btn_changer
            // 
            this.btn_changer.Location = new System.Drawing.Point(28, 246);
            this.btn_changer.Name = "btn_changer";
            this.btn_changer.Size = new System.Drawing.Size(112, 34);
            this.btn_changer.TabIndex = 8;
            this.btn_changer.Text = "Đổi mật khẩu";
            this.btn_changer.Click += new System.EventHandler(this.btn_changer_Click);
            // 
            // lb_status
            // 
            this.lb_status.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lb_status.Appearance.Options.UseForeColor = true;
            this.lb_status.Location = new System.Drawing.Point(28, 213);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(26, 19);
            this.lb_status.TabIndex = 9;
            this.lb_status.Text = "null";
            // 
            // pic_OldPassword
            // 
            this.pic_OldPassword.EditValue = ((object)(resources.GetObject("pic_OldPassword.EditValue")));
            this.pic_OldPassword.Location = new System.Drawing.Point(428, 32);
            this.pic_OldPassword.Name = "pic_OldPassword";
            this.pic_OldPassword.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_OldPassword.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pic_OldPassword.Size = new System.Drawing.Size(32, 32);
            this.pic_OldPassword.TabIndex = 10;
            this.pic_OldPassword.Click += new System.EventHandler(this.txt_1done_Click);
            // 
            // pic_NewPassword
            // 
            this.pic_NewPassword.EditValue = ((object)(resources.GetObject("pic_NewPassword.EditValue")));
            this.pic_NewPassword.Location = new System.Drawing.Point(428, 104);
            this.pic_NewPassword.Name = "pic_NewPassword";
            this.pic_NewPassword.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_NewPassword.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pic_NewPassword.Size = new System.Drawing.Size(32, 32);
            this.pic_NewPassword.TabIndex = 11;
            this.pic_NewPassword.Click += new System.EventHandler(this.txt_1done_Click);
            // 
            // pic_NewPassword1
            // 
            this.pic_NewPassword1.EditValue = ((object)(resources.GetObject("pic_NewPassword1.EditValue")));
            this.pic_NewPassword1.Location = new System.Drawing.Point(428, 175);
            this.pic_NewPassword1.Name = "pic_NewPassword1";
            this.pic_NewPassword1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_NewPassword1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pic_NewPassword1.Size = new System.Drawing.Size(32, 32);
            this.pic_NewPassword1.TabIndex = 12;
            this.pic_NewPassword1.Click += new System.EventHandler(this.txt_1done_Click);
            // 
            // PickDoiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(472, 325);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PickDoiPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.PickDoiPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_OldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPassword1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_OldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NewPassword1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_NewPassword1;
        private DevExpress.XtraEditors.TextEdit txt_NewPassword;
        private DevExpress.XtraEditors.TextEdit txt_OldPassword;
        private DevExpress.XtraEditors.SimpleButton btn_changer;
        private DevExpress.XtraEditors.LabelControl lb_status;
        private DevExpress.XtraEditors.PictureEdit pic_NewPassword;
        private DevExpress.XtraEditors.PictureEdit pic_OldPassword;
        private DevExpress.XtraEditors.PictureEdit pic_NewPassword1;


    }
}