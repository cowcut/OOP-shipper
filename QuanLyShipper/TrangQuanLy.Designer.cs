
namespace QuanLyShipper
{
    partial class frm_TrangQuanLy
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
            this.QuanLy_pnl = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuanLy_pnl
            // 
            this.QuanLy_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuanLy_pnl.BackColor = System.Drawing.SystemColors.Control;
            this.QuanLy_pnl.Location = new System.Drawing.Point(-1, 27);
            this.QuanLy_pnl.Name = "QuanLy_pnl";
            this.QuanLy_pnl.Size = new System.Drawing.Size(801, 423);
            this.QuanLy_pnl.TabIndex = 0;
            this.QuanLy_pnl.Resize += new System.EventHandler(this.QuanLy_pnl_Resize);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.thốngKêĐơnHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.fileToolStripMenuItem.Text = "Thống kê Shipper";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // thốngKêĐơnHàngToolStripMenuItem
            // 
            this.thốngKêĐơnHàngToolStripMenuItem.Name = "thốngKêĐơnHàngToolStripMenuItem";
            this.thốngKêĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thốngKêĐơnHàngToolStripMenuItem.Text = "Thống kê đơn hàng";
            this.thốngKêĐơnHàngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêĐơnHàngToolStripMenuItem_Click);
            // 
            // frm_TrangQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuanLy_pnl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_TrangQuanLy";
            this.Text = "TrangQuanLy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel QuanLy_pnl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêĐơnHàngToolStripMenuItem;
    }
}