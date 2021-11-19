using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Sqlite.Class;
using System.IO;
using App_ThuVien.Class;

namespace App_ThuVien.BarCode
{
    public partial class Frm_KhRaVao : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Frm_KhRaVao()
        {
            InitializeComponent();
        }
        App_ThuVien.BarCode.ControlBarCode barcode = new App_ThuVien.BarCode.ControlBarCode();
        private void Frm_KhRaVao_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // frm bar code
            show();
        }
        void show()
        {
            barcode.Show();
        }
        public string makh, tenkh, time;
        public bool add_val;
        //
       
        void clear_status()
        {
            makh = null;
            tenkh = null;
            time = null;
            add_val = false;
        }
        Getting_UI G_U = new Getting_UI();
        public DataTable add_kh(string str)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("id_taikhoan", typeof(String));
            dt.Columns.Add("ten", typeof(String));
            dt.Columns.Add("thoigian", typeof(String));
            DataRow dr = null;
            dr = dt.NewRow();
            dr["id_taikhoan"] = str;
            dr["ten"] = G_U.mysqli_ex_data(string.Format("select hoten from bandoc where id_taikhoan = {0}", str));
            dr["thoigian"] = DateTime.Now.ToShortDateString();
            dt.Rows.Add(dr);
            // cộng điểm thân thiện
            string diemthanthien = G_U.mysqli_ex_data(
                string.Format("select diem_thanthien from bandoc where id_taikhoan = {0}",str)), diemcong = "";
            foreach (char i in Setting_sys.getting_src_file("DiemThanThien.txt"))
            {
                if ( i == ',')
                {
                    break;
                }
                diemcong += i.ToString();
            }
            int t = int.Parse(diemcong) + int.Parse(diemthanthien);
            G_U.ex_cmd(string.Format("update khachhang set diemthanthien = {0} where id_taikhoan = {1}",t,str));
            return dt;
        }
        List<string> list_kh = new List<string>();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (list_kh.IndexOf(barcode.barcode) < 0 && barcode.barcode != " " && barcode.barcode != null )
            {
                makh = barcode.barcode;
                gc_list_kh.DataSource = add_kh(makh);
                SystemSounds.Question.Play();
                list_kh.Add(makh);
            }
            else
            {
                clear_status();
                barcode.barcode = null;
            }
        }
    }
}