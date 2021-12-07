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
                mof_lydo = "Mất sách";
                get_diem(mof_lydo);
                double tong = double.Parse(G_U.mysqli_ex_data(string.Format("select gia from sach where id_sach = {0}", ma_sach)));
                double t = tong * 0.20;
                tien_phat = ((tong - t) + int.Parse(tien_hientai)).ToString();
                text_lydo.Text = lydo + "\n"+tien + tien_phat.ToString();
                pn_hu_giay.Hide();
            }else if (cbx_lydo.Text == "Hư sách")
            {
                get_diem(mof_lydo);
                pn_hu_giay.Show();
                mof_lydo = "Hư sách";
               text_lydo.Text = lydo + "\n" + 
                    "Số giấy đã hư hỏng : \n"
                    + tien;
            }
            else {
                pn_hu_giay.Hide();
            } /// quá hạn

        }
        string mof_lydo, id_bandoc, tien_phat, tien_hientai, src, id_tt;
        public int get_diem(string term)
        {
            int trangthai;
            if (term == "Mất sách")
            {
                trangthai = 3;
            }
            else
            {
                trangthai = 2;
            }
            string diem = Setting_sys.getting_src_file("DiemThanThien.txt");
            int count = 0;
            foreach (char i in diem)
            {
                if (i == ',')
                {
                    if (count == trangthai)
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
        private void btn_phat_Click(object sender, EventArgs e) // btn report in phiếu phạt
        {

            //  Setting_sys.mess(mof_lydo+id_bandoc);
            var frm_in = new App_ThuVien.Console.In_PhieuPhat();
            tien_phat = ( int.Parse(tien_hientai) +  int.Parse(tien_phat)).ToString();
            try
            {
                G_U.ex_cmd(string.Format("insert into phat values({0},{1},{2},{3},{4},'{5}','{6}')",
                G_U.creater_id("id_phat", "phat"), id_tt, ma_sach, App_ThuVien.FrmThuVien.id_user_name, tien_phat, mof_lydo, string.Format("{0:yyyy/MM/dd}", DateTime.Now)));
                // land other
            string term_cmd = string.Format("update thongtin_muon set trangthai = '{0}' where id_tt_muon = {1} and id_sach = {2}",
                        "Đã trả", G_U.mysqli_ex_data(string.Format("select id_tt_muonsach from phieu_muonsach where id_muonsach = {0}", ma_pm)), ma_sach);
            G_U.ex_cmd(term_cmd);
            int soluong = int.Parse(G_U.mysqli_ex_data(
               string.Format("select soluong from sach where id_sach = {0}", ma_sach))) + 1;
            G_U.ex_cmd(string.Format("update sach set soluong = {0} where id_sach = {1}", soluong, ma_sach));
            // cộng điẻm thân thiện vÀ sô lần mượn
           // string id_ngmuon = G_U.mysqli_ex_data(string.Format("SELECT id_ngmuon FROM phieu_muonsach WHERE id_muonsach = {0}", ma_pm));
            int diem_thanthien = int.Parse(G_U.mysqli_ex_data(string.Format("select diem_thanthien from bandoc where id_taikhoan = {0}", id_bandoc))) -  get_diem(mof_lydo);
            string so_lan_muon = G_U.mysqli_ex_data(string.Format("select solanmuon from bandoc where id_taikhoan = {0}", id_bandoc));
            G_U.ex_cmd(string.Format("update bandoc set diem_thanthien = {0} , solanmuon = {1} where id_taikhoan = {2}", diem_thanthien, int.Parse(so_lan_muon) + 1, id_bandoc));
            // try vaans csdl 
            frm_in.creater_in(lb_ngmuon.Text, lb_sach.Text, tien_phat);
            frm_in.Show();
            this.Close();
            App_ThuVien.Form.Frm_QlMuon.check = false;
            //Setting_sys.mess("Đã trả thành công !"+ diem_thanthien + " " + get_diem(mof_lydo));

            }
            catch (Exception ex)
            {
                Setting_sys.mess(ex.ToString());
            }
            
        }

        private void txt_huhong_EditValueChanged(object sender, EventArgs e)
        {
            if(txt_huhong.Text.Length > 0 )
            {
                int num;
                if(int.TryParse(txt_huhong.Text , out num) == true)
                {
                    tien_phat = (num * 1500).ToString();
                    text_lydo.Text = string.Format("{0} \nSố giấy đã hư : {1}\nSố tiền phải trả: {2}", mof_lydo,num,tien_phat);
                }
                else
                {
                    text_lydo.Text = null;
                }
            }
          
        }

        private void pic_help_Click(object sender, EventArgs e)
        {
            Setting_sys.mess("Lưu ý đối với việc mất sách sẽ phạt giá sách - 20% \nViệc làm hư sách sẽ tính 1 trang hư sách sẽ là 2000vnđ");
        }

        private void Pick_Phat_Load(object sender, EventArgs e)
        {
            pn_hu_giay.Hide();
            id_tt = G_U.mysqli_ex_data(string.Format("SELECT pm.id_tt_muonsach FROM phieu_muonsach pm WHERE pm.id_muonsach = {0}",ma_pm));
            id_bandoc =
          G_U.mysqli_ex_data(string.Format(
                  "SELECT bd.id_taikhoan FROM thongtin_muon tt , phieu_muonsach pm , bandoc bd WHERE tt.id_tt_muon = {0} " +
                  " and tt.id_tt_muon = pm.id_tt_muonsach and pm.id_ngmuon = bd.id_TaiKhoan and tt.id_sach = {1}", id_tt, ma_sach));
            tien_hientai = G_U.mysqli_ex_data(string.Format("select tien from thongtin_muon where id_tt_muon = {0} and id_sach = {1}",id_tt,ma_sach));            lb_ngayphat.Text = DateTime.Now.ToShortDateString() + "Vào lúc: "+DateTime.Now.ToShortTimeString();
            lb_ngmuon.Text = G_U.mysqli_ex_data(string.Format(
                "SELECT bd.hoten FROM thongtin_muon tt , phieu_muonsach pm , bandoc bd WHERE tt.id_tt_muon = {0} " +
                " and tt.id_tt_muon = pm.id_tt_muonsach and pm.id_ngmuon = bd.id_TaiKhoan and tt.id_sach = {1}", id_tt, ma_sach));
            lb_sach.Text = G_U.mysqli_ex_data(string.Format(
                "SELECT s.ten_sach FROM thongtin_muon tt , sach s where tt.id_sach = s.id_sach and tt.id_sach = {0}", ma_sach));
        }
    }
}