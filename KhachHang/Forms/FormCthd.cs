using KhachHang.DAO;
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

namespace KhachHang
{
    public partial class FormCthd : Form
    {


        public FormCthd()
        {
            InitializeComponent();

            LoadLsdh();
        } 

         void LoadLsdh()
         {
             string query = "SELECT * FROM dbo.DonHang";
             DataProvider provider = new DataProvider();
             dgvdonhang.DataSource = provider.ExecuteQuery(query);
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

        }

        private void rjPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
