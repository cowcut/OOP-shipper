namespace QuanLyShipper
{
    partial class frm_DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangKy));
            this.Main_pnl = new System.Windows.Forms.Panel();
            this.LoaiTK_cbbox = new QuanLyShipper.RJControls.RJComboBox();
            this.Login_btn = new QuanLyShipper.RJControls.RJLogin();
            this.DangKy_btn = new QuanLyShipper.RJControls.RJLogin();
            this.rjButton1 = new QuanLyShipper.RJControls.RJButton();
            this.DangKyMK_txt = new QuanLyShipper.RJControls.RJButton();
            this.DangKyTK_txt = new QuanLyShipper.RJControls.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Main_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_pnl
            // 
            this.Main_pnl.AllowDrop = true;
            this.Main_pnl.AutoScroll = true;
            this.Main_pnl.AutoSize = true;
            this.Main_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Main_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_pnl.Controls.Add(this.LoaiTK_cbbox);
            this.Main_pnl.Controls.Add(this.Login_btn);
            this.Main_pnl.Controls.Add(this.DangKy_btn);
            this.Main_pnl.Controls.Add(this.rjButton1);
            this.Main_pnl.Controls.Add(this.DangKyMK_txt);
            this.Main_pnl.Controls.Add(this.DangKyTK_txt);
            this.Main_pnl.Controls.Add(this.label5);
            this.Main_pnl.Controls.Add(this.label1);
            this.Main_pnl.Controls.Add(this.label2);
            this.Main_pnl.Controls.Add(this.label3);
            this.Main_pnl.Location = new System.Drawing.Point(636, 33);
            this.Main_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.Main_pnl.Name = "Main_pnl";
            this.Main_pnl.Size = new System.Drawing.Size(401, 537);
            this.Main_pnl.TabIndex = 12;
            this.Main_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_pnl_Paint);
            // 
            // LoaiTK_cbbox
            // 
            this.LoaiTK_cbbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoaiTK_cbbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.LoaiTK_cbbox.BorderSize = 1;
            this.LoaiTK_cbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.LoaiTK_cbbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoaiTK_cbbox.ForeColor = System.Drawing.Color.DimGray;
            this.LoaiTK_cbbox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.LoaiTK_cbbox.Items.AddRange(new object[] {
            "Shipper",
            "KhachHang"});
            this.LoaiTK_cbbox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.LoaiTK_cbbox.ListTextColor = System.Drawing.Color.DimGray;
            this.LoaiTK_cbbox.Location = new System.Drawing.Point(57, 400);
            this.LoaiTK_cbbox.MinimumSize = new System.Drawing.Size(200, 30);
            this.LoaiTK_cbbox.Name = "LoaiTK_cbbox";
            this.LoaiTK_cbbox.Padding = new System.Windows.Forms.Padding(1);
            this.LoaiTK_cbbox.Size = new System.Drawing.Size(268, 38);
            this.LoaiTK_cbbox.TabIndex = 18;
            this.LoaiTK_cbbox.Texts = "Chọn Loại Tài khoản";
            this.LoaiTK_cbbox.OnSelectedIndexChanged += new System.EventHandler(this.LoaiTK_cbbox_OnSelectedIndexChanged);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Login_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Login_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Login_btn.BorderRadius = 15;
            this.Login_btn.BorderSize = 0;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(241, 17);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(141, 44);
            this.Login_btn.TabIndex = 17;
            this.Login_btn.Text = "Login";
            this.Login_btn.TextColor = System.Drawing.Color.White;
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // DangKy_btn
            // 
            this.DangKy_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.DangKy_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.DangKy_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DangKy_btn.BorderRadius = 15;
            this.DangKy_btn.BorderSize = 0;
            this.DangKy_btn.FlatAppearance.BorderSize = 0;
            this.DangKy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DangKy_btn.ForeColor = System.Drawing.Color.White;
            this.DangKy_btn.Location = new System.Drawing.Point(75, 470);
            this.DangKy_btn.Margin = new System.Windows.Forms.Padding(4);
            this.DangKy_btn.Name = "DangKy_btn";
            this.DangKy_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DangKy_btn.Size = new System.Drawing.Size(213, 44);
            this.DangKy_btn.TabIndex = 16;
            this.DangKy_btn.Text = "Register";
            this.DangKy_btn.TextColor = System.Drawing.Color.White;
            this.DangKy_btn.UseVisualStyleBackColor = false;
            this.DangKy_btn.Click += new System.EventHandler(this.DangKy_btn_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.SystemColors.Window;
            this.rjButton1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 3;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjButton1.Location = new System.Drawing.Point(57, 336);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(5);
            this.rjButton1.Multiline = false;
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.rjButton1.PasswordChar = true;
            this.rjButton1.PlaceholderColor = System.Drawing.Color.Silver;
            this.rjButton1.PlaceholderText = "Retype Password";
            this.rjButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rjButton1.Size = new System.Drawing.Size(268, 39);
            this.rjButton1.TabIndex = 15;
            this.rjButton1.Texts = "";
            this.rjButton1.UnderlinedStyle = false;
            // 
            // DangKyMK_txt
            // 
            this.DangKyMK_txt.BackColor = System.Drawing.SystemColors.Window;
            this.DangKyMK_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.DangKyMK_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.DangKyMK_txt.BorderRadius = 15;
            this.DangKyMK_txt.BorderSize = 3;
            this.DangKyMK_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangKyMK_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DangKyMK_txt.Location = new System.Drawing.Point(57, 261);
            this.DangKyMK_txt.Margin = new System.Windows.Forms.Padding(5);
            this.DangKyMK_txt.Multiline = false;
            this.DangKyMK_txt.Name = "DangKyMK_txt";
            this.DangKyMK_txt.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.DangKyMK_txt.PasswordChar = true;
            this.DangKyMK_txt.PlaceholderColor = System.Drawing.Color.Silver;
            this.DangKyMK_txt.PlaceholderText = "Password";
            this.DangKyMK_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DangKyMK_txt.Size = new System.Drawing.Size(268, 39);
            this.DangKyMK_txt.TabIndex = 14;
            this.DangKyMK_txt.Texts = "";
            this.DangKyMK_txt.UnderlinedStyle = false;
            // 
            // DangKyTK_txt
            // 
            this.DangKyTK_txt.BackColor = System.Drawing.SystemColors.Window;
            this.DangKyTK_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.DangKyTK_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.DangKyTK_txt.BorderRadius = 15;
            this.DangKyTK_txt.BorderSize = 3;
            this.DangKyTK_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangKyTK_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DangKyTK_txt.Location = new System.Drawing.Point(57, 191);
            this.DangKyTK_txt.Margin = new System.Windows.Forms.Padding(5);
            this.DangKyTK_txt.Multiline = false;
            this.DangKyTK_txt.Name = "DangKyTK_txt";
            this.DangKyTK_txt.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.DangKyTK_txt.PasswordChar = false;
            this.DangKyTK_txt.PlaceholderColor = System.Drawing.Color.Silver;
            this.DangKyTK_txt.PlaceholderText = "Username";
            this.DangKyTK_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DangKyTK_txt.Size = new System.Drawing.Size(268, 39);
            this.DangKyTK_txt.TabIndex = 13;
            this.DangKyTK_txt.Texts = "";
            this.DangKyTK_txt.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 311);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Retype Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(91)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(117, 93);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Register";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 166);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 236);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frm_DangKy
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 618);
            this.Controls.Add(this.Main_pnl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_DangKy";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.Main_pnl.ResumeLayout(false);
            this.Main_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Main_pnl;
        private RJControls.RJLogin DangKy_btn;
        private RJControls.RJButton rjButton1;
        private RJControls.RJButton DangKyMK_txt;
        private RJControls.RJButton DangKyTK_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RJControls.RJLogin Login_btn;
        private RJControls.RJComboBox LoaiTK_cbbox;
    }
}