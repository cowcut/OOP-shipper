using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShipper.formshipper
{
    public partial class Shipper : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Shipper()
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

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formshipper.Forms.frm_TaiKhoan(), sender);
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formshipper.Forms.frm_DonHang(), sender);

        }

        private void btn_vanchuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formshipper.Forms.frm_VanChuyen(), sender);

        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formshipper.Forms.frm_ThongBao(), sender);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HeyYou frmDN = new frm_HeyYou();
            ShowDialog(frmDN);

        }
        private void Reset()
        {
            DisableButton();
            lbl_trangchu.Text = "Trang chủ";
            panel6.BackColor = Color.FromArgb(165, 107, 225);
            currentButton = null;
            btn_exit.Visible = false;

        }
    }
}
