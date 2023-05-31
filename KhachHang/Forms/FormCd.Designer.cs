namespace KhachHang
{
    partial class FormCd
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
            this.toi = new System.Windows.Forms.RadioButton();
            this.sang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toi
            // 
            this.toi.AutoSize = true;
            this.toi.BackColor = System.Drawing.Color.Aquamarine;
            this.toi.FlatAppearance.BorderSize = 0;
            this.toi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toi.Location = new System.Drawing.Point(74, 258);
            this.toi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toi.Name = "toi";
            this.toi.Size = new System.Drawing.Size(98, 22);
            this.toi.TabIndex = 14;
            this.toi.TabStop = true;
            this.toi.Text = "Chế độ tối";
            this.toi.UseVisualStyleBackColor = false;
            this.toi.CheckedChanged += new System.EventHandler(this.Btkoxemtruoc_CheckedChanged);
            // 
            // sang
            // 
            this.sang.AutoSize = true;
            this.sang.BackColor = System.Drawing.Color.Aquamarine;
            this.sang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sang.Location = new System.Drawing.Point(74, 206);
            this.sang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sang.Name = "sang";
            this.sang.Size = new System.Drawing.Size(115, 22);
            this.sang.TabIndex = 11;
            this.sang.TabStop = true;
            this.sang.Text = "Chế độ sáng";
            this.sang.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(9, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Giao diện";
            // 
            // FormCd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KhachHang.Properties.Resources._2561184c0d83292e2814a8db5dfe49e11;
            this.ClientSize = new System.Drawing.Size(1042, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toi);
            this.Controls.Add(this.sang);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCd";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton toi;
        private System.Windows.Forms.RadioButton sang;
        private System.Windows.Forms.Label label1;
    }
}