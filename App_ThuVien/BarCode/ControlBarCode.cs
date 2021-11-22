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

namespace App_ThuVien.BarCode
{
    public partial class ControlBarCode : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public ControlBarCode()
        {
            InitializeComponent();
        }
        //thiết lập các frm
        FilterInfoCollection fill;
        VideoCaptureDevice videocam;
        private void ControlBarCode_Load(object sender, EventArgs e)
        {
            cbx_thietbi.Hide();
            fill = new FilterInfoCollection(FilterCategory.VideoInputDevice); // kiểm tra thông tin camera có trong thiết bị
            foreach (FilterInfo device in fill) // đổ dl ra combo box
            {
                cbx_thietbi.Items.Add(device.Name);
                cbx_thietbi.SelectedIndex = 0;
            }
            
        }
        string get_barcode;
        MJPEGStream stream;
        private void stream_NewFrame_1(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pic_qr.Image = bmp;
        }
        public string barcode;
        private void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)//  tao frame
        {

            if (videocam.IsRunning)
            {
                Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
                BarcodeReader br = new BarcodeReader();
                var result = br.Decode(bit);
                if (result != null)
                {
                }
                pic_qr.Image = bit;
            }
            else
            {
                Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
                pic_qr.Image = bmp;
            }
        }
        ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)pic_qr.Image;
            if (img != null)
            {
                try
                {
                    ZXing.Result result = Reader.Decode(img);
                    barcode = result.ToString().Trim();
                    img.Dispose();
                }
                catch (Exception ex)
                {
                  //  Console.WriteLine(ex.Message + "");
                }

            }
        }

        private void ControlBarCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
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
                stream.NewFrame += stream_NewFrame_1;
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
    }
}