
namespace QuanLyShipper
{
    partial class frm_HeyYou
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
            this.NguoiDung_btn = new System.Windows.Forms.Button();
            this.QuanLy_btn = new System.Windows.Forms.Button();
            this.Shipper_btn = new System.Windows.Forms.Button();
            this.Main_pnl = new System.Windows.Forms.Panel();
            this.Main_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // NguoiDung_btn
            // 
            this.NguoiDung_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NguoiDung_btn.Location = new System.Drawing.Point(130, 183);
            this.NguoiDung_btn.Name = "NguoiDung_btn";
            this.NguoiDung_btn.Size = new System.Drawing.Size(112, 33);
            this.NguoiDung_btn.TabIndex = 0;
            this.NguoiDung_btn.Text = "Người dùng";
            this.NguoiDung_btn.UseVisualStyleBackColor = true;
            this.NguoiDung_btn.Click += new System.EventHandler(this.NguoiDung_btn_Click);
            // 
            // QuanLy_btn
            // 
            this.QuanLy_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuanLy_btn.Location = new System.Drawing.Point(470, 183);
            this.QuanLy_btn.Name = "QuanLy_btn";
            this.QuanLy_btn.Size = new System.Drawing.Size(112, 33);
            this.QuanLy_btn.TabIndex = 0;
            this.QuanLy_btn.Text = "Người quản lý";
            this.QuanLy_btn.UseVisualStyleBackColor = true;
            this.QuanLy_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Shipper_btn
            // 
            this.Shipper_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Shipper_btn.Location = new System.Drawing.Point(304, 183);
            this.Shipper_btn.Name = "Shipper_btn";
            this.Shipper_btn.Size = new System.Drawing.Size(112, 33);
            this.Shipper_btn.TabIndex = 0;
            this.Shipper_btn.Text = "Shipper";
            this.Shipper_btn.UseVisualStyleBackColor = true;
            this.Shipper_btn.Click += new System.EventHandler(this.Shipper_btn_Click);
            // 
            // Main_pnl
            // 
            this.Main_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_pnl.Controls.Add(this.Shipper_btn);
            this.Main_pnl.Controls.Add(this.QuanLy_btn);
            this.Main_pnl.Controls.Add(this.NguoiDung_btn);
            this.Main_pnl.Location = new System.Drawing.Point(-1, 0);
            this.Main_pnl.Name = "Main_pnl";
            this.Main_pnl.Size = new System.Drawing.Size(800, 439);
            this.Main_pnl.TabIndex = 1;
            // 
            // frm_HeyYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 437);
            this.Controls.Add(this.Main_pnl);
            this.Name = "frm_HeyYou";
            this.Text = "HeyYou";
            this.Main_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NguoiDung_btn;
        private System.Windows.Forms.Button QuanLy_btn;
        private System.Windows.Forms.Button Shipper_btn;
        private System.Windows.Forms.Panel Main_pnl;
    }
}

