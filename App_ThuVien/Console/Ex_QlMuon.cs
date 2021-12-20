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
using System.Threading;
using MySql.Data.MySqlClient;

namespace App_ThuVien.Console
{
    public partial class Ex_QlMuon : DevExpress.XtraEditors.XtraForm
    {
        public Ex_QlMuon()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Getting_UI G_U = new Getting_UI();
        DateTime dtnow, dtNgTra, dtNgMuon;
        public void loading(int seconds)
        {
            splashScreenManager1.ShowWaitForm();

            for (int i = 1; i <= 100; i++)
            {
                splashScreenManager1.SetWaitFormDescription("Đang thực thi lệnh "+i.ToString() + "%");
                Thread.Sleep(seconds);
            }

            splashScreenManager1.CloseWaitForm();
        }
       MySqlConnection conn;
        MySqlCommand cmd;
        #region Tính phạt quá hạn và cập nhật trạng thái của người mượn
        public void trangthai()
        {
            conn = G_U.connect_mysqli();
            conn.Open();
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
            conn.Close();
        }
        void PhiTien(string id_ttm, string id_sach, DateTime dt_muon, DateTime dt_tra, bool quahan)
        {
            DateTime now = DateTime.Now;
            int reslut = ((now - dt_muon).Days + 1) * 1000; // tiền khi chưa quá hạn
            //  
            string status = "Đang mượn";
            if (quahan == true) //quá hạn
            {
                status = "Quá hạn";
                reslut = (((now - dt_tra).Days + 1) * 2000) + (((dt_tra - dt_muon).Days + 1) * 1000); // quá hạn thì 2k 1 ngày
            }
            ex_cmd(string.Format("call uptrangthai({0},{1},'{2}',{3})", id_ttm, id_sach, status, reslut));
        }
        #endregion
        void ex_cmd(string str)
        {
                cmd = new MySqlCommand(str, conn);
                cmd.ExecuteNonQuery();
        }
        private void Ex_QlMuon_Load(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}