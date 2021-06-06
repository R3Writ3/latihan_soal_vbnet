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
    public partial class frmPDF : Form
    {
        public frmPDF(string a)
        {
            InitializeComponent();
            axAcroPDF1.src = a;
            axAcroPDF1.LoadFile(a);
        }

        private void frmPDF_Load(object sender, EventArgs e)
        {

        }
    }
}
