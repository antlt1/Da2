using App_ThuVien.Class;
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

namespace App_ThuVien.Console
{
    public partial class SuaDiemThanThien : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public SuaDiemThanThien()
        {
            InitializeComponent();
        }
        string val_tt;
        DataTable dt = new DataTable();
        void create_tb()
        {
            dt.Columns.Add("ravao", typeof(String));
            dt.Columns.Add("thanhtoan", typeof(String));
            dt.Columns.Add("matsach", typeof(String));
            dt.Columns.Add("husach", typeof(String));
        }
        string ravao, thanhtoan, matsach, husach;
        void set_val()
        {
            foreach(DataRow dr in dt.Rows)
            {
                ravao = dr["ravao"].ToString();
                thanhtoan = dr["thanhtoan"].ToString();
                matsach = dr["matsach"].ToString();
                husach = dr["husach"].ToString();
            }
        }
        void changed_val(string r , string t , string m , string h)
        {
            dt = new DataTable();
            create_tb();
            DataRow dr = null;
            dr = dt.NewRow();
            dr["ravao"] = r; // "5";
            dr["thanhtoan"] = t;// "20";
            dr["matsach"] = m;// "3";
            dr["husach"] = h;// "10";
            dt.Rows.Add(dr);
            val_tt = string.Format("{0},{1},{2},{3},", dr["ravao"].ToString(), dr["thanhtoan"].ToString(),
                dr["matsach"].ToString(), dr["husach"].ToString());
            Setting_sys.set_src_file("DiemThanThien.txt", val_tt);
        }
         string term = "";
                int count = 0;
       public  DataTable DT_DiemThanThien()
        {

            if (Setting_sys.getting_src_file("DiemThanThien.txt").Length > 0)
            {
               
                foreach(char i in Setting_sys.getting_src_file("DiemThanThien.txt"))
                {
                    if(i == ',')
                    {
                    //    Setting_sys.mess(count.ToString());
                        if(count == 0)
                        {
                            ravao = term;
                        }else if(count == 1)
                        {
                            thanhtoan = term;
                        }
                        else if (count == 2)
                        {
                            matsach = term;
                        }
                        else if (count == 3)
                        {
                            husach = term;
                        }
                        term = null;
                        count++;
                    }
                    else
                    {
                        term += i.ToString();
                    }
                }
               // Setting_sys.mess(string.Format("{0},{1},{2},{3}", ravao, thanhtoan, matsach, husach));
                changed_val(ravao, thanhtoan, matsach, husach);
                return dt;
            }
            else
            {
                changed_val("5", "15", "4", "10");
                return dt;
            }
        }
        private void SuaDiemThanThien_Load(object sender, EventArgs e)
        {
            gc_diemthanthien.DataSource =  DT_DiemThanThien();
            set_val();
        }

        private void gv_diemthanthien_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string column = gv_diemthanthien.FocusedColumn.FieldName.ToString();
            string val = gv_diemthanthien.GetRowCellValue(e.RowHandle, e.Column).ToString();
            if(column == "ravao")
            {
                ravao = val;
            }else if(column == "thanhtoan")
            {
                thanhtoan = val;
            }else if(column == "husach")
            {
                husach = val;
            }
            else
            {
                matsach = val;
            }
            changed_val(ravao, thanhtoan,matsach, husach);
        }
    }
}