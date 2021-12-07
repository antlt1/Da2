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
using App_ThuVien.Class;
using MySql.Data.MySqlClient;

namespace App_ThuVien.ThongKe
{
    public partial class Frm_ThongKe : DevExpress.XtraEditors.XtraForm
    {
        
        public Frm_ThongKe()
        {
            InitializeComponent();
        }
        Getting_UI G_U = new Getting_UI();
        // hàm thống kê theo tháng
        public string result = "Thống kê sách";
        void Line_ThongKe(DateTime dt_start, DateTime dt_finelly, PanelControl pn)
        {
            pn_sach.Controls.Clear();
            ChartControl chartControl1 = new ChartControl();
            if (result == "Thống kê sách")
            {
                Series Series1 = new Series("Sách mượn đã trả", ViewType.Line);
                Series Series2 = new Series("Sách mượn chưa chả", ViewType.Line);
                Series Series3 = new Series("Tổng sách đã phạt", ViewType.Line);
                int result_time = dt_finelly.Month - dt_start.Month;
                for (int i = dt_start.Month; i <= dt_finelly.Month; i++)
                {
                    string cmd1 = G_U.mysqli_ex_data(string.Format(
                "select count(*) as 'time' from thongtin_muon where month(ngaytra) = {0} and trangthai = 'Đả trả'", i));
                    string cmd2 = G_U.mysqli_ex_data(string.Format(
                "select count(*) as 'time' from thongtin_muon where month(ngaytra) = {0} and trangthai != 'Đả trả'", i));
                    string cmd3 = G_U.mysqli_ex_data(string.Format(
                "select count(*) from phat where month(ngayphat) = {0}", i));
                    Series1.Points.Add(new SeriesPoint(i, int.Parse(cmd1))); ;
                    Series2.Points.Add(new SeriesPoint(i, int.Parse(cmd2)));
                    Series3.Points.Add(new SeriesPoint(i, int.Parse(cmd3)));
                }
                chartControl1.Series.Add(Series1);
                chartControl1.Series.Add(Series2);
                chartControl1.Series.Add(Series3);
                Series1.ArgumentScaleType = ScaleType.Numerical;
                // Access the view-type-specific options of the series.
                ((LineSeriesView)Series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                ((LineSeriesView)Series1.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
                ((LineSeriesView)Series1.View).LineStyle.DashStyle = DashStyle.Dash;
                ((LineSeriesView)Series2.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                ((LineSeriesView)Series2.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
                ((LineSeriesView)Series2.View).LineStyle.DashStyle = DashStyle.Dash;
                ((LineSeriesView)Series3.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                ((LineSeriesView)Series3.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
                ((LineSeriesView)Series3.View).LineStyle.DashStyle = DashStyle.Dash;
            }
            // Access the type-specific options of the diagram.
            ((XYDiagram)chartControl1.Diagram).EnableAxisXZooming = true;
            ((XYDiagram)chartControl1.Diagram).AxisX.Label.TextPattern = "Tháng : {A:#}";
            // Hide the legend (if necessary).
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            // Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill;
            pn.Controls.Add(chartControl1);
        }
        DataTable dt = new DataTable();
       
        private void Tk_Sach_Load(object sender, EventArgs e)
        {
            btn_batdau.Hide();
           // BieuDoLine_Sach(DateTime.Parse("01/01/2021"), DateTime.Parse("12/12/2021"), pn_sach);
        }
        void clear()
        {
            lb_thang_bd.Text = "";
            lb_thang_kt.Text = "";
            pn_sach.Controls.Clear();
        }
        private void btn_batdau_Click(object sender, EventArgs e)
        {
            if (btn_batdau.Text == "Bắt đầu")
            {
                btn_batdau.Text = "Kết thúc";
                Line_ThongKe(DateTime.Parse(lb_thang_bd.Text), DateTime.Parse(lb_thang_kt.Text), pn_sach);
                
            }
            else
            {
                btn_batdau.Hide();
                clear();
                btn_batdau.Text = "Bắt đầu";
            }
        }
        App_ThuVien.Console.Pick_Date_MonthandYear fr_pick = new Console.Pick_Date_MonthandYear();
        bool thang1, thang2;
        private void btn_chon_thang_Click(object sender, EventArgs e)
        {
            if (btn_chon_thang.Text == "Chọn tháng bắt đầu")
            {
                btn_chon_thang.Text = "Chọn tháng kết thúc";
                thang1 = true;
            }
            else
            {
                btn_chon_thang.Text = "Chọn tháng bắt đầu";
                thang2 = true;
            }
            fr_pick.ShowDialog();
            timer1.Start();
        }

        private void lb_batdau_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thang1 == true)
            {
                if (fr_pick.dt != null)
                {
                    lb_thang_bd.Text = fr_pick.dt;
                    timer1.Stop();
                    thang1 = false;
                }
            }
            else if (thang2 == true)
            {
                if (fr_pick.dt != null)
                {
                    lb_thang_kt.Text = fr_pick.dt;
                    btn_batdau.Show();
                    timer1.Stop();
                    thang2 = false;
                }
            }
        }

        private void btn_year_Click(object sender, EventArgs e)
        {
            DateTime dt_bd = DateTime.Parse(string.Format("01/01/{0}",txt_year.Text)),
                     dt_kt = DateTime.Parse(string.Format("12/12/{0}",txt_year.Text));
            Line_ThongKe(dt_bd, dt_kt, pn_sach);
        }
        // Biểu đồ chòn
       // Getting_UI G_U = new Getting_UI();
        public class DataPoint
        {
            public string Argument { get; set; }
            public double Value { get; set; }

            public static List<DataPoint> GetDataPoints()
            {
                Getting_UI G_U = new Getting_UI();
                MySqlConnection con = G_U.connect_mysqli();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select soluong from sach", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                int tong = 0;
                while (dr.Read())
                {
                    tong += dr.GetInt32(0);
                }
                return new List<DataPoint> {
                
                    new DataPoint { Argument = "Sách hư",    Value = int.Parse(G_U.mysqli_ex_data("SELECT COUNT(*) FROM phat WHERE phat.lydo = 'Hư sách'"))},
                    new DataPoint { Argument = "Sách đã trả",    Value = int.Parse(G_U.mysqli_ex_data("SELECT COUNT(*) FROM thongtin_muon t where t.trangthai = 'Đả trả'"))},
                    new DataPoint { Argument = "Sách đang mượn",       Value = int.Parse(G_U.mysqli_ex_data("SELECT COUNT(*) FROM thongtin_muon t where t.trangthai = 'Đang mượn'"))},
                    new DataPoint { Argument = "Sách trong thư viện",     Value = tong},
                };
            }
        }
        public class DL_Phieu
        {
            public string Argument { get; set; }
            public double Value { get; set; }

            public static List<DL_Phieu> GetDataPoints()
            {
                Getting_UI G_U = new Getting_UI();
                MySqlConnection con = G_U.connect_mysqli();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select soluong from sach", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                int tong = 0;
                while (dr.Read())
                {
                    tong += dr.GetInt32(0);
                }
                return new List<DL_Phieu> {
                
                    new DL_Phieu { Argument = "Phiếu phạt",    Value = int.Parse(G_U.mysqli_ex_data("SELECT count(*) FROM phat"))},
                    new DL_Phieu { Argument = "Phiếu đã trả",    Value = int.Parse(G_U.mysqli_ex_data("SELECT COUNT(*) FROM thongtin_muon t where t.trangthai = 'Đả trả'"))},
                    new DL_Phieu { Argument = "Phiếu đang mượn",       Value = int.Parse(G_U.mysqli_ex_data("SELECT COUNT(*) FROM thongtin_muon t where t.trangthai = 'Đang mượn'"))},
                };
            }
        }
        public class DL_NgDung
        {
            public string Argument { get; set; }
            public double Value { get; set; }

            public static List<DL_NgDung> GetDataPoints()
            {
                Getting_UI G_U = new Getting_UI();
                MySqlConnection con = G_U.connect_mysqli();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select soluong from sach", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                int tong = 0;
                while (dr.Read())
                {
                    tong += dr.GetInt32(0);
                }
                return new List<DL_NgDung> {
                
                    new DL_NgDung { Argument = "Nhân viên",    Value = int.Parse(G_U.mysqli_ex_data("SELECT count(*) FROM taikhoan , chucvu where chucvu.id_chucvu = taikhoan.id_chucvu and chucvu.ten_chucvu = 'Nhân viên'"))},
                    new DL_NgDung { Argument = "Quản trị",    Value = int.Parse(G_U.mysqli_ex_data("SELECT count(*) FROM taikhoan , chucvu where chucvu.id_chucvu = taikhoan.id_chucvu and chucvu.ten_chucvu != 'Nhân viên'"))},
                    new DL_NgDung { Argument = "Bạn Đọc",    Value = int.Parse(G_U.mysqli_ex_data("SELECT COUNT(*) FROM bandoc"))},
                };
            }
        }
        void ThongKe(string choose)
        {
            pn_sach.Controls.Clear();
            // Create an empty chart.
            ChartControl pieChart = new ChartControl();

            pieChart.Titles.Add(new ChartTitle() { Text = string.Format("Thống kê {0} ",choose) });

            // Create a pie series.
            Series series1 = new Series("(: just sticker ", ViewType.Pie);

            // Bind the series to data.
            if (choose == "sách")
            {
                series1.DataSource = DataPoint.GetDataPoints();
            }
            else if (choose == "phiếu")
            {
                series1.DataSource = DL_Phieu.GetDataPoints();
            }
            else
            {
                series1.DataSource = DL_NgDung.GetDataPoints();
            }
           
            series1.ArgumentDataMember = "Argument";
            series1.ValueDataMembers.AddRange(new string[] { "Value" });

            // Add the series to the chart.
            pieChart.Series.Add(series1);

            // Format the the series labels.
            series1.Label.TextPattern = "{A}: {V:#}";

            // Format the series legend items.
            series1.LegendTextPattern = "{A}";

            // Adjust the position of series labels. 
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;

            // Detect overlapping of series labels.
            ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the view-type-specific options of the series.
            PieSeriesView myView = (PieSeriesView)series1.View;

            // Specify a data filter to explode points.
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
                DataFilterCondition.GreaterThanOrEqual, 9));
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                DataFilterCondition.NotEqual, "Others"));
            myView.ExplodeMode = PieExplodeMode.UseFilters;
            myView.ExplodedDistancePercentage = 30;
            myView.RuntimeExploding = true;

            // Customize the legend.
            pieChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Add the chart to the form.
            pieChart.Dock = DockStyle.Fill;
            pn_sach.Controls.Add(pieChart);
        }
        //
        
        private void cbox_Tong_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (cbox_Tong.EditValue.ToString() == "Sách")
            {
                ThongKe("sách");
            }
            else if (cbox_Tong.EditValue.ToString() == "Phiếu")
            {
                ThongKe("phiếu");
            }
            else
            {
                //私はアンです！ =))) wà ta shi qua an đê sì```` =))
                ThongKe("tài khoản");
            }
        }
       
    }
}