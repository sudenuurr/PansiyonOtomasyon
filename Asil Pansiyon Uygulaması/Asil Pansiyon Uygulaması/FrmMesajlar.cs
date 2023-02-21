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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void verilerigoster()
        {
            listView1.Items.Clear();

            SqlCommand komut = new SqlCommand("select * from Mesajlar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Mesajid"].ToString();
                ekle.SubItems.Add(dr["AdSoyad"].ToString());
                ekle.SubItems.Add(dr["Mesaj"].ToString());


                listView1.Items.Add(ekle);
            }
            bgl.baglanti().Close();


        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Mesajlar (AdSoyad,Mesaj) values('" + TxtAdSoyad.Text + "','" + richTextBox1.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            verilerigoster();
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_Click(object sender, EventArgs e)
        {
            id= int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdSoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
