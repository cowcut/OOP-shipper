
namespace QuanLyShipper
{
    partial class frm_DangNhapSP
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
            this.button1 = new System.Windows.Forms.Button();
            this.TaiKhoan_txt = new System.Windows.Forms.TextBox();
            this.MatKhau_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaiKhoan_txt
            // 
            this.TaiKhoan_txt.Location = new System.Drawing.Point(363, 78);
            this.TaiKhoan_txt.Name = "TaiKhoan_txt";
            this.TaiKhoan_txt.Size = new System.Drawing.Size(100, 20);
            this.TaiKhoan_txt.TabIndex = 6;
            this.TaiKhoan_txt.TextChanged += new System.EventHandler(this.TaiKhoan_txt_TextChanged);
            // 
            // MatKhau_txt
            // 
            this.MatKhau_txt.Location = new System.Drawing.Point(363, 135);
            this.MatKhau_txt.Name = "MatKhau_txt";
            this.MatKhau_txt.Size = new System.Drawing.Size(100, 20);
            this.MatKhau_txt.TabIndex = 7;
            this.MatKhau_txt.TextChanged += new System.EventHandler(this.MatKhau_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_DangNhapSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TaiKhoan_txt);
            this.Controls.Add(this.MatKhau_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangNhapSP";
            this.Text = "Đăng_nhập_SP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TaiKhoan_txt;
        private System.Windows.Forms.TextBox MatKhau_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}