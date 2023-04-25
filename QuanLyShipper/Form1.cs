using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShipper
{
    public partial class frm_HeyYou : Form
    {
        public frm_HeyYou()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhapQL DN = new frm_DangNhapQL();
            DN.ShowDialog();
        }

        private void Shipper_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhapSP SP = new frm_DangNhapSP();
            SP.ShowDialog();
        }

        private void NguoiDung_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhapKH kh = new frm_DangNhapKH();
            kh.ShowDialog();
        }
    }
}
