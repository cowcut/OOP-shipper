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
    public partial class frm_shipper : Form
    {
        public frm_shipper()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_shipper_Load(object sender, EventArgs e)
        {

        }

        private void đToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Taikhoanshipper t = new Taikhoanshipper();
            t.ShowDialog();

        }
    }
}
