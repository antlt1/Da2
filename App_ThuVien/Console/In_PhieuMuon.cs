using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_ThuVien.Console
{
    public partial class In_PhieuMuon : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public In_PhieuMuon()
        {
            InitializeComponent();
        }
        public void cre_print(string id_pm)
        {
            var rp = new App_ThuVien.Report.Rp_PhieuMuon();
            rp.load_val(id_pm);
            dView.DocumentSource = rp;
            rp.CreateDocument();
        }
        private void In_PhieuMuon_Load(object sender, EventArgs e)
        {

        }
    }
}
