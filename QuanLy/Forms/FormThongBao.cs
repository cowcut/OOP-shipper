using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainMenu.Forms
{
    public partial class FormThongBao : Form
    {
        public FormThongBao()
        {
            InitializeComponent();
        }
        private void LayDSHang()
        {
            //khởi tạo các đối tượng SqlConnection, SqlDataAdapter, DataTable
            SqlConnection conn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            //lấy chuỗi kết nối từ file App.config
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["QLHangEntities"].ConnectionString;

            try
            {
                //mở chuỗi kết nối
                conn.Open();
                //khai báo đối tượng SqlCommand trong SqlDataAdapter
                da.SelectCommand = new SqlCommand();
                //gọi thủ tục từ SQL
                da.SelectCommand.CommandText = "SP_Retrieve_User";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //gán chuỗi kết nối
                da.SelectCommand.Connection = conn;
                //sử dụng phương thức fill để điền dữ liệu từ datatable vào SqlDataAdapter
                da.Fill(dt);
                //gán dữ liệu từ datatable vào datagridview
                DGVMatHang.DataSource = dt;
                //đóng chuỗi kết nối
                conn.Close();
                //sử dụng thuộc tính Width và HeaderText để set chiều dài và tiêu đề cho các coloumns
                DGVMatHang.Columns[0].Width = 170;
                DGVMatHang.Columns[0].HeaderText = "Mã Sản Phẩm";
                DGVMatHang.Columns[1].Width = 170;
                DGVMatHang.Columns[1].HeaderText = "Tên Sản Phẩm";
                DGVMatHang.Columns[2].Width = 170;
                DGVMatHang.Columns[2].HeaderText = "Giá Sản Phẩm";
                DGVMatHang.Columns[3].Width = 170;
                DGVMatHang.Columns[3].HeaderText = "Loại Sản Phẩm";
                DGVMatHang.Columns[4].Width = 180;
                DGVMatHang.Columns[4].HeaderText = "Địa Chỉ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            LayDSHang();
        }
        private void DGVMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DGVMatHang.Rows.Count)
            {
                DataGridViewRow row = DGVMatHang.Rows[e.RowIndex];
                txtMaSP.Text = Convert.ToString(row.Cells["MaSP"].Value);
                txtTenSP.Text = Convert.ToString(row.Cells["TenSP"].Value);
                txtGiaSP.Text = Convert.ToString(row.Cells["GiaSP"].Value);
                txtLoaiSP.Text = Convert.ToString(row.Cells["LoaiSP"].Value);
                txtDiaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
            }
        }

        public bool KiemTraThongTin()
        {

            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return false;
            }
            if (txtGiaSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaSP.Focus();
                return false;
            }
            if (txtLoaiSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập loại sản phẩm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoaiSP.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.ToLower();
            LayDSHang();
            foreach (DataGridViewRow row in DGVMatHang.Rows)
            {
                string tenSP = row.Cells["TenSP"].Value.ToString().ToLower();

                if (tenSP.Contains(keyword))
                {
                    row.Visible = true; // Hiển thị dòng nếu tìm thấy từ khóa
                }
                else
                {
                    row.Visible = false; // Ẩn dòng nếu không tìm thấy từ khóa
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["QLHangEntities"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "SP_ThemMatHang";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = txtTenSP.Text;
                    cmd.Parameters.Add("@GiaSP", SqlDbType.NVarChar).Value = txtGiaSP.Text;
                    cmd.Parameters.Add("@LoaiSP", SqlDbType.NVarChar).Value = txtLoaiSP.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;



                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LayDSHang();
                    Reset();
                    MessageBox.Show("Đã thêm mới mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
            }
            else if (KiemTraThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["QLHangEntities"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "SP_SuaMatHang";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = Convert.ToInt32(txtMaSP.Text);
                    cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = txtTenSP.Text;
                    cmd.Parameters.Add("@GiaSP", SqlDbType.NVarChar).Value = txtGiaSP.Text;
                    cmd.Parameters.Add("@LoaiSP", SqlDbType.NVarChar).Value = txtLoaiSP.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LayDSHang();
                    Reset();
                    MessageBox.Show("Đã sửa mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã mặt hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["QLHangEntities"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "SP_XoaMatHang";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = Convert.ToInt32(txtMaSP.Text);
                    cmd.Connection = conn;

                    conn.Open();

                    DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();

                    LayDSHang();
                    Reset();
                    MessageBox.Show("Đã xóa mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void Reset()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaSP.Text = "";
            txtLoaiSP.Text = "";
            txtDiaChi.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            //sử dụng DialogResult để kiểm tra kết quả trả về và hiển thị hộp thoại thông báo
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rjPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void DGVShipper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void rjPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
