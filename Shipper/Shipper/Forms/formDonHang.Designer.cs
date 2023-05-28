namespace Shipper.Forms
{
    partial class formDonHang
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
            panel1 = new Panel();
            lbl_danhsachdonhang = new Label();
            panel2 = new Panel();
            rjPanel1 = new QuanLyShipper.RJControls.RJPanel();
            rjLogin3 = new QuanLyShipper.RJControls.RJLogin();
            rjLogin2 = new QuanLyShipper.RJControls.RJLogin();
            rjLogin1 = new QuanLyShipper.RJControls.RJLogin();
            listView1 = new ListView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            rjPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_danhsachdonhang);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 48);
            panel1.TabIndex = 0;
            // 
            // lbl_danhsachdonhang
            // 
            lbl_danhsachdonhang.BackColor = Color.FromArgb(171, 108, 249);
            lbl_danhsachdonhang.Dock = DockStyle.Fill;
            lbl_danhsachdonhang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_danhsachdonhang.Location = new Point(0, 0);
            lbl_danhsachdonhang.Name = "lbl_danhsachdonhang";
            lbl_danhsachdonhang.Size = new Size(687, 48);
            lbl_danhsachdonhang.TabIndex = 0;
            lbl_danhsachdonhang.Text = "Danh sách đơn hàng";
            lbl_danhsachdonhang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(rjPanel1);
            panel2.Controls.Add(listView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(687, 363);
            panel2.TabIndex = 1;
            // 
            // rjPanel1
            // 
            rjPanel1.BackColor = Color.MediumSlateBlue;
            rjPanel1.BackgroundColor = Color.MediumSlateBlue;
            rjPanel1.BorderColor = Color.PaleVioletRed;
            rjPanel1.BorderRadius = 0;
            rjPanel1.BorderSize = 0;
            rjPanel1.Controls.Add(rjLogin3);
            rjPanel1.Controls.Add(rjLogin2);
            rjPanel1.Controls.Add(rjLogin1);
            rjPanel1.Dock = DockStyle.Right;
            rjPanel1.ForeColor = Color.White;
            rjPanel1.Location = new Point(438, 0);
            rjPanel1.Name = "rjPanel1";
            rjPanel1.Size = new Size(249, 363);
            rjPanel1.TabIndex = 1;
            rjPanel1.TextColor = Color.White;
            // 
            // rjLogin3
            // 
            rjLogin3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            rjLogin3.BackColor = Color.Lavender;
            rjLogin3.BackgroundColor = Color.Lavender;
            rjLogin3.BorderColor = Color.PaleVioletRed;
            rjLogin3.BorderRadius = 10;
            rjLogin3.BorderSize = 0;
            rjLogin3.FlatAppearance.BorderSize = 0;
            rjLogin3.FlatStyle = FlatStyle.Flat;
            rjLogin3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjLogin3.ForeColor = Color.FromArgb(128, 128, 255);
            rjLogin3.Location = new Point(55, 298);
            rjLogin3.Name = "rjLogin3";
            rjLogin3.Size = new Size(166, 40);
            rjLogin3.TabIndex = 2;
            rjLogin3.Text = "Nhận đơn ngay";
            rjLogin3.TextColor = Color.FromArgb(128, 128, 255);
            rjLogin3.UseVisualStyleBackColor = false;
            // 
            // rjLogin2
            // 
            rjLogin2.Anchor = AnchorStyles.Top;
            rjLogin2.BackColor = Color.Lavender;
            rjLogin2.BackgroundColor = Color.Lavender;
            rjLogin2.BorderColor = Color.PaleVioletRed;
            rjLogin2.BorderRadius = 10;
            rjLogin2.BorderSize = 0;
            rjLogin2.FlatAppearance.BorderSize = 0;
            rjLogin2.FlatStyle = FlatStyle.Flat;
            rjLogin2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjLogin2.ForeColor = Color.FromArgb(128, 128, 255);
            rjLogin2.Location = new Point(55, 101);
            rjLogin2.Name = "rjLogin2";
            rjLogin2.Size = new Size(150, 40);
            rjLogin2.TabIndex = 1;
            rjLogin2.Text = "Lưu";
            rjLogin2.TextColor = Color.FromArgb(128, 128, 255);
            rjLogin2.UseVisualStyleBackColor = false;
            // 
            // rjLogin1
            // 
            rjLogin1.Anchor = AnchorStyles.Top;
            rjLogin1.BackColor = Color.Lavender;
            rjLogin1.BackgroundColor = Color.Lavender;
            rjLogin1.BorderColor = Color.PaleVioletRed;
            rjLogin1.BorderRadius = 10;
            rjLogin1.BorderSize = 0;
            rjLogin1.FlatAppearance.BorderSize = 0;
            rjLogin1.FlatStyle = FlatStyle.Flat;
            rjLogin1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjLogin1.ForeColor = Color.FromArgb(128, 128, 255);
            rjLogin1.Location = new Point(55, 33);
            rjLogin1.Name = "rjLogin1";
            rjLogin1.Size = new Size(150, 40);
            rjLogin1.TabIndex = 0;
            rjLogin1.Text = "Chọn ";
            rjLogin1.TextColor = Color.FromArgb(128, 128, 255);
            rjLogin1.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(687, 363);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // formDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 411);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "formDonHang";
            Text = "Đơn hàng";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            rjPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_danhsachdonhang;
        private Panel panel2;
        private ListView listView1;
        private QuanLyShipper.RJControls.RJPanel rjPanel1;
        private QuanLyShipper.RJControls.RJLogin rjLogin1;
        private QuanLyShipper.RJControls.RJLogin rjLogin3;
        private QuanLyShipper.RJControls.RJLogin rjLogin2;
    }
}