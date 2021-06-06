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

namespace Latihan_Soal_VBNET
{
    public partial class frmTamu : Form
    {
        SqlConnection con = koneksi.getDBConnection();
        public frmTamu()
        {
            InitializeComponent();
        }

        private void frmTamu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNIS.Text == "")
            {
                MessageBox.Show("NIS belum benar!!!");
            }   
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from tb_student where nis = @nis", con);
                    cmd.Parameters.AddWithValue("@nis", txtNIS.Text);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil!!!");
                    frmPeminjaman frm1 = new frmPeminjaman();
                    frm1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdminLogin frm1 = new frmAdminLogin();
            frm1.Show();
        }
    }
}
