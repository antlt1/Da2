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

namespace App_ThuVien.Console
{
    public partial class PickSachMuon : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public PickSachMuon()
        {
            InitializeComponent();
        }
        Getting_UI G_U = new Getting_UI();
        private void PickSachMuon_Load(object sender, EventArgs e)
        {
            gsach.DataSource =
G_U.mysqli_ex_value_tb("select s.id_sach as 'id_sach',ten_sach,tl.ten_theloai as 'tl', s.tacgia, s.vitri , ngaysx, gia, soluong, trangthai from sach s , theloai tl  where s.id_theloai = tl.id_theloai");
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
                id_sach = gvsach.GetRowCellValue(e.RowHandle, "id_sach").ToString();
                if (App_ThuVien.Form.Frm_muon.id_sach.IndexOf(int.Parse(id_sach)) < 0){ //check có troq list chưa
                    tensach = gvsach.GetRowCellValue(e.RowHandle, "ten_sach").ToString();
                    ngaymuon =  string.Format("{0:yyyy/MM/dd}", DateTime.Now);
                    App_ThuVien.Form.Frm_muon.id_sach.Add(int.Parse(id_sach)); // thêm vô list
                    if (btime_pickdate == false) // bắt đầu chọn datatime
                    {
                        PickDateMuon fr_picdatemuon = new PickDateMuon();
                        fr_picdatemuon.Show();
                        timer1.Start();
                    }
                }
                else // có trong list rồi thì (:
                {
                    id_sach = "";
                    XtraMessageBox.Show("Sách này đã chọn rồi vui lòng chọn sách khác");
                }
                
                
            }
            //XtraMessageBox.Show("鬼ちゃんが好きです！"); // ((((: đế sừ ((: An vây bu
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(btime_pickdate == true)
            {
                DataRow dr;
                dr = App_ThuVien.Form.Frm_muon.dt.NewRow();
                dr["id_sach"] = id_sach;
                dr["tensach"] = tensach;
                dr["ngaymuon"] = ngaymuon;
                dr["trangthai"] = "Đang Mượn";
                dr["ngaytra"] = datemuon;
                App_ThuVien.Form.Frm_muon.dt.Rows.Add(dr);
                btime_pickdate = false;
                timer1.Stop();
                App_ThuVien.Form.Frm_muon.btimebook = true;
                App_ThuVien.Form.Frm_muon.id_sach.Add(int.Parse(id_sach));
                this.Close();
            }
        }

        private void gvsach_RowCellClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}