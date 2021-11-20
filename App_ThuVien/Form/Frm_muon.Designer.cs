namespace App_ThuVien.Form
{
    partial class Frm_muon
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
            this.btn_sach = new DevExpress.XtraEditors.SimpleButton();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gmuon = new DevExpress.XtraGrid.GridControl();
            this.gvmuon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pn_toolheader = new System.Windows.Forms.Panel();
            this.btn_done = new DevExpress.XtraEditors.SimpleButton();
            this.btn_nguoimuon = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tentk = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gmuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmuon)).BeginInit();
            this.pn_toolheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sach
            // 
            this.btn_sach.Location = new System.Drawing.Point(9, 3);
            this.btn_sach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_sach.Name = "btn_sach";
            this.btn_sach.Size = new System.Drawing.Size(87, 29);
            this.btn_sach.TabIndex = 3;
            this.btn_sach.Text = "Sách Mượn";
            this.btn_sach.Click += new System.EventHandler(this.btn_sach_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(257, 68);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(87, 29);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Xoá";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gmuon, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 99);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 245);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // gmuon
            // 
            this.gmuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmuon.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gmuon.Location = new System.Drawing.Point(2, 3);
            this.gmuon.MainView = this.gvmuon;
            this.gmuon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gmuon.Name = "gmuon";
            this.gmuon.Size = new System.Drawing.Size(850, 239);
            this.gmuon.TabIndex = 7;
            this.gmuon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvmuon});
            // 
            // gvmuon
            // 
            this.gvmuon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn1});
            this.gvmuon.DetailHeight = 295;
            this.gvmuon.GridControl = this.gmuon;
            this.gvmuon.Name = "gvmuon";
            this.gvmuon.OptionsSelection.MultiSelect = true;
            this.gvmuon.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvmuon.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gvmuon.OptionsView.ShowGroupPanel = false;
            this.gvmuon.DataSourceChanged += new System.EventHandler(this.gvmuon_DataSourceChanged);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Sách";
            this.gridColumn2.FieldName = "tensach";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày Mượn";
            this.gridColumn3.FieldName = "ngaymuon";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày Trả";
            this.gridColumn4.FieldName = "ngaytra";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Trạng Thái";
            this.gridColumn5.FieldName = "trangthai";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id_sach";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 87;
            // 
            // pn_toolheader
            // 
            this.pn_toolheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pn_toolheader.Controls.Add(this.btn_done);
            this.pn_toolheader.Controls.Add(this.btn_nguoimuon);
            this.pn_toolheader.Controls.Add(this.btn_sach);
            this.pn_toolheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_toolheader.Location = new System.Drawing.Point(0, 41);
            this.pn_toolheader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pn_toolheader.Name = "pn_toolheader";
            this.pn_toolheader.Size = new System.Drawing.Size(854, 38);
            this.pn_toolheader.TabIndex = 8;
            // 
            // btn_done
            // 
            this.btn_done.Enabled = false;
            this.btn_done.Location = new System.Drawing.Point(192, 3);
            this.btn_done.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(87, 29);
            this.btn_done.TabIndex = 11;
            this.btn_done.Text = "Lập Phiếu";
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_nguoimuon
            // 
            this.btn_nguoimuon.Location = new System.Drawing.Point(100, 3);
            this.btn_nguoimuon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_nguoimuon.Name = "btn_nguoimuon";
            this.btn_nguoimuon.Size = new System.Drawing.Size(87, 29);
            this.btn_nguoimuon.TabIndex = 5;
            this.btn_nguoimuon.Text = "Người Mượn";
            this.btn_nguoimuon.Click += new System.EventHandler(this.btn_nguoimuon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên tài khoản : ";
            // 
            // lb_tentk
            // 
            this.lb_tentk.AutoSize = true;
            this.lb_tentk.Location = new System.Drawing.Point(106, 71);
            this.lb_tentk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tentk.Name = "lb_tentk";
            this.lb_tentk.Size = new System.Drawing.Size(0, 17);
            this.lb_tentk.TabIndex = 10;
            this.lb_tentk.TextAlignChanged += new System.EventHandler(this.lb_tentk_TextAlignChanged);
            this.lb_tentk.TextChanged += new System.EventHandler(this.lb_tentk_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(97, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 2);
            this.panel1.TabIndex = 6;
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(854, 41);
            this.toolbarFormControl1.TabIndex = 12;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 41);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(854, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 341);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(854, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 300);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(854, 41);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 300);
            // 
            // Frm_muon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_toolheader);
            this.Controls.Add(this.lb_tentk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_muon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.Load += new System.EventHandler(this.Frm_muon_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gmuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmuon)).EndInit();
            this.pn_toolheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pn_toolheader;
        private DevExpress.XtraEditors.SimpleButton btn_sach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lb_tentk;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton btn_nguoimuon;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gmuon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvmuon;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btn_done;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}