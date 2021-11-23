using App_ThuVien.Class;
using App_ThuVien.Console;
using App_ThuVien.Form;
using App_ThuVien.Report;
using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Sqlite;
using Test_Sqlite.Class;

namespace App_ThuVien
{
    public partial class FrmThuVien : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public FrmThuVien()
        {
            InitializeComponent();

        }
        // getting bool login
        public static bool login;
        // connection another class cre by : Anz :V
        Getting_UI G_U = new Getting_UI();
        // sqlite and mysql
        MySqlConnection conn_mysql;
        SQLiteConnection conn_sqlite;
        //data id tài khoản đã login
        public static string id_user_name;
        public Login fr_lg = new Login();
        //các tab của mdi main fr
        public List<string> list_tb = new List<string>();
        //
        public static bool time; // set bool cho time 
        void setup_login()
        {
            // set id_user (: khi login
          if(G_U.sqlite_ex_data().Rows[0][0].ToString() != "0")
            {
                lb_inf.Caption = "Xin chào: " + G_U.rt_user(G_U.sqlite_ex_data().Rows[0][0].ToString());
                id_user_name = G_U.sqlite_ex_data().Rows[0][0].ToString();
            }
            else
            {
                lb_inf.Caption = "Xin chào: " + G_U.rt_user(id_user_name);
            }
        }
        // quét barcode 
        private void time_barcode_Tick(object sender, EventArgs e)
        {
         //   btn_soluot.Caption = 
        }
        void fr_barcode()
        {
            // frm bar code
            var barcode = new App_ThuVien.BarCode.ControlBarCode();
            barcode.ShowDialog();
            time_barcode.Start();
        }
        private void FrmThuVien_Load(object sender, EventArgs e)
        {
            //fr_barcode();
            
            
            // getting giao diện
            getting_theme();
            ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // getting size for form (: by Anz
            this.Width = 1100;
            this.Height = 650;
            // getting postion inf user account (:
            bar_list.Alignment = new DevExpress.XtraBars.BarItemLinkAlignment();
            bar_list.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            //
            this.WindowState = FormWindowState.Maximized;
            // this.StartPosition = FormStartPosition.CenterScreen;

            this.Location = new Point(
                    100, 100
                );
            conn_mysql = G_U.connect_mysqli();
            conn_sqlite = G_U.connect_sqlite();
            // check có login chưa
            if (G_U.check_login() == "0")
            {
                if (time == false)
                    time = true;
                timer1.Start();
                this.Hide();
                fr_lg.ShowDialog();
            }
            else
            {
                setup_login();
            }
        }

