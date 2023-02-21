using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Asil_Pansiyon_Uygulaması
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        //sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "101";
            SqlCommand komut = new SqlCommand("insert into Oda101(Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "102";
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "103";
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "104";
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "105";
            SqlCommand komut = new SqlCommand("insert into Oda105(Adi,Soyadi)values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "106";
            SqlCommand komut = new SqlCommand("insert into Oda106(Adi,Soyadi)values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "107";
            SqlCommand komut = new SqlCommand("insert into Oda107(Adi,Soyadi) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "108";
            SqlCommand komut = new SqlCommand("insert into Oda108(Adi,Soyadi)values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "109";
            SqlCommand komut = new SqlCommand("insert into Oda109(Adi,Soyadi)values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli odalar boştur.");
        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli odalar doludur.");
        }

        private void DtpCıkıs_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCıkıs.Text);

            TimeSpan Sonuc = BuyukTarih - KucukTarih;
            label11.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label11.Text) * 50;
            TxtUcret.Text = Ucret.ToString();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into KullaniciEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)values('" + TxtAd.Text + "','" + TxtSoyad.Text + "','" + CmbxCinsiyet.Text + "','" + MsktxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtTC.Text + "','" + TxtOdaNumarası.Text + "','" + TxtUcret.Text + "','" + DtpGiris.Value.ToString("yyyy-MM-dd") + "','" + DtpCıkıs.Value.ToString("yyyy-MM-dd") + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            //oda101
            SqlCommand komut1 = new SqlCommand("select * from Oda101", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                BtnOda101.Text = dr1["Adi"].ToString() + " " + dr1["Soyadi"].ToString();

            }
            bgl.baglanti().Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled=false;
            }
            //oda102
            SqlCommand komut2 = new SqlCommand("select * from Oda102", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                BtnOda102.Text = dr2["Adi"].ToString() + " " + dr2["Soyadi"].ToString();

            }
            bgl.baglanti().Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }

            //oda103
            SqlCommand komut3 = new SqlCommand("select * from Oda103", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                BtnOda103.Text = dr3["Adi"].ToString() + " " + dr3["Soyadi"].ToString();

            }
            bgl.baglanti().Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }

            //Oda104
            SqlCommand komut4 = new SqlCommand("select * from Oda104", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                BtnOda104.Text = dr4["Adi"].ToString() + " " + dr4["Soyadi"].ToString();

            }
            bgl.baglanti().Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }
            //oda105
            SqlCommand komut5 = new SqlCommand("select * from Oda105", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                BtnOda105.Text = dr5["Adi"].ToString() + " " + dr5["Soyadi"].ToString();

            }
            bgl.baglanti().Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }

            //oda106
            SqlCommand komut6 = new SqlCommand("select * from Oda106", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                BtnOda106.Text = dr6["Adi"].ToString() + " " + dr6["Soyadi"].ToString();

            }
            bgl.baglanti().Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }
            //oda107
            SqlCommand komut7 = new SqlCommand("select * from Oda107", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                BtnOda107.Text = dr7["Adi"].ToString() + " " + dr7["Soyadi"].ToString();

            }
            bgl.baglanti().Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }
            //oda108
            SqlCommand komut8 = new SqlCommand("select * from Oda108", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                BtnOda108.Text = dr8["Adi"].ToString() + " " + dr8["Soyadi"].ToString();

            }
            bgl.baglanti().Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }
            //oda109 
            SqlCommand komut9 = new SqlCommand("select * from Oda109", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                BtnOda109.Text = dr9["Adi"].ToString() + " " + dr9["Soyadi"].ToString();

            }
            bgl.baglanti().Close();
            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }
        }
    }
}
