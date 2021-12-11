using App_ThuVien.Class;
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

namespace App_ThuVien.Form
{
    public partial class Frm_QlKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public Frm_QlKhachHang()
        {
            InitializeComponent();
        }

        private void btn_add_data_Click(object sender, EventArgs e)
        {
            if (time_add == true)
            {
                timer1.Start();
            }
            var fr_add = new App_ThuVien.Console.ThemKhachHang();
            fr_add.Show();
        }
        // getting 
        Getting_UI G_U = new Getting_UI();
        //
        public void loading_data()
        {
            gkhachhang.DataSource = G_U.mysqli_ex_value_tb("select * from bandoc");
        }
        private void Frm_QlKhachHang_Load(object sender, EventArgs e)
        {
            loading_data();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
          if(list_ma.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn có chắc chặn muốn xoá ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (int i in list_ma)
                    {
                        G_U.ex_cmd(string.Format("delete from bandoc where id_taikhoan = {0}", i));
                    }
                    XtraMessageBox.Show("Xoá Thành Công !");
                    loading_data();
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn Khách hàng để xoá !");
            }
        }
        List<int> list_ma = new List<int>();
        int key;
        private void gvkhachhang_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            key = int.Parse(gvkhachhang.GetRowCellValue(e.ControllerRow, "id_TaiKhoan").ToString());
            if (e.Action == CollectionChangeAction.Add)
            {
                    list_ma.Add(key);
            }else if(e.Action == CollectionChangeAction.Remove)
            {
                    list_ma.Remove(key);         
            }
        }

        private void btn_rs_Click(object sender, EventArgs e)
        {
            loading_data();
        }
        public static bool time_add = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time_add == false)
            {
                loading_data();
                time_add = true;
                timer1.Stop();
            }
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
           string pm = gvkhachhang.GetRowCellValue(gvkhachhang.FocusedRowHandle, "id_TaiKhoan").ToString();
            string hoten = G_U.mysqli_ex_data(string.Format("select bandoc.hoten from bandoc where bandoc.id_TaiKhoan = {0}",pm)), 
                   diachi = G_U.mysqli_ex_data(string.Format("select bandoc.diachi from bandoc where bandoc.id_TaiKhoan = {0}", pm)), 
                   id_bandoc = G_U.mysqli_ex_data(string.Format("select bandoc.id_taikhoan from bandoc where bandoc.id_TaiKhoan = {0}", pm));
            id_bandoc = G_U.creater_fex(string.Format("select id_taikhoan from bandoc where id_taikhoan = {0}", id_bandoc), "BD");
            Setting_sys.mess(id_bandoc);
            var fr = new App_ThuVien.Console.View_InKhachHang();
            fr.add_Val(hoten, diachi, id_bandoc);
            fr.Show();
        }

        private void gvkhachhang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            G_U.ex_cmd(string.Format("update bandoc set  {0} = '{1}' where id_taikhoan = {2} ", e.Column.FieldName, e.Value,
            gvkhachhang.GetRowCellValue(e.RowHandle, "id_TaiKhoan")));
            loading_data();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}