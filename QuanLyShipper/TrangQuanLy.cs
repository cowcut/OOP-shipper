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
    public partial class frm_TrangQuanLy : Form
    {
        public frm_TrangQuanLy()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLySP QLSP = new frm_QuanLySP();
            QLSP.TopLevel = false;
            QLSP.AutoScroll = true;
            QuanLy_pnl.Controls.Clear();
            QuanLy_pnl.Controls.Add(QLSP);
            QLSP.Show();
            QLSP.Height = QuanLy_pnl.Height;
            QLSP.Width = QuanLy_pnl.Width;
        }
        private void thốngKêĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyDH QLDH = new frm_QuanLyDH();
            QLDH.TopLevel = false;
            QLDH.AutoScroll = true;
            QuanLy_pnl.Controls.Clear();
            QuanLy_pnl.Controls.Add(QLDH);
            QLDH.Show();
            QLDH.Height = QuanLy_pnl.Height;
            QLDH.Width = QuanLy_pnl.Width;
        }
        private void QuanLy_pnl_Resize(object sender, EventArgs e)
        {
            FormCollection fcSP = Application.OpenForms;
            foreach (Form QLSP in fcSP)
            {
                if (QLSP.Name == "frm_QuanLySP")
                {
                    QLSP.Height = QuanLy_pnl.Height;
                    QLSP.Width = QuanLy_pnl.Width;
                }
            }
            FormCollection fcDH = Application.OpenForms;
            foreach (Form QLDH in fcDH)
            {
                if (QLDH.Name == "frm_QuanLyDH")
                {
                    QLDH.Height = QuanLy_pnl.Height;
                    QLDH.Width = QuanLy_pnl.Width;
                }
            }
        }
    }
}
