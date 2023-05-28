using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainMenu.Forms
{
    public partial class FormQLShipper : Form
    {
        public FormQLShipper()
        {
            InitializeComponent();
        }
        void TextClear()
        {
            foreach(var pnl in PnlAdd.Controls.OfType<Panel>())
            {
               pnl.BackColor = Color.Gainsboro;
                foreach (var txt in pnl.Controls.OfType<TextBox>())
                {
                    txt.Text = string.Empty;
                }
            }
            radioButton1.Checked = radioButton2.Checked = false;
            cbbTinhTrang.SelectedIndex = 0;
        }

        private void rjPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void rjPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjLogin1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void DGVShipper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PnlAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

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

        private void txtTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            PnlTaiKhoan.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
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

        private void cbbTinhTrang_MouseDown(object sender, MouseEventArgs e)
        {
            PnlTinhTrang.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void cbbTinhTrang_Leave(object sender, EventArgs e)
        {
            PnlTinhTrang.BackColor = Color.Gainsboro;
        }

        private void radioButton2_MouseDown(object sender, MouseEventArgs e)
        {
            PnlGioiTinh.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void radioButton2_Leave(object sender, EventArgs e)
        {
            PnlGioiTinh.BackColor = Color.Gainsboro;
        }

        private void radioButton1_MouseDown(object sender, MouseEventArgs e)
        {
            PnlGioiTinh.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void radioButton1_Leave(object sender, EventArgs e)
        {
            PnlGioiTinh.BackColor = Color.Gainsboro;
        }

        private void rjLogin6_Click(object sender, EventArgs e)
        {
            PnlAdd.BackColor = Color.Gainsboro;
            foreach (var pnl in PnlAdd.Controls.OfType<Panel>())
            {
                
                foreach (var txt in pnl.Controls.OfType<TextBox>())
                {
                    if (txt.Text == string.Empty)
                    {
                        pnl.BackColor = Color.FromArgb(123, 104, 238);
                    }
                    txt.Text = string.Empty;
                }
            }
            if (radioButton1.Checked == false & radioButton2.Checked == false)
                PnlGioiTinh.BackColor = Color.FromArgb(123, 104, 238);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TextClear();
            DGVShipper.Height = 0;
            lblTitle.Text = "Bổ Sung Shipper";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TextClear();
            DGVShipper.Height = 0;
            lblTitle.Text = "Chỉnh Sửa Shipper";
            if (DGVShipper.CurrentRow != null)
            {
                txtTenSP.Text = DGVShipper.Rows[0].Cells[1].ToString();
                txtCCCD.Text = DGVShipper.Rows[0].Cells[2].ToString();
                txtSDT.Text = DGVShipper.Rows[0].Cells[3].ToString();
                txtTaiKhoan.Text = DGVShipper.Rows[0].Cells[4].ToString();
                txtDiaChi.Text = DGVShipper.Rows[0].Cells[5].ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DGVShipper.Height = 467;
        }

        private void FormQLShipper_Load(object sender, EventArgs e)
        {
            
            DGVShipper.Rows.Add(new object[] { "100", "James", "0262030001", "10000000", "058658451", "Ha Noi", "Nam", "Dang Hoat Dong" });
            DGVShipper.Rows.Add(new object[] { "100", "James", "0262030001", "10000000", "058658451", "Ha Noi", "Nam", "Dang Hoat Dong" });
            DGVShipper.Rows.Add(new object[] { "100", "James", "0262030001", "10000000", "058658451", "Ha Noi", "Nam", "Dang Hoat Dong" });
            DGVShipper.Rows.Add(new object[] { "100", "James", "0262030001", "10000000", "058658451", "Ha Noi", "Nam", "Dang Hoat Dong" });
            DGVShipper.Rows.Add(new object[] { "100", "James", "0262030001", "10000000", "058658451", "Ha Noi", "Nam", "Dang Hoat Dong" });
            DGVShipper.Rows.Add(new object[] { "100", "James", "0262030001", "10000000", "058658451", "Ha Noi", "Nam", "Dang Hoat Dong" });
        }
    }
}
