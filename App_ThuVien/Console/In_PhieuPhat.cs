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
    public partial class In_PhieuPhat : DevExpress.XtraEditors.XtraForm
    {
        public In_PhieuPhat()
        {
            InitializeComponent();
        }
        public void creater_in(string hoten , string sach , string tien)
        {
            var rp = new App_ThuVien.Report.Rp_Phat();
            rp.creater_in(hoten, sach, tien);
            doc_in.DocumentSource = rp;
            rp.CreateDocument();
        }
        private void In_PhieuPhat_Load(object sender, EventArgs e)
        {
            creater_in("Nguyễn Văn An", "Cữu âm chân kinh", "100000");
        }
    }
}