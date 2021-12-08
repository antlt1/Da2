using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.Class;

namespace App_ThuVien.Console // creater by : アン
{
    public partial class ThemKhachHang : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }
        //
        public static View_InKhachHang fr_rp = new View_InKhachHang();
        Getting_UI G_U = new Getting_UI();
        // getting set val
        string id, ten, sdt, diachi, str;
        private void btn_DK_Click(object sender, EventArgs e)
        {
            if (txtHovaTen.Text != null && txtSDT.Text != null && txtDiaChi.Text != null)
            {
                try
                {
                    string id_bandoc = G_U.creater_id("id_taikhoan", "bandoc");
                    str = string.Format("insert into bandoc values ({0},'{1}',{2},'{3}',0,0,0,'bt')",
                    id_bandoc , txtHovaTen.Text, txtSDT.Text, txtDiaChi.Text);
                 //   txtDiaChi.Text = str;
                    G_U.ex_cmd(str);
                    App_ThuVien.Form.Frm_QlKhachHang.time_add = false;
                    if (DialogResult.Yes == XtraMessageBox.Show("Đã tạo bạn đọc thành công ! \nBạn có muốn in thẻ bạn đọc không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        var fr = new App_ThuVien.Console.View_InKhachHang();
                        fr.add_Val(txtHovaTen.Text, txtDiaChi.Text,id_bandoc);
                        fr.Show();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi : " + ex.ToString());
                }
            }



        }
        private void txtMaKH_DoubleClick(object sender, EventArgs e)
        {
          //  txtMaKH.Enabled = false;
        }
    }
}