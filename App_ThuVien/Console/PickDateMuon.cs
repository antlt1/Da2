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
                App_ThuVien.Console.PickSachMuon.datemuon = time;
                App_ThuVien.Console.PickSachMuon.btime_pickdate = true;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn thời gian mượn !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // XtraMessageBox.Show("time :" + time);
        }
        string time;
        private void PickDateMuon_Load(object sender, EventArgs e)
        {
            
            dateEdit1.Properties.MinValue = DateTime.Parse(DateTime.Now.ToShortDateString());
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
           

        }
    }
}