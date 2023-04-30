
namespace QuanLyShipper
{
    partial class frm_shipper
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
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbDonhang = new System.Windows.Forms.ComboBox();
            this.btnHuydon = new System.Windows.Forms.Button();
            this.lblDonhangchuanhan = new System.Windows.Forms.Label();
            this.lsvDonhangchuanhan = new System.Windows.Forms.ListView();
            this.lsvDonhang = new System.Windows.Forms.ListView();
            this.btnChondon = new System.Windows.Forms.Button();
            this.btnNhandon = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menu.shipper";
            // 
            // tàiKhToolStripMenuItem
            // 
            this.tàiKhToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tàiKhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.tàiKhToolStripMenuItem.Name = "tàiKhToolStripMenuItem";
            this.tàiKhToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.tàiKhToolStripMenuItem.Text = "Thông tin tài khoản";
            this.tàiKhToolStripMenuItem.Click += new System.EventHandler(this.tàiKhToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvDonhangchuanhan);
            this.panel1.Location = new System.Drawing.Point(5, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 332);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnNhandon);
            this.panel3.Controls.Add(this.btnChondon);
            this.panel3.Location = new System.Drawing.Point(6, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 33);
            this.panel3.TabIndex = 7;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Đăng xuất";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvDonhang);
            this.panel2.Location = new System.Drawing.Point(397, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 368);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHuydon);
            this.panel4.Controls.Add(this.cbDonhang);
            this.panel4.Location = new System.Drawing.Point(398, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 37);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblDonhangchuanhan);
            this.panel5.Location = new System.Drawing.Point(3, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 37);
            this.panel5.TabIndex = 10;
            // 
            // cbDonhang
            // 
            this.cbDonhang.FormattingEnabled = true;
            this.cbDonhang.Location = new System.Drawing.Point(3, 7);
            this.cbDonhang.Name = "cbDonhang";
            this.cbDonhang.Size = new System.Drawing.Size(308, 21);
            this.cbDonhang.TabIndex = 0;
            // 
            // btnHuydon
            // 
            this.btnHuydon.Location = new System.Drawing.Point(317, 3);
            this.btnHuydon.Name = "btnHuydon";
            this.btnHuydon.Size = new System.Drawing.Size(82, 27);
            this.btnHuydon.TabIndex = 1;
            this.btnHuydon.Text = "Hủy đơn";
            this.btnHuydon.UseVisualStyleBackColor = true;
            // 
            // lblDonhangchuanhan
            // 
            this.lblDonhangchuanhan.BackColor = System.Drawing.SystemColors.Window;
            this.lblDonhangchuanhan.Location = new System.Drawing.Point(0, 3);
            this.lblDonhangchuanhan.Name = "lblDonhangchuanhan";
            this.lblDonhangchuanhan.Size = new System.Drawing.Size(383, 27);
            this.lblDonhangchuanhan.TabIndex = 0;
            this.lblDonhangchuanhan.Text = "Đơn hàng chưa nhận";
            this.lblDonhangchuanhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvDonhangchuanhan
            // 
            this.lsvDonhangchuanhan.HideSelection = false;
            this.lsvDonhangchuanhan.Location = new System.Drawing.Point(3, 3);
            this.lsvDonhangchuanhan.Name = "lsvDonhangchuanhan";
            this.lsvDonhangchuanhan.Size = new System.Drawing.Size(381, 326);
            this.lsvDonhangchuanhan.TabIndex = 0;
            this.lsvDonhangchuanhan.UseCompatibleStateImageBehavior = false;
            // 
            // lsvDonhang
            // 
            this.lsvDonhang.HideSelection = false;
            this.lsvDonhang.Location = new System.Drawing.Point(3, -7);
            this.lsvDonhang.Name = "lsvDonhang";
            this.lsvDonhang.Size = new System.Drawing.Size(397, 372);
            this.lsvDonhang.TabIndex = 0;
            this.lsvDonhang.UseCompatibleStateImageBehavior = false;
            // 
            // btnChondon
            // 
            this.btnChondon.Location = new System.Drawing.Point(3, 3);
            this.btnChondon.Name = "btnChondon";
            this.btnChondon.Size = new System.Drawing.Size(82, 27);
            this.btnChondon.TabIndex = 0;
            this.btnChondon.Text = "Chọn";
            this.btnChondon.UseVisualStyleBackColor = true;
            // 
            // btnNhandon
            // 
            this.btnNhandon.Location = new System.Drawing.Point(303, 3);
            this.btnNhandon.Name = "btnNhandon";
            this.btnNhandon.Size = new System.Drawing.Size(82, 27);
            this.btnNhandon.TabIndex = 1;
            this.btnNhandon.Text = "Nhận ngay";
            this.btnNhandon.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(218, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 27);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // frm_shipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_shipper";
            this.Text = "Shipper";
            this.Load += new System.EventHandler(this.frm_shipper_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ListView lsvDonhangchuanhan;
        private System.Windows.Forms.Button btnNhandon;
        private System.Windows.Forms.Button btnChondon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvDonhang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHuydon;
        private System.Windows.Forms.ComboBox cbDonhang;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDonhangchuanhan;
        private System.Windows.Forms.Button btnLuu;
    }
}