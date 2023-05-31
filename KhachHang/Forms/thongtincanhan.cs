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
    public partial class thongtincanhan : Form
    {
        public thongtincanhan()
        {
            InitializeComponent();
        }

        public delegate void ChinhSua
            (
            bool KhStatus, 
            string strEmail, 
            string strTenHienThi, 
            string strMatkhau, 
            string strMatkhauMoi, 
            string strNhapLai  
            );

        public ChinhSua DchinhSua;

        private void button1_Click(object sender, EventArgs e)
        {

            if (Email.Text == "")
            {
                Email.Focus();
            }
            else if (TenHienThi.Text == "")
            {
                TenHienThi.Focus();
            }
            else if (MatKhau.Text == "")
            {
                MatKhau.Focus();
            }
            else if (MatKhauMoi.Text == "")
            {
                MatKhauMoi.Focus();
            }
            else if (NhapLai.Text == "")
            {
                NhapLai.Focus();
            }
            else
            {

                String strEmail = Email.Text;
                String strTenHienThi = TenHienThi.Text;
                String strMatKhau = MatKhau.Text;
                String strMatkhauMoi = MatKhauMoi.Text;
                String strNhaplai = NhapLai.Text;

                DchinhSua
                    (
                    true,
                    strEmail,
                    strTenHienThi,
                    strMatKhau,
                    strMatkhauMoi,
                    strNhaplai
                    );
                this.Close();
            }
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void thongtincanhan_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
