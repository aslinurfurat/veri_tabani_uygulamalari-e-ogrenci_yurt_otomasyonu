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
    public partial class Odalardaki_Yataklar : Form
    {
        public Odalardaki_Yataklar()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
        SqlCommand komut;
        int odasayisi = 4;
        int yataksayisi = 3;
        int katsayisi = 3;
        public int bulundugu_kat = 0;
        public int oda_numarasi = 0;
        private void Odalardaki_Yataklar_Load(object sender, EventArgs e)
        {
            this.Text = "ODA " + oda_numarasi;
            int[] a = new int[yataksayisi];
            for (int j = 0; j < odasayisi; j++)
            {


                //YATAK BİLGİLERİNİ ÇEKTİĞİMİZ VERİTABANI SORGUMUZU YAZIYORUZ
                string sorgu = "Select yatak_numarasi from Yatak_Bilgileri where yatak_id in( Select yatak_id from Oda_Bilgileri where oda_numarasi=" + oda_numarasi + " and kat='" + bulundugu_kat + "')";

                baglanti.Open();
                komut = new SqlCommand(sorgu, baglanti);
                
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();


                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    a[Convert.ToInt32(dt.Rows[i][0]) - 1] = 1;
                }
            }
            //DOLU OLAN YATAĞIN RENGİNİ DEĞİŞTİRİYORUZ
            if (a[0] == 1)
            {
                lbl_yatak1.Text = "YATAK 1 DOLU";
                lbl_yatak1.BackColor = Color.Red;
                lbl_yatak1.ForeColor = Color.White;
               
            }
            else
            {
                lbl_yatak1.Text = "YATAK 1";
                lbl_yatak1.BackColor = Color.Purple;
                lbl_yatak1.ForeColor = Color.White;
      
            }

            if (a[1] == 1)
            {
                lbl_yatak2.Text = "YATAK 2 DOLU";
                lbl_yatak2.BackColor = Color.Red;
                lbl_yatak2.ForeColor = Color.White;
            }
            else
            {
                lbl_yatak2.Text = "YATAK 2";
                lbl_yatak2.BackColor = Color.Purple;
                lbl_yatak2.ForeColor = Color.White;
            }

            if (a[2] == 1)
            {
                lbl_yatak3.Text = "YATAK 3 DOLU";
                lbl_yatak3.BackColor = Color.Red;
                lbl_yatak3.ForeColor = Color.White;
            }
            else
            {
                lbl_yatak3.Text = "YATAK 3";
                lbl_yatak3.BackColor = Color.Purple;
                lbl_yatak3.ForeColor = Color.White;
            }
            
            
            
            
        }

        DataTable dt;
        void goster()//VERİTABANI BAĞLANTIMIZI OLUŞTURUP TABLOYU DOLDURMA İŞLEMİNİ YAPIYORUZ
        {
            SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
            dt = new DataTable();
            String sql = "Select Ogrenciler.ogr_id,Ogrenciler.tc,Ogrenciler.adi_soyadi,Ogrenciler.dogum_tarihi,Ogrenciler.dogum_yeri,Ogrenciler.kayit_tarihi,Ogrenciler.okulu,Ogrenciler.bolumu,Ogrenciler.ogr_turu,Ogrenciler.tel_no,Ogrenciler.adres , Oda_Bilgileri.oda_numarasi, Oda_Bilgileri.kat ,Yatak_Bilgileri.yatak_numarasi,Yatak_Bilgileri.fiyat FROM Ogrenciler INNER JOIN Yatak_Bilgileri ON Ogrenciler.ogr_id=Yatak_Bilgileri.ogr_id INNER JOIN Oda_Bilgileri ON Yatak_Bilgileri.yatak_id=Oda_Bilgileri.yatak_id where Ogrenciler.ogr_id = '" + ogr_id + "'";
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(dt);

            baglanti.Close();
        }
        

        int ogr_id;
        int yatak_numarasi;
        
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            PictureBox pc = (PictureBox)sender;
            //ÜZERİNE GELDİĞİMİZ YATAK RESMİNİN HANGİ ÖĞRENCİYE AİT OLDUĞUNU BİLDİREN PANELİMİZİ GÖSTERİYORUZ
            string sorgu2 = "Select ogr_id from Yatak_Bilgileri where yatak_numarasi ='"+ Convert.ToInt32(pc.Tag) + "'  and yatak_id in (Select yatak_id from Oda_Bilgileri where oda_numarasi=" + oda_numarasi + " and kat='" + bulundugu_kat + "')";
            
            
            baglanti.Open();
            komut = new SqlCommand(sorgu2, baglanti);
           
            SqlDataAdapter da2 = new SqlDataAdapter(komut);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            baglanti.Close();
            try
            {
                ogr_id = Convert.ToInt32(dt2.Rows[0][0]);

                
            }
            catch (Exception)
            {

                
            }

            goster();
            try
            {
                //YATAĞIN ÖĞRENCİYE AİT OLDUĞU PANELİ DOLDURDUĞUMUZ BİLGİLERİ BURADAN ÇEKİYORUZ
                lKisiTC.Text = dt.Rows[0][1].ToString();
                lAdiSoyadi.Text = dt.Rows[0][2].ToString();
                lKayitTarihi.Text = dt.Rows[0][5].ToString();
                IBolumu.Text = dt.Rows[0][7].ToString();
                IOgrenimTuru.Text = dt.Rows[0][8].ToString();
                IYatakUcreti.Text = dt.Rows[0][14].ToString() + " TL";
            }
            catch (Exception)
            {


            }

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            a.Show();
            this.Hide();

        }

        private void btn_odaya_dön_Click(object sender, EventArgs e)
        {
            Katlardaki_Odalar a = new Katlardaki_Odalar();
            a.Show();
            this.Hide();
        }

        private void btn_katlara_dön_Click(object sender, EventArgs e)
        {
            Odalar a = new Odalar();
            a.Show();
            this.Hide();
        }


    }
}
