using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_btn_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Shipper")
            {
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-MPPJ3B2F\RENTRE;Initial Catalog=QuanLyShipper;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT * FROM Shipper WHERE TaiKhoanSP=@TaiKhoanSP AND MatKhauSP=@MatKhauSP", connection);
                connection.Open();
                command.Parameters.AddWithValue("@TaiKhoanSP", TaiKhoan_txt.Text);
                command.Parameters.AddWithValue("@MatKhauSP", MatKhau_txt.Text);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //Đóng form đăng nhập
                    this.Hide();
                    MessageBox.Show("đăng nhập thành công");

                    //Mở form chính
                    frm_shipper mainForm = new frm_shipper();
                    mainForm.Show();
                    reader.Close();
                    connection.Close();
                    
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
            if (comboBox1.Text == "Quản Lý")
            {
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-MPPJ3B2F\RENTRE;Initial Catalog=QuanLyShipper;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT * FROM QuanLy WHERE TaiKhoanQL=@TaiKhoanQL AND MatKhauQL=@MatKhauQL", connection);
                connection.Open();
                command.Parameters.AddWithValue("@TaiKhoanQL", TaiKhoan_txt.Text);
                command.Parameters.AddWithValue("@MatKhauQL", MatKhau_txt.Text);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //Đóng form đăng nhập
                    this.Hide();
                    MessageBox.Show("đăng nhập thành công");

                    //Mở form chính
                    frm_TrangQuanLy mainForm = new frm_TrangQuanLy();
                    mainForm.Show();
                    reader.Close();
                    connection.Close();

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
            if (comboBox1.Text == "Khách Hàng")
            {
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-MPPJ3B2F\RENTRE;Initial Catalog=QuanLyShipper;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT * FROM KhachHang WHERE TaiKhoanKH=@TaiKhoanKH AND MatKhauKH=@MatKhauKH", connection);
                connection.Open();
                command.Parameters.AddWithValue("@TaiKhoanKH", TaiKhoan_txt.Text);
                command.Parameters.AddWithValue("@MatKhauKH", MatKhau_txt.Text);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //Đóng form đăng nhập
                    this.Hide();
                    

                    //Mở form chính
                    frm_KhachHang mainForm = new frm_KhachHang();
                    mainForm.Show();
                    reader.Close();
                    connection.Close();

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }

        }
    }
}
