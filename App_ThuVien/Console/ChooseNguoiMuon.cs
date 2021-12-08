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

namespace App_ThuVien.Console
{
    public partial class ChooseNguoiMuon : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public ChooseNguoiMuon()
        {
            InitializeComponent();
        }
        Getting_UI G_U = new Getting_UI();
        private void ChooseNguoiMuon_Load(object sender, EventArgs e)
        {
            guser.DataSource = G_U.mysqli_ex_value_tb(
                "select id_taikhoan  , hoten , sdt , diachi  from bandoc");
            btn_search.Select();
        }
        string get_col_choose;
        private void btn_choose_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }
       // bool btime;
        private void gvuser_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
            get_col_choose = gvuser.GetRowCellValue(e.RowHandle, "id_taikhoan").ToString();
            if(get_col_choose != null)
            {
                App_ThuVien.Form.Frm_muon.btime_user = true;
                App_ThuVien.Form.Frm_muon.id_user = get_col_choose;
                this.Close();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (gvuser.IsFindPanelVisible)
                gvuser.HideFindPanel();
            else
                gvuser.ShowFindPanel();
        }
    }
}