
namespace App_ThuVien.Console
{
    partial class ThemKhachHang
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
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHovaTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.btn_DK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHovaTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(281, 45);
            this.fluentDesignFormControl1.TabIndex = 9;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Element1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtSDT);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtHovaTen);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtMaKH);
            this.panelControl1.Controls.Add(this.btn_DK);
            this.panelControl1.Location = new System.Drawing.Point(12, 51);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(257, 308);
            this.panelControl1.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(25, 216);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.AutoHeight = false;
            this.txtDiaChi.Size = new System.Drawing.Size(218, 28);
            this.txtDiaChi.TabIndex = 26;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 191);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 19);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Địa Chỉ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 19);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Số điện thoại *";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(23, 157);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(220, 28);
            this.txtSDT.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 19);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Họ và Tên *";
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(23, 98);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(220, 28);
            this.txtHovaTen.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 19);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Mã khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(23, 39);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(220, 28);
            this.txtMaKH.TabIndex = 18;
            this.txtMaKH.DoubleClick += new System.EventHandler(this.txtMaKH_DoubleClick);
            // 
            // btn_DK
            // 
            this.btn_DK.Location = new System.Drawing.Point(25, 262);
            this.btn_DK.Name = "btn_DK";
            this.btn_DK.Size = new System.Drawing.Size(112, 34);
            this.btn_DK.TabIndex = 17;
            this.btn_DK.Text = "Đăng Ký";
            this.btn_DK.Click += new System.EventHandler(this.btn_DK_Click);
            // 
            // ThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 359);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.Image = global::App_ThuVien.Properties.Resources.bocustomer_16x161;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHovaTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHovaTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.SimpleButton btn_DK;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
    }
}