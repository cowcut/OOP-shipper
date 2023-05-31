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

namespace FormMainMenu
{
    public partial class QuanLy : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //Ham tao
        public QuanLy()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }
        //private void ActivateButton(object btnSender)
        //{
        //    if (btnSender != null)
        //    {
        //        if (currentButton != (Button)btnSender)
        //        {
        //            DisableButton();
        //            Color color = SelectThemeColor();
        //            currentButton = (Button)btnSender;
        //            currentButton.BackColor = color;
        //            currentButton.ForeColor = Color.White;
        //            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            panelTitleBar.BackColor = color;
        //            panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
        //            ThemeColor.PrimaryColor = color;
        //            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
        //            btnCloseChildForm.Visible = true;
        //        }
        //    }
        //}
        //private void DisableButton()
        //{
        //        if(currentButton != null)
        //        {
        //            currentButton.BackColor = Color.FromArgb(123, 104, 238);
        //            currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        //            currentButton.ForeColor = Color.Gainsboro;
        //            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        }

        //}
        //private void OpenChildForm(Form childForm, object btnSender)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    ActivateButton(btnSender);
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    this.panelDesktop.Controls.Add(childForm);
        //    this.panelDesktop.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //    lblTitle.Text = childForm.Text;
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        //private void btnProducts_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormDashboard(), sender);
        //}

        //private void btnQLShipper_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormQLShipper(), sender);
        //}
        //private void btnPBShipper_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormPBShipper(), sender);
        //}
        //private void btnThongBao_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormThongBao(), sender);
        //}
        //private void btnCaiDat_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormCaiDat(), sender);
        //}

        //private void btnCloseChildForm_Click(object sender, EventArgs e)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    Reset();
        //}
        //private void Reset()
        //{
        //    DisableButton();
        //    lblTitle.Text = "Welcom to HeYou";
        //    panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
        //    panelLogo.BackColor = Color.FromArgb(39, 39, 58);
        //    currentButton = null;
        //    btnCloseChildForm.Visible = false;
        //}
        //private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}
        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
        //private void btnMaximize_Click(object sender, EventArgs e)
        //{
        //    if (WindowState == FormWindowState.Normal)
        //        this.WindowState = FormWindowState.Maximized;
        //    else
        //        this.WindowState = FormWindowState.Normal;
        //}
        //private void bntMinimize_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}
        //private void btn_dangxuat_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{

        //}

        //private void panelDesktop_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void pictureBox1_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void panelLogo_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void lblTitle_Click(object sender, EventArgs e)
        //{

        //}
    }
}
