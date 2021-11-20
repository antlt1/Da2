using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Test_Sqlite.Class;
using App_ThuVien.Class;

namespace App_ThuVien.Form
{
    public partial class Frm_QlMuon : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public Frm_QlMuon()
        {
            InitializeComponent();
        }
        //getting csdl 
        Getting_UI G_U = new Getting_UI();
        //getting data
        public void ex_data_user()
        {
            // set val chok các grid 
            guser.DataSource = G_U.mysqli_ex_value_tb("select t.id_taikhoan as 'id_tk' , t.sdt as 'sdt'"+
                ",t.hoten  as 'hovaten' from bandoc t");
        }
        DataTable dt;
        // val for table
       public static string ma_sach , result_frm;
        public static bool check ,  check_time;
        public static char status_char_choose = ' ';
        private void clear_trash()
        {
            ma_sach = " ";
           string  vui =  ma_sach;
        }
        public void ex_data_muon(string str)
        {
            dt = G_U.mysqli_ex_value_tb(string.Format(
        "SELECT ttm.tien, pm.id_tt_muonsach  ,  pm.id_muonsach as 'Mã phiếu mượn', s.id_sach as 'masach'  ,  s.ten_sach as 'Tên sách', bd.id_TaiKhoan as" +
        " 'Mã bạn đọc', bd.hoten as 'Họ và Tên', tk.ten_taikhoan as 'Tài khoản lập phiếu'," +
        " ttm.ngaymuon as 'Ngày mượn', ttm.ngaytra as 'Ngày trả', ttm.trangthai as 'Trạng thái'" +
        " FROM phieu_muonsach pm, thongtin_muon ttm, sach s, taikhoan tk, bandoc bd WHERE pm.id_ngmuon" +
        " = bd.id_TaiKhoan and pm.id_taikhoan_lap = tk.id_TaiKhoan and ttm.id_sach = s.id_sach and" +
        " pm.id_tt_muonsach = ttm.id_tt_muon {0}", str));
            gmuon.DataSource = dt;
        }
        void check_ngaymuon(string str)
        {
            dt = G_U.mysqli_ex_value_tb(string.Format(
        "SELECT ttm.tien, pm.id_tt_muonsach  ,  pm.id_muonsach as 'Mã phiếu mượn', s.id_sach as 'masach'  ,  s.ten_sach as 'Tên sách', bd.id_TaiKhoan as" +
        " 'Mã bạn đọc', bd.hoten as 'Họ và Tên', tk.ten_taikhoan as 'Tài khoản lập phiếu'," +
        " ttm.ngaymuon as 'Ngày mượn', ttm.ngaytra as 'Ngày trả', ttm.trangthai as 'Trạng thái'" +
        " FROM phieu_muonsach pm, thongtin_muon ttm, sach s, taikhoan tk, bandoc bd WHERE pm.id_ngmuon" +
        " = bd.id_TaiKhoan and pm.id_taikhoan_lap = tk.id_TaiKhoan and ttm.id_sach = s.id_sach and" +
        " pm.id_tt_muonsach = ttm.id_tt_muon {0}", str));
            foreach (DataRow dr in dt.Rows) // check quá hạn
            {
                //XtraMessageBox.Show(dr["Trạng thái"].ToString());
                if (dr["Trạng thái"].ToString() != "Đã trả")
                {
                    if (DateTime.Parse(dr["Ngày trả"].ToString()) < DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                        dr["Trạng thái"] = "Quá Hạn";
                       
                    }
                    else
                    {
                        dr["Trạng thái"] = "Đang mượn";
                    }
                    dt.AcceptChanges();
                    dr.SetModified();
                    TimeSpan dtime = DateTime.Now - DateTime.Parse(dr["Ngày mượn"].ToString());
                    if(dtime.Days >= 0)
                    {
                        G_U.ex_cmd(string.Format("update thongtin_muon set tien = {0} where id_tt_muon = {1} and  id_sach = {2}",dtime.Days * 1000,
                            dr["id_tt_muonsach"], dr["masach"]));
                    }
                    G_U.ex_cmd(string.Format("update thongtin_muon set trangthai =" +
                        " 'Quá Hạn' where id_tt_muon = {0} and id_sach = {1}  ",
                       G_U.mysqli_ex_data(string.Format("select id_tt_muonsach from phieu_muonsach " +
                       "where id_muonsach = {0} ", dr["Mã phiếu mượn"])), dr["masach"]));
                }
            }
        }
        // sự  kiện tô màu báo sách quá hạn trả
        void quahan(DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
          //  gvmuon.Appearance.BackColor = Color.Red;
          //gvmuon.Columns.
          //  e.Appearance.BackColor = Color.Red;
        }
        // sự kiện  onload 
        private void Frm_QlMuon_Load(object sender, EventArgs e)
        {
            
            check_ngaymuon("");
            ex_data_user();
            ex_data_muon("");
        }
        string id_tt_pm;
        private void gvuser_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            ex_data_muon("and pm.id_ngmuon = " + gvuser.GetRowCellValue(e.RowHandle, "id_tk").ToString());
      
        }

        private void btn_changer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }
        public static bool check_get_time;
        App_ThuVien.Console.Pick_Lich fr1 = new App_ThuVien.Console.Pick_Lich();
        int ii = 0;
       public  int get_diem()
        {

            string diem = Setting_sys.getting_src_file("DiemThanThien.txt");
            string src = "";
            int count = 0;
            foreach (char i in diem)
            {
                if (i == ',')
                {
                    if (count == 2)
                    {
                        return int.Parse(src);
                    }
                    src = null;
                    count++;
                }
                else
                {
                    src += i.ToString();
                }
               
            }
            return 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(check_time == true)
            {
                if (status_char_choose == 't') // Trả 
                {
                    check_time = false;
                    if (XtraMessageBox.Show("Bạn có chắc trả sách ?","Hệ thống",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        string term_cmd = string.Format("update thongtin_muon set trangthai = '{0}' where id_tt_muon = {1} and id_sach = {2}",
                         "Đã trả", G_U.mysqli_ex_data(string.Format("select id_tt_muonsach from phieu_muonsach where id_muonsach = {0}", ma_pm)), ma_sach_t);
                        G_U.ex_cmd(term_cmd);
                        int soluong = int.Parse(G_U.mysqli_ex_data(
                           string.Format("select soluong from sach where id_sach = {0}",ma_sach_t))) + 1;
                        G_U.ex_cmd(string.Format("update sach set soluong = {0} where id_sach = {1}",soluong,ma_sach_t));
                        Setting_sys.mess("Đã trả thành công !");
                        // cộng điẻm thân thiện vÀ sô lần mượn
                        string id_ngmuon = G_U.mysqli_ex_data(string.Format("SELECT id_ngmuon FROM phieu_muonsach WHERE id_muonsach = {0}", ma_pm));
                        int diem_thanthien = int.Parse(G_U.mysqli_ex_data(string.Format("select diem_thanthien from bandoc where id_taikhoan = {0}", id_ngmuon))) + get_diem();
                        string so_lan_muon = G_U.mysqli_ex_data(string.Format("select solanmuon from bandoc where id_taikhoan = {0}", id_ngmuon));
                        G_U.ex_cmd(string.Format("update bandoc set diem_thanthien = {0} , solanmuon = {1} where id_taikhoan = {2}", diem_thanthien, int.Parse(so_lan_muon)+1 ,id_ngmuon));
                        status_char_choose = ' ';
                        Frm_QlMuon_Load(sender, e);
                    }
                }
                else if(status_char_choose == ' ')
                {
                    //check_time = false;
                }
                else//gia hạn
                {
                    fr1.set_min_date(DateTime.Now);
                    fr1.text = "Chọn ngày trả";
                    fr1.Show();
                    status_char_choose = ' ';
                }
                if (check_get_time == true)
                {
                    check_time = false;
                    timer1.Stop();
                    G_U.ex_cmd(string.Format("update thongtin_muon set ngaytra = '{0}' " +
                        "where id_tt_muon = {1} and id_sach = {2}", fr1.get_dt(),
                        id_tt_pm, ma_sach_t));
                    status_char_choose = ' ';
                    Frm_QlMuon_Load(sender, e);
                }
            }
           
        }
        string ma_pm, ma_sach_t;

        private void gvmuon_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
           // e.Colum
        }

        private void gvmuon_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            ma_pm = gvmuon.GetRowCellValue(e.RowHandle, "Mã phiếu mượn").ToString();
            id_tt_pm = G_U.mysqli_ex_data(string.Format("select id_tt_muonsach from phieu_muonsach where id_muonsach = {0}", ma_pm)).ToString();
            if (e.Column.FieldName == "masach")
            {
                if (gvmuon.GetRowCellValue(e.RowHandle, "Trạng thái").ToString() != "Đã trả")
                {
                    if (check == false)
                    {
                        ma_pm = gvmuon.GetRowCellValue(e.RowHandle, "Mã phiếu mượn").ToString();
                        ma_sach_t = gvmuon.GetRowCellValue(e.RowHandle, "masach").ToString();
                        var fr_choose = new App_ThuVien.Console.Pick_TrangThai_Muon();
                        fr_choose.add_val(ma_pm, ma_sach_t);
                        fr_choose.Show();
                        check = true;
                        if (check_time == false)
                        {
                            timer1.Start();
                        }
                    }
                    else
                    {
                        Setting_sys.mess("Bạn đã chọn rồi vui lòng xem cửa sổ lại !");
                    }
                }
                else
                {
                    Setting_sys.mess("Sách đã trả không thể sửa đổi !");
                }
            }
        }

        private void btn_changer_Click(object sender, EventArgs e)
        {
        }
    }
}