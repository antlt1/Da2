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
    public partial class txt_hide_underline : UserControl
    {
        public txt_hide_underline()
        {
            InitializeComponent();
        }
        public string text_vl;
        private void text_TextChanged(object sender, EventArgs e)
        {
            text_vl = text.Text;
        }
    }
}
