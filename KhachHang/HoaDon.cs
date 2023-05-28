using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachHang
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

      public void ThongTinHh
            (
            bool NhStatus,
            String strSdt,
            String strDiachi,
            String strHoten,
            String strTongkl,
            String strCd,
            String strCr,
            String strCc,
            String BtXemTruoc,
            String BtKoxemTruoc,
            String strGhiChu,
            String strSdtNg,
            String strDiaChiNg,
            String strHoTenNg
            )
        {
            if ( NhStatus ) 
                {
                label1.Text = strSdt;
                label2.Text = strDiachi;
                label3.Text = strHoten; 
                label5.Text = strTongkl;    
                label6.Text = strCd;
                label7.Text = strCr;
                label8.Text = strCc;
                label9.Text = BtXemTruoc;
                label10.Text = BtKoxemTruoc;
                label11.Text = strSdtNg;
                label12.Text = strDiaChiNg;
                label13.Text = strHoTenNg;
                label14.Text = strGhiChu;
                }
            else 
            {
                label1.Text = "Số điện thoại người nhận ";
                label2.Text = "Địa chỉ người nhận ";
                label3.Text = "Họ và tên người nhận ";
                label5.Text = "Tổng khối lượng đơn hàng ";
                label6.Text = "Chiều dài đơn hàng";
                label7.Text = "Chiều rộng đơn hàng ";
                label8.Text = "Chiều cao đơn hàng";
                label9.Text = "Cho xem trước ";
                label10.Text = "Cho không cho xem trước";
                label11.Text = "Số điện thoại người gửi";
                label12.Text = "Địa chỉ người gửi";
                label13.Text = "Họ tên người gửi";
                label14.Text = "Ghi chú cho shipper";

            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
