using DevExpress.Utils.Menu;
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

namespace App_ThuVien.Console
{
    public partial class Pick_TrangThai_Muon : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Pick_TrangThai_Muon()
        {
            InitializeComponent();
        }
        DataTable dt;
        string term_tr;
        public static string ma_pm, ma_sach;
        public void add_val(string ma_pm_t , string ma_sach_t)
        {
            ma_pm = ma_pm_t;
            ma_sach = ma_sach_t;
        }
        void clear_trash()
        {
            term_tr = "";
        }
        public DataTable creater()
        {
            DataTable dt_t = new DataTable("pick_status");
            dt_t.Columns.Add("pick",typeof(String));
            DataRow dr = null;
            foreach (char i in "Gia hạn,Phạt,")
            {
                if (i != ',')
                {
                    term_tr += i;
                }
                else
                {
                    dr = dt_t.NewRow();
                    dr["pick"] = term_tr;
                    term_tr = null;
                    dt_t.Rows.Add(dr);
                }
            }
            return dt_t;

        }
        private void Pick_TrangThai_Muon_Load(object sender, EventArgs e)
        {
            lu_choose.Properties.DataSource = creater();

           // lu_choose.Select()
        }

        private void Pick_TrangThai_Muon_FormClosed(object sender, FormClosedEventArgs e)
        {
            App_ThuVien.Form.Frm_QlMuon.check = false;
        }

        private void lu_choose_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {         
            if(lu_choose.Text == "Trả sách")
            {
                App_ThuVien.Form.Frm_QlMuon.status_char_choose = 't';
            }
            else if (lu_choose.Text =="Gia hạn")
            {
                App_ThuVien.Form.Frm_QlMuon.status_char_choose = 'g';
            }
            else
            {
                var fr_phat = new App_ThuVien.Console.Pick_Phat();
                fr_phat.val(ma_pm, ma_sach);
                fr_phat.Show();
            }
            App_ThuVien.Form.Frm_QlMuon.check_time = true;
            this.Close();
        }
    }
}