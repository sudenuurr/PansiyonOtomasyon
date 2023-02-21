using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Asil_Pansiyon_Uygulaması
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-S9BLVBOD;Initial Catalog=AsilPansiyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
