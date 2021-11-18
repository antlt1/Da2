using App_ThuVien.Class;
using DevExpress.XtraEditors;
using System;
using Test_Sqlite.Class;

namespace App_ThuVien.Console
{
    public partial class Pick_Phat : DevExpress.XtraEditors.XtraForm
    {
        public Pick_Phat()
        {
            InitializeComponent();
        }
        Getting_UI G_U = new Getting_UI();
        string ma_pm, ma_sach;
        public void val(string ma_pm_t ,string ma_sach_t)
        {
            ma_pm = ma_pm_t;
            ma_sach = ma_sach_t;
        }
        string lydo()
        {
            return G_U.mysqli_ex_data(string.Format("select trangthai from "));
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void cbx_lydo_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            string tien = "Số tiền phải trả : ", lydo =  "Lý do : "+cbx_lydo.Text;

           if(cbx_lydo.Text == "Mất sách")
            {
                double tong = double.Parse(G_U.mysqli_ex_data(string.Format("select gia from sach where id_sach = {0}", ma_sach)));
                double t = tong * 0.20;
                tong = tong - t;

                text_lydo.Text = lydo + "\n"+tien + tong.ToString();
            }else if (cbx_lydo.Text == "Hư sách")
            {
                text_lydo.Text = lydo + "\n" + 
                    "Số giấy đã hư hỏng : \n"
                    + tien;
            }
            else { }

        }

        private void btn_phat_Click(object sender, EventArgs e)
        {

        }

        private void pic_help_Click(object sender, EventArgs e)
        {
            Setting_sys.mess("Lưu ý đối với việc mất sách sẽ phạt giá sách - 20% \nViệc làm hư sách sẽ tính 1 trang hư sách sẽ là 2000vnđ");
        }

        private void Pick_Phat_Load(object sender, EventArgs e)
        {
            string id_tt = G_U.mysqli_ex_data(string.Format("SELECT pm.id_tt_muonsach FROM phieu_muonsach pm WHERE pm.id_muonsach = {0}",ma_pm));
          //  string id_ngmuon = 
            lb_ngayphat.Text = DateTime.Now.ToShortDateString() + "Vào lúc: "+DateTime.Now.ToShortTimeString();
            lb_ngmuon.Text = G_U.mysqli_ex_data(string.Format(
                "SELECT bd.hoten FROM thongtin_muon tt , phieu_muonsach pm , bandoc bd WHERE tt.id_tt_muon = {0} " +
                " and tt.id_tt_muon = pm.id_tt_muonsach and pm.id_ngmuon = bd.id_TaiKhoan and tt.id_sach = {1}", id_tt, ma_sach));
            lb_sach.Text = G_U.mysqli_ex_data(string.Format(
                "SELECT s.ten_sach FROM thongtin_muon tt , sach s where tt.id_sach = s.id_sach and tt.id_sach = {0}", ma_sach));
        }
    }
}