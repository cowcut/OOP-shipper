namespace HoanThien.FormChildShipper
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_huydon = new QuanLyShipper.RJControls.RJLogin();
            this.btn_chitietdonhang = new QuanLyShipper.RJControls.RJLogin();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_donhangdanhan = new System.Windows.Forms.Label();
            this.DonHangDaNhan_dgv = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonHangDaNhan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.DonHangDaNhan_dgv);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 573);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_huydon);
            this.panel6.Controls.Add(this.btn_chitietdonhang);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 519);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(970, 54);
            this.panel6.TabIndex = 2;
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
            this.btn_huydon.Location = new System.Drawing.Point(808, 6);
            this.btn_huydon.Name = "btn_huydon";
            this.btn_huydon.Size = new System.Drawing.Size(150, 40);
            this.btn_huydon.TabIndex = 2;
            this.btn_huydon.Text = "Hủy đơn";
            this.btn_huydon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_huydon.UseVisualStyleBackColor = false;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(249)))));
            this.panel4.Controls.Add(this.lbl_donhangdanhan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(970, 50);
            this.panel4.TabIndex = 1;
            // 
            // lbl_donhangdanhan
            // 
            this.lbl_donhangdanhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_donhangdanhan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_donhangdanhan.Location = new System.Drawing.Point(0, 0);
            this.lbl_donhangdanhan.Name = "lbl_donhangdanhan";
            this.lbl_donhangdanhan.Size = new System.Drawing.Size(970, 50);
            this.lbl_donhangdanhan.TabIndex = 1;
            this.lbl_donhangdanhan.Text = "Đơn hàng đã nhận";
            this.lbl_donhangdanhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DonHangDaNhan_dgv
            // 
            this.DonHangDaNhan_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DonHangDaNhan_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DonHangDaNhan_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DonHangDaNhan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DonHangDaNhan_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.DonHangDaNhan_dgv.Location = new System.Drawing.Point(0, 53);
            this.DonHangDaNhan_dgv.Name = "DonHangDaNhan_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DonHangDaNhan_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DonHangDaNhan_dgv.Size = new System.Drawing.Size(969, 466);
            this.DonHangDaNhan_dgv.TabIndex = 3;
            // 
            // frm_VanChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 573);
            this.Controls.Add(this.panel2);
            this.Name = "frm_VanChuyen";
            this.Text = "Vận chuyển ";
            //this.Load += new System.EventHandler(this.frm_VanChuyen_Load);
            //this.Resize += new System.EventHandler(this.frm_VanChuyen_Resize);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DonHangDaNhan_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_donhangdanhan;
        private QuanLyShipper.RJControls.RJLogin btn_huydon;
        private QuanLyShipper.RJControls.RJLogin btn_chitietdonhang;
        private System.Windows.Forms.DataGridView DonHangDaNhan_dgv;
    }
}