
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.pic_qr = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pn_droidcam = new DevExpress.XtraEditors.PanelControl();
            this.btn_connect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_link = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.gc_list_kh = new DevExpress.XtraGrid.GridControl();
            this.gv_list_kh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_droidcam)).BeginInit();
            this.pn_droidcam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_link.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list_kh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list_kh)).BeginInit();
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
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(903, 28);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // pic_qr
            // 
            this.pic_qr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_qr.Location = new System.Drawing.Point(429, 63);
            this.pic_qr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic_qr.Name = "pic_qr";
            this.pic_qr.Size = new System.Drawing.Size(474, 309);
            this.pic_qr.TabIndex = 4;
            this.pic_qr.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pn_droidcam
            // 
            this.pn_droidcam.Controls.Add(this.btn_connect);
            this.pn_droidcam.Controls.Add(this.labelControl1);
            this.pn_droidcam.Controls.Add(this.txt_link);
            this.pn_droidcam.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_droidcam.Location = new System.Drawing.Point(0, 28);
            this.pn_droidcam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pn_droidcam.Name = "pn_droidcam";
            this.pn_droidcam.Size = new System.Drawing.Size(903, 34);
            this.pn_droidcam.TabIndex = 7;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(429, 5);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(112, 27);
            this.btn_connect.TabIndex = 11;
            this.btn_connect.Text = "Kết nối";
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 8);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 19);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Droid Cam link :";
            // 
            // txt_link
            // 
            this.txt_link.EditValue = "http://192.168.1.5:4747/video";
            this.txt_link.Location = new System.Drawing.Point(135, 5);
            this.txt_link.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(289, 28);
            this.txt_link.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(12, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 19);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Mã bạn đọc : ";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit1.Location = new System.Drawing.Point(115, 69);
            this.buttonEdit1.Name = "buttonEdit1";
            editorButtonImageOptions1.Image = global::App_ThuVien.Properties.Resources.apply_16x164;
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.buttonEdit1.Size = new System.Drawing.Size(122, 28);
            this.buttonEdit1.TabIndex = 12;
            // 
            // gc_list_kh
            // 
            this.gc_list_kh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gc_list_kh.Location = new System.Drawing.Point(0, 102);
            this.gc_list_kh.MainView = this.gv_list_kh;
            this.gc_list_kh.Name = "gc_list_kh";
            this.gc_list_kh.Size = new System.Drawing.Size(424, 270);
            this.gc_list_kh.TabIndex = 11;
            this.gc_list_kh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_list_kh});
            // 
            // gv_list_kh
            // 
            this.gv_list_kh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_list_kh.GridControl = this.gc_list_kh;
            this.gv_list_kh.Name = "gv_list_kh";
            this.gv_list_kh.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã bạn đọc";
            this.gridColumn1.FieldName = "id_taikhoan";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên bạn đọc";
            this.gridColumn2.FieldName = "ten";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Vào lúc";
            this.gridColumn3.FieldName = "thoigian";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 112;
            // 
            // ControlBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 373);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.gc_list_kh);
            this.Controls.Add(this.pn_droidcam);
            this.Controls.Add(this.pic_qr);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlBarCode";
            this.Text = "Quét";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlBarCode_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlBarCode_FormClosed);
            this.Load += new System.EventHandler(this.ControlBarCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_droidcam)).EndInit();
            this.pn_droidcam.ResumeLayout(false);
            this.pn_droidcam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_link.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list_kh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list_kh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private System.Windows.Forms.PictureBox pic_qr;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.PanelControl pn_droidcam;
        private DevExpress.XtraEditors.SimpleButton btn_connect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_link;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraGrid.GridControl gc_list_kh;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_list_kh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}