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
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using App_ThuVien.Form;
using DevExpress.XtraTab;
using System.Diagnostics;

namespace Test_Sqlite
{
    public partial class Main_Frm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main_Frm()
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
        void setup_login()
        {
            // set id_user (: khi login
            id_user_name = G_U.sqlite_ex_data().Rows[0][0].ToString();
            //barButtonItem1.Caption = id_user_name;
            //sổ lb inf tên người login
            lb_inf.Caption = "Xin chào: " + G_U.rt_user();
        }
        //load các fr vào tab page
        void loadpage()
        {
            //fr loại sách
            Frm_Loaisach frm_ls = new Frm_Loaisach()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            //tab_theloai.Controls.Add(frm_ls);
            frm_ls.Show();
            //fr sách
            Frm_Sach frm_sach = new Frm_Sach()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
           // tab_sach.Controls.Add(frm_sach);
            frm_sach.Show();
            //fr lập pếu mượn
            Frm_muon frm_muon = new Frm_muon()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            //tab_muon.Controls.Add(frm_muon);
            frm_muon.Show();
            //fr ql mượn
            Frm_QlMuon frm_qlmuon = new Frm_QlMuon()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
           // tab_QlMuon.Controls.Add(frm_qlmuon);
            frm_qlmuon.Show();
            //
        }
        //
        private void Main_Frm_Load(object sender, EventArgs e)
        {
            //set size cho hằq form
            //this.Width = 1000; // bị đẩy cái bar inf (: cayy ta
            // connect twitch database
            conn_mysql = G_U.connect_mysqli();
            conn_sqlite = G_U.connect_sqlite();
            // check có login chưa
            if (G_U.check_login() == "0")
            {
               if( time == false)
                time = true;
                timer1.Start();
                this.Hide();
                fr_lg.ShowDialog();
            }
            else
            {
                setup_login();
            }
            //check app mở chưa
          
            loadpage();
        }
      
        //close all form tét chơi
        
        // đóng của sổ :V
        private void Main_Frm_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = XtraMessageBox.Show("Bạn thực sự muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No;
        }
        //bool các tab
        bool b_tab_sach, b_tab_theloai, b_tab_muon , b_tab_QlMuon;
        // xoá trạng thái chưa sử dụng :V 
        void del_status()
        {
            string s = b_tab_muon.ToString() + b_tab_theloai.ToString()+ b_tab_sach.ToString()+
                Frm_Sach.new_row.ToString();
        }
       
        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

            //if (!tab_cl.TabPages.Contains(tab_sach))
            //{
            //    tab_cl.TabPages.Add(tab_sach);

            //}
            //tab_cl.SelectedTabPage = tab_sach;
            var f1 = new Frm_Sach();
            f1.MdiParent = this;
            f1.Show();
        }

        public static bool time; // set bool cho time 
        private void bar_list_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            //MessageBox.Show(bar_list.ItemIndex.ToString());
            if (bar_list.ItemIndex == 0)
            {
                Inf_User frm_use = new Inf_User()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
            //    if (!tab_cl.TabPages.Contains(tab_inf_use))
            //{
            //    tab_cl.TabPages.Add(tab_inf_use);
            //        tab_inf_use.Controls.Add(frm_use);
            //        frm_use.Show();
            //        //b_tab_use = true;
            //}
            // tab_cl.SelectedTabPage = tab_inf_use;
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

        private void timer1_Tick(object sender, EventArgs e) // rối (: fr1 fr2 chơi hàm time cho ngầu ))
        {
            //barButtonItem1.Caption = "statust: "+ login.ToString();
            if (login == true)
            {
                login = false;
                this.Show();
                timer1.Stop();
                setup_login();
            }
        }
        // tab thể loại sách
      
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            
            //if (!tab_cl.TabPages.Contains(tab_theloai))
            //{
            //    tab_cl.TabPages.Add(tab_theloai);
               
            //    b_tab_theloai = true;
            //}
            //    tab_cl.SelectedTabPage = tab_theloai;
        }
        // btn chọn vô thể loại để  sửa :V
        private void tab_cl_CloseButtonClick(object sender, EventArgs e)
        {
            //tab_cl.TabPages.Remove(tab_cl.SelectedTabPage);
        }

        private void tk_sach_Click(object sender, EventArgs e)
        {
            Frm_ThongKe tk = new Frm_ThongKe();
            tk.Show();
        }
      
        // hiện frm lập phiếu mượn
        private void tab_left_muon_Click(object sender, EventArgs e)
        {
            
            //if (!tab_cl.TabPages.Contains(tab_muon))
            //{
            //    tab_cl.TabPages.Add(tab_muon);
               
            //    b_tab_muon = true;
            //}
            //tab_cl.SelectedTabPage = tab_muon;
        }
        
        private void tab_left_QlMuon_Click(object sender, EventArgs e)
        {
            
            //if (!tab_cl.TabPages.Contains(tab_QlMuon))
            //{
            //    tab_cl.TabPages.Add(tab_QlMuon);
                
            //    b_tab_QlMuon = true;
            //}
            //tab_cl.SelectedTabPage = tab_QlMuon;
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {

            /*
             Frm_Loaisach frm_ls = new Frm_Loaisach()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };          
            if (!tab_cl.TabPages.Contains(tab_theloai))
            {
                tab_cl.TabPages.Add(tab_theloai);
                tab_theloai.Controls.Add(frm_ls);
                frm_ls.Show();
                b_tab_theloai = true;
            }
                tab_cl.SelectedTabPage = tab_theloai;
             */
        }
        // Hiện page mượn
        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            
        }
    }
}