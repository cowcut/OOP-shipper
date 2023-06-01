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
    public partial class FormHD : Form
    {
        public FormHD()
        {
            InitializeComponent();
        }

        // Con trỏ để tạo hóa đơn 
        public delegate void BenNhanHang
            (
            bool NhStatus,
            String strSdt,
            String strDiachi,
            String strHoten,
            String strQuanhuyen,
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
            );

        public BenNhanHang DNhanhang;

        private void button6_Click(object sender, EventArgs e)
        {
            //Số điện thoại
            if (TxtSdt.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa nhập số điện thoại người nhận!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                TxtSdt.Focus();
            }
            //Địa chỉ
            else if (TxtDiaChi.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa nhập địa chỉ!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                TxtDiaChi.Focus();
            }
            //Họ tên
            else if (TxtHoTen.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa nhập họ tên!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                TxtHoTen.Focus();
            }
         
            //Tổng khối lượng đơn
            else if (TxtTongKl.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa nhập tồng khối lượng hàng!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                TxtTongKl.Focus();
            }
            // Chiều dài đơn
            else if (TxtCd.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa nhập chiều dài đơn hàng!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                TxtCd.Focus();
            }
            //Chiều rộng đơn
            else if (TxtCr.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa nhập chiều rộng đơn hàng!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                TxtCr.Focus();
            }
            //Chiều cao đơn
            else if (TxtCc.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa nhập chiều cao đơn hàng!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                TxtCc.Focus();
            }
            //Lưu ý khách hàng
            else if (Btkoxemtruoc.Checked && Btxemtruoc.Checked)
            {
                MessageBox.Show
                    (
                    "Bạn chưa tích vào một trong hai lưu ý trước khi giao hàng!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                Btkoxemtruoc.Focus();
                Btxemtruoc.Focus();
            }
            //Ghi chú khách hàng
            else if (TxtGhiChu.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn Không có ghi chú gì cho shipper?", "Lưu ý",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                TxtGhiChu.Focus();
            }
            //SDT NG
            else if (SdtNg.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa điền số điện thoại của bạn!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                SdtNg.Focus();
            }
            //Họ và tên người gửi
            else if (HoTenNg.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa điền họ và tên của bạn!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                HoTenNg.Focus();
            }
            //Địa chỉ người gửi
            else if (DiaChiNg.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa nhập địa chỉ nhà!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                DiaChiNg.Focus();
            }
            else
            {
                String strSdt = TxtSdt.Text;
                String strDiachi = TxtDiaChi.Text;
                String strHoten = TxtHoTen.Text;
                String strTongkl = TxtTongKl.Text;
                String strCd = TxtCd.Text;
                String strCr = TxtCr.Text;
                String strCc = TxtCc.Text;
                String BtXemTruoc = Btxemtruoc.Text;
                String BtKoXemTruoc = Btkoxemtruoc.Text;
                String strGhiChu = TxtGhiChu.Text;
                String strSdtNg = SdtNg.Text;
                String strDiaChiNg = DiaChiNg.Text; 
                String strHoTenNg = HoTenNg.Text;

                HoaDon f = new HoaDon();
                f.ThongTinHh(true,
                     TxtSdt.Text, TxtDiaChi.Text, TxtHoTen.Text, TxtTongKl.Text, TxtCd.Text, TxtCc.Text, TxtCr.Text, Btkoxemtruoc.Text, TxtGhiChu.Text, Btxemtruoc.Text, SdtNg.Text, DiaChiNg.Text, HoTenNg.Text);
                f.ShowDialog();
            }

           

        }

        private void TxtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }
    }

       
    }

