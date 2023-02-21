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
    public partial class FrmSifreGuncelleme : Form
    {
        public FrmSifreGuncelleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update KullaniciGiris set Kullanici ='" + TxtKullaniciAdi.Text + "',Sifre='" + TxtSifre.Text +  "'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            
        }
    }
}
