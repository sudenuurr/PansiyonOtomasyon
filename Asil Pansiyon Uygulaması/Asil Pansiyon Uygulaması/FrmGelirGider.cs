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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {

            int personel = Convert.ToInt16(TxtPersonelSayisi.Text);
            LblPersonelMaaslari.Text = (personel * 5500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblToplamTutar.Text)-(Convert.ToInt32(LblPersonelMaaslari.Text)+Convert.ToInt32(LblUrunlerinTutari1.Text)+Convert.ToInt32(LblUrunlerinTutari2.Text)+Convert.ToInt32(LblUrunlerinTutari3.Text)+Convert.ToInt32(LblFaturalar1.Text)+Convert.ToInt32(LblFaturalar2.Text)+Convert.ToInt32(LblFaturalar3.Text));
            LblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            SqlCommand komut = new SqlCommand("select sum (Ucret) as toplam from KullaniciEKle", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamTutar.Text = dr["toplam"].ToString();
            }
            bgl.baglanti().Close();
            // gıda giderleri
            SqlCommand komut2 = new SqlCommand("select sum (Gida) as toplam1 from Stoklar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblUrunlerinTutari1.Text = dr2["toplam1"].ToString();
            }
            bgl.baglanti().Close();

            //içecek giderleri
            SqlCommand komut3 = new SqlCommand("select sum (İcecek) as toplam2 from Stoklar", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblUrunlerinTutari2.Text = dr3["toplam2"].ToString();
            }
            bgl.baglanti().Close();

            //Çerez Giderleri
            SqlCommand komut4 = new SqlCommand("select sum (Cerezler) as toplam3 from Stoklar", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblUrunlerinTutari3.Text = dr4["toplam3"].ToString();
            }
            bgl.baglanti().Close();

            //Elektrik Giderleri
            SqlCommand komut5 = new SqlCommand("select sum (Elektrik) as toplam4 from Faturalar", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblFaturalar1.Text = dr5["toplam4"].ToString();
            }
            bgl.baglanti().Close();

            //Su Giderleri
            SqlCommand komut6 = new SqlCommand("select sum (Su) as toplam5 from Faturalar", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblFaturalar2.Text = dr6["toplam5"].ToString();
            }
            bgl.baglanti().Close();

            //İnternet Giderleri
            SqlCommand komut7 = new SqlCommand("select sum (İnternet) as toplam6 from Faturalar", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                LblFaturalar3.Text = dr7["toplam6"].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
