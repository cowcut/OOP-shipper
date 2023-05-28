namespace Shipper.Forms
{
    partial class formThongBao
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
            rjPanel1 = new QuanLyShipper.RJControls.RJPanel();
            SuspendLayout();
            // 
            // rjPanel1
            // 
            rjPanel1.BackColor = Color.FromArgb(171, 108, 249);
            rjPanel1.BackgroundColor = Color.FromArgb(171, 108, 249);
            rjPanel1.BorderColor = Color.PaleVioletRed;
            rjPanel1.BorderRadius = 0;
            rjPanel1.BorderSize = 0;
            rjPanel1.Dock = DockStyle.Fill;
            rjPanel1.ForeColor = Color.White;
            rjPanel1.Location = new Point(0, 0);
            rjPanel1.Name = "rjPanel1";
            rjPanel1.Size = new Size(686, 406);
            rjPanel1.TabIndex = 0;
            rjPanel1.TextColor = Color.White;
            // 
            // formThongBao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 406);
            Controls.Add(rjPanel1);
            Name = "formThongBao";
            Text = "Thông báo";
            ResumeLayout(false);
        }

        #endregion

        private QuanLyShipper.RJControls.RJPanel rjPanel1;
    }
}