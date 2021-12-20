namespace App_ThuVien.Console
{
    partial class Setting
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
            this.left_bar = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aCThoat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aCMenu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.tab_setting = new DevExpress.XtraTab.XtraTabControl();
            this.xtab_Close = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_save_close = new DevExpress.XtraEditors.SimpleButton();
            this.check_close = new DevExpress.XtraEditors.CheckEdit();
            this.xtab_menu = new DevExpress.XtraTab.XtraTabPage();
            this.tS_menuTop = new DevExpress.XtraEditors.ToggleSwitch();
            this.tS_menuLeft = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.left_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_setting)).BeginInit();
            this.tab_setting.SuspendLayout();
            this.xtab_Close.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_close.Properties)).BeginInit();
            this.xtab_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tS_menuTop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tS_menuLeft.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // left_bar
            // 
            this.left_bar.Appearance.Item.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.left_bar.Appearance.Item.Hovered.ForeColor = System.Drawing.Color.White;
            this.left_bar.Appearance.Item.Hovered.Options.UseBorderColor = true;
            this.left_bar.Appearance.Item.Hovered.Options.UseForeColor = true;
            this.left_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_bar.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.aCThoat,
            this.aCMenu});
            this.left_bar.Location = new System.Drawing.Point(0, 28);
            this.left_bar.Name = "left_bar";
            this.left_bar.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.left_bar.Size = new System.Drawing.Size(260, 577);
            this.left_bar.TabIndex = 1;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // aCThoat
            // 
            this.aCThoat.Name = "aCThoat";
            this.aCThoat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aCThoat.Text = "Nhắc nhở thoát";
            this.aCThoat.Click += new System.EventHandler(this.aCMenu_Click);
            // 
            // aCMenu
            // 
            this.aCMenu.Name = "aCMenu";
            this.aCMenu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aCMenu.Text = "Cài đặt menu";
            this.aCMenu.Click += new System.EventHandler(this.aCMenu_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1173, 28);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1103, 577);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 28);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Đóng";
            // 
            // tab_setting
            // 
            this.tab_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_setting.Location = new System.Drawing.Point(260, 28);
            this.tab_setting.Name = "tab_setting";
            this.tab_setting.SelectedTabPage = this.xtab_Close;
            this.tab_setting.Size = new System.Drawing.Size(913, 577);
            this.tab_setting.TabIndex = 4;
            this.tab_setting.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtab_Close,
            this.xtab_menu});
            // 
            // xtab_Close
            // 
            this.xtab_Close.Controls.Add(this.labelControl1);
            this.xtab_Close.Controls.Add(this.btn_save_close);
            this.xtab_Close.Controls.Add(this.check_close);
            this.xtab_Close.Name = "xtab_Close";
            this.xtab_Close.Size = new System.Drawing.Size(905, 542);
            this.xtab_Close.Text = "Nhắc nhở thoát";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(209, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Cài đặt : Tự động thoát";
            // 
            // btn_save_close
            // 
            this.btn_save_close.Location = new System.Drawing.Point(225, 94);
            this.btn_save_close.Name = "btn_save_close";
            this.btn_save_close.Size = new System.Drawing.Size(90, 34);
            this.btn_save_close.TabIndex = 1;
            this.btn_save_close.Text = "Lưu";
            this.btn_save_close.Click += new System.EventHandler(this.btn_save_close_Click);
            // 
            // check_close
            // 
            this.check_close.Location = new System.Drawing.Point(93, 99);
            this.check_close.Name = "check_close";
            this.check_close.Properties.AutoWidth = true;
            this.check_close.Properties.Caption = "Tự động thoát";
            this.check_close.Size = new System.Drawing.Size(126, 25);
            this.check_close.TabIndex = 0;
            // 
            // xtab_menu
            // 
            this.xtab_menu.Controls.Add(this.tS_menuTop);
            this.xtab_menu.Controls.Add(this.tS_menuLeft);
            this.xtab_menu.Controls.Add(this.labelControl4);
            this.xtab_menu.Controls.Add(this.labelControl3);
            this.xtab_menu.Controls.Add(this.labelControl2);
            this.xtab_menu.Name = "xtab_menu";
            this.xtab_menu.Size = new System.Drawing.Size(905, 547);
            this.xtab_menu.Text = "Cài đặt menu";
            // 
            // tS_menuTop
            // 
            this.tS_menuTop.Location = new System.Drawing.Point(173, 147);
            this.tS_menuTop.Name = "tS_menuTop";
            this.tS_menuTop.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.tS_menuTop.Properties.OffText = "Tắt";
            this.tS_menuTop.Properties.OnText = "Bật";
            this.tS_menuTop.Size = new System.Drawing.Size(132, 34);
            this.tS_menuTop.TabIndex = 7;
            this.tS_menuTop.Toggled += new System.EventHandler(this.tS_menuTop_Toggled);
            this.tS_menuTop.Click += new System.EventHandler(this.tab_setting_Click);
            // 
            // tS_menuLeft
            // 
            this.tS_menuLeft.Location = new System.Drawing.Point(173, 74);
            this.tS_menuLeft.Name = "tS_menuLeft";
            this.tS_menuLeft.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.tS_menuLeft.Properties.OffText = "Tắt";
            this.tS_menuLeft.Properties.OnText = "Bật";
            this.tS_menuLeft.Size = new System.Drawing.Size(132, 34);
            this.tS_menuLeft.TabIndex = 6;
            this.tS_menuLeft.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            this.tS_menuLeft.Click += new System.EventHandler(this.tab_setting_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(40, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 22);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Menu trên : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(40, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(127, 22);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Menu bên trái : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(235, 24);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Cài đặt : Menu trái và trên";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1173, 605);
            this.Controls.Add(this.tab_setting);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.left_bar);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.LargeImage = global::App_ThuVien.Properties.Resources.properties_32x32;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.NavigationControl = this.left_bar;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.left_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_setting)).EndInit();
            this.tab_setting.ResumeLayout(false);
            this.xtab_Close.ResumeLayout(false);
            this.xtab_Close.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_close.Properties)).EndInit();
            this.xtab_menu.ResumeLayout(false);
            this.xtab_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tS_menuTop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tS_menuLeft.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl left_bar;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aCThoat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aCMenu;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraTab.XtraTabControl tab_setting;
        private DevExpress.XtraTab.XtraTabPage xtab_Close;
        private DevExpress.XtraTab.XtraTabPage xtab_menu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_save_close;
        private DevExpress.XtraEditors.CheckEdit check_close;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ToggleSwitch tS_menuLeft;
        private DevExpress.XtraEditors.ToggleSwitch tS_menuTop;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
    }
}