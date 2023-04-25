
namespace QuanLyShipper
{
    partial class frm_QuanLySP
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
            this.QLSP_pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // QLSP_pnl
            // 
            this.QLSP_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QLSP_pnl.AutoSize = true;
            this.QLSP_pnl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.QLSP_pnl.Location = new System.Drawing.Point(-3, 0);
            this.QLSP_pnl.Name = "QLSP_pnl";
            this.QLSP_pnl.Size = new System.Drawing.Size(805, 452);
            this.QLSP_pnl.TabIndex = 0;
            // 
            // frm_QuanLySP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QLSP_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QuanLySP";
            this.Text = "QuanLySP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel QLSP_pnl;
    }
}