
namespace QuanLyShipper
{
    partial class frm_HeyYou
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
            this.Main_pnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DangNhap_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MatKhau_txt = new System.Windows.Forms.TextBox();
            this.TaiKhoan_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MatKhau_lbl = new System.Windows.Forms.Label();
            this.TaiKhoan_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_pnl
            // 
            this.Main_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_pnl.Controls.Add(this.button1);
            this.Main_pnl.Controls.Add(this.DangNhap_btn);
            this.Main_pnl.Controls.Add(this.comboBox1);
            this.Main_pnl.Controls.Add(this.MatKhau_txt);
            this.Main_pnl.Controls.Add(this.TaiKhoan_txt);
            this.Main_pnl.Controls.Add(this.label5);
            this.Main_pnl.Controls.Add(this.MatKhau_lbl);
            this.Main_pnl.Controls.Add(this.TaiKhoan_lbl);
            this.Main_pnl.Controls.Add(this.label1);
            this.Main_pnl.Location = new System.Drawing.Point(-1, 0);
            this.Main_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.Main_pnl.Name = "Main_pnl";
            this.Main_pnl.Size = new System.Drawing.Size(1067, 540);
            this.Main_pnl.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DangNhap_btn
            // 
            this.DangNhap_btn.Location = new System.Drawing.Point(294, 390);
            this.DangNhap_btn.Name = "DangNhap_btn";
            this.DangNhap_btn.Size = new System.Drawing.Size(161, 50);
            this.DangNhap_btn.TabIndex = 9;
            this.DangNhap_btn.Text = "Đăng Nhập";
            this.DangNhap_btn.UseVisualStyleBackColor = true;
            this.DangNhap_btn.Click += new System.EventHandler(this.DangNhap_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Quản Lý",
            "Shipper",
            "Khách Hàng"});
            this.comboBox1.Location = new System.Drawing.Point(294, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(325, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // MatKhau_txt
            // 
            this.MatKhau_txt.Location = new System.Drawing.Point(294, 336);
            this.MatKhau_txt.Name = "MatKhau_txt";
            this.MatKhau_txt.Size = new System.Drawing.Size(325, 22);
            this.MatKhau_txt.TabIndex = 7;
            this.MatKhau_txt.UseSystemPasswordChar = true;
            // 
            // TaiKhoan_txt
            // 
            this.TaiKhoan_txt.Location = new System.Drawing.Point(294, 247);
            this.TaiKhoan_txt.Name = "TaiKhoan_txt";
            this.TaiKhoan_txt.Size = new System.Drawing.Size(325, 22);
            this.TaiKhoan_txt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại Tài Khoản";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MatKhau_lbl
            // 
            this.MatKhau_lbl.AutoSize = true;
            this.MatKhau_lbl.Location = new System.Drawing.Point(297, 308);
            this.MatKhau_lbl.Name = "MatKhau_lbl";
            this.MatKhau_lbl.Size = new System.Drawing.Size(62, 16);
            this.MatKhau_lbl.TabIndex = 3;
            this.MatKhau_lbl.Text = "Mật Khẩu";
            this.MatKhau_lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // TaiKhoan_lbl
            // 
            this.TaiKhoan_lbl.AutoSize = true;
            this.TaiKhoan_lbl.Location = new System.Drawing.Point(291, 228);
            this.TaiKhoan_lbl.Name = "TaiKhoan_lbl";
            this.TaiKhoan_lbl.Size = new System.Drawing.Size(68, 16);
            this.TaiKhoan_lbl.TabIndex = 2;
            this.TaiKhoan_lbl.Text = "Tài Khoản";
            this.TaiKhoan_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_HeyYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 538);
            this.Controls.Add(this.Main_pnl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_HeyYou";
            this.Text = "HeyYou";
            this.Main_pnl.ResumeLayout(false);
            this.Main_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Main_pnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MatKhau_lbl;
        private System.Windows.Forms.Label TaiKhoan_lbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox MatKhau_txt;
        private System.Windows.Forms.TextBox TaiKhoan_txt;
        private System.Windows.Forms.Button DangNhap_btn;
        private System.Windows.Forms.Button button1;
    }
}

