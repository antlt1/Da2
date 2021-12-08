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
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using DevExpress.UserSkins;
using App_ThuVien.Design;
using App_ThuVien;
using App_ThuVien.Class;

namespace ThuVien
{
    public partial class Login : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public Login()
        {
            InitializeComponent();
        }
        // csdl
        MySqlConnection mysqli_conn;
        // class
        Getting_UI G_U = new Getting_UI();
        
        // Setting_sys.mess(txt_underline_11.text_vl);
        private void button1_Click(object sender, EventArgs e)
        {
            Setting_sys.mess(txt_underline__user.text_vl);
        }
        bool check;
        private void btn_login_Click(object sender, EventArgs e)
        {
           // csdl của sql off
            mysqli_conn = G_U.connect_mysqli();
            mysqli_conn.Open();
            //
         string user = txt_underline__user.text_vl,
                pass = txt_underline_pass.text_vl;
          //  Setting_sys.mess(cBox_log.CheckState.ToString());
            if (txt_underline__user.text_vl != null && txt_underline_pass.text_vl != null)
            {
                //Setting_sys.mess(cBox_log.CheckState.ToString());
               if(cBox_log.CheckState.ToString() == "Checked"){
                   check = true; } else { check = false; }
            }
            else
            {
                Setting_sys.mess("Tên đăng nhập và mật khẩu không được bỏ trống !", "Hệ Thống");
            }
            //cmd check login (:
                string str = string.Format("select count(*) from taikhoan where ten_taikhoan = '{0}' and matkhau = '{1}'",
                user, pass);
            // thay doi csdl sqlite
            G_U.mysql_cmd = new MySqlCommand(str, mysqli_conn);
            //check để login :V
            if (G_U.mysql_cmd.ExecuteScalar().ToString() != "0") // rt về 1 gt là có (:
                {
                string id_user = G_U.mysqli_ex_data(string.Format("select id_taikhoan from taikhoan where ten_taikhoan = '{0}'",
                            user)).ToString();
                Setting_sys.mess("Đăng nhập thành công !");
                App_ThuVien.FrmThuVien.id_user_name = id_user;
                    if (check == true)
                    {
                    //set id_taikhoan
                    
                    //Setting_sys.mess("checked");
                    G_U.save_log(id_user,user, pass);
                    }
                    else
                    {
                        //Setting_sys.mess("unchecked");
                        G_U.save_log("0"," ", " ");
                    }
                    if (FrmThuVien.time == true)
                    {
                    FrmThuVien.login = true;
                    }
                    this.Close();
                }
                else
                {
                    Setting_sys.mess("Tài khoản và mật khẩu không chính xác vui lòng thử lại!");
                }
           

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            if (G_U.check_login() != "0")
            {
                DataTable dt = G_U.sqlite_ex_data();
                txt_underline__user.text.Text = dt.Rows[0][1].ToString();
                txt_underline_pass.text.Text = dt.Rows[0][2].ToString();
                cBox_log.Checked = true;
            }
            // ẩn panel loading ))
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FrmThuVien.time == false)
            {
                Environment.Exit(0);
            }
            this.Hide();
            e.Cancel = true;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}