        private void lb_inf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (login == true)
            {
                login = false;
                this.Show();
                timer1.Stop();
                setup_login();
            }
        }
        // Tổmq các list mở app 
       public List<string> list_frm = new List<string>();
        void act_frm(XtraForm frm, string text_frm, string name_frm)
        {
            if(check_exit(frm) == false)
            {
                frm.MdiParent = this;
                frm.Text = text_frm;
                frm.Show();
                list_frm.Add(name_frm);
            }

        }
        bool check_exit(XtraForm form)
        {
            foreach(var child in MdiChildren)
            {
                if(form.Name == child.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        // các act thanh left bar
        //act Sách
        private void tab_left_sachh_Click(object sender, EventArgs e)
        {
            var frm = new Frm_Sach();
            act_frm(frm, "Quản lý sách", "Frm_Sach");
        }
        //act LOại sách
        private void tab_left_tlsach_Click(object sender, EventArgs e)
        {
            var frm = new Frm_Loaisach();
            act_frm(frm, "Thể loại sách", "Frm_Loaisach");
        }
        //act Lập mượn
        private void tab_left_muon_Click(object sender, EventArgs e)
        {
            var frm = new Frm_muon();
            act_frm(frm, "Lập phiếu mượn", "Frm_muon");
        }
        // act quản lý phiếu mượn
        private void tab_left_QlMuon_Click(object sender, EventArgs e)
        {
            var frm = new Frm_QlMuon();
            act_frm(frm, "Quản lý phiếu mượn", "Frm_QlMuon");
        }
        //act Thống kê
        //act QUản lý khách hàng
        private void left_bar_qlkh_Click(object sender, EventArgs e)
        {
            var frm = new Frm_QlKhachHang();
            act_frm(frm, "Quản lý khách hàng", "Frm_QlKhachHang");
        }
        // act nhân viên
        private void left_bar_nv_Click(object sender, EventArgs e)
        {
            if (G_U.gand_admin(id_user_name) == true)
            {
                var frm = new Frm_NhanVien();
                act_frm(frm, "Quản lý nhân viên", "Frm_NhanVien");
            }
            else
            {
                Setting_sys.mess("Bạn không có quyền chỉnh sửa thông tin này !");
            }
        }
        // sự kiện chọn icon account trên thanh nav bar
        private void bar_list_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            //MessageBox.Show(bar_list.ItemIndex.ToString());
            if (bar_list.ItemIndex == 0)
            {
                if (list_tb.IndexOf("Inf_User") < 0)
                {
                    var frm = new Inf_User();
                    act_frm(frm, "Thông Tin Cá Nhân", "Inf_User");
                }
                else
                {
                    //check_mdi("Inf_User");
                }
            }
            else if (bar_list.ItemIndex == 1)
            {
                fr_lg = new Login();
                if (time == false)
                    time = true;
                login = false;
                this.Hide();
                timer1.Start();
                fr_lg.Show();
            }
            else if (bar_list.ItemIndex == 2)
            {
                this.Close();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void nhàSángLậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // var fr_viewRp = new View_Rp();
            //  fr_viewRp.ShowDialog();
        }

        // land setting theme
        void getting_theme()
        {
            Setting_sys.getting_load();
            if (Setting_sys.header_ribbon == 1)
            {
                on_nav_bar.Text = "✓On";
                off_nav_bar.Text = "Off";
                on_nav_bar.Enabled = false;
                off_nav_bar.Enabled = true;
                ribbonControl1.Show();
            }
            else
            {
                on_nav_bar.Text = "On";
                off_nav_bar.Text = "✓Off";
                on_nav_bar.Enabled = true;
                off_nav_bar.Enabled = false;
                ribbonControl1.Hide();
            }
            if (Setting_sys.left_bar == 1)
            {
                on_left_bar.Enabled = false;
                off_left_bar.Enabled = true;
                on_left_bar.Text = "✓On";
                off_left_bar.Text = "Off";
                left_bar.Show();
            }
            else
            {
                on_nav_bar.Enabled = true;
                off_nav_bar.Enabled = false;
                left_bar.Hide();
                on_left_bar.Text = "On";
                off_left_bar.Text = "✓Off";
            }
        }
        private void on_left_bar_Click(object sender, EventArgs e)
        {
            left_bar.Show();
            on_left_bar.Enabled = false;
            off_left_bar.Enabled = true;
            on_left_bar.Text = "✓On";
            off_left_bar.Text = "Off";
        }

        private void off_left_bar_Click(object sender, EventArgs e)
        {
            left_bar.Hide();
            off_left_bar.Enabled = false;
            on_left_bar.Enabled = true;
            on_left_bar.Text = "On";
            off_left_bar.Text = "✓Off";
        }

        private void btn_sach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tab_left_sachh_Click(sender, e);
        }

        private void on_nav_bar_Click(object sender, EventArgs e)
        {
            on_nav_bar.Text = "✓On";
            off_nav_bar.Text = "Off";
            on_nav_bar.Enabled = false;
            off_nav_bar.Enabled = true;
            ribbonControl1.Show();
        }

        private void off_nav_bar_Click(object sender, EventArgs e)
        {
            on_nav_bar.Text = "On";
            off_nav_bar.Text = "✓Off";
            on_nav_bar.Enabled = true;
            off_nav_bar.Enabled = false;
            ribbonControl1.Hide();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }
        App_ThuVien.BarCode.Frm_KhRaVao frm_kh = new App_ThuVien.BarCode.Frm_KhRaVao();
        private void btn_soluot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(frm_kh.Visible == false){ frm_kh.Show(); } else { frm_kh.Hide(); }
            time_barcode.Start();
        }

        private void sửaĐiểmThânThiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_diemthanthien = new App_ThuVien.Console.SuaDiemThanThien();
            frm_diemthanthien.Show();
        }

        private void FrmThuVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (XtraMessageBox.Show("Bạn có chắc thoát ?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Environment.Exit(0);
            //}
            //    e.Cancel = true;
        }

        private void mdi_fr_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
           
        }
      
        private void FrmThuVien_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void termToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tk_sach_Click(object sender, EventArgs e)
        {
            var frm = new ThongKe.Tk_Sach();
            frm.choose_tk("Sach");
            act_frm(frm, "Thống kê sách", "Tk_Sach");
        }

        private void tk_nguoidung_Click(object sender, EventArgs e)
        {
            var frm = new ThongKe.Tk_Sach();
            frm.choose_tk("NguoiDung");
            act_frm(frm, "Thống kê người dùng", "Tk_Sach");
        }
    }
}