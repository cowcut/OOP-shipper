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
            this.DangKyTK_txt = new System.Windows.Forms.TextBox();
            this.DangKyMK_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoaiTK_cbbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DangKy_btn = new System.Windows.Forms.Button();
            this.QuayLai_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NhapLaiMK_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DangKyTK_txt
            // 
            this.DangKyTK_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DangKyTK_txt.Location = new System.Drawing.Point(309, 160);
            this.DangKyTK_txt.Multiline = true;
            this.DangKyTK_txt.Name = "DangKyTK_txt";
            this.DangKyTK_txt.Size = new System.Drawing.Size(265, 22);
            this.DangKyTK_txt.TabIndex = 0;
            // 
            // DangKyMK_txt
            // 
            this.DangKyMK_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DangKyMK_txt.Location = new System.Drawing.Point(309, 225);
            this.DangKyMK_txt.Multiline = true;
            this.DangKyMK_txt.Name = "DangKyMK_txt";
            this.DangKyMK_txt.Size = new System.Drawing.Size(265, 22);
            this.DangKyMK_txt.TabIndex = 1;
            this.DangKyMK_txt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng Ký Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu";
            // 
            // LoaiTK_cbbox
            // 
            this.LoaiTK_cbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiTK_cbbox.FormattingEnabled = true;
            this.LoaiTK_cbbox.Items.AddRange(new object[] {
            "Shipper",
            "KhachHang"});
            this.LoaiTK_cbbox.Location = new System.Drawing.Point(309, 344);
            this.LoaiTK_cbbox.Name = "LoaiTK_cbbox";
            this.LoaiTK_cbbox.Size = new System.Drawing.Size(265, 24);
            this.LoaiTK_cbbox.TabIndex = 6;
            this.LoaiTK_cbbox.SelectedIndexChanged += new System.EventHandler(this.LoaiTK_cbbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại Tài Khoản";
            // 
            // DangKy_btn
            // 
            this.DangKy_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DangKy_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DangKy_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DangKy_btn.FlatAppearance.BorderSize = 0;
            this.DangKy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DangKy_btn.Location = new System.Drawing.Point(309, 392);
            this.DangKy_btn.Name = "DangKy_btn";
            this.DangKy_btn.Size = new System.Drawing.Size(127, 54);
            this.DangKy_btn.TabIndex = 8;
            this.DangKy_btn.Text = "Đăng Ký";
            this.DangKy_btn.UseVisualStyleBackColor = false;
            this.DangKy_btn.Click += new System.EventHandler(this.DangKy_btn_Click);
            // 
            // QuayLai_btn
            // 
            this.QuayLai_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QuayLai_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuayLai_btn.FlatAppearance.BorderSize = 0;
            this.QuayLai_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuayLai_btn.Location = new System.Drawing.Point(451, 392);
            this.QuayLai_btn.Name = "QuayLai_btn";
            this.QuayLai_btn.Size = new System.Drawing.Size(123, 54);
            this.QuayLai_btn.TabIndex = 9;
            this.QuayLai_btn.Text = "Quay lại";
            this.QuayLai_btn.UseVisualStyleBackColor = false;
            this.QuayLai_btn.Click += new System.EventHandler(this.QuayLai_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhập Lại Mật Khẩu";
            // 
            // NhapLaiMK_txt
            // 
            this.NhapLaiMK_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NhapLaiMK_txt.Location = new System.Drawing.Point(309, 286);
            this.NhapLaiMK_txt.Multiline = true;
            this.NhapLaiMK_txt.Name = "NhapLaiMK_txt";
            this.NhapLaiMK_txt.Size = new System.Drawing.Size(265, 22);
            this.NhapLaiMK_txt.TabIndex = 10;
            this.NhapLaiMK_txt.UseSystemPasswordChar = true;
            // 
            // frm_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 508);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NhapLaiMK_txt);
            this.Controls.Add(this.QuayLai_btn);
            this.Controls.Add(this.DangKy_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoaiTK_cbbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DangKyMK_txt);
            this.Controls.Add(this.DangKyTK_txt);
            this.Name = "frm_DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DangKyTK_txt;
        private System.Windows.Forms.TextBox DangKyMK_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LoaiTK_cbbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DangKy_btn;
        private System.Windows.Forms.Button QuayLai_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NhapLaiMK_txt;
    }
}