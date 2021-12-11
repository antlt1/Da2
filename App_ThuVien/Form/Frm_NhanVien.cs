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
using App_ThuVien.Class;

namespace App_ThuVien.Form
{
    public partial class Frm_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }
        Getting_UI G_U = new Getting_UI();
        string str_nhanvien = string.Format("SELECT t.id_TaiKhoan , t.ten_taikhoan , t.matkhau , t.hoten  , t.diachi , t.sdt ," +
                " t.email , t.trangthai FROM taikhoan t , chucvu c where t.id_chucvu = c.id_chucvu and c.ten_chucvu = 'Nhân viên' and  t.trangthai = 1"),
                str_xacnhan = string.Format("SELECT t.id_TaiKhoan , t.ten_taikhoan , t.matkhau , t.hoten  , t.diachi , t.sdt ," +
                " t.email , t.trangthai FROM taikhoan t , chucvu c where t.id_chucvu = c.id_chucvu and c.ten_chucvu = 'Nhân viên' and t.trangthai = 0 ");
        void ex_nhanvien()
        {
            gridColumn9.Visible = false;
            gc_nhanvien.DataSource = G_U.mysqli_ex_value_tb(str_nhanvien);
        }
        void ex_dk_nhanvien()
        {
            gridColumn9.Visible = true;
            gc_nhanvien.DataSource = G_U.mysqli_ex_value_tb(str_xacnhan);
        }
        void load_lab_dk()
        {
            lab_dangky.Text = "( " + G_U.mysqli_ex_data("select count(*) from taikhoan t , chucvu c where t.id_chucvu = c.id_chucvu and c.ten_chucvu  = 'Nhân viên' and t.trangthai = 0") + " )";
        }
        void on_off_them(bool bol)
        {
            if(bol == true)
            {
                btn_add_data.Enabled = true;
            }
            else
            {
               
                btn_add_data.Enabled = false;
            }
        }
        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            on_off_them(true);
            ex_nhanvien();
            load_lab_dk();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            if( btn_dangky.Text == "Danh sách đăng ký")
            {
                on_off_them(false);
                ex_dk_nhanvien();
                btn_dangky.Text = "Danh nhân viên";
            }
            else
            {
                on_off_them(true);
                ex_nhanvien();
                btn_dangky.Text = "Danh sách đăng ký";
            }
        }

        private void gv_nhanvien_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string column = gv_nhanvien.FocusedColumn.FieldName.ToString(),
                    id_taikhoan = gv_nhanvien.GetRowCellValue(e.RowHandle, "id_TaiKhoan").ToString(),
                    new_val = gv_nhanvien.GetRowCellValue(e.RowHandle, e.Column).ToString();
            //Setting_sys.mess(id_taikhoan);
            if(column == "trangthai" && btn_dangky.Text != "Danh sách đăng ký")
            {
                if (XtraMessageBox.Show("Bạn chắc chắn duyệt Nhân viên ?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    G_U.ex_cmd(string.Format("update taikhoan set trangthai = {0} where id_taikhoan = {1}", true,id_taikhoan));
                    Setting_sys.mess("Cập nhật thành công !");
                    ex_nhanvien();
                    load_lab_dk();
                }
                else { Frm_NhanVien_Load(sender, e); }
            }
            else  if(column != "trangthai") {
                G_U.ex_cmd(string.Format("update taikhoan set {0} = '{1}'  where id_taikhoan = {2}", column, new_val, id_taikhoan));
                Frm_NhanVien_Load(sender, e);
            }

        }
        List<int> list_id = new List<int>();
        string id_old;
        private void gv_nhanvien_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            id_old = gv_nhanvien.GetRowCellValue(e.RowHandle, "id_TaiKhoan").ToString();
            if (gv_nhanvien.GetFocusedDisplayText() == "Unchecked")
            {
                if (list_id.Contains(Convert.ToInt32(id_old)) == false)
                {
                    list_id.Add(Convert.ToInt32(id_old));
                }
            }
            else
            {
                if (list_id.Contains(Convert.ToInt32(id_old)) == true)
                {
                    list_id.Remove(Convert.ToInt32(id_old));
                }
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if(list_id.Count > 0)
            {
                if(XtraMessageBox.Show("Bạn có chắc chắn muốn xoá không ?","Hệ thống",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach(int id  in list_id)
                    {
                        G_U.ex_cmd(string.Format("delete from taikhoan where id_taikhoan = {0} ",id.ToString()));
                    }
                    Setting_sys.mess("Đã xoá thành công !");
                    Frm_NhanVien_Load(sender, e);
                }
            }
        }

        private void btn_rs_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Load(sender, e);
        }

        private void btn_add_data_Click(object sender, EventArgs e)
        {
            gv_nhanvien.AddNewRow();
            string id_acc = G_U.creater_id("id_taikhoan", "taikhoan");
            string id_cv = G_U.mysqli_ex_data("select id_chucvu from chucvu where ten_chucvu = 'nhân viên'");
            G_U.ex_cmd(string.Format("insert into taikhoan values({0},{1},'NV{2}','null','null','null',0,'null',1) ", 
              id_acc  , id_cv,id_acc));
            Frm_NhanVien_Load(sender, e);
        }
    }
}