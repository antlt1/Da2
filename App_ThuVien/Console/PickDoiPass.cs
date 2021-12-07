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

namespace App_ThuVien.Console
{
    public partial class PickDoiPass : DevExpress.XtraEditors.XtraForm
    {
        public PickDoiPass()
        {
            InitializeComponent();
        }
        void hide_show_click(TextEdit txt) // ng chơi hệ code ngắn cre : アン =))
        {
            txt.Properties.UseSystemPasswordChar = (txt.Properties.UseSystemPasswordChar == false) ? true : false;
        }
        void hide_showPass(string str , PictureEdit pic)
        {
            if (str.Length > 0)
            {
                lb_status.Text = "";
                pic.Show();
            }
            else
            {
                lb_status.Text = "Mật khẩu không được bỏ trống !";
                pic.Hide();
            }
        }
        void check_txt(string txt1 , string txt2)
        {
            if (txt1.Length < 8)
            {
                lb_status.Text = "Mật khẩu phải từ 8 ký tự trở lên !";
            }
            else
            {
                lb_status.Text = "";
                
            }
            if (txt2.Length != 0)
            {
                if (txt2 != txt1)
                {
                    lb_status.Text = "Mật khẩu không trùng ở trên !";
                    
                }
                else
                {
                    pic_NewPassword.Show();
                    lb_status.Text = "";
                    btn_changer.Enabled = true;
                }
            }
        }
        string pass_new1, pass_new2;
        private void txt_OldPassword_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            
            switch (txt.Name)
            {
                case "txt_OldPassword":
                    {
                        hide_showPass(txt.Text, pic_OldPassword);
                        break;
                    }
                case "txt_NewPassword":
                    {
                        hide_showPass(txt.Text, pic_NewPassword);
                        pass_new1 = txt.Text; 
                        check_txt(txt.Text,"");
                        break;
                    }
                case "txt_NewPassword1":
                    {
                        hide_showPass(txt.Text, pic_NewPassword1);
                        pass_new2 = txt.Text;
                        check_txt(pass_new1,txt.Text);
                        break;
                    }
            }
        }

        private void PickDoiPass_Load(object sender, EventArgs e)
        {
            lb_status.Text = "";
            pic_OldPassword.Hide();
            pic_NewPassword.Hide();
            pic_NewPassword1.Hide();
            btn_changer.Enabled = false;
        }

        private void txt_1done_Click(object sender, EventArgs e)
        {
            PictureEdit picedit = (PictureEdit) sender;

            switch (picedit.Name)
            {
                case "pic_OldPassword":
                    {
                        hide_show_click(txt_OldPassword);
                        break;
                    }
                case "pic_NewPassword":
                    {
                        hide_show_click(txt_NewPassword);
                        break;
                    }
                case "pic_NewPassword1":
                    {
                        hide_show_click(txt_NewPassword1);
                        break;
                    }
            }
        }
        Getting_UI G_U = new Getting_UI();
        private void btn_changer_Click(object sender, EventArgs e)
        {
            if (G_U.mysqli_ex_data(string.Format("select count(*) from taikhoan where id_taikhoan = '{0}' and matkhau = '{1}'", App_ThuVien.FrmThuVien.id_user_name, txt_OldPassword.Text)) == "1")
            {
                try
                {
                    if (XtraMessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu không ?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        G_U.ex_cmd(string.Format("update taikhoan set matkhau = '{0}' where id_taikhoan = '{1}'", txt_NewPassword1.Text, App_ThuVien.FrmThuVien.id_user_name));
                        Setting_sys.mess("Đổi mật khẩu thành công !");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    Setting_sys.mess("Đổi mật thất bại : "+ ex.Message);
                }
            }
            else
            {
                Setting_sys.mess("Mật khẩu cũ không đúng !");
            }
            
        }
    }
}