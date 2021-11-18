
namespace App_ThuVien.BarCode
{
    partial class ControlBarCode
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.droidCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtBịVậtLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_qr = new System.Windows.Forms.PictureBox();
            this.list_user = new System.Windows.Forms.ListView();
            this.TenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThoiGianVao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbx_thietbi = new System.Windows.Forms.ComboBox();
            this.pn_droidcam = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_link = new DevExpress.XtraEditors.TextEdit();
            this.btn_connect = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_droidcam)).BeginInit();
            this.pn_droidcam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_link.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 76);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(358, 385);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Page 0";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(729, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thiếtBịToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thiếtBịToolStripMenuItem
            // 
            this.thiếtBịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.droidCamToolStripMenuItem,
            this.thiếtBịVậtLýToolStripMenuItem});
            this.thiếtBịToolStripMenuItem.Name = "thiếtBịToolStripMenuItem";
            this.thiếtBịToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.thiếtBịToolStripMenuItem.Text = "Kết Nối Cam";
            // 
            // droidCamToolStripMenuItem
            // 
            this.droidCamToolStripMenuItem.Name = "droidCamToolStripMenuItem";
            this.droidCamToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.droidCamToolStripMenuItem.Text = "DroidCam";
            this.droidCamToolStripMenuItem.Click += new System.EventHandler(this.droidCamToolStripMenuItem_Click);
            // 
            // thiếtBịVậtLýToolStripMenuItem
            // 
            this.thiếtBịVậtLýToolStripMenuItem.Name = "thiếtBịVậtLýToolStripMenuItem";
            this.thiếtBịVậtLýToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.thiếtBịVậtLýToolStripMenuItem.Text = "Thiết bị vật lý";
            this.thiếtBịVậtLýToolStripMenuItem.Click += new System.EventHandler(this.thiếtBịVậtLýToolStripMenuItem_Click);
            // 
            // pic_qr
            // 
            this.pic_qr.Location = new System.Drawing.Point(12, 105);
            this.pic_qr.Name = "pic_qr";
            this.pic_qr.Size = new System.Drawing.Size(346, 256);
            this.pic_qr.TabIndex = 4;
            this.pic_qr.TabStop = false;
            // 
            // list_user
            // 
            this.list_user.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenKH,
            this.ThoiGianVao});
            this.list_user.HideSelection = false;
            this.list_user.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.list_user.Location = new System.Drawing.Point(364, 105);
            this.list_user.Name = "list_user";
            this.list_user.Size = new System.Drawing.Size(365, 256);
            this.list_user.TabIndex = 5;
            this.list_user.UseCompatibleStateImageBehavior = false;
            // 
            // TenKH
            // 
            this.TenKH.Text = "Tên khách hàng";
            // 
            // ThoiGianVao
            // 
            this.ThoiGianVao.Text = "Vào lúc";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbx_thietbi
            // 
            this.cbx_thietbi.FormattingEnabled = true;
            this.cbx_thietbi.Location = new System.Drawing.Point(596, 66);
            this.cbx_thietbi.Name = "cbx_thietbi";
            this.cbx_thietbi.Size = new System.Drawing.Size(121, 27);
            this.cbx_thietbi.TabIndex = 6;
            // 
            // pn_droidcam
            // 
            this.pn_droidcam.Controls.Add(this.btn_connect);
            this.pn_droidcam.Controls.Add(this.labelControl1);
            this.pn_droidcam.Controls.Add(this.txt_link);
            this.pn_droidcam.Location = new System.Drawing.Point(12, 66);
            this.pn_droidcam.Name = "pn_droidcam";
            this.pn_droidcam.Size = new System.Drawing.Size(633, 34);
            this.pn_droidcam.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 19);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Droid Cam link :";
            // 
            // txt_link
            // 
            this.txt_link.EditValue = "http://192.168.1.5:4747/video";
            this.txt_link.Location = new System.Drawing.Point(134, 4);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(289, 28);
            this.txt_link.TabIndex = 9;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(429, 5);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(112, 27);
            this.btn_connect.TabIndex = 11;
            this.btn_connect.Text = "Kết nối";
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // ControlBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 373);
            this.Controls.Add(this.pn_droidcam);
            this.Controls.Add(this.cbx_thietbi);
            this.Controls.Add(this.list_user);
            this.Controls.Add(this.pic_qr);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlBarCode";
            this.Text = "Quét";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlBarCode_FormClosed);
            this.Load += new System.EventHandler(this.ControlBarCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_droidcam)).EndInit();
            this.pn_droidcam.ResumeLayout(false);
            this.pn_droidcam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_link.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private System.Windows.Forms.ListView list_user;
        private System.Windows.Forms.ColumnHeader TenKH;
        private System.Windows.Forms.ColumnHeader ThoiGianVao;
        private System.Windows.Forms.PictureBox pic_qr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thiếtBịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem droidCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiếtBịVậtLýToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbx_thietbi;
        private DevExpress.XtraEditors.PanelControl pn_droidcam;
        private DevExpress.XtraEditors.SimpleButton btn_connect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_link;
    }
}