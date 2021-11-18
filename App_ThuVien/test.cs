using App_ThuVien.Form;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_ThuVien
{
    public partial class test : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public test()
        {
            InitializeComponent();
        }

        private void tabFormControl1_Click(object sender, EventArgs e)
        {
            var f1 = new Frm_Sach();
            f1.MdiParent = this;
            f1.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //XtraMessageBox.Show("app : " + Process.GetProcessesByName(Path.GetFileNameWithoutExtension(textEdit1.Text)).Length.ToString());
            //int RootProcessId = Process.GetCurrentProcess().Id;
            
           
        }

        private void test_Load(object sender, EventArgs e)
        {
          //  rbcontrol1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
//;           rbcontrol1.Hide();
        }
    }
}