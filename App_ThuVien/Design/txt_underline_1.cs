using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.Design
{
    public partial class txt_underline_1 : UserControl
    {
        public txt_underline_1()
        {
            InitializeComponent();
        }
            public string text_vl;
        public void text_TextChanged(object sender, EventArgs e)
        {
            text_vl = text.Text;
        }
    }
}
