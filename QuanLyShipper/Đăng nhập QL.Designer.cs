
namespace QuanLyShipper
{
    partial class frm_DangNhapQL
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
            this.label2 = new System.Windows.Forms.Label();
            this.MatKhau_txt = new System.Windows.Forms.TextBox();
            this.TaiKhoan_txt = new System.Windows.Forms.TextBox();
            this.DangNhapSP_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // MatKhau_txt
            // 
            this.MatKhau_txt.Location = new System.Drawing.Point(320, 138);
            this.MatKhau_txt.Name = "MatKhau_txt";
            this.MatKhau_txt.Size = new System.Drawing.Size(100, 20);
            this.MatKhau_txt.TabIndex = 2;
            // 
            // TaiKhoan_txt
            // 
            this.TaiKhoan_txt.Location = new System.Drawing.Point(320, 81);
            this.TaiKhoan_txt.Name = "TaiKhoan_txt";
            this.TaiKhoan_txt.Size = new System.Drawing.Size(100, 20);
            this.TaiKhoan_txt.TabIndex = 2;
            // 
            // DangNhapSP_btn
            // 
            this.DangNhapSP_btn.Location = new System.Drawing.Point(334, 222);
            this.DangNhapSP_btn.Name = "DangNhapSP_btn";
            this.DangNhapSP_btn.Size = new System.Drawing.Size(75, 23);
            this.DangNhapSP_btn.TabIndex = 3;
            this.DangNhapSP_btn.Text = "Đăng nhập";
            this.DangNhapSP_btn.UseVisualStyleBackColor = true;
            this.DangNhapSP_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_DangNhapQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DangNhapSP_btn);
            this.Controls.Add(this.TaiKhoan_txt);
            this.Controls.Add(this.MatKhau_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangNhapQL";
            this.Text = "Đăng_nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MatKhau_txt;
        private System.Windows.Forms.TextBox TaiKhoan_txt;
        private System.Windows.Forms.Button DangNhapSP_btn;
    }
}