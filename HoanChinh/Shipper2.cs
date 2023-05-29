using System;

namespace QuanLyShipper
{
    public partial class QuanLyShipper : Form
    {
        private Button currentButton;
        private Form activeForm;
        public QuanLyShipper()
        {
            InitializeComponent();
            btn_exit.Visible = false;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(204, 131, 248);
                    currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                    btn_exit.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(165, 107, 225);
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.paneldesktop.Controls.Add(childForm);
            this.paneldesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_trangchu.Text = childForm.Text;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formTaiKhoan(), sender);
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formDonHang(), sender);
        }

        private void btn_vanchuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formVanChuyen(), sender);
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.formThongBao(), sender);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            lbl_trangchu.Text = "Trang chủ";
            panel6.BackColor = Color.FromArgb(165, 107, 225);
            currentButton = null;
            btn_exit.Visible = false;

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}