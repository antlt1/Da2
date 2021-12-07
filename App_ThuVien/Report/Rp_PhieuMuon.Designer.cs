namespace App_ThuVien.Report
{
    partial class Rp_PhieuMuon
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.rowphieu = new DevExpress.XtraReports.UI.XRTableRow();
            this.xtensach = new DevExpress.XtraReports.UI.XRTableCell();
            this.xtien = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_name = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_ngaylap = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_id = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 96F;
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 96F;
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lb_id,
            this.lb_ngaylap,
            this.xrLabel1,
            this.xrTable1,
            this.lb_name});
            this.Detail.Dpi = 96F;
            this.Detail.HeightF = 234.5067F;
            this.Detail.Name = "Detail";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Dpi = 96F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(86.66669F, 136.6667F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.rowphieu});
            this.xrTable1.SizeF = new System.Drawing.SizeF(414.6667F, 24F);
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // rowphieu
            // 
            this.rowphieu.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xtensach,
            this.xtien});
            this.rowphieu.Dpi = 96F;
            this.rowphieu.Name = "rowphieu";
            this.rowphieu.Weight = 1D;
            // 
            // xtensach
            // 
            this.xtensach.Dpi = 96F;
            this.xtensach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xtensach.Multiline = true;
            this.xtensach.Name = "xtensach";
            this.xtensach.StylePriority.UseFont = false;
            this.xtensach.Text = "Tên sách";
            this.xtensach.Weight = 1.4335664335664335D;
            // 
            // xtien
            // 
            this.xtien.Dpi = 96F;
            this.xtien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.xtien.Multiline = true;
            this.xtien.Name = "xtien";
            this.xtien.StylePriority.UseFont = false;
            this.xtien.Text = "Ngày trả";
            this.xtien.Weight = 1.4662003950639204D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 96F;
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 20F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(156.6666F, 50.58667F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(283.3333F, 41.41333F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "PHIẾU MƯỢN SÁCH";
            // 
            // lb_name
            // 
            this.lb_name.Dpi = 96F;
            this.lb_name.LocationFloat = new DevExpress.Utils.PointFloat(86.66669F, 92F);
            this.lb_name.Multiline = true;
            this.lb_name.Name = "lb_name";
            this.lb_name.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lb_name.SizeF = new System.Drawing.SizeF(226F, 22.07999F);
            this.lb_name.Text = "Họ  tên :";
            // 
            // lb_ngaylap
            // 
            this.lb_ngaylap.Dpi = 96F;
            this.lb_ngaylap.LocationFloat = new DevExpress.Utils.PointFloat(10F, 202.4267F);
            this.lb_ngaylap.Multiline = true;
            this.lb_ngaylap.Name = "lb_ngaylap";
            this.lb_ngaylap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lb_ngaylap.SizeF = new System.Drawing.SizeF(192F, 22.07999F);
            this.lb_ngaylap.Text = "Ngày lập :";
            // 
            // lb_id
            // 
            this.lb_id.Dpi = 96F;
            this.lb_id.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
            this.lb_id.Multiline = true;
            this.lb_id.Name = "lb_id";
            this.lb_id.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lb_id.SizeF = new System.Drawing.SizeF(204F, 22.08F);
            this.lb_id.Text = "Mã phiếu mượn :";
            // 
            // Rp_PhieuMuon
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Dpi = 96F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 399;
            this.PageWidth = 600;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PaperName = "Custom";
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels;
            this.SnapGridSize = 12.5F;
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow rowphieu;
        private DevExpress.XtraReports.UI.XRTableCell xtensach;
        private DevExpress.XtraReports.UI.XRTableCell xtien;
        private DevExpress.XtraReports.UI.XRLabel lb_ngaylap;
        private DevExpress.XtraReports.UI.XRLabel lb_name;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lb_id;

    }
}
