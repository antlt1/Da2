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
        DataTable Thong_Ke() {
            DataTable tb,tb_val;
            tb_val = G_U.mysqli_ex_value_tb("SELECT s.id_sach , s.ten_sach , s.ngaysx , s.soluong  FROM sach s");
            tb = new DataTable("ThongKe");
            tb.Columns.Add("Tên Sách", typeof(String));
            for (int i = 1 ; i <= 12; i++)
            {
                tb.Columns.Add(string.Format("Tháng {0}",i.ToString()),typeof(Int32));
            }
            if (tb_val != null)
            {

                foreach (DataRow dr in tb_val.Rows)
                {
                    DataRow rw_val = null;
                    if (DateTime.Parse(dr["ngaysx"].ToString()).ToString("yyyy") == "2021")
                    {
                        string thang = DateTime.Parse(dr["ngaysx"].ToString()).ToString("MM");
                        rw_val = tb.NewRow();
                        rw_val["Tên Sách"] = dr["ten_sach"].ToString();
                        switch (thang)
                        {
                            case "01":
                                {
                                    rw_val["Tháng 1"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }
                            case "02":
                                {
                                    rw_val["Tháng 2"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }
                            case "03":
                                {
                                    rw_val["Tháng 3"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }
                            case "04":
                                {
                                    rw_val["Tháng 4"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }
                            case "05":
                                {
                                    rw_val["Tháng 5"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }
                            case "06":
                                {
                                    rw_val["Tháng 6"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }
                            case "07":
                                {
                                    rw_val["Tháng 7"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }
                            case "08":
                                {
                                    rw_val["Tháng 8"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }
                            case "09":
                                {
                                    rw_val["Tháng 9"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }
                            case "10":
                                {
                                    rw_val["Tháng 10"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }
                            case "11":
                                {
                                    rw_val["Tháng 11"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }
                            case "12":
                                {
                                    rw_val["Tháng 12"] = int.Parse(dr["soluong"].ToString());
                                    tb.Rows.Add(rw_val);
                                    break;
                                }

                        }
                        //XtraMessageBox.Show(dr["ten_sach"].ToString()+DateTime.Parse(dr["ngaysx"].ToString()).ToString("MM"));
                    }

                }
            }
            return tb;
        }
        
        DataTable Thong_Ke_Val()
        {
            DataTable tb, tb_val;
            tb_val = G_U.mysqli_ex_value_tb("SELECT s.id_sach , s.ten_sach , s.ngaysx , s.soluong  FROM sach s");
            tb = new DataTable("ThongKe");
            tb.Columns.Add("Tên Sách", typeof(String));
            for (int i = 1; i <= 12; i++)
            {
                tb.Columns.Add(string.Format("Tháng {0}", i.ToString()), typeof(Int32));
            }
            // set val tháng
            
            return tb_val;
        }
        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
           
            //dgv.DataSource = Thong_Ke();
            //dgv_val.DataSource = Thong_Ke_Val();
            //foreach(DataRow i in charbar(0).Rows)
            //{
            //    XtraMessageBox.Show(i["date"].ToString());
            //}
            Getting_UI G_U = new Getting_UI();
            Series se = new Series("Sach Viet", ViewType.Bar);
            Series se1 = new Series("Sach AV", ViewType.Bar);
            se.ArgumentDataMember = "Tên Sách";
        //    se.ValueDataMembers = 9;

            se.DataSource = Thong_Ke();
            //se1.DataSource = charbar(60);
            //se.ValueScaleType = ScaleType.Numerical;
            //se.ValueDataMembers.AddRange(new string[] { "ten_theloai" });
            chartControl1.Series.Add(se);
            chartControl1.Series.Add(se1);
        }
    }
}