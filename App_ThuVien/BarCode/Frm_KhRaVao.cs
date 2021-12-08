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
using ThuVien.Class;
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
        void set_barcode()
        {

            
            barcode.FormBorderStyle = FormBorderStyle.None;
            barcode.TopLevel = false;
            barcode.Dock = DockStyle.Fill;
            pn_barcode.Controls.Add(barcode);
            barcode.Show();
        }
        void set_lay_after()
        {
            this.Width = 310;
            this.Height = 457;
            pn_barcode.Hide();
            labelControl2.Hide();
        }
        void set_lay_before()
        {
            this.Width = 700;
            this.Height = 457;
            pn_barcode.Show();
            labelControl2.Show();
        }
        private void Frm_KhRaVao_Load(object sender, EventArgs e)
        {
             dt = new DataTable();
            dt.Columns.Add("id_taikhoan", typeof(String));
            dt.Columns.Add("ten", typeof(String));
            dt.Columns.Add("thoigian", typeof(String));
            timer1.Start();
            // frm bar code
            set_barcode();
            //set layout
            set_lay_after();
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
        DataTable dt;
        public DataTable add_kh(string str)
        {

           
            DataRow dr = dt.NewRow();
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
            G_U.ex_cmd(string.Format("update bandoc set diem_thanthien = {0} where id_taikhoan = {1}",t,str));
            return dt;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void click_cam_Click(object sender, EventArgs e)
        {
            if (click_cam.Text == "Bật quét cam")
            {
                click_cam.Text = "Tắt quét cam";
                set_lay_before();
            }
            else
            {
                click_cam.Text = "Bật quét cam";
                set_lay_after();
            }
        }

        private void Frm_KhRaVao_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        List<string> list_kh = new List<string>();
        public int count_num;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (list_kh.IndexOf(barcode.barcode) < 0 && barcode.barcode != " " && barcode.barcode != null )
            {
                makh = barcode.barcode;
                gc_list_kh.DataSource = add_kh(makh);
                SystemSounds.Question.Play();
                list_kh.Add(makh);
                count_num++;
            }
            else
            {
                clear_status();
                barcode.barcode = null;
            }
        }
    }
}