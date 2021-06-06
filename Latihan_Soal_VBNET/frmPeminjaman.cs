using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_Soal_VBNET
{
    public partial class frmPeminjaman : Form
    {
        SqlConnection con = koneksi.getDBConnection();
        public frmPeminjaman()
        {
            InitializeComponent();
        }

        public void filename()
        {

        }

        public void isidatagrid()
        {
            SqlCommand cmd = new SqlCommand("select name, sinopsis, genre, dokumen from tb_books", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dgv1.DataSource = dt;
        }

        private void frmPeminjaman_Load(object sender, EventArgs e)
        {
            isidatagrid();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select File to be Uploaded";
            openFileDialog1.Filter = "Select File {*.pdf; *.doc}|*.pdf; *.doc";
            openFileDialog1.FilterIndex = 1;

            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if(openFileDialog1.CheckFileExists)
                    {
                        string path = Path.GetFileName(openFileDialog1.FileName);
                        txtFile.Text = path;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string filename = Path.GetFileName(openFileDialog1.FileName);
            string path1 = Path.GetFullPath(openFileDialog1.FileName);
            Byte[] bytes = File.ReadAllBytes(path1);
            string file = Convert.ToBase64String(bytes);

            try
            {

                if(filename == null)
                {
                    MessageBox.Show("Isi lagi!!!");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into tb_books(name, genre, sinopsis, dokumen)values(@name, @genre, @sinopsis, '" + file + "')", con);
                    cmd.Parameters.AddWithValue("@name", txtJudul.Text);
                    cmd.Parameters.AddWithValue("@genre", comGenre.Text);
                    cmd.Parameters.AddWithValue("@sinopsis", richtxtsinopsis.Text);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    File.Copy(openFileDialog1.FileName, path + "\\Media\\" + filename);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil");
                    isidatagrid();
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string basefile = dgv1.CurrentRow.Cells["dokumen"].Value.ToString();
                string filename = dgv1.CurrentRow.Cells["name"].Value.ToString();
                
                if(filename != null)
                {
                    Byte[] ap = Convert.FromBase64String(basefile);
                    string tempName = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + ".pdf");
                    File.WriteAllBytes(tempName, ap);

                    frmPDF frm1 = new frmPDF(tempName);
                    frm1.Show();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(openFileDialog1.FileName);
            string path1 = Path.GetFullPath(openFileDialog1.FileName);
            Byte[] bytes = File.ReadAllBytes(path1);
            string file = Convert.ToBase64String(bytes);
            try
            {
                
                if (filename == null)
                {
                    MessageBox.Show("File tidak ada");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Delete from tb_books where name=@name ")
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgv1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                txtJudul.Text = dgv1.CurrentRow.Cells["name"].Value.ToString();
                comGenre.Text = dgv1.CurrentRow.Cells["genre"].Value.ToString();
                richtxtsinopsis.Text = dgv1.CurrentRow.Cells["sinopsis"].Value.ToString();
                txtFile.Text = dgv1.CurrentRow.Cells["dokumen"].Value.ToString();
            }
        }
    }
}
