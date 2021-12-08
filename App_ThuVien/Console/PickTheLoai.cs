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
using App_ThuVien.Form;

namespace App_ThuVien.Console
{
    public partial class PickTheLoai : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public PickTheLoai()
        {
            InitializeComponent();
        }
        ThuVien.Class.Getting_UI G_U = new ThuVien.Class.Getting_UI();
        private void PickTheLoai_Load(object sender, EventArgs e)
        {
            //changed btn
          
            lTheLoai.Properties.DataSource =
                G_U.mysqli_ex_value_tb("select id_theloai as 'ID_TL', ten_theloai as 'Tên Thể Loại' from theloai where id_theloai != 3");
            lTheLoai.Properties.DisplayMember = "Tên Thể Loại";
            lTheLoai.Properties.ValueMember = "ID_TL";
        }
        
        private void btn_create_Click_1(object sender, EventArgs e)
        {
           
        }

        private void lTheLoai_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            G_U.ex_cmd(string.Format("update sach set id_theloai = {0} where id_sach = {1}", lTheLoai.EditValue, App_ThuVien.Form.Frm_Sach.masach_old));
            Frm_Sach.time_set_tl = true;
            this.Close();
        }
    }
}