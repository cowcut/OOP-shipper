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
    public partial class frm_DangKy : Form
    {
        public frm_DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void LoaiTK_cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DangKy_btn_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (SqlConnection connection = Sqlketnoi.GetConnection())
                {
                    
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;

                    if (LoaiTK_cbbox.Text == "Shipper")
                    {

                        string csdl = "insert into Shipper(MaSP, TaiKhoanSP, MatKhauSP) values(@MaSP, @TaiKhoanSP, @MatKhauSP)";
                        string MaSP = TaoMaMoi("SP");
                        command.Parameters.AddWithValue("@MaSP", MaSP);
                        command.Parameters.AddWithValue("@TaiKhoanSP", DangKyTK_txt.Text);
                        command.Parameters.AddWithValue("@MatKhauSP", DangKyMK_txt.Text);
                        command.Connection = connection;
                        command.CommandText = csdl;
                    }
                    else if (LoaiTK_cbbox.Text == "KhachHang")
                    {
                        string csdl = "insert into KhachHang(MaKH, TaiKhoanKH, MatKhauKH) values(@MaKH, @TaiKhoanKH, @MatKhauKH)";
                        string MaKH = TaoMaMoi("KH");
                        command.Parameters.AddWithValue("@MaKH", MaKH);
                        command.Parameters.AddWithValue("@TaiKhoanKH", DangKyTK_txt.Text);
                        command.Parameters.AddWithValue("@MatKhauKH", DangKyMK_txt.Text);
                        command.Connection = connection;
                        command.CommandText = csdl;
                    }
          
                    else
                    {
                        MessageBox.Show("Vui lòng chọn loại tài khoản");
                    }

                    int result = command.ExecuteNonQuery();
                     if (result > 0)
                    {
                        MessageBox.Show("Đăng ký tài khoản thàng công!");
                    }
                    else
                    {
                   
                        MessageBox.Show("Đăng ký tài khoản thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }           
        }
        private string TaoMaMoi(string prefix)
        {
            string newCode = "";
            using (SqlConnection connection = Sqlketnoi.GetConnection())
            {
                connection.Open();

                bool trungma = true;
                while (trungma)
                {
                    Random random = new Random();
                    string randomString = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 4)
                                                     .Select(s => s[random.Next(s.Length)]).ToArray());
                    newCode = prefix + randomString;
                    string query = "";
                    if (prefix == "SP")
                    {
                        query = "SELECT COUNT(*) FROM Shipper WHERE MaSP = @MaSP";

                    }
                    else if (prefix == "KH")
                    {
                        query = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
                    }
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaSP", newCode);
                    command.Parameters.AddWithValue("@MaKH", newCode);
                    int count = (int)command.ExecuteScalar();
                    trungma = (count > 0);
                }

                return newCode;
            }
        }




        private void QuayLai_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_HeyYou frmDN = new frm_HeyYou();
            frmDN.Show();
        }
    }
}
