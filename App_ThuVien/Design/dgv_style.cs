using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_ThuVien.Design
{
    public partial class dgv_style : UserControl
    {
        public dgv_style()
        {
            InitializeComponent();
        }
        // value result
        public string result_val;
        string colum;
        public void set_colum(string colum)
        {
            this.colum = colum;
        }
        //
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            result_val = gridView1.GetRowCellValue(e.RowHandle,colum).ToString();
          //  MessageBox.Show(result_val);
        }
    }
}
