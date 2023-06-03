using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HoanThien
{
    partial class FormShipper
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_thongbao = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_vanchuyen = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_donhang = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_taikhoan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.lbl_trangchu = new System.Windows.Forms.Label();
            this.paneldesktop = new System.Windows.Forms.Panel();
            this.pic_heyou = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            this.paneldesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_heyou)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 538);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(107)))), ((int)(((byte)(225)))));
            this.panel8.Controls.Add(this.btn_dangxuat);
            this.panel8.Controls.Add(this.btn_thongbao);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 213);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(170, 325);
            this.panel8.TabIndex = 5;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_dangxuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_dangxuat.Image = global::HoanThien.Properties.Resources.Dangxuat;
            this.btn_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.Location = new System.Drawing.Point(0, 273);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_dangxuat.Size = new System.Drawing.Size(170, 52);
            this.btn_dangxuat.TabIndex = 2;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btn_thongbao
            // 
            this.btn_thongbao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(107)))), ((int)(((byte)(225)))));
            this.btn_thongbao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thongbao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_thongbao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thongbao.Image = global::HoanThien.Properties.Resources.z4400015639114_cbc5bcb3906a471df72f7406192a81db;
            this.btn_thongbao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongbao.Location = new System.Drawing.Point(0, 0);
            this.btn_thongbao.Name = "btn_thongbao";
            this.btn_thongbao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_thongbao.Size = new System.Drawing.Size(170, 52);
            this.btn_thongbao.TabIndex = 1;
            this.btn_thongbao.Text = "Thông báo";
            this.btn_thongbao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thongbao.UseVisualStyleBackColor = false;
            this.btn_thongbao.Click += new System.EventHandler(this.btn_thongbao_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_vanchuyen);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 161);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 52);
            this.panel5.TabIndex = 4;
            // 
            // btn_vanchuyen
            // 
            this.btn_vanchuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(107)))), ((int)(((byte)(225)))));
            this.btn_vanchuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_vanchuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vanchuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_vanchuyen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_vanchuyen.Image = global::HoanThien.Properties.Resources.z4400015613728_d3b7ba3851aee53b2d1372f42bb8ba91;
            this.btn_vanchuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vanchuyen.Location = new System.Drawing.Point(0, 0);
            this.btn_vanchuyen.Name = "btn_vanchuyen";
            this.btn_vanchuyen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_vanchuyen.Size = new System.Drawing.Size(170, 52);
            this.btn_vanchuyen.TabIndex = 1;
            this.btn_vanchuyen.Text = "Vận chuyển";
            this.btn_vanchuyen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_vanchuyen.UseVisualStyleBackColor = false;
            this.btn_vanchuyen.Click += new System.EventHandler(this.btn_vanchuyen_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_donhang);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 52);
            this.panel4.TabIndex = 3;
            // 
            // btn_donhang
            // 
            this.btn_donhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(107)))), ((int)(((byte)(225)))));
            this.btn_donhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_donhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_donhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_donhang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_donhang.Image = global::HoanThien.Properties.Resources.z4400015606789_2c0c5c9e831dd574b3230d7c8b64bf8c;
            this.btn_donhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_donhang.Location = new System.Drawing.Point(0, 0);
            this.btn_donhang.Name = "btn_donhang";
            this.btn_donhang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_donhang.Size = new System.Drawing.Size(170, 52);
            this.btn_donhang.TabIndex = 1;
            this.btn_donhang.Text = "Đơn hàng";
            this.btn_donhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_donhang.UseVisualStyleBackColor = false;
            this.btn_donhang.Click += new System.EventHandler(this.btn_donhang_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_taikhoan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 52);
            this.panel3.TabIndex = 2;
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(107)))), ((int)(((byte)(225)))));
            this.btn_taikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_taikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_taikhoan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_taikhoan.Image = global::HoanThien.Properties.Resources.z4400015596827_25497d217777882b305147c632b32738;
            this.btn_taikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taikhoan.Location = new System.Drawing.Point(0, 0);
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_taikhoan.Size = new System.Drawing.Size(170, 52);
            this.btn_taikhoan.TabIndex = 0;
            this.btn_taikhoan.Text = "Tài khoản";
            this.btn_taikhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_taikhoan.UseVisualStyleBackColor = false;
            this.btn_taikhoan.Click += new System.EventHandler(this.btn_taikhoan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(107)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.pic_logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 57);
            this.panel2.TabIndex = 1;
            // 
            // pic_logo
            // 
            this.pic_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_logo.Image = global::HoanThien.Properties.Resources.z4400015613589_2c331ea92c39e93d478d20c79deebd56;
            this.pic_logo.Location = new System.Drawing.Point(0, 0);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(170, 57);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            this.pic_logo.UseWaitCursor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(107)))), ((int)(((byte)(225)))));
            this.panel6.Controls.Add(this.btn_exit);
            this.panel6.Controls.Add(this.pic_home);
            this.panel6.Controls.Add(this.lbl_trangchu);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(170, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(877, 57);
            this.panel6.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.btn_exit.Image = global::HoanThien.Properties.Resources.z4400015600247_a0ea6a504e71a26e8c8b9fb85714419e;
            this.btn_exit.Location = new System.Drawing.Point(820, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(57, 57);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pic_home
            // 
            this.pic_home.Image = global::HoanThien.Properties.Resources.home;
            this.pic_home.Location = new System.Drawing.Point(229, 8);
            this.pic_home.Name = "pic_home";
            this.pic_home.Size = new System.Drawing.Size(44, 43);
            this.pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_home.TabIndex = 0;
            this.pic_home.TabStop = false;
            // 
            // lbl_trangchu
            // 
            this.lbl_trangchu.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_trangchu.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_trangchu.Location = new System.Drawing.Point(267, 8);
            this.lbl_trangchu.Name = "lbl_trangchu";
            this.lbl_trangchu.Size = new System.Drawing.Size(133, 43);
            this.lbl_trangchu.TabIndex = 0;
            this.lbl_trangchu.Text = "Trang chủ";
            this.lbl_trangchu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paneldesktop
            // 
            this.paneldesktop.BackColor = System.Drawing.SystemColors.Control;
            this.paneldesktop.Controls.Add(this.pic_heyou);
            this.paneldesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesktop.Location = new System.Drawing.Point(170, 57);
            this.paneldesktop.Name = "paneldesktop";
            this.paneldesktop.Size = new System.Drawing.Size(877, 481);
            this.paneldesktop.TabIndex = 2;
            // 
            // pic_heyou
            // 
            this.pic_heyou.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_heyou.Image = global::HoanThien.Properties.Resources.z4400015631736_04667a7889c627cbc061a05ef07885af;
            this.pic_heyou.Location = new System.Drawing.Point(0, 0);
            this.pic_heyou.Name = "pic_heyou";
            this.pic_heyou.Size = new System.Drawing.Size(877, 481);
            this.pic_heyou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_heyou.TabIndex = 0;
            this.pic_heyou.TabStop = false;
            // 
            // FormShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(143)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1047, 538);
            this.Controls.Add(this.paneldesktop);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "FormShipper";
            this.Text = "Shipper";
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            this.paneldesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_heyou)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel8;
        private Button btn_dangxuat;
        private Button btn_thongbao;
        private Panel panel5;
        private Button btn_vanchuyen;
        private Panel panel4;
        private Button btn_donhang;
        private Panel panel3;
        private Button btn_taikhoan;
        private Panel panel6;
        private Panel paneldesktop;
        private Label lbl_trangchu;
        private PictureBox pic_home;
        private Panel panel2;
        private Button btn_exit;
        private PictureBox pic_heyou;
        private PictureBox pic_logo;
    }
}