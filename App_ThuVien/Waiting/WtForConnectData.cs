using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;
using System.Threading;
using DevExpress.XtraSplashScreen;

namespace App_ThuVien.Waiting
{
    public partial class WtForConnectData : WaitForm
    {
        public WtForConnectData()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }
        public void stop()
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(10);
                if (i == 49)
                {
                    this.Close();
                }
            }
           
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressPanel1_Click(object sender, EventArgs e)
        {

        }

        private void WtForConnectData_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(20);
            }
            this.Close();
        }
    }
}