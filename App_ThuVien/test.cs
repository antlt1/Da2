using App_ThuVien.Form;
using DevExpress.XtraCharts;
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
using Test_Sqlite.Class;
using MySql.Data.MySqlClient;

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
        Getting_UI G_U = new Getting_UI();

        private void test_Load(object sender, EventArgs e)
        {
           
        }

        //private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
