using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using ThuVien.Class;
using App_ThuVien.Class;

namespace App_ThuVien.BarCode
{
    public partial class ControlBarCode : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public ControlBarCode()
        {
            InitializeComponent();
        }
        #region Khai báo biến
        //thiết lập các frm
        DataTable dt;
        List<int> list_kh = new List<int>();
        Getting_UI G_U = new Getting_UI();
        #endregion

        private void ControlBarCode_Load(object sender, EventArgs e)
        {
            #region Các biến column dattable
            dt = new DataTable();
            dt.Columns.Add("id_taikhoan", typeof(String));
            dt.Columns.Add("ten", typeof(String));
            dt.Columns.Add("thoigian", typeof(String));
            #endregion

        }
        #region Các fame xủ lý frame 
        string get_barcode;
        MJPEGStream stream;
        private void stream_NewFrame_1(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            if (bmp != null)
            {
                pic_qr.Image = bmp;
            }
           
        }
        public string barcode;
        private void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)//  tao frame
        {      
                Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
                if (bmp != null)
                {
                    pic_qr.Image = bmp;
                }
        }
        ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
       public static int count_kh;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)pic_qr.Image;
            if (img != null)
            {
                try
                {
                    ZXing.Result result = Reader.Decode(img);
                    if (list_kh.IndexOf(int.Parse(result.ToString().Trim())) < 0 )
                    {
                        list_kh.Add(int.Parse(result.ToString().Trim()));
                        gc_list_kh.DataSource = add_kh(result.ToString().Trim());
                        count_kh++;
                    }
                    //img.Dispose();
                }
                catch (Exception)
                {
                  //  Console.WriteLine(ex.Message + "");
                }

            }
        }
        #endregion
        #region Thêm khách hàng vào gid và cộng điểm thân thiện (:
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
                string.Format("select diem_thanthien from bandoc where id_taikhoan = {0}", str)), diemcong = "";
            foreach (char i in Setting_sys.getting_src_file("DiemThanThien.txt"))
            {
                if (i == ',')
                {
                    break;
                }
                diemcong += i.ToString();
            }
            int t = int.Parse(diemcong) + int.Parse(diemthanthien);
            G_U.ex_cmd(string.Format("update bandoc set diem_thanthien = {0} where id_taikhoan = {1}", t, str));
            return dt;
        }
        #endregion
        private void ControlBarCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void thiếtBịVậtLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void droidCamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (btn_connect.Text == "Kết nối")
            {
                stream = new MJPEGStream(txt_link.Text);
                stream.NewFrame += stream_NewFrame;
                stream.Start();
                timer1.Enabled = true;
                timer1.Start();
                btn_connect.Text = "Ngừng";
            }
            else
            {
                btn_connect.Text = "Kết nối";
                stream.Stop();
                timer1.Stop();
            }
        }

        private void ControlBarCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btn_scaner_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          
            try
            {
                if (G_U.mysqli_ex_data(string.Format("select count(*) from bandoc where id_taikhoan = {0}", btn_scaner.Text)) != "0")
                {
                    list_kh.Add(int.Parse(btn_scaner.Text));
                    gc_list_kh.DataSource = add_kh(btn_scaner.Text);
                    count_kh++;
                }
                else
                {
                    Setting_sys.mess("Mã bạn đọc không tồn tại !");
                }
              
            }
            catch (Exception)
            {
             
            }
        }
    }
}