namespace QuanLyShipper.formshipper.Forms
{
    partial class frm_doiMK
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
            this.pnl_BGdoiMK = new System.Windows.Forms.Panel();
            this.btn_quenmk = new QuanLyShipper.RJControls.RJLogin();
            this.lbl_mkcu = new QuanLyShipper.RJControls.RJLogin();
            this.txt_mkcu = new QuanLyShipper.RJControls.RJButton();
            this.btn_xacnhan = new QuanLyShipper.RJControls.RJLogin();
            this.lbl_mkmoi = new QuanLyShipper.RJControls.RJLogin();
            this.txt_mkmoi = new QuanLyShipper.RJControls.RJButton();
            this.lbl_nhaplaimkmoi = new QuanLyShipper.RJControls.RJLogin();
            this.txt_nhaplaimkmoi = new QuanLyShipper.RJControls.RJButton();
            this.pnl_BGdoiMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_BGdoiMK
            // 
            this.pnl_BGdoiMK.BackColor = System.Drawing.Color.MediumPurple;
            this.pnl_BGdoiMK.Controls.Add(this.lbl_nhaplaimkmoi);
            this.pnl_BGdoiMK.Controls.Add(this.txt_nhaplaimkmoi);
            this.pnl_BGdoiMK.Controls.Add(this.lbl_mkmoi);
            this.pnl_BGdoiMK.Controls.Add(this.txt_mkmoi);
            this.pnl_BGdoiMK.Controls.Add(this.btn_quenmk);
            this.pnl_BGdoiMK.Controls.Add(this.lbl_mkcu);
            this.pnl_BGdoiMK.Controls.Add(this.txt_mkcu);
            this.pnl_BGdoiMK.Controls.Add(this.btn_xacnhan);
            this.pnl_BGdoiMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BGdoiMK.Location = new System.Drawing.Point(0, 0);
            this.pnl_BGdoiMK.Name = "pnl_BGdoiMK";
            this.pnl_BGdoiMK.Size = new System.Drawing.Size(307, 372);
            this.pnl_BGdoiMK.TabIndex = 1;
            // 
            // btn_quenmk
            // 
            this.btn_quenmk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_quenmk.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_quenmk.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.btn_quenmk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_quenmk.BorderRadius = 0;
            this.btn_quenmk.BorderSize = 0;
            this.btn_quenmk.FlatAppearance.BorderSize = 0;
            this.btn_quenmk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quenmk.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quenmk.ForeColor = System.Drawing.Color.White;
            this.btn_quenmk.Location = new System.Drawing.Point(128, 87);
            this.btn_quenmk.Name = "btn_quenmk";
            this.btn_quenmk.Size = new System.Drawing.Size(150, 26);
            this.btn_quenmk.TabIndex = 30;
            this.btn_quenmk.Text = "Quên mật khẩu?";
            this.btn_quenmk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quenmk.TextColor = System.Drawing.Color.White;
            this.btn_quenmk.UseVisualStyleBackColor = false;
            this.btn_quenmk.Click += new System.EventHandler(this.rjLogin4_Click);
            // 
            // lbl_mkcu
            // 
            this.lbl_mkcu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mkcu.BackColor = System.Drawing.Color.MediumPurple;
            this.lbl_mkcu.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.lbl_mkcu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_mkcu.BorderRadius = 0;
            this.lbl_mkcu.BorderSize = 0;
            this.lbl_mkcu.FlatAppearance.BorderSize = 0;
            this.lbl_mkcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_mkcu.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mkcu.ForeColor = System.Drawing.Color.White;
            this.lbl_mkcu.Location = new System.Drawing.Point(28, 25);
            this.lbl_mkcu.Name = "lbl_mkcu";
            this.lbl_mkcu.Size = new System.Drawing.Size(150, 26);
            this.lbl_mkcu.TabIndex = 29;
            this.lbl_mkcu.Text = "Mật khẩu cũ";
            this.lbl_mkcu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mkcu.TextColor = System.Drawing.Color.White;
            this.lbl_mkcu.UseVisualStyleBackColor = false;
            // 
            // txt_mkcu
            // 
            this.txt_mkcu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mkcu.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txt_mkcu.BackColor = System.Drawing.SystemColors.Window;
            this.txt_mkcu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_mkcu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_mkcu.BorderRadius = 15;
            this.txt_mkcu.BorderSize = 3;
            this.txt_mkcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkcu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_mkcu.Location = new System.Drawing.Point(28, 49);
            this.txt_mkcu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mkcu.Multiline = false;
            this.txt_mkcu.Name = "txt_mkcu";
            this.txt_mkcu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_mkcu.PasswordChar = false;
            this.txt_mkcu.PlaceholderColor = System.Drawing.Color.Silver;
            this.txt_mkcu.PlaceholderText = "Nhập mật khẩu cũ";
            this.txt_mkcu.Size = new System.Drawing.Size(250, 31);
            this.txt_mkcu.TabIndex = 25;
            this.txt_mkcu.Texts = "";
            this.txt_mkcu.UnderlinedStyle = false;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xacnhan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_xacnhan.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_xacnhan.BorderColor = System.Drawing.Color.White;
            this.btn_xacnhan.BorderRadius = 15;
            this.btn_xacnhan.BorderSize = 0;
            this.btn_xacnhan.FlatAppearance.BorderSize = 0;
            this.btn_xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xacnhan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhan.ForeColor = System.Drawing.Color.White;
            this.btn_xacnhan.Location = new System.Drawing.Point(28, 315);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(250, 30);
            this.btn_xacnhan.TabIndex = 27;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.TextColor = System.Drawing.Color.White;
            this.btn_xacnhan.UseVisualStyleBackColor = false;
            // 
            // lbl_mkmoi
            // 
            this.lbl_mkmoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mkmoi.BackColor = System.Drawing.Color.MediumPurple;
            this.lbl_mkmoi.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.lbl_mkmoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_mkmoi.BorderRadius = 0;
            this.lbl_mkmoi.BorderSize = 0;
            this.lbl_mkmoi.FlatAppearance.BorderSize = 0;
            this.lbl_mkmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_mkmoi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mkmoi.ForeColor = System.Drawing.Color.White;
            this.lbl_mkmoi.Location = new System.Drawing.Point(28, 119);
            this.lbl_mkmoi.Name = "lbl_mkmoi";
            this.lbl_mkmoi.Size = new System.Drawing.Size(150, 26);
            this.lbl_mkmoi.TabIndex = 32;
            this.lbl_mkmoi.Text = "Mật khẩu mới";
            this.lbl_mkmoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mkmoi.TextColor = System.Drawing.Color.White;
            this.lbl_mkmoi.UseVisualStyleBackColor = false;
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mkmoi.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txt_mkmoi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_mkmoi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_mkmoi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_mkmoi.BorderRadius = 15;
            this.txt_mkmoi.BorderSize = 3;
            this.txt_mkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkmoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_mkmoi.Location = new System.Drawing.Point(28, 143);
            this.txt_mkmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mkmoi.Multiline = false;
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_mkmoi.PasswordChar = false;
            this.txt_mkmoi.PlaceholderColor = System.Drawing.Color.Silver;
            this.txt_mkmoi.PlaceholderText = "Nhập mật khẩu mới";
            this.txt_mkmoi.Size = new System.Drawing.Size(250, 31);
            this.txt_mkmoi.TabIndex = 31;
            this.txt_mkmoi.Texts = "";
            this.txt_mkmoi.UnderlinedStyle = false;
            // 
            // lbl_nhaplaimkmoi
            // 
            this.lbl_nhaplaimkmoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_nhaplaimkmoi.BackColor = System.Drawing.Color.MediumPurple;
            this.lbl_nhaplaimkmoi.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.lbl_nhaplaimkmoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_nhaplaimkmoi.BorderRadius = 0;
            this.lbl_nhaplaimkmoi.BorderSize = 0;
            this.lbl_nhaplaimkmoi.FlatAppearance.BorderSize = 0;
            this.lbl_nhaplaimkmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nhaplaimkmoi.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhaplaimkmoi.ForeColor = System.Drawing.Color.White;
            this.lbl_nhaplaimkmoi.Location = new System.Drawing.Point(28, 187);
            this.lbl_nhaplaimkmoi.Name = "lbl_nhaplaimkmoi";
            this.lbl_nhaplaimkmoi.Size = new System.Drawing.Size(195, 26);
            this.lbl_nhaplaimkmoi.TabIndex = 34;
            this.lbl_nhaplaimkmoi.Text = "Nhập lại mật khẩu mới";
            this.lbl_nhaplaimkmoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_nhaplaimkmoi.TextColor = System.Drawing.Color.White;
            this.lbl_nhaplaimkmoi.UseVisualStyleBackColor = false;
            // 
            // txt_nhaplaimkmoi
            // 
            this.txt_nhaplaimkmoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nhaplaimkmoi.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txt_nhaplaimkmoi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nhaplaimkmoi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_nhaplaimkmoi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_nhaplaimkmoi.BorderRadius = 15;
            this.txt_nhaplaimkmoi.BorderSize = 3;
            this.txt_nhaplaimkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhaplaimkmoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_nhaplaimkmoi.Location = new System.Drawing.Point(28, 211);
            this.txt_nhaplaimkmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nhaplaimkmoi.Multiline = false;
            this.txt_nhaplaimkmoi.Name = "txt_nhaplaimkmoi";
            this.txt_nhaplaimkmoi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nhaplaimkmoi.PasswordChar = false;
            this.txt_nhaplaimkmoi.PlaceholderColor = System.Drawing.Color.Silver;
            this.txt_nhaplaimkmoi.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txt_nhaplaimkmoi.Size = new System.Drawing.Size(250, 31);
            this.txt_nhaplaimkmoi.TabIndex = 33;
            this.txt_nhaplaimkmoi.Texts = "";
            this.txt_nhaplaimkmoi.UnderlinedStyle = false;
            // 
            // frm_doiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 372);
            this.Controls.Add(this.pnl_BGdoiMK);
            this.Name = "frm_doiMK";
            this.Text = "Đổi mật khẩu";
            this.pnl_BGdoiMK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BGdoiMK;
        private RJControls.RJLogin btn_quenmk;
        private RJControls.RJLogin lbl_mkcu;
        private RJControls.RJButton txt_mkcu;
        private RJControls.RJLogin btn_xacnhan;
        private RJControls.RJLogin lbl_nhaplaimkmoi;
        private RJControls.RJButton txt_nhaplaimkmoi;
        private RJControls.RJLogin lbl_mkmoi;
        private RJControls.RJButton txt_mkmoi;
    }
}