
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Main_pnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DangKy_btn = new System.Windows.Forms.LinkLabel();
            this.DangNhap_btn = new QuanLyShipper.RJControls.RJLogin();
            this.comboBox1 = new QuanLyShipper.RJControls.RJComboBox();
            this.MatKhau_txt = new QuanLyShipper.RJControls.RJButton();
            this.TaiKhoan_txt = new QuanLyShipper.RJControls.RJButton();
            this.Main_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_pnl
            // 
            this.Main_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(209)))), ((int)(((byte)(229)))));
            this.Main_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main_pnl.Controls.Add(this.label4);
            this.Main_pnl.Controls.Add(this.label3);
            this.Main_pnl.Controls.Add(this.label2);
            this.Main_pnl.Controls.Add(this.label1);
            this.Main_pnl.Controls.Add(this.pictureBox1);
            this.Main_pnl.Controls.Add(this.DangKy_btn);
            this.Main_pnl.Controls.Add(this.DangNhap_btn);
            this.Main_pnl.Controls.Add(this.comboBox1);
            this.Main_pnl.Controls.Add(this.MatKhau_txt);
            this.Main_pnl.Controls.Add(this.TaiKhoan_txt);
            this.Main_pnl.Location = new System.Drawing.Point(-1, 0);
            this.Main_pnl.Name = "Main_pnl";
            this.Main_pnl.Size = new System.Drawing.Size(393, 514);
            this.Main_pnl.TabIndex = 1;
            this.Main_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_pnl_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(68, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Don\'t have account ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(134, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Forget password ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(79, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(79, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyShipper.Properties.Resources.Login_Nav;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(63, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 63);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // DangKy_btn
            // 
            this.DangKy_btn.AutoSize = true;
            this.DangKy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangKy_btn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.DangKy_btn.Location = new System.Drawing.Point(216, 461);
            this.DangKy_btn.Name = "DangKy_btn";
            this.DangKy_btn.Size = new System.Drawing.Size(105, 17);
            this.DangKy_btn.TabIndex = 15;
            this.DangKy_btn.TabStop = true;
            this.DangKy_btn.Text = "Create Account";
            // 
            // DangNhap_btn
            // 
            this.DangNhap_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.DangNhap_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.DangNhap_btn.BorderColor = System.Drawing.Color.White;
            this.DangNhap_btn.BorderRadius = 15;
            this.DangNhap_btn.BorderSize = 0;
            this.DangNhap_btn.FlatAppearance.BorderSize = 0;
            this.DangNhap_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DangNhap_btn.ForeColor = System.Drawing.Color.White;
            this.DangNhap_btn.Location = new System.Drawing.Point(71, 375);
            this.DangNhap_btn.Name = "DangNhap_btn";
            this.DangNhap_btn.Size = new System.Drawing.Size(250, 30);
            this.DangNhap_btn.TabIndex = 13;
            this.DangNhap_btn.Text = "Login";
            this.DangNhap_btn.TextColor = System.Drawing.Color.White;
            this.DangNhap_btn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBox1.BorderSize = 1;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.comboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Shipper",
            "Client"});
            this.comboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBox1.ListTextColor = System.Drawing.Color.Black;
            this.comboBox1.Location = new System.Drawing.Point(97, 164);
            this.comboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.comboBox1.Size = new System.Drawing.Size(200, 30);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Texts = "Loại Tài Khoản";
            this.comboBox1.UseWaitCursor = true;
            // 
            // MatKhau_txt
            // 
            this.MatKhau_txt.BackColor = System.Drawing.SystemColors.Window;
            this.MatKhau_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.MatKhau_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.MatKhau_txt.BorderRadius = 15;
            this.MatKhau_txt.BorderSize = 3;
            this.MatKhau_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhau_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MatKhau_txt.Location = new System.Drawing.Point(71, 318);
            this.MatKhau_txt.Margin = new System.Windows.Forms.Padding(4);
            this.MatKhau_txt.Multiline = false;
            this.MatKhau_txt.Name = "MatKhau_txt";
            this.MatKhau_txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.MatKhau_txt.PasswordChar = true;
            this.MatKhau_txt.PlaceholderColor = System.Drawing.Color.Silver;
            this.MatKhau_txt.PlaceholderText = "Enter password";
            this.MatKhau_txt.Size = new System.Drawing.Size(250, 31);
            this.MatKhau_txt.TabIndex = 11;
            this.MatKhau_txt.Texts = "";
            this.MatKhau_txt.UnderlinedStyle = false;
            // 
            // TaiKhoan_txt
            // 
            this.TaiKhoan_txt.BackColor = System.Drawing.SystemColors.Window;
            this.TaiKhoan_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TaiKhoan_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TaiKhoan_txt.BorderRadius = 15;
            this.TaiKhoan_txt.BorderSize = 3;
            this.TaiKhoan_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiKhoan_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TaiKhoan_txt.Location = new System.Drawing.Point(71, 241);
            this.TaiKhoan_txt.Margin = new System.Windows.Forms.Padding(4);
            this.TaiKhoan_txt.Multiline = false;
            this.TaiKhoan_txt.Name = "TaiKhoan_txt";
            this.TaiKhoan_txt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TaiKhoan_txt.PasswordChar = false;
            this.TaiKhoan_txt.PlaceholderColor = System.Drawing.Color.Silver;
            this.TaiKhoan_txt.PlaceholderText = "Enter username";
            this.TaiKhoan_txt.Size = new System.Drawing.Size(250, 31);
            this.TaiKhoan_txt.TabIndex = 10;
            this.TaiKhoan_txt.Texts = "";
            this.TaiKhoan_txt.UnderlinedStyle = false;
            // 
            // frm_HeyYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(388, 509);
            this.Controls.Add(this.Main_pnl);
            this.DoubleBuffered = true;
            this.Name = "frm_HeyYou";
            this.Text = "HeyYou";
            this.Load += new System.EventHandler(this.frm_HeyYou_Load);
            this.Main_pnl.ResumeLayout(false);
            this.Main_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Main_pnl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RJControls.RJButton MatKhau_txt;
        private RJControls.RJButton TaiKhoan_txt;
        private RJControls.RJComboBox comboBox1;
        private RJControls.RJLogin DangNhap_btn;
        private System.Windows.Forms.LinkLabel DangKy_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
