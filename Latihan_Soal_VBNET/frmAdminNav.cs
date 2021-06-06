using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_Soal_VBNET
{
    public partial class frmAdminNav : Form
    {
        public frmAdminNav()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPeminjaman frm1 = new frmPeminjaman();
            this.Hide();
            frm1.Show();
        }
    }
}
