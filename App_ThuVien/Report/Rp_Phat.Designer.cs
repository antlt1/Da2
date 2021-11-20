
namespace App_ThuVien.Report
{
    partial class Rp_Phat
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
            this.lab_tenthuvien = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_hovaten = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_name_book = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_ngaytao = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_money = new DevExpress.XtraReports.UI.XRLabel();
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
            this.lb_money,
            this.lab_tenthuvien,
            this.xrLabel1,
            this.lb_hovaten,
            this.lb_name_book,
            this.lb_ngaytao});
            this.Detail.Dpi = 96F;
            this.Detail.HeightF = 270F;
            this.Detail.Name = "Detail";
            this.Detail.AfterPrint += new System.EventHandler(this.Detail_AfterPrint);
            // 
            // lab_tenthuvien
            // 
            this.lab_tenthuvien.Dpi = 96F;
            this.lab_tenthuvien.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lab_tenthuvien.Multiline = true;
            this.lab_tenthuvien.Name = "lab_tenthuvien";
            this.lab_tenthuvien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lab_tenthuvien.SizeF = new System.Drawing.SizeF(126.6666F, 55.41333F);
            this.lab_tenthuvien.Text = "Tên Thư Viện";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Dpi = 96F;
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(38.66677F, 55.41333F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(157.3332F, 33.41333F);
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "PHIẾU PHẠT";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lb_hovaten
            // 
            this.lb_hovaten.BorderColor = System.Drawing.Color.Transparent;
            this.lb_hovaten.Dpi = 96F;
            this.lb_hovaten.LocationFloat = new DevExpress.Utils.PointFloat(9.999994F, 88.82666F);
            this.lb_hovaten.Multiline = true;
            this.lb_hovaten.Name = "lb_hovaten";
            this.lb_hovaten.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lb_hovaten.SizeF = new System.Drawing.SizeF(242F, 22.08F);
            this.lb_hovaten.StylePriority.UseBorderColor = false;
            this.lb_hovaten.Text = "Họ và Tên : ";
            // 
            // lb_name_book
            // 
            this.lb_name_book.BorderColor = System.Drawing.Color.Transparent;
            this.lb_name_book.Dpi = 96F;
            this.lb_name_book.LocationFloat = new DevExpress.Utils.PointFloat(9.999994F, 126.1067F);
            this.lb_name_book.Multiline = true;
            this.lb_name_book.Name = "lb_name_book";
            this.lb_name_book.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lb_name_book.SizeF = new System.Drawing.SizeF(242F, 22.08001F);
            this.lb_name_book.StylePriority.UseBorderColor = false;
            this.lb_name_book.Text = "Sách :";
            // 
            // lb_ngaytao
            // 
            this.lb_ngaytao.BorderColor = System.Drawing.Color.Transparent;
            this.lb_ngaytao.Dpi = 96F;
            this.lb_ngaytao.LocationFloat = new DevExpress.Utils.PointFloat(10F, 237.92F);
            this.lb_ngaytao.Multiline = true;
            this.lb_ngaytao.Name = "lb_ngaytao";
            this.lb_ngaytao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lb_ngaytao.SizeF = new System.Drawing.SizeF(164F, 22.08F);
            this.lb_ngaytao.StylePriority.UseBorderColor = false;
            this.lb_ngaytao.Text = "Ngày phạt : ";
            // 
            // lb_money
            // 
            this.lb_money.BorderColor = System.Drawing.Color.Transparent;
            this.lb_money.Dpi = 96F;
            this.lb_money.LocationFloat = new DevExpress.Utils.PointFloat(10F, 158.24F);
            this.lb_money.Multiline = true;
            this.lb_money.Name = "lb_money";
            this.lb_money.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lb_money.SizeF = new System.Drawing.SizeF(242F, 22.08001F);
            this.lb_money.StylePriority.UseBorderColor = false;
            this.lb_money.Text = "Tiền phạt : ";
            // 
            // Rp_Phat
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Dpi = 96F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 399;
            this.PageWidth = 266;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels;
            this.SnapGridSize = 12.5F;
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel lb_money;
        private DevExpress.XtraReports.UI.XRLabel lab_tenthuvien;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lb_hovaten;
        private DevExpress.XtraReports.UI.XRLabel lb_name_book;
        private DevExpress.XtraReports.UI.XRLabel lb_ngaytao;
    }
}
