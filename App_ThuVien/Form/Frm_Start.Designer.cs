
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "App Quản Lý Thư Viện";
            // 
            // lb_exit
            // 
            this.lb_exit.AutoSize = true;
            this.lb_exit.Location = new System.Drawing.Point(808, 401);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(0, 26);
            this.lb_exit.TabIndex = 1;
            this.lb_exit.Click += new System.EventHandler(this.lb_exit_Click);
            // 
            // Frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 462);
            this.Controls.Add(this.lb_exit);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Start";
            this.Text = "Frm_Start";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Start_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_exit;
    }
}