namespace Shipper.Forms
{
    partial class formVanChuyen
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
            listView1 = new ListView();
            panel3 = new Panel();
            lbl_daluu = new Label();
            panel2 = new Panel();
            listView2 = new ListView();
            panel4 = new Panel();
            lbl_donhangdanhan = new Label();
            panel5 = new Panel();
            rjLogin1 = new QuanLyShipper.RJControls.RJLogin();
            panel6 = new Panel();
            rjLogin2 = new QuanLyShipper.RJControls.RJLogin();
            rjLogin3 = new QuanLyShipper.RJControls.RJLogin();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(171, 108, 249);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 413);
            panel1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 48);
            listView1.Name = "listView1";
            listView1.Size = new Size(356, 365);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbl_daluu);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 48);
            panel3.TabIndex = 0;
            // 
            // lbl_daluu
            // 
            lbl_daluu.Dock = DockStyle.Fill;
            lbl_daluu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_daluu.Location = new Point(0, 0);
            lbl_daluu.Name = "lbl_daluu";
            lbl_daluu.Size = new Size(356, 48);
            lbl_daluu.TabIndex = 0;
            lbl_daluu.Text = "Đơn hàng đã lưu";
            lbl_daluu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(171, 108, 249);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(listView2);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(356, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 413);
            panel2.TabIndex = 1;
            // 
            // listView2
            // 
            listView2.Dock = DockStyle.Fill;
            listView2.Location = new Point(0, 48);
            listView2.Name = "listView2";
            listView2.Size = new Size(353, 365);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbl_donhangdanhan);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(353, 48);
            panel4.TabIndex = 1;
            // 
            // lbl_donhangdanhan
            // 
            lbl_donhangdanhan.Dock = DockStyle.Fill;
            lbl_donhangdanhan.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_donhangdanhan.Location = new Point(0, 0);
            lbl_donhangdanhan.Name = "lbl_donhangdanhan";
            lbl_donhangdanhan.Size = new Size(353, 48);
            lbl_donhangdanhan.TabIndex = 1;
            lbl_donhangdanhan.Text = "Đơn hàng đã nhận";
            lbl_donhangdanhan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(rjLogin1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 341);
            panel5.Name = "panel5";
            panel5.Size = new Size(356, 72);
            panel5.TabIndex = 2;
            // 
            // rjLogin1
            // 
            rjLogin1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rjLogin1.BackColor = Color.Lavender;
            rjLogin1.BackgroundColor = Color.Lavender;
            rjLogin1.BorderColor = Color.PaleVioletRed;
            rjLogin1.BorderRadius = 10;
            rjLogin1.BorderSize = 0;
            rjLogin1.FlatAppearance.BorderSize = 0;
            rjLogin1.FlatStyle = FlatStyle.Flat;
            rjLogin1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjLogin1.ForeColor = Color.FromArgb(128, 128, 255);
            rjLogin1.Location = new Point(189, 16);
            rjLogin1.Name = "rjLogin1";
            rjLogin1.Size = new Size(150, 40);
            rjLogin1.TabIndex = 3;
            rjLogin1.Text = "Nhận đơn";
            rjLogin1.TextColor = Color.FromArgb(128, 128, 255);
            rjLogin1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(rjLogin2);
            panel6.Controls.Add(rjLogin3);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 341);
            panel6.Name = "panel6";
            panel6.Size = new Size(353, 72);
            panel6.TabIndex = 3;
            // 
            // rjLogin2
            // 
            rjLogin2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rjLogin2.BackColor = Color.Lavender;
            rjLogin2.BackgroundColor = Color.Lavender;
            rjLogin2.BorderColor = Color.PaleVioletRed;
            rjLogin2.BorderRadius = 10;
            rjLogin2.BorderSize = 0;
            rjLogin2.FlatAppearance.BorderSize = 0;
            rjLogin2.FlatStyle = FlatStyle.Flat;
            rjLogin2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjLogin2.ForeColor = Color.FromArgb(128, 128, 255);
            rjLogin2.Location = new Point(190, 16);
            rjLogin2.Margin = new Padding(0);
            rjLogin2.Name = "rjLogin2";
            rjLogin2.Size = new Size(150, 40);
            rjLogin2.TabIndex = 5;
            rjLogin2.Text = "Hủy đơn";
            rjLogin2.TextColor = Color.FromArgb(128, 128, 255);
            rjLogin2.UseVisualStyleBackColor = false;
            // 
            // rjLogin3
            // 
            rjLogin3.BackColor = Color.Lavender;
            rjLogin3.BackgroundColor = Color.Lavender;
            rjLogin3.BorderColor = Color.PaleVioletRed;
            rjLogin3.BorderRadius = 10;
            rjLogin3.BorderSize = 0;
            rjLogin3.FlatAppearance.BorderSize = 0;
            rjLogin3.FlatStyle = FlatStyle.Flat;
            rjLogin3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjLogin3.ForeColor = Color.FromArgb(128, 128, 255);
            rjLogin3.Location = new Point(9, 16);
            rjLogin3.Name = "rjLogin3";
            rjLogin3.Size = new Size(150, 40);
            rjLogin3.TabIndex = 6;
            rjLogin3.Text = "Chi tiết đơn hàng";
            rjLogin3.TextColor = Color.FromArgb(128, 128, 255);
            rjLogin3.UseVisualStyleBackColor = false;
            // 
            // formVanChuyen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 413);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "formVanChuyen";
            Text = "Vận chuyển ";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private ListView listView1;
        private ListView listView2;
        private Label lbl_daluu;
        private Label lbl_donhangdanhan;
        private Panel panel5;
        private QuanLyShipper.RJControls.RJLogin rjLogin1;
        private Panel panel6;
        private QuanLyShipper.RJControls.RJLogin rjLogin2;
        private QuanLyShipper.RJControls.RJLogin rjLogin3;
    }
}