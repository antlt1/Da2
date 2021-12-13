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
using DevExpress.Utils.Animation;

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
        public bool check_log;
        private void btn_login_Click(object sender, EventArgs e)
        {
           // csdl của sql off
            mysqli_conn = G_U.connect_mysqli();
            mysqli_conn.Open();
            //
         string user = txt_underline__user.text_vl,
                pass = txt_underline_pass.text_vl;  
            if (txt_underline__user.text_vl != null && txt_underline_pass.text_vl != null)
            {
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
                
                    if (check == true)
                    {
                    //set id_taikhoan
                    G_U.save_log(id_user,user, pass);
                    }
                    else
                    {
                        G_U.save_log("0"," ", " ");
                    }
                    this.Hide();
                    int count_frm = 0;
                    App_ThuVien.FrmThuVien.id_user_name = id_user;
                    //foreach (Form frm in Application.OpenForms)
                    //{
                    //    if (frm.Name == "Login")
                    //    {
                    //       
                    //    }
                    //    else
                    //    {
                    //        this.Close();
                    //    }
                    //}
                if(Application.OpenForms.Count > 1){
                    App_ThuVien.FrmThuVien.login = true;
                    this.Close();
                }else{
                    this.Hide();
                    var main = new FrmThuVien();
                    main.Show();
                }
                /*
                 login - > main this.close -> 
                 main -> login -> 
                 
                 */
                    
                    
                  //  this.Dispose();
                }
                else
                {
                    Setting_sys.mess("Tài khoản và mật khẩu không chính xác vui lòng thử lại!");
                }
        }   
        void size_login(bool t)
        {
            this.Height = (t == true) ? 260 : 340;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            size_login(true);
            TabControls.SelectedTabPage = tabSignIn;
            TabControls.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
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
        private void transitionManager1_CustomTransition(DevExpress.Utils.Animation.ITransition transition, DevExpress.Utils.Animation.CustomTransitionEventArgs e)
        {
            e.Regions = new Rectangle[] { TabControls.Bounds };

        }
        private void btn_openDk_Click(object sender, EventArgs e)
        {
            TabControls.SelectedTabPage = tabSignUp;
            size_login(false);
        }
        private void btn_openLoginIn_Click(object sender, EventArgs e)
        {
            TabControls.SelectedTabPage = tabSignIn;
            size_login(true);
        }

        private void btn_userSignUp_Click(object sender, EventArgs e)
        {
            if (txt_userSignUp.text.Text == null || txt_passSignUp.text.Text == null || txt_passSignUp1.text.Text == null)
            {
                Setting_sys.mess("Tên hoặc mật khẩu không được bỏ trống !"); return;
            }
            if (txt_fullName.text.Text == null || txt_email.text.Text == null)
            {
                Setting_sys.mess("Họ tên và email không được bỏ trống !"); return;
            }
            string cmd = string.Format("insert into taikhoan values({0},{1},'{2}','{3}','{4}','{5}',{6},'{7}','0')", G_U.creater_id("id_taikhoan", "taikhoan"),
                    1, txt_userSignUp.text.Text, txt_passSignUp.text.Text, txt_fullName.text.Text, "null", 0, txt_email.text.Text);
            try
            {
                G_U.ex_cmd(cmd);
                Setting_sys.mess("Đăng ký thành công !");
                TabControls.SelectedTabPage = tabSignIn;
                size_login(true);
                txt_underline__user.text.Text = txt_userSignUp.text.Text;
                txt_underline_pass.text.Text = txt_passSignUp.text.Text;
            }
            catch (Exception) { Setting_sys.mess("Đăng ký thành công cc !"); /*txt_email.text.Text = cmd; */}
        }
    }
}