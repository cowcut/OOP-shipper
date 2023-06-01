using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachHang
{
    public partial class KhachHangg : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form FormCon;

        public KhachHangg()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 65);
            MenuPanel.Controls.Add(leftBorderBtn);
            //xóa lề trên max form với màn hình
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //set color for menu
        private struct RGBcolor
        {
            public static Color color1 = Color.FromArgb (252, 210, 8);

            public static Color color2 = Color.FromArgb (138, 43, 226);

            public static Color color3 = Color.FromArgb (29, 212, 117);

            public static Color color4 = Color.FromArgb (226, 43, 138);
        }

        private void ActivateButton (object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton) senderBtn;
                currentBtn.BackColor = Color.FromArgb(12,13,19);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //home button
                HomeBt.IconChar = currentBtn.IconChar;
                HomeBt.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(96, 110, 253);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (FormCon != null)
            {
                FormCon.Close();
            }
            FormCon = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            FormPanel.Controls.Add(childForm);
            FormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TrangChu.Text = childForm.Text;
        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            HomeBt.IconChar = IconChar.Home;
            HomeBt.IconColor = Color.GhostWhite;
            TrangChu.Text = "Trang Chủ";
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolor.color1);
            OpenChildForm(new FormHD());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolor.color2);
            OpenChildForm(new FormCthd());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolor.color3);
            OpenChildForm(new FormKh());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolor.color4);
            OpenChildForm(new FormCd());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (FormCon != null)
            {
                FormCon.Close();
            }
            Reset();
        }



        //Dùng để di form  
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Close-Maximize-Minimize
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Remove transparent border in maximized state
        private void Khachhang_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }


        private void FormPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
