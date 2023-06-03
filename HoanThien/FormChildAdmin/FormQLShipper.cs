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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HoanThien.Forms
{
    public partial class FormQLShipper : Form
    {
        private bool isEditMode = false; // Biến đánh dấu chế độ chỉnh sửa
        private int selectedRowIndex = -1; // Chỉ số hàng được chọn trong DataGridView

        public FormQLShipper()
        {
            InitializeComponent();
        }

        // Xóa dữ liệu và reset giao diện
        private void TextClear()
        {
            foreach (var pnl in PnlAdd.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Gainsboro;
                foreach (var txt in pnl.Controls.OfType<TextBox>())
                {
                    txt.Text = string.Empty;
                }
            }
        }
        private string connectionString = "data source=.;initial catalog=Demo;integrated security=True";

        private void txtTenSP_MouseClick(object sender, MouseEventArgs e)
        {
            PnlTenSP.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void txtTenSP_Leave(object sender, EventArgs e)
        {
            PnlTenSP.BackColor = Color.Gainsboro;
        }

        private void txtCCCD_MouseClick(object sender, MouseEventArgs e)
        {
            PnlCCCD.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            PnlCCCD.BackColor = Color.Gainsboro;
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            PnlTaiKhoan.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            PnlTaiKhoan.BackColor = Color.Gainsboro;
        }

        private void txtSDT_MouseClick(object sender, MouseEventArgs e)
        {
            PnlSDT.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            PnlSDT.BackColor = Color.Gainsboro;
        }

        private void txtDiaChi_MouseClick(object sender, MouseEventArgs e)
        {
            PnlDiaChi.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            PnlDiaChi.BackColor = Color.Gainsboro;
        }
        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Gainsboro;
        }
        private void txtMatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Gainsboro;
        }

        //Phương thức tìm kiếm dữ liệu
        void SearchData(string keyword)
        {
            // Thực hiện tìm kiếm dựa trên keyword
            // Ví dụ:
            // string query = "SELECT * FROM Shipper WHERE TenSP LIKE '%" + keyword + "%'";
            // ExecuteQuery(query);

            // Sau khi thực hiện tìm kiếm, cập nhật dữ liệu vào DataGridView
            // Ví dụ:
            // DGVShipper.DataSource = GetSearchResults(query);
        }
        private void txtTimKiem_CLick(object sender, EventArgs e)
        {

        }
        // Sự kiện Click của Button tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            SearchData(keyword);
        }
        

        private void btnLuu_Click(object sender, EventArgs e)
        {

            foreach (var pnl in PnlAdd.Controls.OfType<Panel>())
            {
                foreach (var txt in pnl.Controls.OfType<TextBox>())
                {
                    if (txt.Text == string.Empty)
                    {
                        pnl.BackColor = Color.FromArgb(123, 104, 238);
                    }
                }
            }

            if (isEditMode)
            {
                // Thực hiện lưu thông tin chỉnh sửa
                if (selectedRowIndex >= 0 && selectedRowIndex < DGVShipper.Rows.Count)
                {
                    if (selectedRowIndex >= 0 && selectedRowIndex < DGVShipper.Rows.Count)
                    {
                        DGVShipper.Rows[selectedRowIndex].Cells[1].Value = txtTenSP.Text;
                        DGVShipper.Rows[selectedRowIndex].Cells[2].Value = txtCCCD.Text;
                        DGVShipper.Rows[selectedRowIndex].Cells[3].Value = txtSDT.Text;
                        DGVShipper.Rows[selectedRowIndex].Cells[4].Value = txtEmail.Text;
                        DGVShipper.Rows[selectedRowIndex].Cells[5].Value = txtDiaChi.Text;
                        DGVShipper.Rows[selectedRowIndex].Cells[6].Value = txtUsername.Text;
                        DGVShipper.Rows[selectedRowIndex].Cells[7].Value = txtMatKhau.Text;
                    }
                }
            }
            else
            {
                // Thực hiện lưu thông tin mới
                DGVShipper.Rows.Add(new object[]
                {
                    DGVShipper.Rows.Count + 1,
                    txtTenSP.Text,
                    txtCCCD.Text,
                    txtSDT.Text,
                    txtEmail.Text,
                    txtDiaChi.Text,
                    txtUsername.Text,
                    txtMatKhau.Text

                });
            }

            TextClear();
            DGVShipper.Height = 467;
            lblTitle.Text = "Quản Lý Shipper";
            isEditMode = false;
            selectedRowIndex = -1;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            TextClear();
            DGVShipper.Height = 467;
            lblTitle.Text = "Quản Lý Shipper";
            isEditMode = false;
            selectedRowIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TextClear();
            DGVShipper.Height = 0;
            lblTitle.Text = "Bổ Sung Shipper";
            isEditMode = false;
            selectedRowIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DGVShipper.CurrentRow != null)
            {
                TextClear();
                DGVShipper.Height = 0;
                lblTitle.Text = "Chỉnh Sửa Shipper";
                selectedRowIndex = DGVShipper.CurrentRow.Index;

                // Đổ dữ liệu vào các TextBox và các controls khác
                txtTenSP.Text = DGVShipper.CurrentRow.Cells[1].Value.ToString();
                txtCCCD.Text = DGVShipper.CurrentRow.Cells[2].Value.ToString();
                txtSDT.Text = DGVShipper.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = DGVShipper.CurrentRow.Cells[4].Value.ToString();
                txtDiaChi.Text = DGVShipper.CurrentRow.Cells[5].Value.ToString();
                txtUsername.Text = DGVShipper.CurrentRow.Cells[6].Value.ToString();
                txtMatKhau.Text = DGVShipper.CurrentRow.Cells[7].Value.ToString();

                isEditMode = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DGVShipper.CurrentRow != null)
            {
                DGVShipper.Rows.Remove(DGVShipper.CurrentRow);
                TextClear();
                DGVShipper.Height = 467;
                lblTitle.Text = "Quản Lý Shipper";
                isEditMode = false;
                selectedRowIndex = -1;
            }
        }

        // Load dữ liệu mẫu
        private void FormQLShipper_Load(object sender, EventArgs e)
        {
        // Load dữ liệu từ cơ sở dữ liệu vào DataGridView khi Form được tải
    }
    }
}
