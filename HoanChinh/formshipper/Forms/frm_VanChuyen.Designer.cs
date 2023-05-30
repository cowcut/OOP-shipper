namespace QuanLyShipper.formshipper.Forms
{
    partial class frm_VanChuyen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_daluu = new System.Windows.Forms.Label();
            this.lbl_donhangdanhan = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btn_nhandon = new QuanLyShipper.RJControls.RJLogin();
            this.btn_chitietdonhang = new QuanLyShipper.RJControls.RJLogin();
            this.btn_huydon = new QuanLyShipper.RJControls.RJLogin();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 418);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(350, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 418);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.panel3.Controls.Add(this.lbl_daluu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 50);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.panel4.Controls.Add(this.lbl_donhangdanhan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 50);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_nhandon);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 364);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 54);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_huydon);
            this.panel6.Controls.Add(this.btn_chitietdonhang);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 364);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(343, 54);
            this.panel6.TabIndex = 2;
            // 
            // lbl_daluu
            // 
            this.lbl_daluu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_daluu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_daluu.Location = new System.Drawing.Point(0, 0);
            this.lbl_daluu.Name = "lbl_daluu";
            this.lbl_daluu.Size = new System.Drawing.Size(350, 50);
            this.lbl_daluu.TabIndex = 0;
            this.lbl_daluu.Text = "Đơn hàng đã lưu";
            this.lbl_daluu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_donhangdanhan
            // 
            this.lbl_donhangdanhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_donhangdanhan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_donhangdanhan.Location = new System.Drawing.Point(0, 0);
            this.lbl_donhangdanhan.Name = "lbl_donhangdanhan";
            this.lbl_donhangdanhan.Size = new System.Drawing.Size(343, 50);
            this.lbl_donhangdanhan.TabIndex = 1;
            this.lbl_donhangdanhan.Text = "Đơn hàng đã nhận";
            this.lbl_donhangdanhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 314);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 50);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(343, 314);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btn_nhandon
            // 
            this.btn_nhandon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nhandon.BackColor = System.Drawing.Color.Lavender;
            this.btn_nhandon.BackgroundColor = System.Drawing.Color.Lavender;
            this.btn_nhandon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_nhandon.BorderRadius = 10;
            this.btn_nhandon.BorderSize = 0;
            this.btn_nhandon.FlatAppearance.BorderSize = 0;
            this.btn_nhandon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhandon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhandon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_nhandon.Location = new System.Drawing.Point(184, 6);
            this.btn_nhandon.Name = "btn_nhandon";
            this.btn_nhandon.Size = new System.Drawing.Size(150, 40);
            this.btn_nhandon.TabIndex = 0;
            this.btn_nhandon.Text = "Nhận đơn";
            this.btn_nhandon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_nhandon.UseVisualStyleBackColor = false;
            // 
            // btn_chitietdonhang
            // 
            this.btn_chitietdonhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_chitietdonhang.BackColor = System.Drawing.Color.Lavender;
            this.btn_chitietdonhang.BackgroundColor = System.Drawing.Color.Lavender;
            this.btn_chitietdonhang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_chitietdonhang.BorderRadius = 10;
            this.btn_chitietdonhang.BorderSize = 0;
            this.btn_chitietdonhang.FlatAppearance.BorderSize = 0;
            this.btn_chitietdonhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chitietdonhang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chitietdonhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_chitietdonhang.Location = new System.Drawing.Point(6, 6);
            this.btn_chitietdonhang.Name = "btn_chitietdonhang";
            this.btn_chitietdonhang.Size = new System.Drawing.Size(150, 40);
            this.btn_chitietdonhang.TabIndex = 1;
            this.btn_chitietdonhang.Text = "Chi tiết đơn hàng";
            this.btn_chitietdonhang.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_chitietdonhang.UseVisualStyleBackColor = false;
            // 
            // btn_huydon
            // 
            this.btn_huydon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_huydon.BackColor = System.Drawing.Color.Lavender;
            this.btn_huydon.BackgroundColor = System.Drawing.Color.Lavender;
            this.btn_huydon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_huydon.BorderRadius = 10;
            this.btn_huydon.BorderSize = 0;
            this.btn_huydon.FlatAppearance.BorderSize = 0;
            this.btn_huydon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huydon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huydon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_huydon.Location = new System.Drawing.Point(181, 6);
            this.btn_huydon.Name = "btn_huydon";
            this.btn_huydon.Size = new System.Drawing.Size(150, 40);
            this.btn_huydon.TabIndex = 2;
            this.btn_huydon.Text = "Hủy đơn";
            this.btn_huydon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_huydon.UseVisualStyleBackColor = false;
            // 
            // frm_VanChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_VanChuyen";
            this.Text = "Vận chuyển ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_daluu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_donhangdanhan;
        private RJControls.RJLogin btn_nhandon;
        private RJControls.RJLogin btn_huydon;
        private RJControls.RJLogin btn_chitietdonhang;
    }
}