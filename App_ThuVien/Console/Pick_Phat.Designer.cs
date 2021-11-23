namespace App_ThuVien.Console
{
    partial class Pick_Phat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pick_Phat));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pic_help = new DevExpress.XtraEditors.PictureEdit();
            this.btn_phat = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_lydo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lb_sach = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.text_lydo = new System.Windows.Forms.RichTextBox();
            this.lb_ngayphat = new DevExpress.XtraEditors.LabelControl();
            this.lb_ngmuon = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_hu_giay = new DevExpress.XtraEditors.PanelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_huhong = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_help.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_lydo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_hu_giay)).BeginInit();
            this.pn_hu_giay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_huhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pn_hu_giay);
            this.panelControl1.Controls.Add(this.pic_help);
            this.panelControl1.Controls.Add(this.btn_phat);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.cbx_lydo);
            this.panelControl1.Controls.Add(this.lb_sach);
            this.panelControl1.Controls.Add(this.panel3);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.text_lydo);
            this.panelControl1.Controls.Add(this.lb_ngayphat);
            this.panelControl1.Controls.Add(this.lb_ngmuon);
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(321, 409);
            this.panelControl1.TabIndex = 0;
            // 
            // pic_help
            // 
            this.pic_help.EditValue = ((object)(resources.GetObject("pic_help.EditValue")));
            this.pic_help.Location = new System.Drawing.Point(285, 86);
            this.pic_help.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pic_help.Name = "pic_help";
            this.pic_help.Properties.InitialImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("pic_help.Properties.InitialImageOptions.SvgImage")));
            this.pic_help.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_help.Size = new System.Drawing.Size(23, 25);
            this.pic_help.TabIndex = 29;
            this.pic_help.Click += new System.EventHandler(this.pic_help_Click);
            // 
            // btn_phat
            // 
            this.btn_phat.Location = new System.Drawing.Point(212, 356);
            this.btn_phat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_phat.Name = "btn_phat";
            this.btn_phat.Size = new System.Drawing.Size(87, 29);
            this.btn_phat.TabIndex = 28;
            this.btn_phat.Text = "Phạt";
            this.btn_phat.Click += new System.EventHandler(this.btn_phat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Chi tiết";
            // 
            // cbx_lydo
            // 
            this.cbx_lydo.Location = new System.Drawing.Point(100, 88);
            this.cbx_lydo.Name = "cbx_lydo";
            this.cbx_lydo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_lydo.Properties.Items.AddRange(new object[] {
            "Mất sách",
            "Hư sách",
            "Quá hạn"});
            this.cbx_lydo.Size = new System.Drawing.Size(179, 22);
            this.cbx_lydo.TabIndex = 26;
            this.cbx_lydo.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.cbx_lydo_Closed);
            // 
            // lb_sach
            // 
            this.lb_sach.Location = new System.Drawing.Point(99, 54);
            this.lb_sach.Name = "lb_sach";
            this.lb_sach.Size = new System.Drawing.Size(20, 16);
            this.lb_sach.TabIndex = 25;
            this.lb_sach.Text = "null";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(99, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sách :";
            // 
            // text_lydo
            // 
            this.text_lydo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.text_lydo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_lydo.Location = new System.Drawing.Point(15, 239);
            this.text_lydo.Name = "text_lydo";
            this.text_lydo.Size = new System.Drawing.Size(284, 68);
            this.text_lydo.TabIndex = 22;
            this.text_lydo.Text = "";
            // 
            // lb_ngayphat
            // 
            this.lb_ngayphat.Location = new System.Drawing.Point(99, 326);
            this.lb_ngayphat.Name = "lb_ngayphat";
            this.lb_ngayphat.Size = new System.Drawing.Size(20, 16);
            this.lb_ngayphat.TabIndex = 21;
            this.lb_ngayphat.Text = "null";
            // 
            // lb_ngmuon
            // 
            this.lb_ngmuon.Location = new System.Drawing.Point(99, 8);
            this.lb_ngmuon.Name = "lb_ngmuon";
            this.lb_ngmuon.Size = new System.Drawing.Size(20, 16);
            this.lb_ngmuon.TabIndex = 20;
            this.lb_ngmuon.Text = "null";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(99, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(99, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ngày phạt :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 92);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 17);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Lý do phạt : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Người mượn: ";
            // 
            // pn_hu_giay
            // 
            this.pn_hu_giay.Controls.Add(this.label5);
            this.pn_hu_giay.Controls.Add(this.txt_huhong);
            this.pn_hu_giay.Location = new System.Drawing.Point(5, 116);
            this.pn_hu_giay.Name = "pn_hu_giay";
            this.pn_hu_giay.Size = new System.Drawing.Size(311, 47);
            this.pn_hu_giay.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Số tờ hỏng  :";
            // 
            // txt_huhong
            // 
            this.txt_huhong.Location = new System.Drawing.Point(106, 13);
            this.txt_huhong.Name = "txt_huhong";
            this.txt_huhong.Size = new System.Drawing.Size(125, 22);
            this.txt_huhong.TabIndex = 32;
            this.txt_huhong.EditValueChanged += new System.EventHandler(this.txt_huhong_EditValueChanged);
            // 
            // Pick_Phat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 432);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Pick_Phat.IconOptions.LargeImage")));
            this.Name = "Pick_Phat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu phạt";
            this.Load += new System.EventHandler(this.Pick_Phat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_help.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_lydo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_hu_giay)).EndInit();
            this.pn_hu_giay.ResumeLayout(false);
            this.pn_hu_giay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_huhong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lb_sach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox text_lydo;
        private DevExpress.XtraEditors.LabelControl lb_ngayphat;
        private DevExpress.XtraEditors.LabelControl lb_ngmuon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_lydo;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_phat;
        private DevExpress.XtraEditors.PictureEdit pic_help;
        private DevExpress.XtraEditors.PanelControl pn_hu_giay;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txt_huhong;
    }
}