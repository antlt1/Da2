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
    public partial class Pick_Date_MonthandYear : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public Pick_Date_MonthandYear()
        {
            InitializeComponent();
        }

        private void Pick_Date_MonthandYear_Load(object sender, EventArgs e)
        {
            
        }
        public string dt;
        private void dt_pick_DateTimeChanged(object sender, EventArgs e)
        {
            dt = dt_pick.DateTime.ToShortDateString();
            this.Close();
        }
    }
}