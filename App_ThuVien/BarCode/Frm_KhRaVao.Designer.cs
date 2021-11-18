
namespace App_ThuVien.BarCode
{
    partial class Frm_KhRaVao
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gc_list_kh = new DevExpress.XtraGrid.GridControl();
            this.gv_list_kh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list_kh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(407, 50);
            this.fluentDesignFormControl1.TabIndex = 3;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 390);
            this.textBox1.TabIndex = 4;
            // 
            // gc_list_kh
            // 
            this.gc_list_kh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_list_kh.Location = new System.Drawing.Point(0, 50);
            this.gc_list_kh.MainView = this.gv_list_kh;
            this.gc_list_kh.Name = "gc_list_kh";
            this.gc_list_kh.Size = new System.Drawing.Size(407, 378);
            this.gc_list_kh.TabIndex = 5;
            this.gc_list_kh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_list_kh});
            // 
            // gv_list_kh
            // 
            this.gv_list_kh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_list_kh.GridControl = this.gc_list_kh;
            this.gv_list_kh.Name = "gv_list_kh";
            this.gv_list_kh.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã bạn đọc";
            this.gridColumn1.FieldName = "id_taikhoan";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên bạn đọc";
            this.gridColumn2.FieldName = "ten";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Vào lúc";
            this.gridColumn3.FieldName = "thoigian";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 112;
            // 
            // Frm_KhRaVao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 428);
            this.Controls.Add(this.gc_list_kh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Frm_KhRaVao";
            this.Text = "Ra vào";
            this.Load += new System.EventHandler(this.Frm_KhRaVao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list_kh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list_kh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraGrid.GridControl gc_list_kh;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_list_kh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}