
namespace App_ThuVien.Console
{
    partial class SuaDiemThanThien
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
            this.gc_diemthanthien = new DevExpress.XtraGrid.GridControl();
            this.gv_diemthanthien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_diemthanthien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_diemthanthien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_diemthanthien
            // 
            this.gc_diemthanthien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_diemthanthien.Location = new System.Drawing.Point(0, 50);
            this.gc_diemthanthien.MainView = this.gv_diemthanthien;
            this.gc_diemthanthien.Name = "gc_diemthanthien";
            this.gc_diemthanthien.Size = new System.Drawing.Size(681, 56);
            this.gc_diemthanthien.TabIndex = 0;
            this.gc_diemthanthien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_diemthanthien});
            // 
            // gv_diemthanthien
            // 
            this.gv_diemthanthien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gv_diemthanthien.GridControl = this.gc_diemthanthien;
            this.gv_diemthanthien.Name = "gv_diemthanthien";
            this.gv_diemthanthien.OptionsView.ShowGroupPanel = false;
            this.gv_diemthanthien.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_diemthanthien_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Vào Thư Viện";
            this.gridColumn1.FieldName = "ravao";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Thanh Toán";
            this.gridColumn2.FieldName = "thanhtoan";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.Red;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.Caption = "Hư Sách";
            this.gridColumn3.FieldName = "husach";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 112;
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 50);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(681, 56);
            this.fluentDesignFormContainer1.TabIndex = 1;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(681, 50);
            this.fluentDesignFormControl1.TabIndex = 3;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.Red;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.Caption = "Mất Sách";
            this.gridColumn4.FieldName = "matsach";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 112;
            // 
            // SuaDiemThanThien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(681, 106);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.gc_diemthanthien);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.ShowIcon = false;
            this.Name = "SuaDiemThanThien";
            this.Text = "Sửa Điểm Thân Thiện";
            this.Load += new System.EventHandler(this.SuaDiemThanThien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_diemthanthien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_diemthanthien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_diemthanthien;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_diemthanthien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}