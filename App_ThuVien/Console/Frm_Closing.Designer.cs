namespace App_ThuVien.Console
{
    partial class Frm_Closing
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
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.checker = new DevExpress.XtraEditors.CheckEdit();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checker.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(683, 28);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(60, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(546, 24);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Thiết lập thoát cho hệ thống bạn có đóng ngay cho  lần sau ?";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(190, 103);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(118, 34);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Thoát";
            this.btn_close.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // checker
            // 
            this.checker.Location = new System.Drawing.Point(12, 108);
            this.checker.Name = "checker";
            this.checker.Properties.Caption = "Lưu cho lần sau";
            this.checker.Size = new System.Drawing.Size(142, 25);
            this.checker.TabIndex = 5;
            this.checker.CheckedChanged += new System.EventHandler(this.checker_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(438, 103);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(118, 34);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // Frm_Closing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 149);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.checker);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.LargeImage = global::App_ThuVien.Properties.Resources.warning_32x32;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Closing";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Closing_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Closing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checker.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraEditors.CheckEdit checker;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
    }
}