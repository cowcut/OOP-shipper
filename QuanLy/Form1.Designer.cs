using System;

namespace FormMainMenu
{
    partial class Form1
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
            this.panelDesktop = new QuanLyShipper.RJControls.RJPanel();
            this.panelTitleBar = new QuanLyShipper.RJControls.RJPanel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new QuanLyShipper.RJControls.RJPanel();
            this.btn_dangxuat = new QuanLyShipper.RJControls.RJLogin();
            this.btnCaiDat = new QuanLyShipper.RJControls.RJLogin();
            this.btnThongBao = new QuanLyShipper.RJControls.RJLogin();
            this.btnPBShipper = new QuanLyShipper.RJControls.RJLogin();
            this.btnQLShipper = new QuanLyShipper.RJControls.RJLogin();
            this.btnProducts = new QuanLyShipper.RJControls.RJLogin();
            this.panelLogo = new QuanLyShipper.RJControls.RJPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelDesktop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelDesktop.BackgroundImage = global::FormMainMenu.Properties.Resources.Brown_and_Yellow_Minimalist_Home_Sweet_Home_Delivery_Facebook_Cover__2_;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.BorderColor = System.Drawing.Color.DarkOrchid;
            this.panelDesktop.BorderRadius = 15;
            this.panelDesktop.BorderSize = 3;
            this.panelDesktop.ForeColor = System.Drawing.Color.White;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1123, 570);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.TabStop = true;
            this.panelDesktop.TextColor = System.Drawing.Color.White;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.MediumPurple;
            this.panelTitleBar.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.panelTitleBar.BorderColor = System.Drawing.Color.DarkOrchid;
            this.panelTitleBar.BorderRadius = 20;
            this.panelTitleBar.BorderSize = 0;
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.White;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1123, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.TextColor = System.Drawing.Color.White;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackgroundImage = global::FormMainMenu.Properties.Resources.exit_formchild;
            this.btnCloseChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnCloseChildForm.Location = new System.Drawing.Point(36, 15);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(50, 50);
            this.btnCloseChildForm.TabIndex = 0;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(472, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcom to HeYou";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelMenu.BorderRadius = 20;
            this.panelMenu.BorderSize = 0;
            this.panelMenu.Controls.Add(this.btn_dangxuat);
            this.panelMenu.Controls.Add(this.btnCaiDat);
            this.panelMenu.Controls.Add(this.btnThongBao);
            this.panelMenu.Controls.Add(this.btnPBShipper);
            this.panelMenu.Controls.Add(this.btnQLShipper);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 650);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.TextColor = System.Drawing.Color.White;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_dangxuat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_dangxuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dangxuat.BorderRadius = 15;
            this.btn_dangxuat.BorderSize = 0;
            this.btn_dangxuat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_dangxuat.Image = global::FormMainMenu.Properties.Resources.Dangxuat;
            this.btn_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.Location = new System.Drawing.Point(0, 545);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_dangxuat.Size = new System.Drawing.Size(220, 50);
            this.btn_dangxuat.TabIndex = 6;
            this.btn_dangxuat.Text = " Đăng xuất";
            this.btn_dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.TextColor = System.Drawing.Color.Gainsboro;
            this.btn_dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCaiDat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCaiDat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCaiDat.BorderRadius = 15;
            this.btnCaiDat.BorderSize = 0;
            this.btnCaiDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCaiDat.ForeColor = System.Drawing.Color.White;
            this.btnCaiDat.Image = global::FormMainMenu.Properties.Resources.CaiDat;
            this.btnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.Location = new System.Drawing.Point(0, 320);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCaiDat.Size = new System.Drawing.Size(220, 60);
            this.btnCaiDat.TabIndex = 5;
            this.btnCaiDat.Text = " Cài đặt";
            this.btnCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.TextColor = System.Drawing.Color.White;
            this.btnCaiDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaiDat.UseVisualStyleBackColor = false;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThongBao.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThongBao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThongBao.BorderRadius = 15;
            this.btnThongBao.BorderSize = 0;
            this.btnThongBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongBao.FlatAppearance.BorderSize = 0;
            this.btnThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongBao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThongBao.ForeColor = System.Drawing.Color.White;
            this.btnThongBao.Image = global::FormMainMenu.Properties.Resources.Đơnhàng;
            this.btnThongBao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongBao.Location = new System.Drawing.Point(0, 260);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnThongBao.Size = new System.Drawing.Size(220, 60);
            this.btnThongBao.TabIndex = 4;
            this.btnThongBao.Text = " Quản lý đơn hàng";
            this.btnThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongBao.TextColor = System.Drawing.Color.White;
            this.btnThongBao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongBao.UseVisualStyleBackColor = false;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // btnPBShipper
            // 
            this.btnPBShipper.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPBShipper.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPBShipper.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPBShipper.BorderRadius = 15;
            this.btnPBShipper.BorderSize = 0;
            this.btnPBShipper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPBShipper.FlatAppearance.BorderSize = 0;
            this.btnPBShipper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPBShipper.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPBShipper.ForeColor = System.Drawing.Color.White;
            this.btnPBShipper.Image = global::FormMainMenu.Properties.Resources.phanbo;
            this.btnPBShipper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPBShipper.Location = new System.Drawing.Point(0, 200);
            this.btnPBShipper.Name = "btnPBShipper";
            this.btnPBShipper.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPBShipper.Size = new System.Drawing.Size(220, 60);
            this.btnPBShipper.TabIndex = 3;
            this.btnPBShipper.Text = " Phân bổ Shipper";
            this.btnPBShipper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPBShipper.TextColor = System.Drawing.Color.White;
            this.btnPBShipper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPBShipper.UseVisualStyleBackColor = false;
            this.btnPBShipper.Click += new System.EventHandler(this.btnPBShipper_Click);
            // 
            // btnQLShipper
            // 
            this.btnQLShipper.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQLShipper.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQLShipper.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQLShipper.BorderRadius = 15;
            this.btnQLShipper.BorderSize = 0;
            this.btnQLShipper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLShipper.FlatAppearance.BorderSize = 0;
            this.btnQLShipper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLShipper.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLShipper.ForeColor = System.Drawing.Color.White;
            this.btnQLShipper.Image = global::FormMainMenu.Properties.Resources.QLSP;
            this.btnQLShipper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLShipper.Location = new System.Drawing.Point(0, 140);
            this.btnQLShipper.Name = "btnQLShipper";
            this.btnQLShipper.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnQLShipper.Size = new System.Drawing.Size(220, 60);
            this.btnQLShipper.TabIndex = 2;
            this.btnQLShipper.Text = " Quản lý Shipper";
            this.btnQLShipper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLShipper.TextColor = System.Drawing.Color.White;
            this.btnQLShipper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLShipper.UseVisualStyleBackColor = false;
            this.btnQLShipper.Click += new System.EventHandler(this.btnQLShipper_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnProducts.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnProducts.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnProducts.BorderRadius = 15;
            this.btnProducts.BorderSize = 0;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = global::FormMainMenu.Properties.Resources.home;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 80);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(220, 60);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = " Bảng điều khiển";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextColor = System.Drawing.Color.White;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.BorderColor = System.Drawing.Color.DarkOrchid;
            this.panelLogo.BorderRadius = 20;
            this.panelLogo.BorderSize = 2;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.White;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.TextColor = System.Drawing.Color.White;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FormMainMenu.Properties.Resources.QLSP;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1343, 650);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "  Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QuanLyShipper.RJControls.RJPanel panelDesktop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCloseChildForm;
        private QuanLyShipper.RJControls.RJPanel panelTitleBar;
        private QuanLyShipper.RJControls.RJPanel panelLogo;
        private QuanLyShipper.RJControls.RJLogin btnProducts;
        private QuanLyShipper.RJControls.RJLogin btnQLShipper;
        private QuanLyShipper.RJControls.RJLogin btnPBShipper;
        private QuanLyShipper.RJControls.RJLogin btnThongBao;
        private QuanLyShipper.RJControls.RJLogin btnCaiDat;
        private QuanLyShipper.RJControls.RJLogin btn_dangxuat;
        private QuanLyShipper.RJControls.RJPanel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

