using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using Test_Sqlite.Class;

namespace App_ThuVien.ThongKe
{
    public partial class Tk_Sach : DevExpress.XtraEditors.XtraForm
    {
        Getting_UI G_U = new Getting_UI();
        DataTable ThongKeSach()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ThuTu", typeof(String)); // số thứ tự
            dt.Columns.Add("Sach", typeof(String));
            dt.Columns.Add("Tong", typeof(String)); // tổng theo select 
            /// add csdl giả
            /// 
            // data row thông kê
            DataRow dr = null;
            List<string> list_sach = new List<string>();
            list_sach.Add("Sách hư");
            list_sach.Add("Sách mất");
            list_sach.Add("Sách đã trả");
            list_sach.Add("Sách đng mượn");
            string[] list_tong = {
                G_U.mysqli_ex_data("select count(*) from phat where lydo = 'Hư sách'"),
                G_U.mysqli_ex_data("select count(*) from phat where lydo = 'Mất sách'"),
                G_U.mysqli_ex_data("select count(*) from thongtin_muon where trangthai  = 'Đã trả'"),
                G_U.mysqli_ex_data("select count(*) from thongtin_muon where trangthai  = 'Đang mượn'")};
            int count = 0;
            Random rand = new Random();
            foreach (string i in list_sach)
            {
                int tong = rand.Next(100, 10000);                
                dr = dt.NewRow();
                dr["ThuTu"] = count.ToString() ;
                dr["Sach"] = i;
                dr["Tong"] = list_tong[count];
                dt.Rows.Add(dr);
                count++;
            }
            return dt;

        }

        DataTable ThongKeNgDung()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ThuTu", typeof(String)); // số thứ tự
            dt.Columns.Add("NguoiDung", typeof(String));
            dt.Columns.Add("Tong", typeof(String)); // tổng theo select 
            /// add csdl giả
            /// 
            // data row thông kê
            DataRow dr = null;
            List<string> list_sach = new List<string>();
            list_sach.Add("Bạn đọc");
            list_sach.Add("Nhân viên");
            list_sach.Add("Quản trị thư viện");
            string[] list_tong = {
                G_U.mysqli_ex_data("select count(*) from bandoc"),
                G_U.mysqli_ex_data("select count(*) from taikhoan t , chucvu c WHERE t.id_chucvu = c.id_chucvu and c.ten_chucvu = 'Nhân viên'"),
                G_U.mysqli_ex_data("select count(*) from taikhoan t , chucvu c WHERE t.id_chucvu = c.id_chucvu and c.ten_chucvu != 'Nhân viên'") };
                    
            int count = 0;
            Random rand = new Random();
            foreach (string i in list_sach)
            {
                int tong = rand.Next(100, 10000);
                dr = dt.NewRow();
                dr["ThuTu"] = count.ToString();
                dr["NguoiDung"] = i;
                dr["Tong"] = list_tong[count];
                dt.Rows.Add(dr);
                count++;
            }
            return dt;

        }





        // tạo biểu đồ
        void TaoBieuDo( string tencot/* table , string dr tên của cột   */) //  tuỳ biến get theo data table -< > - // sách // nhân viên /  khách hàng 
        {
            /// choose if else
            /// 
            string title = "";
            Series se1 = new Series("Title thôi", ViewType.Pie); //
            if (tencot == "Sach") // lấy trong đây  --> sach
            {
                // try vấn
                title = "Sách";
                foreach (DataRow dr in /* table */ ThongKeSach().Rows)
                {
                    se1.Points.Add(new SeriesPoint(dr["Sach"] , dr["Tong"]));
                }
            }
            else if (tencot == "NguoiDung")
            {
                title = "Tài khoản";
                // hmm
                foreach (DataRow dr in /* table */ ThongKeNgDung().Rows)
                {
                    se1.Points.Add(new SeriesPoint(dr["NguoiDung"], dr["Tong"]));
                }

            }
            else if (tencot == "Phieu")
            {
                title = "Phiếu mượn và trả";
            }
            ChartControl ThongKe1 = new ChartControl();
            ThongKe1.Titles.Add(new DevExpress.XtraCharts.ChartTitle() { Text = string.Format("Thống kê {0}",title) });
            se1.Label.TextPattern = "{A}: {VP:p2}";
            se1.LegendTextPattern = "{A}";
            ((PieSeriesLabel)se1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((PieSeriesLabel)se1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            // view
            PieSeriesView view = (PieSeriesView)se1.View;
            // Data srouce
            se1.ArgumentDataMember = "Sach";
            se1.ValueDataMembers.AddRange(new string[] { "Tong" });
            //document của dev
            ThongKe1.Series.Add(se1);
            // Specify a data filter to explode points.
            view.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
                DataFilterCondition.GreaterThanOrEqual, 9));
            view.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                DataFilterCondition.NotEqual, "Others"));
            view.ExplodeMode = PieExplodeMode.UseFilters;
            view.ExplodedDistancePercentage = 8;
            view.RuntimeExploding = true;

            // Customize the legend.
            ThongKe1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Add the chart to the form.
            ThongKe1.Dock = DockStyle.Fill;
            this.Controls.Add(ThongKe1);

        }
        public Tk_Sach()
        {
            InitializeComponent();
        }
        public void choose_tk(string choose)
        {
            if (choose == "Sach")
            {
                TaoBieuDo("Sach");
            }
            else if (choose == "NguoiDung")
            {
                TaoBieuDo("NguoiDung");
            }else
            {
                TaoBieuDo("Phieu");
            }
        }
        private void Tk_Sach_Load(object sender, EventArgs e)
        {
        }
        // choose
        // 
        /*
            thông kê theo sách ->
            theo người dùng ( khách hàng và nhân viên count(*)
            count(*) tổng phiếu đang mượn
            // tổng sách có trong thư viện <-> tổng đaq mượn 
            
         */
    }
}