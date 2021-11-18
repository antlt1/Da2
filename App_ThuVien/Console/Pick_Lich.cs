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

namespace App_ThuVien.Console
{
    public partial class Pick_Lich : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Pick_Lich()
        {
            InitializeComponent();
        }
        public string text;
        public void set_min_date(DateTime dt)
        {
            dateEdit1.Properties.MinValue = dt;
        }
        public void set_max_date(DateTime dt)
        {
            dateEdit1.Properties.MaxValue = dt;
        }
        public string date;
        public static bool check_pick;
        private void dateEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            date = string.Format("{0:yyyy/MM/dd}", dateEdit1.DateTime);
            App_ThuVien.Form.Frm_QlMuon.check_get_time = true;
            this.Close();
        }
        public string get_dt()
        {
            return date;
        }
        
        private void Pick_Lich_Load(object sender, EventArgs e)
        {
            this.Text = text;
        }
    }
}