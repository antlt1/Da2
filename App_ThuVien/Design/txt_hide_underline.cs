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
            if (text.Text.Length > 0)
            {
                if (text.Properties.UseSystemPasswordChar == true)
                {
                    img_show.Show();
                }
                else
                {
                    img_hide.Show();
                }
              //  text.Properties.ContextImageOptions.s;
            }
            else
            {
                img_hide.Hide();
                img_show.Hide();
            }
        }

        private void text_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void txt_hide_underline_Load(object sender, EventArgs e)
        {
            if (text.Properties.UseSystemPasswordChar == true)
            {
                img_show.Hide();
                
            }
            else
            {
                img_hide.Hide();
            }
        }

        private void img_show_Click(object sender, EventArgs e)
        {
            text.Properties.UseSystemPasswordChar = false;
            img_show.Hide();
            img_hide.Show();
        }

        private void img_hide_Click(object sender, EventArgs e)
        {
            text.Properties.UseSystemPasswordChar = true;
            img_hide.Hide();
            img_show.Show();
        }
    }
}
