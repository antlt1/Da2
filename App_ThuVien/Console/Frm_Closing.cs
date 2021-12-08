using App_ThuVien.Class;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThuVien.Class;

namespace App_ThuVien.Console
{
    public partial class Frm_Closing : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Frm_Closing()
        {
            InitializeComponent();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            if (btn.Name == "btn_close")
            {
                if (checker.Checked)
                {
                    G_U.Changer_hide_close("close");
                }
                Environment.Exit(0);
            }
            else if (btn.Name == "btn_hide")
            {
                if (checker.Checked)
                {
                    G_U.Changer_hide_close("hide");
                }
                stt = 1;
                this.Close();
               // XtraMessageBox.Show("vc");
            }
            else
            {
                this.Close();
            }
        }
        public int stt;
        private void checker_CheckedChanged(object sender, EventArgs e)
        {
            btn_cancel.Enabled = (checker.Checked) ? false : true;
        }
        Getting_UI G_U = new Getting_UI();
        
        private void Frm_Closing_Load(object sender, EventArgs e)
        {
            
        }

        private void Frm_Closing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stt != 1)
            {
                stt = 2;
            }
        }
    }
}
