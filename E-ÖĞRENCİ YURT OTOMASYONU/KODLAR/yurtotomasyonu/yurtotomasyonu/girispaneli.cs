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

namespace yurtotomasyonu
{
    public partial class girispaneli : Form
    {
        public girispaneli()
        {
            InitializeComponent();
        }
        //SQL VERİTABANI BAĞLANTISINI OLUŞTURDUK
        SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
        SqlCommand komut;
        private void btn_giris_Click(object sender, EventArgs e)
        {
            //SİSTEME GİRMEK İÇİN BİR SQL SORGUSU OLUŞTURDUK
             DataTable dt = new DataTable();
            String sql = "Select * from Yonetici where kullanici_adi = '"+ txt_kullanici_adi.Text + "' and sifre='" + txt_sifre.Text + "' ";
            //BAĞLANTIMIZI AÇTIK
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(dt);
            baglanti.Close();
            //YÖNETİCİ TABLOSUNDA OLAN KULLANICI ADI VE SİFRESİ VARSA SİSTEME GİRİŞ YAPTIRIYORUZ
            if (dt.Rows.Count != 0)
            {
                Anasayfa a = new Anasayfa();
                a.Show();
                this.Hide();
            }
            else
                MessageBox.Show("KULLANICI ADINIZI VE PAROLANIZI YANLIŞ GİRDİNİZ..!!!");
            
        }
        //OTOMASYONU DİREK KAPATMA BUTONU
        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //GİZLEDİĞİMİZ PAROLAYI GÖSTERME BUTONU
        private void girispaneli_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';
        }

        private void chc_sifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_sifre.Checked)
            {
                txt_sifre.PasswordChar = '\0';

            }
            else
            {
                txt_sifre.PasswordChar = '*';
            }
        }
    }
}
