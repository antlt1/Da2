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
            Getting_UI G_U = new Getting_UI();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           

            if (Process.GetProcessesByName("App_ThuVien").Length >= 2)
            {
                XtraMessageBox.Show("Ứng dụng đã mở rồi !","Hệ thống",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                Application.Exit();
            }
            else
            {
                if (G_U.check_login() == "0")
                {
                    Application.Run(new Login());
                }
                else
                {
                    var frm_traqthai = new App_ThuVien.Console.Ex_QlMuon();
                    frm_traqthai.trangthai();
                    Application.Run(new FrmThuVien());
                }
            }
           // if()

        }
    }
    }
