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

namespace HoanThien.FormChildShipper
{
    public partial class frm_DonHang : Form
    {
        public frm_DonHang()
        {
            InitializeComponent();

        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjLogin2_Click(object sender, EventArgs e)
        {

        }

        private void frm_DonHang_Load(object sender, EventArgs e)
        {
            /*
            var dskh = db.DonHangs;
            DanhSachDonHang_dgv.DataSource = dskh;
            DanhSachDonHang_dgv.Columns["ThoiDiemNhan"].Visible = false;
            DanhSachDonHang_dgv.Columns["ThoiDiemNhanHang"].Visible = false;
            DanhSachDonHang_dgv.Columns["ThoiDiemNhan"].Visible = false;
            DanhSachDonHang_dgv.Columns["TinhTrangDon"].Visible = false;
            DanhSachDonHang_dgv.Columns["MaSP"].Visible = false;
            DanhSachDonHang_dgv.Columns["MaKH"].Visible = false;
            DanhSachDonHang_dgv.Columns["MaQL"].Visible = false;
            DanhSachDonHang_dgv.Columns["KhachHang"].Visible = false;
            DanhSachDonHang_dgv.Columns["QuanLy"].Visible = false;
            DanhSachDonHang_dgv.Columns["Shipper"].Visible = false;

            CurrencyManager cm = (CurrencyManager)DanhSachDonHang_dgv.BindingContext[DanhSachDonHang_dgv.DataSource];
            int currentRowIndex = cm.Position; //Lưu lại vị trí hàng đang được chọn

            foreach (DataGridViewRow row in DanhSachDonHang_dgv.Rows)
            {
                if (row.Cells["MaSP"].Value == null || row.Cells["MaSP"].Value.ToString().Trim().Length == 0)
                {
                    if (row.Index != currentRowIndex) //Kiểm tra nếu không phải hàng đang được chọn thì mới ẩn
                    {
                        row.Visible = true;
                    }
                }
                else
                {
                    row.Visible = false;
                }
            }

            //Đặt lại vị trí hàng đang được chọn cho CurrencyManager
            cm.Position = currentRowIndex;
        }
        private void frm_DonHang_Resize(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frm_QuanLyKhoaHoc")
                {
                    f.Height = DanhSachDonHang_dgv.Height;
                    f.Width = DanhSachDonHang_dgv.Width;
                }
            }
            */

        }

        private void DanhSachDonHang_dgv_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void rjLogin1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=laptop-dfsf0mk1\\sqlexpress;Initial Catalog=QuanLyShipper;Integrated Security=True"; //Chuỗi kết nối đến cơ sở dữ liệu
            string query = "SELECT MaSP FROM Shipper WHERE MaSP = @MaSP"; //Truy vấn để lấy mã dựa trên tên sản phẩm
                                                                          // Kiểm tra xem DataGridView có hàng được chọn hay không
            if (DanhSachDonHang_dgv.SelectedRows.Count > 0)
            {

                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Với mỗi hàng được chọn trong DataGridView, thực hiện truy vấn để lấy mã sản phẩm
                    foreach (DataGridViewRow row in DanhSachDonHang_dgv.SelectedRows)
                    {
                        string MaSP = row.Cells["MaSP"].Value.ToString();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MaSP", MaSP);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string maSP = reader.GetString(0);
                            row.Cells["MaSP"].Value = maSP; // Gán mã sản phẩm vào cột "Mã sản phẩm" trong DataGridView
                        }
                        reader.Close(); // Đóng DataReader
                    }
                }
            }
        }

    }
}
