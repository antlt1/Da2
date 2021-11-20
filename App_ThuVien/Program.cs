using App_ThuVien;
using App_ThuVien.Form;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Sqlite.Class;
using Test_Sqlite.Design;

namespace Test_Sqlite
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           

            if (Process.GetProcessesByName("App_ThuVien").Length >= 2)
            {
                XtraMessageBox.Show("Ứng dụng đã mở rồi !","Hệ thống",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                Application.Exit();
            }
            else
            {
             //   Application.Run(new App_ThuVien.Console.In_PhieuPhat());
               Application.Run(new FrmThuVien());
            }
        }
    }
    }
