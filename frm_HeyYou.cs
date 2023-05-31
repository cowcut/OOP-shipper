using QuanLyShipper.formshipper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QuanLyShipper
{
    public partial class frm_HeyYou : Form
    {

        public frm_HeyYou()
        {
            InitializeComponent();
        }

        private void DangNhap_btn_Click(object sender, EventArgs e)
        {

        }

        private void frm_HeyYou_Load(object sender, EventArgs e)
        {

        }

        private void Main_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void MatKhau_txt__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjLogin4_Click(object sender, EventArgs e)
        {

        }

        private void DangKy_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void DangNhap_btn_Click_1(object sender, EventArgs e)
        {
            if (LoaiTK_cbbox.Texts == "Shipper")
            {
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT * FROM Shipper WHERE TaiKhoanSP=@TaiKhoanSP AND MatKhauSP=@MatKhauSP", connection);
                connection.Open();
                command.Parameters.AddWithValue("@TaiKhoanSP", TaiKhoan_txt.Texts);
                command.Parameters.AddWithValue("@MatKhauSP", MatKhau_txt.Texts);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //Đóng form đăng nhập
                    this.Hide();
                    MessageBox.Show("đăng nhập thành công");

                    //Mở form chính
                    frm_Shipper mainForm = new frm_Shipper();
                    mainForm.Show();
                    reader.Close();
                    connection.Close();


                    connection.Open();
                    object storedShipperCode = command.ExecuteScalar();
                    connection.Close();

                   

                        string storedShipperCodeString = storedShipperCode.ToString();
                        Properties.Settings.Default.BienLuuTruMa = storedShipperCodeString; // Lưu mã stored procedure vào biến cục bộ
                        Properties.Settings.Default.Save(); // Lưu thay đổi vào tệ cấu hình
                    }
                    
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
            //if (LoaiTK_cbbox.Texts == "Quản Lý")
            //{
            //    SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-MPPJ3B2F\RENTRE;Initial Catalog=QuanLyShipper;Integrated Security=True");
            //    SqlCommand command = new SqlCommand("SELECT * FROM QuanLy WHERE TaiKhoanQL=@TaiKhoanQL AND MatKhauQL=@MatKhauQL", connection);
            //    connection.Open();
            //    command.Parameters.AddWithValue("@TaiKhoanQL", TaiKhoan_txt.Text);
            //    command.Parameters.AddWithValue("@MatKhauQL", MatKhau_txt.Text);
            //    SqlDataReader reader = command.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        //Đóng form đăng nhập
            //        this.Hide();
            //        MessageBox.Show("đăng nhập thành công");

            //        //Mở form chính
            //        frm_TrangQuanLy mainForm = new frm_TrangQuanLy();
            //        mainForm.Show();
            //        reader.Close();
            //        connection.Close();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            //    }
            //}
            //if (LoaiTK_cbbox.Texts == "Khách Hàng")
            //{
            //    SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-MPPJ3B2F\RENTRE;Initial Catalog=QuanLyShipper;Integrated Security=True");
            //    SqlCommand command = new SqlCommand("SELECT * FROM KhachHang WHERE TaiKhoanKH=@TaiKhoanKH AND MatKhauKH=@MatKhauKH", connection);
            //    connection.Open();
            //    command.Parameters.AddWithValue("@TaiKhoanKH", TaiKhoan_txt.Text);
            //    command.Parameters.AddWithValue("@MatKhauKH", MatKhau_txt.Text);
            //    SqlDataReader reader = command.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        //Đóng form đăng nhập
            //        this.Hide();


            //        //Mở form chính
            //        frm_KhachHang mainForm = new frm_KhachHang();
            //        mainForm.Show();
            //        reader.Close();
            //        connection.Close();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            //    }
            //}
        }
}
