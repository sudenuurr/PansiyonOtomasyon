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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Asil_Pansiyon_Uygulaması
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void verilerigoster()
        {
            listView1.Items.Clear();

            SqlCommand komut = new SqlCommand("select * from KullaniciEkle ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Kullaniciid"].ToString();
                ekle.SubItems.Add(dr["Adi"].ToString());
                ekle.SubItems.Add(dr["Soyadi"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Mail"].ToString());
                ekle.SubItems.Add(dr["TC"].ToString());
                ekle.SubItems.Add(dr["OdaNo"].ToString());
                ekle.SubItems.Add(dr["Ucret"].ToString());
                ekle.SubItems.Add(dr["GirisTarihi"].ToString());
                ekle.SubItems.Add(dr["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        int id = 0;

        private void listView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CmbxCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MsktxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNumarası.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCıkıs.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(TxtOdaNumarası.Text=="101")
            {
                SqlCommand komut = new SqlCommand("delete from Oda101 ", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilerigoster();
            }
            if (TxtOdaNumarası.Text == "102")
            {
                SqlCommand komut = new SqlCommand("delete from Oda102 ", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilerigoster();
            }
            if (TxtOdaNumarası.Text == "103")
            {
                SqlCommand komut = new SqlCommand("delete from Oda103 ", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilerigoster();

            }
            if (TxtOdaNumarası.Text == "104")
            {
                SqlCommand komut = new SqlCommand("delete from Oda104 ", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilerigoster();
            }
            if (TxtOdaNumarası.Text == "105")
            {
                SqlCommand komut = new SqlCommand("delete from Oda105 ", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilerigoster();
            }
            if (TxtOdaNumarası.Text == "106")
            {
                SqlCommand komut = new SqlCommand("delete from Oda106", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilerigoster();
            }
            if (TxtOdaNumarası.Text == "107")
            {
                SqlCommand komut = new SqlCommand("delete from Oda107 ", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilerigoster();
            }
            if (TxtOdaNumarası.Text == "108")
            {
                SqlCommand komut = new SqlCommand("delete from Oda108 ", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilerigoster();
            }
            if (TxtOdaNumarası.Text == "109")
            {
                SqlCommand komut = new SqlCommand("delete from Oda109 ", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilerigoster();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtSoyad.Clear();
            CmbxCinsiyet.Text = "";
            MsktxtTelefon.Clear();
            TxtMail.Clear();
            TxtTC.Clear();
            TxtOdaNumarası.Clear();
            TxtUcret.Clear();
            DtpGiris.Text = "";
            DtpCıkıs.Text = "";

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update KullaniciEkle set Adi ='"+TxtAd.Text+"',Soyadi='"+TxtSoyad.Text+"',Cinsiyet='"+CmbxCinsiyet.Text+"',Telefon='"+MsktxtTelefon.Text +"',Mail='"+TxtMail.Text +"',TC='"+TxtTC.Text+"',OdaNo='"+TxtOdaNumarası.Text+"',Ucret='"+TxtUcret.Text+"',GirişTarihi='"+DtpGiris.Value.ToString("yyyy-MM-dd")+"',CikisTarihi='"+DtpCıkıs.Value.ToString("yyyy-MM-dd")+"' where Kullaniciid="+id+"",bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            verilerigoster();

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();

            SqlCommand komut = new SqlCommand("select * from KullaniciEkle Where Adi like '%"+TxtIsim.Text+ "%'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Kullaniciid"].ToString();
                ekle.SubItems.Add(dr["Adi"].ToString());
                ekle.SubItems.Add(dr["Soyadi"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Mail"].ToString());
                ekle.SubItems.Add(dr["TC"].ToString());
                ekle.SubItems.Add(dr["OdaNo"].ToString());
                ekle.SubItems.Add(dr["Ucret"].ToString());
                ekle.SubItems.Add(dr["GirisTarihi"].ToString());
                ekle.SubItems.Add(dr["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            bgl.baglanti().Close();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }
    }
}

