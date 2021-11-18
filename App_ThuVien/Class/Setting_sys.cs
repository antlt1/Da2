using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using Test_Sqlite.Class;

namespace App_ThuVien.Class
{
   public static class Setting_sys
    {
        // getting Thông báo
        public static void mess(string str)
        {
            XtraMessageBox.Show(str, "Hệ thống");
        }
        public static void mess(string str , string inf)
        {
            XtraMessageBox.Show(str, inf);
        }
        public static void mess (string str ,MessageBoxButtons btn , MessageBoxIcon ico)
        {
            XtraMessageBox.Show(str, "Hệ thống",btn,ico);
        }

        // design setting giao diện
        public static SQLiteCommand sqlite_cmd;
        //SQLiteDataReader sqlite_dr;
        public static SQLiteDataAdapter sqlite_da;
        //
        public static SQLiteConnection connect_sqlite()
        {
            string str = string.Format(@"Data Source={0}\Database\Getting_UI.db", Application.StartupPath);
            SQLiteConnection conn = new SQLiteConnection(str);
            return conn;
        }
        // sever data Log_login
        public static void save_log(string c, string u, string p)
        {
            using (SQLiteConnection conn = connect_sqlite())
            {
                conn.Open();
                string str = string.Format("update log_login set status = {0} , name = '{1}' , pass = '{2}'",
                  c, u, p);
                sqlite_cmd = new SQLiteCommand(str, conn);
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        // land Laucher Theme
        public static int header_ribbon,
                           left_bar;

        public static void getting_load()
        {
            using (SQLiteConnection conn = connect_sqlite())
            {
                conn.Open();
                sqlite_cmd = new SQLiteCommand("select header_ribbon from laucher",conn);
                header_ribbon = int.Parse(sqlite_cmd.ExecuteScalar().ToString());
                sqlite_cmd = new SQLiteCommand("select left_bar from laucher", conn);
                left_bar = int.Parse(sqlite_cmd.ExecuteScalar().ToString());
                conn.Close();
            }
        }
        public static void set_main_laucher(bool term)
        {
            
        }
       // land FILE
        public static string getting_src_file(string source) // get value
        {
            string src = Application.StartupPath + @"\Resources\" + source; 
            string term = "";
            if (!File.Exists(src))
            {
                File.Create(src);
            }
            else
            {
             //   using(StreamReader sd = new StreamReader())
                term = File.ReadAllText(src);
            }
            return term;
        }
        // set value
        public static void set_src_file(string source,string val)
        {
            string src = Application.StartupPath + @"\Resources\" + source;
            using(TextWriter tw = new StreamWriter(src))
            {
                tw.Write(val);
            }
        }
       
    }
}
