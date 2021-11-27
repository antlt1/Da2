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
using DevExpress.XtraBars.Navigation;

namespace App_ThuVien.Form
{
    public partial class Frm_ThongKe : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Frm_ThongKe()
        {
            InitializeComponent();
        }
      
        Getting_UI G_U = new Getting_UI();
        // hàm thống kê theo tháng
     

        void BieuDoLine(DateTime dt_start, DateTime dt_finelly, TabNavigationPage tab) // 12 - 11
        {
            ChartControl lineChart = new ChartControl();
            // Create a line series.
            Series series1 = new Series("Sách mượn đã trả", ViewType.Line);
            Series series2 = new Series("Sách mượn chưa chả", ViewType.Line);
            int result_time = dt_finelly.Month - dt_start.Month;
            for (int i = dt_start.Month; i <= dt_finelly.Month; i++)
            {          
                string cmd1 = G_U.mysqli_ex_data(string.Format(
            "select count(*) as 'time' from thongtin_muon where month(ngaytra) = {0} and trangthai = 'Đả trả'", i));
                string cmd2 = G_U.mysqli_ex_data(string.Format(
            "select count(*) as 'time' from thongtin_muon where month(ngaytra) = {0} and trangthai != 'Đả trả'", i));
                series1.Points.Add(new SeriesPoint(i, int.Parse(cmd1))); ;
                series2.Points.Add(new SeriesPoint(i, int.Parse(cmd2)));
            }
            lineChart.Series.Add(series1);
            lineChart.Series.Add(series2);
            series1.ArgumentScaleType = ScaleType.Numerical;
            // Access the view-type-specific options of the series.
            ((LineSeriesView)series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
            ((LineSeriesView)series1.View).LineStyle.DashStyle = DashStyle.Dash;
            ((LineSeriesView)series2.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series2.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
            ((LineSeriesView)series2.View).LineStyle.DashStyle = DashStyle.Dash;
            // Access the type-specific options of the diagram.
            ((XYDiagram)lineChart.Diagram).EnableAxisXZooming = true;

            // Hide the legend (if necessary).
            lineChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Add a title to the chart (if necessary).
            lineChart.Titles.Add(new ChartTitle());
            lineChart.Titles[0].Text = "A Line Chart";

            // Add the chart to the form.
            lineChart.Dock = DockStyle.Fill;
            // panelControl1.Controls.Add(lineChart);
            if (!tab_thongke.Controls.Contains(tab))
            {
                tab_thongke.Controls.Add(tab);
                tab_thongke.SelectedPage = tab;
            }
            else
            {
                tab_thongke.SelectedPage = tab;
            }
        }
        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
           
           
        }

        private void tab_thongke_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            //e.Page
        }

        private void tab_sach_Click(object sender, EventArgs e)
        {

        }
    }
}