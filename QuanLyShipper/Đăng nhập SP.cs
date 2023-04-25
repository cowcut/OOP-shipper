using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyShipper
{
    public partial class frm_DangNhapSP : Form
    {
        public frm_DangNhapSP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT * FROM Shipper WHERE TaiKhoanSP=@TaiKhoanSP AND MatKhauSP=@MatKhauSP", connection);
            connection.Open();
            command.Parameters.AddWithValue("@TaiKhoanSP", TaiKhoan_txt.Text);
            command.Parameters.AddWithValue("@MatKhauSP", MatKhau_txt.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                //Đóng form đăng nhập
                this.Hide();
                this.Close();

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

        private void TaiKhoan_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MatKhau_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
