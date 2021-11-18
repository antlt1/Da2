using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace App_ThuVien.Report
{
    public partial class Rp_TheBanDoc : DevExpress.XtraReports.UI.XtraReport
    {
        public Rp_TheBanDoc()
        {
            InitializeComponent();
        }
        // var report (:
    ///   public static string hovaten, diachi, mabandoc, ngaylap;

        private void Detail_AfterPrint(object sender, EventArgs e)
        {

        }
        public void add_Val(string hovaten , string diachi)
        {
            lb_hovaten.Text = hovaten;
             lb_diachi.Text = diachi;
            lb_ngaytao.Text = DateTime.Now.ToShortDateString();
            //   barcode.pro
        }
        private void TopMargin_AfterPrint(object sender, EventArgs e)
        {
            // PageSize.Height = 200 ;
            lab_tenthuvien.Text = "THƯ VIỆN AN ĐẠT\nCần Thơ";
           
           
        }
    }
}
