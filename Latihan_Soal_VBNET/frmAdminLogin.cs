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
    public partial class frmAdminLogin : Form
    {
        SqlConnection con = koneksi.getDBConnection();
        int number = 0;
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        public void isidatacaptcha()
        {
            Random r1 = new Random();
            number = r1.Next(1000, 10000);
            var img = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(img);
            graphics.DrawString(number.ToString(), font, Brushes.Gray, new Point(0, 0));
            pictureBox1.Image = img;
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {
            isidatacaptcha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Mohon dilengkapi!!!");
            }
            else if(txtCaptcha.Text != number.ToString())
            {
                MessageBox.Show("Mohon captcha diisi!!!");
                isidatacaptcha();
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from tb_admin where email = @email and password = @password", con);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    MessageBox.Show("Berhasil!!!");
                    frmAdminNav frm1 = new frmAdminNav();
                    frm1.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            isidatacaptcha();
        }
    }
}
