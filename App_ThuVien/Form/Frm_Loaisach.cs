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
using ThuVien;

namespace App_ThuVien.Form
{
    public partial class Frm_Loaisach : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Frm_Loaisach()
        {
            InitializeComponent();
        }
        Getting_UI G_U = new Getting_UI();
        void load_data()
        {
            dgv.DataSource = G_U.mysqli_ex_value_tb(
        "select tl.id_theloai as 'id_theloai', tl.id_theloaicha as 'id_theloaicha', tk.ten_taikhoan as 'ten_tk' , tl.id_taikhoan as 'id_taikhoan', tl.ten_theloai as 'ten_theloai'  from theloai tl , taikhoan tk where id_theloai != 3 and tl.id_taikhoan = tk.id_taikhoan");
        }
        private void Frm_Loaisach_Load(object sender, EventArgs e)
        {
            //add csdl vào dgv
            load_data();
            
        }
        void add_data(string table, string id_str, string str)
        {
            DataTable dt = G_U.mysqli_ex_value_tb(string.Format("select {0} from {1} order by {2} asc ", id_str, table, id_str)); // get id
            dt.Rows.Add(9999999); // cc ghe chua
            int n = 0, i = 1;
            foreach (DataRow dtr in dt.Rows)
            {
                if (int.Parse(dt.Rows[n][0].ToString()) == i)
                {
                    i++;
                } // more val
                else
                {
                    //textBox1.Text = string.Format("insert into {0} values ({1},{2})", table, i.ToString(), str);
                    G_U.ex_cmd(string.Format("insert into {0} values ({1},{2})", table, i.ToString(), str));
                    break;
                }
                n++;
            }
        }
        public static bool new_row;
        void clear_status()
        {
            new_row = false;

        }
        string id_user = FrmThuVien.id_user_name;
        private void btn_add_data_Click(object sender, EventArgs e)
        {
            //XtraMessageBox.Show(id_user);
            if (new_row == false)
            {
                add_data("theloai", "id_theloai", string.Format("0,{0},'null'", id_user));
                Frm_Loaisach_Load(sender, e);
            }
        }
        string id_maloai_old;
        List<int> list_check = new List<int>();
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            id_maloai_old = gridView1.GetRowCellValue(e.RowHandle, "id_theloai").ToString();
            if (gridView1.GetFocusedDisplayText() == "Unchecked")
            {
                if (list_check.Contains(Convert.ToInt32(id_maloai_old)) == false)
                {
                    list_check.Add(Convert.ToInt32(id_maloai_old));
                }
            }
            else
            {
                if (list_check.Contains(Convert.ToInt32(id_maloai_old)) == true)
                {
                    list_check.Remove(Convert.ToInt32(id_maloai_old));
                }
            }
        }

        private void btn_rs_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (list_check.Count >= 1)
            {
                if (XtraMessageBox.Show("Bạn đã chắc chắn muốn xoá ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (int i in list_check)
                    {
                        try
                        {
                            G_U.ex_cmd(string.Format("delete from theloai where id_theloai = {0}", i.ToString()));
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.ToString());
                        }
                    }
                    load_data();
                    XtraMessageBox.Show("Xoá thành công !");
                    list_check.Clear();
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn sách để xoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string str_changed, str_colum, str_id;
            str_changed = gridView1.GetRowCellValue(e.RowHandle, e.Column).ToString();
            str_colum = gridView1.FocusedColumn.FieldName.ToString();
            str_id = gridView1.GetRowCellValue(e.RowHandle, "id_theloai").ToString();
            //textBox1.Text = string.Format("update theloai set {0} = '{1}' where id_theloai = {2}", str_colum, str_changed, str_id);
            G_U.ex_cmd(string.Format("update theloai set {0} = '{1}' where id_theloai = {2}", str_colum, str_changed, str_id));
            load_data();
        }

        private void repositoryItemComboBox1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ComboBoxEdit edit = sender as ComboBoxEdit;
             if(edit.SelectedItem.ToString() != null)
            {
                edit.SelectedItem = edit.SelectedItem;
             //   repositoryItemComboBox1.ShowDropDown.;
            }
            
        }
    }
}