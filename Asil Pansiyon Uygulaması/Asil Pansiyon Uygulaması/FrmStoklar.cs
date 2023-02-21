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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl= new sqlbaglantisi(); 
        private void veriler ()
        {
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand(" select * from Stoklar", bgl.baglanti());
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem(); 
                ekle.Text= dr["Gida"].ToString();
                ekle.SubItems.Add(dr["İcecek"].ToString());
                ekle.SubItems.Add(dr["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            bgl.baglanti().Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            SqlCommand komut2 = new SqlCommand(" select * from Faturalar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr2["Elektrik"].ToString();
                ekle.SubItems.Add(dr2["Su"].ToString());
                ekle.SubItems.Add(dr2["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            bgl.baglanti().Close();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Stoklar (Gida,İcecek,Cerezler) values ('" + TxtGidalar.Text + "','" + TxtIcecekler.Text + "','" + TxtCerez.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            SqlCommand komut2= new SqlCommand("insert into Faturalar (Elektrik, Su, İnternet) values ('" + TxtElektrik.Text + "','" + TxtSu.Text + "','" + Txtİnternet.Text + "')", bgl.baglanti());
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            veriler2();
        }
    }
}
