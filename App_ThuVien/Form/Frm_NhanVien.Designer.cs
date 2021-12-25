namespace App_ThuVien.Form
{
    partial class Frm_NhanVien
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btn_rs = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add_data = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_print = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_nhanvien = new DevExpress.XtraGrid.GridControl();
            this.gv_nhanvien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_dangky = new DevExpress.XtraEditors.SimpleButton();
            this.lab_dangky = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rs
            // 
            this.btn_rs.ImageOptions.Image = global::App_ThuVien.Properties.Resources.refresh2_16x16;
            this.btn_rs.ImageOptions.ImageIndex = 9;
            this.btn_rs.Location = new System.Drawing.Point(-1, 14);
            this.btn_rs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rs.Name = "btn_rs";
            this.btn_rs.Size = new System.Drawing.Size(104, 37);
            this.btn_rs.TabIndex = 114;
            this.btn_rs.Text = "Làm mới";
            this.btn_rs.Click += new System.EventHandler(this.btn_rs_Click);
            // 
            // btn_del
            // 
            this.btn_del.ImageOptions.Image = global::App_ThuVien.Properties.Resources.trash_16x16;
            this.btn_del.ImageOptions.ImageIndex = 9;
            this.btn_del.Location = new System.Drawing.Point(219, 14);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(104, 37);
            this.btn_del.TabIndex = 113;
            this.btn_del.Text = "Xoá";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add_data
            // 
            this.btn_add_data.ImageOptions.Image = global::App_ThuVien.Properties.Resources.add_16x16;
            this.btn_add_data.ImageOptions.ImageIndex = 9;
            this.btn_add_data.Location = new System.Drawing.Point(109, 14);
            this.btn_add_data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add_data.Name = "btn_add_data";
            this.btn_add_data.Size = new System.Drawing.Size(104, 37);
            this.btn_add_data.TabIndex = 112;
            this.btn_add_data.Text = "Thêm";
            this.btn_add_data.Click += new System.EventHandler(this.btn_add_data_Click);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = global::App_ThuVien.Properties.Resources.printernetwork_16x16;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_print
            // 
            this.btn_print.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn_print.Name = "btn_print";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gc_nhanvien
            // 
            this.gc_nhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc_nhanvien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gc_nhanvien.Location = new System.Drawing.Point(-1, 58);
            this.gc_nhanvien.MainView = this.gv_nhanvien;
            this.gc_nhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gc_nhanvien.Name = "gc_nhanvien";
            this.gc_nhanvien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit2});
            this.gc_nhanvien.Size = new System.Drawing.Size(1295, 444);
            this.gc_nhanvien.TabIndex = 115;
            this.gc_nhanvien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_nhanvien});
            // 
            // gv_nhanvien
            // 
            this.gv_nhanvien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gv_nhanvien.GridControl = this.gc_nhanvien;
            this.gv_nhanvien.Name = "gv_nhanvien";
            this.gv_nhanvien.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gv_nhanvien.OptionsSelection.MultiSelect = true;
            this.gv_nhanvien.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_nhanvien.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gv_nhanvien.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gv_nhanvien.OptionsView.ShowGroupPanel = false;
            this.gv_nhanvien.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv_nhanvien_RowCellClick);
            this.gv_nhanvien.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_nhanvien_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhân viên";
            this.gridColumn1.FieldName = "id_TaiKhoan";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ và Tên";
            this.gridColumn2.FieldName = "hoten";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 159;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số Điện Thoại";
            this.gridColumn3.FieldName = "sdt";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 144;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa Chỉ";
            this.gridColumn4.FieldName = "diachi";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 168;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên tài khoản";
            this.gridColumn6.FieldName = "ten_taikhoan";
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 84;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mật khẩu";
            this.gridColumn7.FieldName = "matkhau";
            this.gridColumn7.MinWidth = 30;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 87;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Email";
            this.gridColumn8.FieldName = "email";
            this.gridColumn8.MinWidth = 30;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 78;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Trạng Thái";
            this.gridColumn9.FieldName = "trangthai";
            this.gridColumn9.MinWidth = 30;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            this.gridColumn9.Width = 94;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "In thẻ";
            this.gridColumn10.ColumnEdit = this.repositoryItemButtonEdit2;
            this.gridColumn10.FieldName = "in";
            this.gridColumn10.MinWidth = 30;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 112;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions2.Image = global::App_ThuVien.Properties.Resources.printernetwork_16x16;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btn_dangky
            // 
            this.btn_dangky.ImageOptions.Image = global::App_ThuVien.Properties.Resources.news_16x16;
            this.btn_dangky.ImageOptions.ImageIndex = 9;
            this.btn_dangky.Location = new System.Drawing.Point(328, 14);
            this.btn_dangky.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(194, 37);
            this.btn_dangky.TabIndex = 116;
            this.btn_dangky.Text = "Danh sách đăng ký";
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // lab_dangky
            // 
            this.lab_dangky.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lab_dangky.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_dangky.Appearance.Options.UseFont = true;
            this.lab_dangky.Appearance.Options.UseForeColor = true;
            this.lab_dangky.Location = new System.Drawing.Point(528, 21);
            this.lab_dangky.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lab_dangky.Name = "lab_dangky";
            this.lab_dangky.Size = new System.Drawing.Size(34, 22);
            this.lab_dangky.TabIndex = 117;
            this.lab_dangky.Text = "null";
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 492);
            this.Controls.Add(this.lab_dangky);
            this.Controls.Add(this.btn_dangky);
            this.Controls.Add(this.gc_nhanvien);
            this.Controls.Add(this.btn_rs);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add_data);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_NhanVien";
            this.Text = "Frm_NhanVien";
            this.Load += new System.EventHandler(this.Frm_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_rs;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.SimpleButton btn_add_data;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_print;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.GridControl gc_nhanvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_nhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraEditors.SimpleButton btn_dangky;
        private DevExpress.XtraEditors.LabelControl lab_dangky;
    }
}