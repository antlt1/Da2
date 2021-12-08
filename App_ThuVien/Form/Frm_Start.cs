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

namespace App_ThuVien.Form
{
    public partial class Frm_Start : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Start()
        {
            InitializeComponent();
        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Start_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.F)
            {
                lb_exit_Click(sender,e);
            }
        }

        private void Frm_Start_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}