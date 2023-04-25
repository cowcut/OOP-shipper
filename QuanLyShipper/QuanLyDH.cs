using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShipper
{
    public partial class frm_QuanLyDH : Form
    {
        public frm_QuanLyDH()
        {
            InitializeComponent();
        }

        private void TenDH_lbl_Click(object sender, EventArgs e)
        {

        }

        private void frm_QuanLyDH_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var dsDH = db.DonHangs;
            BangDonHang_dgv.DataSource = dsDH;
        }
    }
}
