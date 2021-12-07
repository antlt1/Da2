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
using DevExpress.XtraEditors.Repository;
using Test_Sqlite;

namespace App_ThuVien.Form
{
    public partial class Frm_Sach : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        Getting_UI G_U = new Getting_UI();
        public Frm_Sach()
        {
            InitializeComponent();
        }
        //
        public string result_val;
        string colum;
        //inf của tài khoản
        string id_user;
        public void set_colum(string colum)
        {
            this.colum = colum;
        }
        // group Lưu dl (:
        public void load_data()
        {
            dgv.DataSource = G_U.mysqli_ex_value_tb("select s.id_sach as 'id_sach',ten_sach,tl.ten_theloai as 'tl', s.tacgia, s.vitri , ngaysx, gia, soluong, trangthai from sach s , theloai tl  where s.id_theloai = tl.id_theloai");
        }
        private void Frm_sach_Load(object sender, EventArgs e)
        {
            id_user = G_U.sqlite_ex_data().Rows[0][0].ToString();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //getting dữ liệu vào
            load_data();
            gridView1.Columns[2].OptionsColumn.ReadOnly = true;
        }
        // function add int id =))))
        void add_data(string table,string id_str, string str)
        {
            DataTable dt = G_U.mysqli_ex_value_tb(string.Format("select {0} from {1} order by {2} asc ",id_str,table,id_str)); // get id
            dt.Rows.Add(9999999); // cc ghe chua
            int n = 0, i = 1;
            foreach (DataRow dtr in dt.Rows)
            {
                if (int.Parse(dt.Rows[n][0].ToString()) == i) { i++;
                } // more val
                else
                {
                    G_U.ex_cmd(string.Format("insert into {0} values ({1},{2})", table, i.ToString(), str));
                    break;
                }
                n++;
            }
        }

        private void dgv_sach_Click(object sender, EventArgs e)
        {        
            //txt_tensach.text.Text = result_val;
        }
       public static bool new_row;
        private void btn_add_data_Click(object sender, EventArgs e)
        {
            if (new_row == false)
            {
                add_data("sach","id_sach",id_user+ ",'null',3,'null','null','null',current_timestamp(),0,0,'null'");
                load_data();
            }
            
        }

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            XtraMessageBox.Show("Không được bỏ trống !");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            G_U.ex_cmd("");
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
          // xửa lý bé gridview ))
            // dl của bé ))
       public static string masach, ten_sach, theloai, tacgia, vitri, ngay, gia, soluong, trangthai,masach_old;
        // xoá list sách
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
                            G_U.ex_cmd(string.Format("delete from sach where id_sach = {0}", i.ToString()));
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
                XtraMessageBox.Show("Vui lòng chọn sách để xoá","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_sl_tl_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            App_ThuVien.Console.PickTheLoai fr_pick = new Console.PickTheLoai();
            fr_pick.ShowDialog();
            timer1.Start();
        }
        public static bool time_set_tl;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time_set_tl == true)
            timer1.Stop();
            load_data();
            time_set_tl = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (gridView1.IsFindPanelVisible)
                gridView1.HideFindPanel();
            else
                gridView1.ShowFindPanel();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // add các id của sách vào list
        List<int> list_check = new List<int>();
        // sự kiện cell click của gridview1
        private void gridView1_RowCellClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            masach_old = gridView1.GetRowCellValue(e.RowHandle, "id_sach").ToString();
            if (gridView1.GetFocusedDisplayText() == "Unchecked")
            {
                if(list_check.Contains(Convert.ToInt32(masach_old)) == false)
                {
                    list_check.Add(Convert.ToInt32(masach_old));
                }
            }
            else
            {
                if(list_check.Contains(Convert.ToInt32(masach_old)) == true)
                {
                    list_check.Remove(Convert.ToInt32(masach_old));
                }
            }
        }
        // sự kiện resert cái gv 
        private void btn_rs_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            string str_column = gridView1.Columns.First().FieldName.ToString(); // get id của sách :V
            //gán gt
            masach = gridView1.GetRowCellDisplayText(e.RowHandle, str_column).ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string str_changed, str_colum, str_id;
            str_changed = gridView1.GetRowCellValue(e.RowHandle, e.Column).ToString();
            if(str_changed.IndexOf("/") > 0)
            {
                str_changed = string.Format("{0:yyyy/MM/dd}", DateTime.Parse(str_changed));
            }
            str_colum = gridView1.FocusedColumn.FieldName.ToString();
            str_id = gridView1.GetRowCellValue(e.RowHandle,"id_sach").ToString();
            G_U.ex_cmd(string.Format("update sach set {0} = '{1}' where id_sach = {2}", str_colum, str_changed, str_id));
            Frm_sach_Load(sender, e);
        }

        private void btn_set_tl_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("u r click !");
            //gridView1.GetRowCellValue();
        }
        
        private void btn_check_sach_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(btn_check_sach.ValueChecked.ToString());
        }
    }
}