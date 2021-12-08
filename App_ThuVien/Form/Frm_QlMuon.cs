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
using ThuVien.Class;
using App_ThuVien.Class;
using DevExpress.XtraSplashScreen;
using System.Threading;
using App_ThuVien.Console;

namespace App_ThuVien.Form
{
    public partial class Frm_QlMuon : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public Frm_QlMuon()
        {
            InitializeComponent();
        }
       
        #region Khai báo biến
        //getting csdl 
        Getting_UI G_U = new Getting_UI();
        //getting data
        bool giahan, phat;
        App_ThuVien.Console.Pick_Phat frm_phat = new Console.Pick_Phat();
        DataTable dt;
        // val for table
       public static string ma_sach , result_frm;
        public static bool check ,  check_time;
        public static char status_char_choose = ' ';
        #endregion
        public void ex_data_user()
        {
            // set val chok các grid 
            guser.DataSource = G_U.mysqli_ex_value_tb("select t.id_taikhoan as 'id_tk' , t.sdt as 'sdt'" +
                ",t.hoten  as 'hovaten' from bandoc t");
        }
        private void clear_trash()
        {
            ma_sach = " ";
           string  vui =  ma_sach;
        }
        // load pm
        void load_pm(string id_ngmuon)
        { 
          string  more_query= (id_ngmuon != "")? "and pm.idngmuon = "+id_ngmuon:"";
            gc_pm.DataSource = G_U.mysqli_ex_value_tb(
               string.Format("select pm.id_muonsach as 'id_muonsach', pm.id_tt_muonsach as 'id_tt_muonsach' , b.hoten as 'ten_bd', t.hoten as 'ten_nv' , pm.id_ngmuon , pm.id_taikhoan_lap  from phieu_muonsach pm , taikhoan t , bandoc b where pm.id_ngmuon = b.id_TaiKhoan and pm.id_taikhoan_lap = t.id_TaiKhoan {0}",more_query));
        }
       // laod thông tin phiếu mượn
        void load_ttm(string id_bd,string id_pm)
        {
            string more_query = (id_bd != "empty") ? "and bd.id_taikhoan = " + id_bd : "",
                   one_more_query = (id_pm != "empty") ? "and pm.id_muonsach = " + id_pm : "";
            dt = G_U.mysqli_ex_value_tb(string.Format("SELECT bd.id_taikhoan as 'id_bandoc', pm.id_muonsach as 'ma_pm' , ttm.tien, pm.id_tt_muonsach as 'id_ttm' , s.id_sach as 'masach'  ,  s.ten_sach as 'Tên sách', ttm.ngaymuon as 'Ngày mượn', " +
                "ttm.ngaytra as 'Ngày trả', ttm.trangthai as 'Trạng thái'  FROM thongtin_muon ttm, sach s , phieu_muonsach pm , bandoc bd  WHERE ttm.id_sach = s.id_sach "+
                "and pm.id_ngmuon = bd.id_TaiKhoan and pm.id_tt_muonsach = ttm.id_tt_muon {0} {1}  order by (s.id_sach) asc", more_query, one_more_query));
            gcmuon.DataSource = dt;
        }
        DateTime dtnow, dtNgTra,dtNgMuon;
        //
        #region Tính phạt quá hạn và cập nhật trạng thái của người mượn
        void trangthai()
        {
            dt = G_U.mysqli_ex_value_tb("SELECT bd.id_taikhoan as 'id_bandoc', pm.id_muonsach as 'ma_pm' , ttm.tien, pm.id_tt_muonsach as 'id_ttm' , s.id_sach as 'masach'  ,  s.ten_sach as 'Tên sách', ttm.ngaymuon as 'Ngày mượn', " +
                "ttm.ngaytra as 'Ngày trả', ttm.trangthai as 'Trạng thái'  FROM thongtin_muon ttm, sach s , phieu_muonsach pm , bandoc bd  WHERE ttm.id_sach = s.id_sach " +
                "and pm.id_ngmuon = bd.id_TaiKhoan and pm.id_tt_muonsach = ttm.id_tt_muon order by (s.id_sach) asc");
            string status = "";
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Trạng thái"].ToString() != "Đã trả")
                {
                    // check quá hạn chưa
                    dtnow = DateTime.Now;
                    dtNgMuon = DateTime.Parse(dr["Ngày mượn"].ToString());
                    dtNgTra = DateTime.Parse(dr["Ngày trả"].ToString());
                    status = (dtnow > dtNgTra) ? "Quá hạn" : "Đang mượn";
                    // Gán vô csdl trạng thái

                    if (status == "Đang mượn")
                    {
                        PhiTien(dr["id_ttm"].ToString(), dr["masach"].ToString(), dtNgMuon, dtNgTra, false);
                    }
                    else
                    {
                        PhiTien(dr["id_ttm"].ToString(), dr["masach"].ToString(), dtNgMuon, dtNgTra, true);
                    }
                }
            }
            dt.Clear();
        }
        void PhiTien(string id_ttm,string id_sach ,DateTime dt_muon, DateTime dt_tra , bool quahan)
        {
            DateTime now = DateTime.Now;
            int reslut = ((now - dt_muon).Days+1) * 1000; // tiền khi chưa quá hạn
         //  
            string status = "Đang mượn";
            if (quahan == true) //quá hạn
            {
                status = "Quá hạn";
                reslut = (((now - dt_tra).Days + 1) * 2000) + (((dt_tra - dt_muon).Days + 1) * 1000); // quá hạn thì 2k 1 ngày
            }
            G_U.ex_cmd(string.Format("update thongtin_muon set tien = {0} , trangthai = '{1}' where id_tt_muon = {2} and  id_sach = {3}", reslut,status,
                               id_ttm, id_sach));  
        }
        #endregion
        // sự  kiện tô màu báo sách quá hạn trả

        //
        // sự kiện  onload 
        private void Frm_QlMuon_Load(object sender, EventArgs e)
        {
            gridColumn7.Visible = false;
            //load phiêu mượn
           
            load_pm("");
            trangthai();
            load_ttm("empty", "empty");
            ex_data_user();
        }
        string id_tt_pm;
        private void gvuser_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            load_ttm(gvuser.GetRowCellValue(e.RowHandle, "id_tk").ToString(), "empty");
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
            if(giahan == true)
            {
                if (check_get_time == true)
                {
                    giahan = false;
                    check_get_time = false;      
                    G_U.ex_cmd(string.Format("update thongtin_muon set ngaytra = '{0}' " +
                        "where id_tt_muon = {1} and id_sach = {2}", fr1.get_dt(),
                        id_tt_pm, ma_sach_t));
                    Setting_sys.mess("Gia hạn thành công !");
                    Frm_QlMuon_Load(sender, e);
                    timer1.Stop();
                }
                else if (phat == true)
                {
                    if (check == true)
                    {
                        timer1.Stop();
                        phat = false;
                        Frm_QlMuon_Load(sender, e);
                    }

                }
            }
           
        }
        string ma_pm, ma_sach_t;
        #region GV mượn cell click có phạt , mượn trả , gia hạn
        private void gvmuon_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            ma_pm = gvmuon.GetRowCellValue(e.RowHandle, "ma_pm").ToString();
            id_tt_pm = G_U.mysqli_ex_data(string.Format("select id_tt_muonsach from phieu_muonsach where id_muonsach = {0}", ma_pm)).ToString();
                        ma_sach_t = gvmuon.GetRowCellValue(e.RowHandle, "masach").ToString();
                        string check_btn = gvmuon.FocusedColumn.Caption;
                        if (check_btn == "Phạt")
                        {
                            if (check_datra() == true)
                            {
                                phat = true;
                                frm_phat.val(ma_pm, ma_sach_t);
                                frm_phat.ShowDialog();
                                timer1.Start();
                            }

                        }
                        else if (check_btn == "Gia hạn")
                        {
                            if (check_datra() == true)
                            {
                                timer1.Start();
                                giahan = true;
                                fr1.set_min_date(DateTime.Now);
                                fr1.text = "Chọn ngày trả";
                                fr1.ShowDialog();
                            }                       
                        }
                        else if (check_btn == "Trả sách")
                        {
                            if (check_datra() == true)
                            {
                                if (XtraMessageBox.Show("Bạn có chắc trả sách ?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                          == DialogResult.Yes)
                                {
                                    string term_cmd = string.Format("update thongtin_muon set trangthai = '{0}' where id_tt_muon = {1} and id_sach = {2}",
                                     "Đã trả", G_U.mysqli_ex_data(string.Format("select id_tt_muonsach from phieu_muonsach where id_muonsach = {0}", ma_pm)), ma_sach_t);
                                    G_U.ex_cmd(term_cmd);
                                    int soluong = int.Parse(G_U.mysqli_ex_data(
                                       string.Format("select soluong from sach where id_sach = {0}", ma_sach_t))) + 1;
                                    G_U.ex_cmd(string.Format("update sach set soluong = {0} where id_sach = {1}", soluong, ma_sach_t));
                                    Setting_sys.mess("Đã trả thành công !");
                                    // cộng điẻm thân thiện vÀ sô lần mượn
                                    string id_ngmuon = G_U.mysqli_ex_data(string.Format("SELECT id_ngmuon FROM phieu_muonsach WHERE id_muonsach = {0}", ma_pm));
                                    int diem_thanthien = int.Parse(G_U.mysqli_ex_data(string.Format("select diem_thanthien from bandoc where id_taikhoan = {0}", id_ngmuon))) + get_diem();
                                    string so_lan_muon = G_U.mysqli_ex_data(string.Format("select solanmuon from bandoc where id_taikhoan = {0}", id_ngmuon));
                                    G_U.ex_cmd(string.Format("update bandoc set diem_thanthien = {0} , solanmuon = {1} where id_taikhoan = {2}", diem_thanthien, int.Parse(so_lan_muon) + 1, id_ngmuon));
                                    status_char_choose = ' ';
                                    Frm_QlMuon_Load(sender, e);
                                }
                            }
                        }
        }
        #endregion kết thúc

        private void btn_changer_Click(object sender, EventArgs e)
        {
        }
        bool check_datra()
        {
            if (gvmuon.GetRowCellValue(gvmuon.FocusedRowHandle, "Trạng thái").ToString() != "Đã trả")
            {
                return true;
            }
            else
            {
                Setting_sys.mess("Sách đã trả không thể sửa đổi !");
            }
            return false;
        }

        private void groupBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (Keys.F5 == e.KeyCode)
            {
                load_pm("");
                ex_data_user();
            SplashScreenManager.ShowForm(this, typeof(WaitingForMe), true, true, false);
            for (int i = 1; i <= 100; i++)
            {
                SplashScreenManager.Default.SetWaitFormCaption("Đang làm mới");
                SplashScreenManager.Default.SetWaitFormDescription("vui lòng đợi"+i.ToString() + "%");
                Thread.Sleep(20);
            }
            SplashScreenManager.CloseForm(false);

                load_ttm("empty", "empty");  
            }
        }
       
    }
}