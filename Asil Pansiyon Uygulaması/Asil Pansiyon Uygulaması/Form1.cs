using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Asil_Pansiyon_Uygulaması
{
    public partial class FrmKullaniciGiris : Form
    {
        public FrmKullaniciGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e) 
        {
            try
            {
                string sql = "select * from KullaniciGiris where Kullanici=@k1 AND Sifre=@k2";
                SqlParameter prm1 = new SqlParameter("k1",TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("k2",TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, bgl.baglanti());
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FrmSifreGuncelle fr = new FrmSifreGuncelle();
                    fr.Show();
                    this.Hide();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
                
            }
            bgl.baglanti().Close();

        }
    }
}
