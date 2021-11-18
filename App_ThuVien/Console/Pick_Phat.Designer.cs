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
            this.pic_help = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_lydo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_help.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
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
            this.panelControl1.Location = new System.Drawing.Point(15, 14);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(413, 350);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_phat
            // 
            this.btn_phat.Location = new System.Drawing.Point(272, 311);
            this.btn_phat.Name = "btn_phat";
            this.btn_phat.Size = new System.Drawing.Size(112, 34);
            this.btn_phat.TabIndex = 28;
            this.btn_phat.Text = "Phạt";
            this.btn_phat.Click += new System.EventHandler(this.btn_phat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Chi tiết";
            // 
            // cbx_lydo
            // 
            this.cbx_lydo.Location = new System.Drawing.Point(129, 104);
            this.cbx_lydo.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_lydo.Name = "cbx_lydo";
            this.cbx_lydo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_lydo.Properties.Items.AddRange(new object[] {
            "Mất sách",
            "Hư sách",
            "Quá hạn"});
            this.cbx_lydo.Size = new System.Drawing.Size(230, 28);
            this.cbx_lydo.TabIndex = 26;
            this.cbx_lydo.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.cbx_lydo_Closed);
            // 
            // lb_sach
            // 
            this.lb_sach.Location = new System.Drawing.Point(127, 64);
            this.lb_sach.Margin = new System.Windows.Forms.Padding(4);
            this.lb_sach.Name = "lb_sach";
            this.lb_sach.Size = new System.Drawing.Size(26, 19);
            this.lb_sach.TabIndex = 25;
            this.lb_sach.Text = "null";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(127, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 1);
            this.panel3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sách :";
            // 
            // text_lydo
            // 
            this.text_lydo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_lydo.Location = new System.Drawing.Point(19, 172);
            this.text_lydo.Margin = new System.Windows.Forms.Padding(4);
            this.text_lydo.Name = "text_lydo";
            this.text_lydo.Size = new System.Drawing.Size(365, 81);
            this.text_lydo.TabIndex = 22;
            this.text_lydo.Text = "";
            // 
            // lb_ngayphat
            // 
            this.lb_ngayphat.Location = new System.Drawing.Point(127, 275);
            this.lb_ngayphat.Margin = new System.Windows.Forms.Padding(4);
            this.lb_ngayphat.Name = "lb_ngayphat";
            this.lb_ngayphat.Size = new System.Drawing.Size(26, 19);
            this.lb_ngayphat.TabIndex = 21;
            this.lb_ngayphat.Text = "null";
            // 
            // lb_ngmuon
            // 
            this.lb_ngmuon.Location = new System.Drawing.Point(127, 10);
            this.lb_ngmuon.Margin = new System.Windows.Forms.Padding(4);
            this.lb_ngmuon.Name = "lb_ngmuon";
            this.lb_ngmuon.Size = new System.Drawing.Size(26, 19);
            this.lb_ngmuon.TabIndex = 20;
            this.lb_ngmuon.Text = "null";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(127, 297);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 1);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(127, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 1);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ngày phạt :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 109);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 19);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Lý do phạt : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Người mượn: ";
            // 
            // pic_help
            // 
            this.pic_help.EditValue = ((object)(resources.GetObject("pic_help.EditValue")));
            this.pic_help.Location = new System.Drawing.Point(366, 102);
            this.pic_help.Name = "pic_help";
            this.pic_help.Properties.InitialImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("pictureEdit1.Properties.InitialImageOptions.SvgImage")));
            this.pic_help.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_help.Size = new System.Drawing.Size(30, 30);
            this.pic_help.TabIndex = 29;
            this.pic_help.Click += new System.EventHandler(this.pic_help_Click);
            // 
            // Pick_Phat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 378);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Pick_Phat.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pick_Phat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu phạt";
            this.Load += new System.EventHandler(this.Pick_Phat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_lydo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_help.Properties)).EndInit();
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
    }
}