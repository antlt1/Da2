using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Test_Sqlite.Class
{
      class Getting_UI
    {
        // check xampp and running this (: cre : Anz ))
        public void check_xampp()
        {
            if (Directory.Exists(@"C:\xampp") == false)
            {
                MessageBox.Show("Bạn chưa cài đặt xampp trên máy hệ thống sẽ tự động chuyển qua cài đặt xampp!");
                System.Diagnostics.Process.Start("https://www.apachefriends.org/download.html");

            }
            else if (Directory.Exists(@"C:\xampp") == true && Process.GetProcessesByName("xampp-control").Length == 0)
            {

                Process.Start(Application.StartupPath + @"\Data\Run_app.bat");

            }
            else if (Directory.Exists(@"C:\xampp") == true && Process.GetProcessesByName("xampp-control").Length > 0)
            {
                MessageBox.Show("Xampp đaq dược chạy");
            }
        }

      // land for mysql
        public MySqlCommand mysql_cmd;
        public MySqlDataAdapter mysql_da;
        //
        public DataTable dt;

        // str connect mysql free )) and sqlite
        public MySqlConnection connect_mysqli()
        {
           string   s1 =   "datasource=https://databases-auth.000webhost.com,port:3306,username=id15353028_admin,password=Antlt1182000@gmail.com,database=id15353028_db_qltv_anz",
                    s2 = "Server=localhost;Database=thuvien;port=;User Id=root;password=",
                    s3 = "datasource=26.9.216.208:8080;Database=thuvien;port=;User Id=root;password=";

            string str = s2,str1=s1;
            MySqlConnection conn = new MySqlConnection(s3);
            return conn;
        }
        // login
        public int mysqli_ex(string str)
        {
            using (MySqlConnection conn = connect_mysqli())
            {
                mysql_cmd = new MySqlCommand(str, conn);
                return int.Parse(mysql_cmd.ExecuteScalar().ToString());
            }
        }
        // return table
        public DataTable mysqli_ex_value_tb(string str)
        {
            using (MySqlConnection conn = connect_mysqli())
            {
                conn.Open();
                mysql_da = new MySqlDataAdapter(str, conn);
                dt = new DataTable();
                mysql_da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        //return data
        public string mysqli_ex_data(string str)
        {
            string data;
            using (MySqlConnection conn = connect_mysqli())
            {
                conn.Open();
                mysql_cmd = new MySqlCommand(str, conn);
                data = mysql_cmd.ExecuteScalar().ToString();
                conn.Close();
                return data;
            }
            
           
        }
        // truy van csdl
        public void ex_cmd(string str)
        {
            MySqlConnection conn = connect_mysqli();
            conn.Open();
            //
            mysql_cmd = new MySqlCommand(str,conn);
            mysql_cmd.ExecuteNonQuery();
            conn.Close();
        }
        // hàm đếm
        public int count_val(string str)
        {
            MySqlConnection conn = connect_mysqli();
            conn.Open();
            //
            mysql_cmd = new MySqlCommand(str, conn);
            return int.Parse(mysql_cmd.ExecuteScalar().ToString());
        }
        // gand quyền
        public bool gand_admin(string src)
        {
            string cmd = string.Format("SELECT c.ten_chucvu FROM chucvu c , taikhoan t WHERE  t.id_chucvu = c.id_chucvu and t.id_TaiKhoan = {0}",src);
            if (mysqli_ex_data(cmd) == "Admin")
            {
                return true;
            }
            return false;
        }
        public string rt_user(string id_taikhoan)
        {
            using (MySqlConnection conn = connect_mysqli())
            {
                conn.Open();
                mysql_cmd = new MySqlCommand(string.Format("select hoten from taikhoan where id_taikhoan = {0} ", id_taikhoan), conn);
                return mysql_cmd.ExecuteScalar().ToString();
            }
        }
        // land for sqlite
        //connecting sqlite ~~ function sqlite
        SQLiteCommand sqlite_cmd;
        //SQLiteDataReader sqlite_dr;
        SQLiteDataAdapter sqlite_da;
        //
        public SQLiteConnection connect_sqlite()
        {
            string str = string.Format(@"Data Source={0}\Database\Getting_UI.db", Application.StartupPath);
            SQLiteConnection conn = new SQLiteConnection(str);
            return conn;
        }
        // sever data Log_login
       public void save_log(string c , string u , string p){
           using (SQLiteConnection conn = connect_sqlite())
           {
               conn.Open();
               string str = string.Format("update log_login set status = {0} , name = '{1}' , pass = '{2}'",
                 c,u,p  );
               sqlite_cmd = new SQLiteCommand(str, conn);
               sqlite_cmd.ExecuteNonQuery();
               conn.Close();
           }
       }
        // return datatable login
       public DataTable sqlite_ex_data()
       {
           using (SQLiteConnection conn = connect_sqlite())
           {
               conn.Open();
               string str = "select * from log_login";
               dt = new DataTable();
               sqlite_da = new SQLiteDataAdapter(str,conn);
               sqlite_da.Fill(dt);
               return dt;
           }
       } 


        // check login UI
        public string check_login()
        {
            using (SQLiteConnection conn = connect_sqlite())
            {
                conn.Open();
                sqlite_cmd = new SQLiteCommand("select status from Log_login ", conn);
                return sqlite_cmd.ExecuteScalar().ToString();
            }
        }
        
        // Land getting csdl
        int diem;
        public string creater_id(string id, string from)
        {
            foreach (DataRow dr in mysqli_ex_value_tb(string.Format("select {0} from {1} order by {1}.{0} asc  ", id, from)).Rows)
            {
                diem++;
                if (diem == int.Parse(dr[id].ToString())) { } // hav't thing
                else
                {
                    return diem.ToString();
                }
            }
            diem++;
            return diem.ToString();
        }
    }
}
