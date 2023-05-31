using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShipper.formshipper.Forms
{
    public partial class frm_VanChuyen : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        frm_DonHang DH = new frm_DonHang();
        public frm_VanChuyen()
        {
            InitializeComponent();
            
        }

        private void frm_VanChuyen_Resize(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frm_QuanLyKhoaHoc")
                {
                    f.Height = DonHangDaNhan_dgv.Height;
                    f.Width = DonHangDaNhan_dgv.Width;
                }
            }
           
        }


        private void frm_VanChuyen_Load(object sender, EventArgs e)
        {
           
        }
            private List<object[]> _selectedRows;
        public void frm_VanChuyen_Don(List<object[]> selectedRows)
        {
            // Loop qua tất cả các cột của DataGridView1 và sao chép vào DataGridView2
            
            InitializeComponent();

            _selectedRows = selectedRows;

            foreach (object[] row in selectedRows)
            {
                DonHangDaNhan_dgv.Rows.Add(row);
            }

        }
    }
}


