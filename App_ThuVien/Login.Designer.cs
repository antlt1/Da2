namespace ThuVien
{
    partial class Login
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
            DevExpress.Utils.Animation.Transition transition1 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.SlideFadeTransition slideFadeTransition1 = new DevExpress.Utils.Animation.SlideFadeTransition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.TabControls = new DevExpress.XtraTab.XtraTabControl();
            this.tabSignIn = new DevExpress.XtraTab.XtraTabPage();
            this.txt_underline_pass = new App_ThuVien.Design.txt_hide_underline();
            this.btn_openDk = new System.Windows.Forms.Button();
            this.cBox_log = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_underline__user = new ThuVien.Design.txt_underline_1();
            this.tabSignUp = new DevExpress.XtraTab.XtraTabPage();
            this.txt_email = new ThuVien.Design.txt_underline_1();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_fullName = new ThuVien.Design.txt_underline_1();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_userSignUp = new ThuVien.Design.txt_underline_1();
            this.txt_passSignUp = new App_ThuVien.Design.txt_hide_underline();
            this.txt_passSignUp1 = new App_ThuVien.Design.txt_hide_underline();
            this.btn_openLoginIn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_userSignUp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.transitionManager1 = new DevExpress.Utils.Animation.TransitionManager(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControls)).BeginInit();
            this.TabControls.SuspendLayout();
            this.tabSignIn.SuspendLayout();
            this.tabSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.TabControls);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 28);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(452, 441);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // TabControls
            // 
            this.TabControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControls.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.TabControls.Location = new System.Drawing.Point(0, 0);
            this.TabControls.Margin = new System.Windows.Forms.Padding(2);
            this.TabControls.Name = "TabControls";
            this.TabControls.SelectedTabPage = this.tabSignIn;
            this.TabControls.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.False;
            this.TabControls.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.TabControls.Size = new System.Drawing.Size(452, 441);
            this.TabControls.TabIndex = 21;
            this.TabControls.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabSignIn,
            this.tabSignUp});
            // 
            // tabSignIn
            // 
            this.tabSignIn.Controls.Add(this.txt_underline_pass);
            this.tabSignIn.Controls.Add(this.btn_openDk);
            this.tabSignIn.Controls.Add(this.cBox_log);
            this.tabSignIn.Controls.Add(this.label1);
            this.tabSignIn.Controls.Add(this.label2);
            this.tabSignIn.Controls.Add(this.btn_login);
            this.tabSignIn.Controls.Add(this.label3);
            this.tabSignIn.Controls.Add(this.txt_underline__user);
            this.tabSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.tabSignIn.Name = "tabSignIn";
            this.tabSignIn.Size = new System.Drawing.Size(444, 406);
            this.tabSignIn.Text = "tabSignIn";
            // 
            // txt_underline_pass
            // 
            this.txt_underline_pass.BackColor = System.Drawing.SystemColors.Window;
            this.txt_underline_pass.Location = new System.Drawing.Point(39, 142);
            this.txt_underline_pass.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_underline_pass.Name = "txt_underline_pass";
            this.txt_underline_pass.Size = new System.Drawing.Size(323, 31);
            this.txt_underline_pass.TabIndex = 30;
            // 
            // btn_openDk
            // 
            this.btn_openDk.BackColor = System.Drawing.Color.MintCream;
            this.btn_openDk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_openDk.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_openDk.FlatAppearance.BorderSize = 0;
            this.btn_openDk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btn_openDk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btn_openDk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openDk.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_openDk.ForeColor = System.Drawing.Color.Black;
            this.btn_openDk.Location = new System.Drawing.Point(252, 220);
            this.btn_openDk.Name = "btn_openDk";
            this.btn_openDk.Size = new System.Drawing.Size(110, 47);
            this.btn_openDk.TabIndex = 21;
            this.btn_openDk.Text = "Đăng ký";
            this.btn_openDk.UseVisualStyleBackColor = false;
            this.btn_openDk.Click += new System.EventHandler(this.btn_openDk_Click);
            // 
            // cBox_log
            // 
            this.cBox_log.AutoSize = true;
            this.cBox_log.Location = new System.Drawing.Point(39, 181);
            this.cBox_log.Name = "cBox_log";
            this.cBox_log.Size = new System.Drawing.Size(91, 23);
            this.cBox_log.TabIndex = 19;
            this.cBox_log.Text = "Ghi nhớ";
            this.cBox_log.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(151, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên đăng nhập";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_login.Location = new System.Drawing.Point(39, 220);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(205, 47);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "Đăng Nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(36, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mật khẩu";
            // 
            // txt_underline__user
            // 
            this.txt_underline__user.BackColor = System.Drawing.SystemColors.Window;
            this.txt_underline__user.Location = new System.Drawing.Point(40, 76);
            this.txt_underline__user.Name = "txt_underline__user";
            this.txt_underline__user.Size = new System.Drawing.Size(322, 32);
            this.txt_underline__user.TabIndex = 16;
            // 
            // tabSignUp
            // 
            this.tabSignUp.Controls.Add(this.txt_email);
            this.tabSignUp.Controls.Add(this.label9);
            this.tabSignUp.Controls.Add(this.txt_fullName);
            this.tabSignUp.Controls.Add(this.label8);
            this.tabSignUp.Controls.Add(this.txt_userSignUp);
            this.tabSignUp.Controls.Add(this.txt_passSignUp);
            this.tabSignUp.Controls.Add(this.txt_passSignUp1);
            this.tabSignUp.Controls.Add(this.btn_openLoginIn);
            this.tabSignUp.Controls.Add(this.label7);
            this.tabSignUp.Controls.Add(this.label4);
            this.tabSignUp.Controls.Add(this.label5);
            this.tabSignUp.Controls.Add(this.btn_userSignUp);
            this.tabSignUp.Controls.Add(this.label6);
            this.tabSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.tabSignUp.Name = "tabSignUp";
            this.tabSignUp.Size = new System.Drawing.Size(444, 406);
            this.tabSignUp.Text = "tabSignUp";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_email.Location = new System.Drawing.Point(45, 298);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(325, 29);
            this.txt_email.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label9.Location = new System.Drawing.Point(42, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 22);
            this.label9.TabIndex = 34;
            this.label9.Text = "Email";
            // 
            // txt_fullName
            // 
            this.txt_fullName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_fullName.Location = new System.Drawing.Point(46, 244);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(325, 25);
            this.txt_fullName.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label8.Location = new System.Drawing.Point(43, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "Họ và tên";
            // 
            // txt_userSignUp
            // 
            this.txt_userSignUp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_userSignUp.Location = new System.Drawing.Point(46, 67);
            this.txt_userSignUp.Name = "txt_userSignUp";
            this.txt_userSignUp.Size = new System.Drawing.Size(325, 26);
            this.txt_userSignUp.TabIndex = 31;
            // 
            // txt_passSignUp
            // 
            this.txt_passSignUp.BackColor = System.Drawing.SystemColors.Window;
            this.txt_passSignUp.Location = new System.Drawing.Point(46, 122);
            this.txt_passSignUp.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_passSignUp.Name = "txt_passSignUp";
            this.txt_passSignUp.Size = new System.Drawing.Size(325, 28);
            this.txt_passSignUp.TabIndex = 30;
            // 
            // txt_passSignUp1
            // 
            this.txt_passSignUp1.BackColor = System.Drawing.SystemColors.Window;
            this.txt_passSignUp1.Location = new System.Drawing.Point(46, 180);
            this.txt_passSignUp1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_passSignUp1.Name = "txt_passSignUp1";
            this.txt_passSignUp1.Size = new System.Drawing.Size(325, 34);
            this.txt_passSignUp1.TabIndex = 29;
            // 
            // btn_openLoginIn
            // 
            this.btn_openLoginIn.BackColor = System.Drawing.Color.MintCream;
            this.btn_openLoginIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_openLoginIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_openLoginIn.FlatAppearance.BorderSize = 0;
            this.btn_openLoginIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btn_openLoginIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btn_openLoginIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openLoginIn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_openLoginIn.ForeColor = System.Drawing.Color.Black;
            this.btn_openLoginIn.Location = new System.Drawing.Point(247, 342);
            this.btn_openLoginIn.Name = "btn_openLoginIn";
            this.btn_openLoginIn.Size = new System.Drawing.Size(141, 47);
            this.btn_openLoginIn.TabIndex = 27;
            this.btn_openLoginIn.Text = "Đăng nhập";
            this.btn_openLoginIn.UseVisualStyleBackColor = false;
            this.btn_openLoginIn.Click += new System.EventHandler(this.btn_openLoginIn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.Location = new System.Drawing.Point(43, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nhập lại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(43, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(43, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mật khẩu";
            // 
            // btn_userSignUp
            // 
            this.btn_userSignUp.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_userSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_userSignUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_userSignUp.FlatAppearance.BorderSize = 0;
            this.btn_userSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_userSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_userSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userSignUp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_userSignUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_userSignUp.Location = new System.Drawing.Point(47, 342);
            this.btn_userSignUp.Name = "btn_userSignUp";
            this.btn_userSignUp.Size = new System.Drawing.Size(194, 47);
            this.btn_userSignUp.TabIndex = 20;
            this.btn_userSignUp.Text = "Đăng Ký";
            this.btn_userSignUp.UseVisualStyleBackColor = false;
            this.btn_userSignUp.Click += new System.EventHandler(this.btn_userSignUp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(179, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "ĐĂNG KÝ";
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(452, 28);
            this.toolbarFormControl1.TabIndex = 1;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 28);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(452, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 469);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(452, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 441);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(452, 28);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 441);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // transitionManager1
            // 
            transition1.BarWaitingIndicatorProperties.Caption = "";
            transition1.BarWaitingIndicatorProperties.Description = "";
            transition1.Control = null;
            transition1.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.LineWaitingIndicatorProperties.Caption = "";
            transition1.LineWaitingIndicatorProperties.Description = "";
            transition1.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.RingWaitingIndicatorProperties.Caption = "";
            transition1.RingWaitingIndicatorProperties.Description = "";
            transition1.TransitionType = slideFadeTransition1;
            transition1.WaitingIndicatorProperties.Caption = "";
            transition1.WaitingIndicatorProperties.Description = "";
            this.transitionManager1.Transitions.Add(transition1);
            this.transitionManager1.CustomTransition += new DevExpress.Utils.Animation.CustomTransitionEventHandler(this.transitionManager1_CustomTransition);
            // 
            // Login
            // 
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(452, 469);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Login.IconOptions.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControls)).EndInit();
            this.TabControls.ResumeLayout(false);
            this.tabSignIn.ResumeLayout(false);
            this.tabSignIn.PerformLayout();
            this.tabSignUp.ResumeLayout(false);
            this.tabSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBox_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Design.txt_underline_1 txt_underline__user;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraTab.XtraTabControl TabControls;
        private DevExpress.XtraTab.XtraTabPage tabSignIn;
        private DevExpress.XtraTab.XtraTabPage tabSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_userSignUp;
        private System.Windows.Forms.Label label6;
        private DevExpress.Utils.Animation.TransitionManager transitionManager1;
        private System.Windows.Forms.Button btn_openDk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_openLoginIn;
        private App_ThuVien.Design.txt_hide_underline txt_underline_pass;
        private App_ThuVien.Design.txt_hide_underline txt_passSignUp;
        private App_ThuVien.Design.txt_hide_underline txt_passSignUp1;
        private Design.txt_underline_1 txt_userSignUp;
        private Design.txt_underline_1 txt_email;
        private System.Windows.Forms.Label label9;
        private Design.txt_underline_1 txt_fullName;
        private System.Windows.Forms.Label label8;

    }
}