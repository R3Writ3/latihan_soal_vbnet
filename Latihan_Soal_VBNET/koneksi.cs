using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Soal_VBNET
{
    class koneksi
    {
        public static SqlConnection getDBConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=latihan_lks;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
