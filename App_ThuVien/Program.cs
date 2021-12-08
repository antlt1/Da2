using App_ThuVien;
using App_ThuVien.Console;
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
using ThuVien.Class;
using ThuVien.Design;

namespace ThuVien
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
                //Application.Run(new App_ThuVien.Form.Frm_Start());
                Application.Run(new FrmThuVien());
                //Application.Run(new test());
            }
        }
    }
    }
