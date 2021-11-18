
namespace App_ThuVien.Report
{
    partial class Rp_TheBanDoc
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.barcode = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_hovaten = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_diachi = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_ngaytao = new DevExpress.XtraReports.UI.XRLabel();
            this.lab_tenthuvien = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Scripts.OnAfterPrint = "TopMargin_AfterPrint_1";
            this.TopMargin.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StyleName = "xrControlStyle1";
            this.TopMargin.AfterPrint += new System.EventHandler(this.TopMargin_AfterPrint);
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.barcode,
            this.xrLabel1,
            this.lb_hovaten,
            this.lb_diachi,
            this.lb_ngaytao,
            this.lab_tenthuvien});
            this.Detail.HeightF = 201.2223F;
            this.Detail.Name = "Detail";
            this.Detail.AfterPrint += new System.EventHandler(this.Detail_AfterPrint);
            // 
            // barcode
            // 
            this.barcode.LocationFloat = new DevExpress.Utils.PointFloat(263.6389F, 154.4168F);
            this.barcode.Name = "barcode";
            this.barcode.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.barcode.SizeF = new System.Drawing.SizeF(142.3611F, 36.80555F);
            this.barcode.Symbology = code128Generator1;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(148.6112F, 22.91667F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(163.8888F, 34.80555F);
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "THẺ BẠN ĐỌC";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lb_hovaten
            // 
            this.lb_hovaten.BorderColor = System.Drawing.Color.Transparent;
            this.lb_hovaten.LocationFloat = new DevExpress.Utils.PointFloat(9.999996F, 68.75F);
            this.lb_hovaten.Multiline = true;
            this.lb_hovaten.Name = "lb_hovaten";
            this.lb_hovaten.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lb_hovaten.SizeF = new System.Drawing.SizeF(252.0833F, 23F);
            this.lb_hovaten.StylePriority.UseBorderColor = false;
            this.lb_hovaten.Text = "Họ và Tên : ";
            // 
            // lb_diachi
            // 
            this.lb_diachi.BorderColor = System.Drawing.Color.Transparent;
            this.lb_diachi.LocationFloat = new DevExpress.Utils.PointFloat(9.999996F, 103.75F);
            this.lb_diachi.Multiline = true;
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lb_diachi.SizeF = new System.Drawing.SizeF(252.0833F, 23.00001F);
            this.lb_diachi.StylePriority.UseBorderColor = false;
            this.lb_diachi.Text = "Địa chỉ : ";
            // 
            // lb_ngaytao
            // 
            this.lb_ngaytao.BorderColor = System.Drawing.Color.Transparent;
            this.lb_ngaytao.LocationFloat = new DevExpress.Utils.PointFloat(9.999996F, 137.8611F);
            this.lb_ngaytao.Multiline = true;
            this.lb_ngaytao.Name = "lb_ngaytao";
            this.lb_ngaytao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lb_ngaytao.SizeF = new System.Drawing.SizeF(170.8333F, 23F);
            this.lb_ngaytao.StylePriority.UseBorderColor = false;
            this.lb_ngaytao.Text = "Ngày tạo : ";
            // 
            // lab_tenthuvien
            // 
            this.lab_tenthuvien.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lab_tenthuvien.Multiline = true;
            this.lab_tenthuvien.Name = "lab_tenthuvien";
            this.lab_tenthuvien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lab_tenthuvien.SizeF = new System.Drawing.SizeF(131.9444F, 57.72222F);
            this.lab_tenthuvien.Text = "Tên Thư Viện";
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // Rp_TheBanDoc
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 243;
            this.PageWidth = 416;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PaperName = "Custom";
            this.ScriptsSource = "\r\nprivate void TopMargin_AfterPrint(object sender, System.EventArgs e) {\r\n\r\n}\r\n\r\n" +
    "private void TopMargin_AfterPrint_1(object sender, System.EventArgs e) {\r\n\r\n}\r\n";
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1});
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.XRBarCode barcode;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lb_hovaten;
        private DevExpress.XtraReports.UI.XRLabel lb_diachi;
        private DevExpress.XtraReports.UI.XRLabel lb_ngaytao;
        private DevExpress.XtraReports.UI.XRLabel lab_tenthuvien;
    }
}
