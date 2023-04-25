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
    public partial class frm_QuanLySP : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public frm_QuanLySP()
        {
            InitializeComponent();
        }

        private void frm_QuanLySP_Load(object sender, EventArgs e)
        {
            var dsSP = db.Shippers;
            BangSP_dgv.DataSource = dsSP;
        }

        private void ThemSP_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Shipper newObj = new Shipper();
                newObj.TenSP = TenSP_txt.Text;
                newObj.SDTSP = SDTsp_txt.Text;
                newObj.CCCD = CMT_txt.Text;
                newObj.DiaChi = DiaChi_txt.Text;
                newObj.TaiKhoanNganHang = TaiKhoanNH_txt.Text;
                newObj.TinhTrang = TinhTrang_txt.Text;
                db.Shippers.InsertOnSubmit(newObj);
                db.SubmitChanges();
                MessageBox.Show("Thêm Shipper thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm shipper không thành công");
            }
            TenSP_txt.Text = "";
            SDTsp_txt.Text = "";
            CMT_txt.Text = "";
            DiaChi_txt.Text = "";
            TaiKhoanNH_txt.Text = "";
            TinhTrang_txt.Text = "";
        }
    }
}
