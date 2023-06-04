//using HoanThien.DAO;
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
using System.Windows.Markup;

namespace HoanThien.FormChildCustomer
{
   public partial class FormCthd : Form
    {


        public FormCthd()
        {
            InitializeComponent();

            LoadLsdh();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        } 

         void LoadLsdh()
         {
             string query = "SELECT * FROM dbo.DonHang";
             DataProvider provider = new DataProvider();
             dataGridView1.DataSource = provider.ExecuteQuery(query);
         } 

        private void btnToday_Click(object sender, EventArgs e)
        {
            
        }
        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            
        }
        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            
        }
        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            
        }
        private void btnCustomDate_Click(object sender, EventArgs e)
        {
           
        }

       /* void LoadHDByDate(DateTime Dayin, DateTime Dayout )
        {
            dgvdonhang.DataSource = CthdDAO.Instance.GetHdByDate(Dayin, Dayout);
        } */
        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            // LoadHDByDate(dtpStartDate.Value, dtpEndDate.Value);
   
        }


        private void FormCthd_Load(object sender, EventArgs e)
        {

        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            TxtMaDon.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            TxtTenHang.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            TxtLoaiHang.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            TxtGiaTri.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            TxtMaSP.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            TxtDiaChiNhanHang.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            ThoiDiemNhanHang.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void rjPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
