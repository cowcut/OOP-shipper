namespace QuanLyShipper.formshipper.Forms
{
    partial class frm_DonHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_danhsachdonhang = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DanhSachDonHang_dgv = new System.Windows.Forms.DataGridView();
            this.rjPanel1 = new QuanLyShipper.RJControls.RJPanel();
            this.rjLogin3 = new QuanLyShipper.RJControls.RJLogin();
            this.rjLogin2 = new QuanLyShipper.RJControls.RJLogin();
            this.rjLogin1 = new QuanLyShipper.RJControls.RJLogin();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachDonHang_dgv)).BeginInit();
            this.rjPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.lbl_danhsachdonhang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 50);
            this.panel1.TabIndex = 0;
            // 
            // lbl_danhsachdonhang
            // 
            this.lbl_danhsachdonhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_danhsachdonhang.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_danhsachdonhang.Location = new System.Drawing.Point(0, 0);
            this.lbl_danhsachdonhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_danhsachdonhang.Name = "lbl_danhsachdonhang";
            this.lbl_danhsachdonhang.Size = new System.Drawing.Size(758, 50);
            this.lbl_danhsachdonhang.TabIndex = 0;
            this.lbl_danhsachdonhang.Text = "Danh sách đơn hàng";
            this.lbl_danhsachdonhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DanhSachDonHang_dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 437);
            this.panel2.TabIndex = 2;
            // 
            // DanhSachDonHang_dgv
            // 
            this.DanhSachDonHang_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DanhSachDonHang_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DanhSachDonHang_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachDonHang_dgv.Location = new System.Drawing.Point(0, 50);
            this.DanhSachDonHang_dgv.Name = "DanhSachDonHang_dgv";
            this.DanhSachDonHang_dgv.Size = new System.Drawing.Size(527, 387);
            this.DanhSachDonHang_dgv.TabIndex = 0;
            this.DanhSachDonHang_dgv.SelectionChanged += new System.EventHandler(this.DanhSachDonHang_dgv_SelectionChanged);
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 0;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.rjLogin3);
            this.rjPanel1.Controls.Add(this.rjLogin2);
            this.rjPanel1.Controls.Add(this.rjLogin1);
            this.rjPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(524, 50);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(234, 387);
            this.rjPanel1.TabIndex = 1;
            this.rjPanel1.TextColor = System.Drawing.Color.White;
            this.rjPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel1_Paint);
            // 
            // rjLogin3
            // 
            this.rjLogin3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rjLogin3.BackColor = System.Drawing.Color.Lavender;
            this.rjLogin3.BackgroundColor = System.Drawing.Color.Lavender;
            this.rjLogin3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin3.BorderRadius = 10;
            this.rjLogin3.BorderSize = 0;
            this.rjLogin3.FlatAppearance.BorderSize = 0;
            this.rjLogin3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjLogin3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjLogin3.Location = new System.Drawing.Point(49, 311);
            this.rjLogin3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rjLogin3.Name = "rjLogin3";
            this.rjLogin3.Size = new System.Drawing.Size(150, 40);
            this.rjLogin3.TabIndex = 2;
            this.rjLogin3.Text = "Nhận đơn ngay";
            this.rjLogin3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjLogin3.UseVisualStyleBackColor = false;
            // 
            // rjLogin2
            // 
            this.rjLogin2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjLogin2.BackColor = System.Drawing.Color.Lavender;
            this.rjLogin2.BackgroundColor = System.Drawing.Color.Lavender;
            this.rjLogin2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin2.BorderRadius = 10;
            this.rjLogin2.BorderSize = 0;
            this.rjLogin2.FlatAppearance.BorderSize = 0;
            this.rjLogin2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjLogin2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjLogin2.Location = new System.Drawing.Point(49, 110);
            this.rjLogin2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rjLogin2.Name = "rjLogin2";
            this.rjLogin2.Size = new System.Drawing.Size(150, 40);
            this.rjLogin2.TabIndex = 1;
            this.rjLogin2.Text = "Lưu";
            this.rjLogin2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjLogin2.UseVisualStyleBackColor = false;
            this.rjLogin2.Click += new System.EventHandler(this.rjLogin2_Click);
            // 
            // rjLogin1
            // 
            this.rjLogin1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjLogin1.BackColor = System.Drawing.Color.Lavender;
            this.rjLogin1.BackgroundColor = System.Drawing.Color.Lavender;
            this.rjLogin1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin1.BorderRadius = 10;
            this.rjLogin1.BorderSize = 0;
            this.rjLogin1.FlatAppearance.BorderSize = 0;
            this.rjLogin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjLogin1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjLogin1.Location = new System.Drawing.Point(49, 32);
            this.rjLogin1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rjLogin1.Name = "rjLogin1";
            this.rjLogin1.Size = new System.Drawing.Size(150, 40);
            this.rjLogin1.TabIndex = 0;
            this.rjLogin1.Text = "Chọn";
            this.rjLogin1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjLogin1.UseVisualStyleBackColor = false;
            this.rjLogin1.Click += new System.EventHandler(this.rjLogin1_Click);
            // 
            // frm_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 437);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_DonHang";
            this.Text = "Đơn Hàng";
            this.Load += new System.EventHandler(this.frm_DonHang_Load);
            this.Resize += new System.EventHandler(this.frm_DonHang_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachDonHang_dgv)).EndInit();
            this.rjPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.Label lbl_danhsachdonhang;
        private RJControls.RJLogin rjLogin3;
        private RJControls.RJLogin rjLogin2;
        private RJControls.RJLogin rjLogin1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView DanhSachDonHang_dgv;
    }
}