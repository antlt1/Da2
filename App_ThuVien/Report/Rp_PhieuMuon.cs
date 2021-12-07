using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using Test_Sqlite.Class;

namespace App_ThuVien.Report
{
    public partial class Rp_PhieuMuon : DevExpress.XtraReports.UI.XtraReport
    {
        public Rp_PhieuMuon()
        {
            InitializeComponent();
        }
        Getting_UI G_U = new Getting_UI();
        DataTable dt = new DataTable();
       public void load_val(string id_pm)
        {
           // dl vào lable
            lb_id.Text += id_pm;
            lb_name.Text += G_U.mysqli_ex_data(string.Format("SELECT b.hoten as 'Tên bạn đọc' FROM phieu_muonsach pm , bandoc b WHERE pm.id_ngmuon = b.id_TaiKhoan and pm.id_muonsach = {0}",id_pm));
            lb_ngaylap.Text += DateTime.Now.ToShortDateString();
           // list sách mượn
            xrTable1.BeginInit();
            dt = G_U.mysqli_ex_value_tb(string.Format("SELECT s.ten_sach as 'Tên sách' , ttm.ngaytra as 'Ngày trả' FROM sach s , phieu_muonsach pm , thongtin_muon ttm where ttm.id_tt_muon = pm.id_tt_muonsach and s.id_sach = ttm.id_sach and pm.id_muonsach = {0}",id_pm));
           foreach (DataRow dr in dt.Rows)
            {
                xtensach = new XRTableCell();
                xtien = new XRTableCell();
                rowphieu = new XRTableRow();
                xtensach.Text = dr["Tên sách"].ToString();
                xtien.Text = DateTime.Parse(dr["Ngày trả"].ToString()).ToShortDateString();
                rowphieu.Cells.Add(xtensach);
                rowphieu.Cells.Add(xtien);
                xrTable1.Rows.Add(rowphieu);
              
            }
            xrTable1.EndInit();
        }
    }
}
