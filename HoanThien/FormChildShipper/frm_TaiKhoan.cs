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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HoanThien.FormChildShipper
{
    public partial class frm_TaiKhoan : Form
    {
        public frm_TaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_nhandon_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {

            /*
            string storedProcedureCodeString = Properties.Settings.Default.BienLuuTruMa;
            if (!string.IsNullOrEmpty(storedProcedureCodeString))
            {
                // Sử dụng mã stored procedure ở đây
                // Kết nối tới SQL Server
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
                string sqlQuery = "SELECT * FROM Shipper WHERE MaSP=@MaSP";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();

                // Thực hiện truy vấn để lấy dữ liệu từ SQL Server
                SqlDataReader reader = command.ExecuteReader();

                // Đọc dữ liệu từ SqlDataReader và gán vào TextBox
                if (reader.HasRows)
                {
                    string myData = reader.GetString(0);
                    Ten_tb.Text = myData;
                }

                // Đóng kết nối và giải phóng tài nguyên
                reader.Close();
                connection.Close();
            }
            */
        }
    }
}
