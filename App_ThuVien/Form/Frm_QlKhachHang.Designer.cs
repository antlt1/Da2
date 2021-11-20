
namespace App_ThuVien.Form
{
    partial class Frm_QlKhachHang
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gkhachhang = new DevExpress.XtraGrid.GridControl();
            this.gvkhachhang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_print = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_rs = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add_data = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gkhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvkhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).BeginInit();
            this.SuspendLayout();
            // 
            // gkhachhang
            // 
            this.gkhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gkhachhang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gkhachhang.Location = new System.Drawing.Point(1, 40);
            this.gkhachhang.MainView = this.gvkhachhang;
            this.gkhachhang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gkhachhang.Name = "gkhachhang";
            this.gkhachhang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_print});
            this.gkhachhang.Size = new System.Drawing.Size(789, 317);
            this.gkhachhang.TabIndex = 0;
            this.gkhachhang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvkhachhang});
            // 
            // gvkhachhang
            // 
            this.gvkhachhang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gvkhachhang.DetailHeight = 295;
            this.gvkhachhang.GridControl = this.gkhachhang;
            this.gvkhachhang.Name = "gvkhachhang";
            this.gvkhachhang.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvkhachhang.OptionsSelection.MultiSelect = true;
            this.gvkhachhang.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvkhachhang.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gvkhachhang.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gvkhachhang.OptionsView.ShowGroupPanel = false;
            this.gvkhachhang.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvkhachhang_SelectionChanged);
            this.gvkhachhang.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvkhachhang_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã khách hàng";
            this.gridColumn1.FieldName = "id_TaiKhoan";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ và Tên";
            this.gridColumn2.FieldName = "hoten";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 124;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số Điện Thoại";
            this.gridColumn3.FieldName = "sdt";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 112;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa Chỉ";
            this.gridColumn4.FieldName = "diachi";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 131;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số Lần Đọc";
            this.gridColumn5.FieldName = "solandoc";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 65;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số Lần Mượn";
            this.gridColumn6.FieldName = "solanmuon";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 68;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Điểm Thân Thiện";
            this.gridColumn7.FieldName = "diem_thanthien";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            this.gridColumn7.Width = 61;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Trạng Thái";
            this.gridColumn8.FieldName = "trangthai";
            this.gridColumn8.MinWidth = 23;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 9;
            this.gridColumn8.Width = 73;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "In thẻ";
            this.gridColumn9.ColumnEdit = this.btn_print;
            this.gridColumn9.FieldName = "in";
            this.gridColumn9.MinWidth = 23;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 87;
            // 
            // btn_print
            // 
            this.btn_print.AutoHeight = false;
            editorButtonImageOptions6.Image = global::App_ThuVien.Properties.Resources.printernetwork_16x16;
            this.btn_print.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_print.Name = "btn_print";
            this.btn_print.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_rs
            // 
            this.btn_rs.ImageOptions.ImageIndex = 9;
            this.btn_rs.Location = new System.Drawing.Point(9, 4);
            this.btn_rs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_rs.Name = "btn_rs";
            this.btn_rs.Size = new System.Drawing.Size(81, 31);
            this.btn_rs.TabIndex = 110;
            this.btn_rs.Text = "Làm mới";
            this.btn_rs.Click += new System.EventHandler(this.btn_rs_Click);
            // 
            // btn_del
            // 
            this.btn_del.ImageOptions.ImageIndex = 9;
            this.btn_del.Location = new System.Drawing.Point(180, 4);
            this.btn_del.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(81, 31);
            this.btn_del.TabIndex = 109;
            this.btn_del.Text = "Xoá";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add_data
            // 
            this.btn_add_data.ImageOptions.ImageIndex = 9;
            this.btn_add_data.Location = new System.Drawing.Point(95, 4);
            this.btn_add_data.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_add_data.Name = "btn_add_data";
            this.btn_add_data.Size = new System.Drawing.Size(81, 31);
            this.btn_add_data.TabIndex = 108;
            this.btn_add_data.Text = "Thêm";
            this.btn_add_data.Click += new System.EventHandler(this.btn_add_data_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_QlKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 355);
            this.Controls.Add(this.btn_rs);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add_data);
            this.Controls.Add(this.gkhachhang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_QlKhachHang";
            this.Text = "Frm_QlKhachHang";
            this.Load += new System.EventHandler(this.Frm_QlKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gkhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvkhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gkhachhang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvkhachhang;
        private DevExpress.XtraEditors.SimpleButton btn_rs;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.SimpleButton btn_add_data;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_print;
    }
}