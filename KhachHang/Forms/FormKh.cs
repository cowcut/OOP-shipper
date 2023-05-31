using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachHang
{
    public partial class FormKh : Form
    {
        public FormKh()
        {
            InitializeComponent();
        }


        void ChinhSuaTT
           (
           bool KhStatus,
           string strEmail,
           string strTenHienThi,
           string strMatkhau,
           string strMatkhauMoi,
           string strNhapLai
           )
        {
            if (KhStatus)
            {
                label19.Text = strEmail;
                label18.Text = strTenHienThi;
                label17.Text = strMatkhau;
                label16.Text = strMatkhauMoi;
                label15.Text = strNhapLai;
            }
            else
            {
                label19.Text = "Tên tài khoản ";
                label18.Text = "Ngày, tháng, năm sinh";
                label17.Text = "Địa chỉ nhà";
                label16.Text = "Số điện thoại";
                label15.Text = "Email";

            }
        } 

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            thongtincanhan f = new thongtincanhan();
            f.DchinhSua = ChinhSuaTT;
            f.ShowDialog();
        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjLogin4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
