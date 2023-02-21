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
   
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl= new sqlbaglantisi();
        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //oda101
            SqlCommand komut1 = new SqlCommand("select * from Oda101", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                BtnOda101.Text= dr1["Adi"].ToString() +" "+ dr1["Soyadi"].ToString();

            }
            bgl.baglanti().Close();
            if (BtnOda101.Text!="101")
            {
                BtnOda101.BackColor=Color.Red;
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
            }
        }
    }
}
