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

namespace App_ThuVien.Console
{
    public partial class PickSachMuon : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public PickSachMuon()
        {
            InitializeComponent();
        }
        Getting_UI G_U = new Getting_UI();
        void load_lupTL()
        {
            lupTL.Properties.ValueMember = "id_theloai";
            lupTL.Properties.DisplayMember = "ten_theloai";
            lupTL.Properties.DataSource = G_U.mysqli_ex_value_tb("select id_theloai , ten_theloai from theloai where id_theloai != 3 ");
        }
        void load_gv(string sk)
        {
            gsach.DataSource =
G_U.mysqli_ex_value_tb(string.Format("select s.id_sach as 'id_sach',ten_sach,tl.ten_theloai as 'tl', s.tacgia, s.vitri , ngaysx, gia, soluong, trangthai from sach s , theloai tl  where s.id_theloai = tl.id_theloai {0}",sk));
        }
        private void PickSachMuon_Load(object sender, EventArgs e)
        {
            load_gv("");
            load_lupTL();
        }

        private void gsach_Click(object sender, EventArgs e)
        {

        }
        public static bool btime_pickdate = false;
        public static string datemuon= "";
        string id_sach, tensach, ngaymuon;
       private void gvsach_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if(e.Column.ColumnHandle == -1) // nếu mà chọn btn choose đaq nằm ở col -1 thì làm (:
            {
                if (gvsach.GetRowCellValue(e.RowHandle, "id_sach").ToString() != "0")
                {
                    id_sach = gvsach.GetRowCellValue(e.RowHandle, "id_sach").ToString();
                    if (App_ThuVien.Form.Frm_muon.id_sach.IndexOf(int.Parse(id_sach)) < 0)
                    { //check có troq list chưa
                        tensach = gvsach.GetRowCellValue(e.RowHandle, "ten_sach").ToString();
                        ngaymuon = string.Format("{0:yyyy/MM/dd}", DateTime.Now);
                        App_ThuVien.Form.Frm_muon.id_sach.Add(int.Parse(id_sach)); // thêm vô list
                        DataRow dr;
                        dr = App_ThuVien.Form.Frm_muon.dt.NewRow();
                        dr["id_sach"] = id_sach;
                        dr["tensach"] = tensach;
                        dr["ngaymuon"] = ngaymuon;
                        dr["trangthai"] = "Đang Mượn";
                        dr["ngaytra"] = App_ThuVien.Form.Frm_muon.ngmuon;
                        App_ThuVien.Form.Frm_muon.dt.Rows.Add(dr);
                        App_ThuVien.Form.Frm_muon.btimebook = true;
                        App_ThuVien.Form.Frm_muon.id_sach.Add(int.Parse(id_sach));
                        this.Close();
                    }
                }
                else // có trong list rồi thì (:
                {
                    id_sach = "";
                    Setting_sys.mess("Sách này đã chọn rồi vui lòng chọn sách khác");
                }             
            }else { Setting_sys.mess("Sách này không còn trong kho !"); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void gvsach_RowCellClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            load_gv("");
            load_lupTL();
        }

        private void lupTL_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (lupTL.EditValue != "")
            {
                load_gv(string.Format("and tl.id_theloai = {0}", lupTL.EditValue));
            }
           
        }
    }
}