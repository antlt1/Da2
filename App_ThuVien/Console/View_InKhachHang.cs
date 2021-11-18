using App_ThuVien.Form;
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
    public partial class View_InKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public View_InKhachHang()
        {
            InitializeComponent();
        }
        //View_InKhachHang fr_rp = new View_InKhachHang();
        App_ThuVien.Report.Rp_TheBanDoc rp = new App_ThuVien.Report.Rp_TheBanDoc();
        public void add_Val(string hovaten , string diachi)
        {
             rp = new App_ThuVien.Report.Rp_TheBanDoc();
            //rp.DataSource = ;
            rp.add_Val(hovaten,diachi);
        }
        private void View_InKhachHang_Load(object sender, EventArgs e)
        {
            view_rp.DocumentSource = rp;
            rp.CreateDocument();
           
        }
    }
}