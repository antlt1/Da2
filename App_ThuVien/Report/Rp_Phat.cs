using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace App_ThuVien.Report
{
    public partial class Rp_Phat : DevExpress.XtraReports.UI.XtraReport
    {
        private void Detail_AfterPrint(object sender, EventArgs e)
        {
          
          
        }
        public void creater_in(string hoten, string sach, string tien)
        {
            lb_hovaten.Text += hoten;
            lb_money.Text += tien;
            lb_name_book.Text += sach;
            lb_ngaytao.Text += DateTime.Now.ToShortDateString();
        }
        public Rp_Phat()
        {
            InitializeComponent();
           
        }

    }
}
