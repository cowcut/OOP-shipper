namespace KhachHang
{
    partial class flogin
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
            this.exit = new System.Windows.Forms.Button();
            this.signin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.boxpassword = new System.Windows.Forms.TextBox();
            this.userpass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textusername = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.signin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 267);
            this.panel1.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.exit.Location = new System.Drawing.Point(526, 206);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(127, 38);
            this.exit.TabIndex = 3;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.signin.Location = new System.Drawing.Point(375, 206);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(127, 38);
            this.signin.TabIndex = 2;
            this.signin.Text = "Đăng nhập\r\n";
            this.signin.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.boxpassword);
            this.panel3.Controls.Add(this.userpass);
            this.panel3.Location = new System.Drawing.Point(3, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 100);
            this.panel3.TabIndex = 1;
            // 
            // boxpassword
            // 
            this.boxpassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxpassword.Location = new System.Drawing.Point(217, 28);
            this.boxpassword.Name = "boxpassword";
            this.boxpassword.Size = new System.Drawing.Size(433, 33);
            this.boxpassword.TabIndex = 1;
            this.boxpassword.UseSystemPasswordChar = true;
            this.boxpassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userpass
            // 
            this.userpass.AutoSize = true;
            this.userpass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.userpass.Location = new System.Drawing.Point(0, 34);
            this.userpass.Name = "userpass";
            this.userpass.Size = new System.Drawing.Size(137, 27);
            this.userpass.TabIndex = 0;
            this.userpass.Text = "Mật Khẩu : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textusername);
            this.panel2.Controls.Add(this.username);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 100);
            this.panel2.TabIndex = 0;
            // 
            // textusername
            // 
            this.textusername.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textusername.Location = new System.Drawing.Point(217, 28);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(433, 33);
            this.textusername.TabIndex = 1;
            this.textusername.TextChanged += new System.EventHandler(this.textusername_TextChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.username.Location = new System.Drawing.Point(0, 34);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(199, 27);
            this.username.TabIndex = 0;
            this.username.Text = "Tên đăng nhập : ";
            // 
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 286);
            this.Controls.Add(this.panel1);
            this.Name = "flogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_closing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox boxpassword;
        private System.Windows.Forms.Label userpass;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button exit;
    }
}

