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
    public partial class PickDateMuon : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public PickDateMuon()
        {
            InitializeComponent();
        }

        private void dateEdit1_DateTimeChanged(object sender, EventArgs e)
        {
            time = string.Format("{0:yyyy/MM/dd}", dateEdit1.EditValue);
            if (time != null)
            {
                App_ThuVien.Form.Frm_muon.ngmuon = time;
                App_ThuVien.Form.Frm_muon.btime_pickdate = true;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn thời gian mượn !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // XtraMessageBox.Show("time :" + time);
        }
        string time;
        Getting_UI G_U = new Getting_UI();
        private void PickDateMuon_Load(object sender, EventArgs e)
        {
            
            dateEdit1.Properties.MinValue = DateTime.Now;
            string id = App_ThuVien.Form.Frm_muon.id_user;
            // theo điểm than thiện
            int i = int.Parse(G_U.mysqli_ex_data(string.Format("select diem_thanthien from bandoc where id_taikhoan = {0}", id)));
            int day = (i >= 50) ? 14 : 7;
            dateEdit1.Properties.MaxValue = DateTime.Now.AddDays(day);
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
           

        }
    }
}