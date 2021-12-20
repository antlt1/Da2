
namespace App_ThuVien.Form
{
    partial class Frm_Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Start));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(0, 0);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(957, 442);
            this.imageSlider1.TabIndex = 0;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // Frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 442);
            this.ControlBox = false;
            this.Controls.Add(this.imageSlider1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Start";
            this.Text = "Frm_Start";
            this.Load += new System.EventHandler(this.Frm_Start_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Start_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
    }
}