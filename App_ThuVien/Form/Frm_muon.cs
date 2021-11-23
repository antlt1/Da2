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
using App_ThuVien.Console;
using Test_Sqlite.Class;
using Test_Sqlite;
using App_ThuVien.Class;

namespace App_ThuVien.Form
{
    public partial class Frm_muon : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public Frm_muon()
        {
            InitializeComponent();
        }
        // public các giá trị qua các form picker
       public static bool btime_user, btimebook;
       public static string id_user, id_book;
       public static List<int> id_sach = new List<int>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(btime_user == true)
            {
                lb_tentk.Text = G_U.mysqli_ex_data(string.Format("SELECT hoten FROM bandoc WHERE id_taikhoan = '{0}'",id_user));
                btime_user = false;
                timer1.Stop();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lb_tentk.Text = null;
            gmuon.DataSource = "";
            dt.Clear();
            id_sach.Clear();
            btn_done.Enabled = false;
        }

        private void btn_nguoimuon_Click(object sender, EventArgs e)
        {
            // choose người có tài khoản hoặc chưa coá
            
            if (btime_user == false)
            {
                ChooseNguoiMuon choose_kind_user = new ChooseNguoiMuon();
                choose_kind_user.Show();
                timer1.Start();
             
            }
        }
        // check lập phiếu mượn
        void check_pm()
        {
            if (lb_tentk.Text.Length > 0 && gvmuon.DataRowCount > 0)
            {
                btn_done.Enabled = true;
            }
        }
        private void Frm_muon_Load(object sender, EventArgs e)
        {
            //gridColumn1.Visible = false;
            dt = new DataTable();
            dt.Columns.Add("id_sach",typeof(String));
            dt.Columns.Add("tensach", typeof(String));
            dt.Columns.Add("ngaymuon", typeof(String));
            dt.Columns.Add("ngaytra", typeof(String));
            dt.Columns.Add("trangthai", typeof(String));
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(btimebook == true)
            {
                gmuon.DataSource = dt;
                btimebook = false;
            }
        }
        Getting_UI G_U = new Getting_UI();
        // function add int id =))))
       
        private void btn_done_Click(object sender, EventArgs e)
        {
            if (lb_tentk.Text.ToString() != "")
            {
                DataTable dtrr = G_U.mysqli_ex_value_tb("select id_tt_muon from thongtin_muon order by id_tt_muon asc");
                dtrr.Rows.Add(9999999); // cc ghe chua
                int n = 0, i = 1;
                List<int> l_int = new List<int>();
                foreach (DataRow dtr in dtrr.Rows)
                {
                    l_int.Add(int.Parse(dtrr.Rows[n][0].ToString()));
                    n++;
                }

              
                   foreach(DataRow dr in dt.Rows)
                    {
                        
                   foreach(int ii in l_int)
                    {
                        if (l_int.IndexOf(i) < 0)
                        {
                            G_U.ex_cmd(string.Format("insert into thongtin_muon values ({0},{1},'{2}','{3}',0,'Đang mượn')",
                                i.ToString(),
                                dr["id_sach"].ToString(),
                                dr["ngaymuon"].ToString(),
                                dr["ngaytra"].ToString()));
                            // trừ sl trong kho
                            int soluong = int.Parse(G_U.mysqli_ex_data(string.Format(
                              "select soluong from sach where id_sach = {0}", dr["id_sach"].ToString()))) - 1;
                            G_U.ex_cmd(string.Format("update sach set soluong = {0} where id_sach = {1}", soluong,
                               dr["id_sach"].ToString()));
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    }
                G_U.ex_cmd(string.Format("insert into phieu_muonsach(id_tt_muonsach,id_taikhoan_lap,id_ngmuon) values ({0},{1},{2})",
                    i.ToString(), FrmThuVien.id_user_name.ToString(),id_user));
                XtraMessageBox.Show("Lập phiếu mượn thành công !");
                if(XtraMessageBox.Show("Bạn thực Có muốn In phiếu mượn ? ", "Thông báo", 
                    MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.No == false){
                    // in phiếu
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn người mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon
                    .Warning);
            }
        }

        private void gvmuon_DataSourceChanged(object sender, EventArgs e)
        {
            check_pm();
        }

        private void lb_tentk_TextChanged(object sender, EventArgs e)
        {
            check_pm();
        }

        private void lb_tentk_TextAlignChanged(object sender, EventArgs e)
        {
            check_pm();
        }

        public static DataTable dt;
        private void btn_sach_Click(object sender, EventArgs e)
        {
            if(btimebook == false)
            {
                PickSachMuon fr_picksach = new PickSachMuon();
                fr_picksach.Show();
                timer2.Start();
                check_pm();
            }
            
            

        }
    }
}