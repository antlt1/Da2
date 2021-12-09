namespace App_ThuVien.ThongKe
{
    partial class Frm_ThongKe
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
            this.btn_chon_thang = new DevExpress.XtraEditors.SimpleButton();
            this.lb_thang_kt = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lb_thang_bd = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btn_batdau = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btn_year = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txt_year = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbox_Tong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pn_sach = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_year.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_Tong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_chon_thang
            // 
            this.btn_chon_thang.Location = new System.Drawing.Point(8, 47);
            this.btn_chon_thang.Name = "btn_chon_thang";
            this.btn_chon_thang.Size = new System.Drawing.Size(174, 34);
            this.btn_chon_thang.TabIndex = 9;
            this.btn_chon_thang.Text = "Chọn tháng bắt đầu";
            this.btn_chon_thang.Click += new System.EventHandler(this.btn_chon_thang_Click);
            // 
            // lb_thang_kt
            // 
            this.lb_thang_kt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lb_thang_kt.Appearance.Options.UseFont = true;
            this.lb_thang_kt.Location = new System.Drawing.Point(8, 160);
            this.lb_thang_kt.Name = "lb_thang_kt";
            this.lb_thang_kt.Size = new System.Drawing.Size(59, 24);
            this.lb_thang_kt.TabIndex = 10;
            this.lb_thang_kt.Text = "lb_null";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImageOptions.Image = global::App_ThuVien.Properties.Resources.reverssort_16x16;
            this.labelControl2.Location = new System.Drawing.Point(51, 130);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(16, 24);
            this.labelControl2.TabIndex = 11;
            // 
            // lb_thang_bd
            // 
            this.lb_thang_bd.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lb_thang_bd.Appearance.Options.UseFont = true;
            this.lb_thang_bd.Location = new System.Drawing.Point(8, 100);
            this.lb_thang_bd.Name = "lb_thang_bd";
            this.lb_thang_bd.Size = new System.Drawing.Size(59, 24);
            this.lb_thang_bd.TabIndex = 8;
            this.lb_thang_bd.Text = "lb_null";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.xtraTabControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(317, 475);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Chọn kiểu thống kê";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 27);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(317, 448);
            this.xtraTabControl1.TabIndex = 14;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btn_batdau);
            this.xtraTabPage1.Controls.Add(this.btn_chon_thang);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.lb_thang_bd);
            this.xtraTabPage1.Controls.Add(this.lb_thang_kt);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(309, 413);
            this.xtraTabPage1.Text = "Tháng";
            // 
            // btn_batdau
            // 
            this.btn_batdau.Location = new System.Drawing.Point(8, 190);
            this.btn_batdau.Name = "btn_batdau";
            this.btn_batdau.Size = new System.Drawing.Size(112, 34);
            this.btn_batdau.TabIndex = 13;
            this.btn_batdau.Text = "Bắt đầu";
            this.btn_batdau.Click += new System.EventHandler(this.btn_batdau_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btn_year);
            this.xtraTabPage2.Controls.Add(this.panelControl3);
            this.xtraTabPage2.Controls.Add(this.txt_year);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(309, 413);
            this.xtraTabPage2.Text = "Năm";
            // 
            // btn_year
            // 
            this.btn_year.Location = new System.Drawing.Point(181, 112);
            this.btn_year.Name = "btn_year";
            this.btn_year.Size = new System.Drawing.Size(112, 34);
            this.btn_year.TabIndex = 1;
            this.btn_year.Text = "Chọn";
            this.btn_year.Click += new System.EventHandler(this.btn_year_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Location = new System.Drawing.Point(8, 145);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(165, 1);
            this.panelControl3.TabIndex = 2;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(8, 116);
            this.txt_year.Name = "txt_year";
            this.txt_year.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_year.Size = new System.Drawing.Size(165, 26);
            this.txt_year.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Nhập năm thống kê";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.labelControl3);
            this.xtraTabPage3.Controls.Add(this.cbox_Tong);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(309, 413);
            this.xtraTabPage3.Text = "Thống kê tổng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(134, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Chọn loại thống kê";
            // 
            // cbox_Tong
            // 
            this.cbox_Tong.Location = new System.Drawing.Point(8, 79);
            this.cbox_Tong.Name = "cbox_Tong";
            this.cbox_Tong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_Tong.Properties.Items.AddRange(new object[] {
            "Sách",
            "Phiếu",
            "Tài khoản"});
            this.cbox_Tong.Size = new System.Drawing.Size(303, 28);
            this.cbox_Tong.TabIndex = 0;
            this.cbox_Tong.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.cbox_Tong_Closed);
            // 
            // pn_sach
            // 
            this.pn_sach.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pn_sach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_sach.Location = new System.Drawing.Point(2, 24);
            this.pn_sach.Margin = new System.Windows.Forms.Padding(4);
            this.pn_sach.Name = "pn_sach";
            this.pn_sach.Size = new System.Drawing.Size(947, 449);
            this.pn_sach.TabIndex = 13;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.pn_sach);
            this.groupControl2.Location = new System.Drawing.Point(326, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(951, 475);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Biểu đồ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 476);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.Tk_Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_year.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_Tong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_chon_thang;
        private DevExpress.XtraEditors.LabelControl lb_thang_kt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lb_thang_bd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btn_batdau;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton btn_year;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit txt_year;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pn_sach;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_Tong;
    }
}