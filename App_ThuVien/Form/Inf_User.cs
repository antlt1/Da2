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
    public partial class Inf_User : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public Inf_User()
        {
            InitializeComponent();
        }

        private void txt_hoten_DoubleClick(object sender, EventArgs e)
        {
            txt_hoten.Enabled = true;
        }
        Getting_UI G_U = new Getting_UI();
        private void Inf_User_Load(object sender, EventArgs e)
        {
            string id_user = App_ThuVien.FrmThuVien.id_user_name;
            lb_tenchucvu.Text = G_U.mysqli_ex_data(
                string.Format("select c.ten_chucvu from chucvu c , taikhoan t where t.id_chucvu = c.id_chucvu and t.id_TaiKhoan = {0}",id_user));
            txt_hoten.Text = G_U.mysqli_ex_data(string.Format("select hoten from taikhoan where id_taikhoan = {0} ",id_user));
            txt_sdt.Text = G_U.mysqli_ex_data(string.Format("select sdt from taikhoan where id_taikhoan = {0} ", id_user));
            txt_email.Text = G_U.mysqli_ex_data(string.Format("select email from taikhoan where id_taikhoan = {0} ", id_user));
            txt_address.Text = G_U.mysqli_ex_data(string.Format("select diachi from taikhoan where id_taikhoan = {0} ", id_user));
        }

        private void txt_hoten_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string column = "";
                TextBox txt = sender as TextBox;
                if(txt.Name == "txt_hoten")
                {
                    column = "hoten";
                }else if (txt.Name == "txt_sdt")
                {
                    column = "sdt";
                }else if (txt.Name == "txt_email")
                {
                    column = "email";
                }else
                {
                    column = "diachi";
                }
                G_U.ex_cmd(string.Format("update taikhoan set {0} = '{1}' where id_taikhoan = {2} ",
                    column,txt.Text,App_ThuVien.FrmThuVien.id_user_name));
                Inf_User_Load(sender, e);
            }
        }

        private void lb_changer_password_Click(object sender, EventArgs e)
        {
            var frm_doipass = new App_ThuVien.Console.PickDoiPass();
            frm_doipass.ShowDialog();
        }
    }
}