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
    public partial class Kayit_İslemleri : Form
    {

        SqlConnection baglanti;
        SqlDataAdapter da;
        SqlCommand komut;

        public Kayit_İslemleri()
        {
            InitializeComponent();
        }



        private void Kayit_İslemleri_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
            DataTable dt = new DataTable();
            String sql = "Select Ogrenciler.ogr_id,Ogrenciler.tc,Ogrenciler.adi_soyadi,Ogrenciler.dogum_tarihi,Ogrenciler.dogum_yeri,Ogrenciler.kayit_tarihi,Ogrenciler.okulu,Ogrenciler.bolumu,Ogrenciler.ogr_turu,Ogrenciler.tel_no,Ogrenciler.adres , Oda_Bilgileri.oda_numarasi, Oda_Bilgileri.kat ,Yatak_Bilgileri.yatak_numarasi,Yatak_Bilgileri.fiyat FROM Ogrenciler INNER JOIN Yatak_Bilgileri ON Ogrenciler.ogr_id=Yatak_Bilgileri.ogr_id INNER JOIN Oda_Bilgileri ON Yatak_Bilgileri.yatak_id=Oda_Bilgileri.yatak_id ";
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            cmb_kat.Items.Clear();
            for (int i = 1; i <= katsayisi; i++)
            {
                cmb_kat.Items.Add(i);

            }
            for (int j = 1; j <= katsayisi; j++)
            {
                int doluodasayisi = 0;
                for (int i = 0; i < odasayisi; i++)
            {
                    int odanumaralari = j * 100 + i;
                string sorgu = "Select yatak_id from Oda_Bilgileri where oda_numarasi=" + odanumaralari + "" + " and kat='" + j+ "' ";

                baglanti.Open();
                komut = new SqlCommand(sorgu, baglanti);

                SqlDataAdapter da3 = new SqlDataAdapter(komut);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                baglanti.Close();
                if (dt3.Rows.Count == yataksayisi)
                {
                        doluodasayisi++;
                }
            }
                if (doluodasayisi==odasayisi)
                {
                    cmb_kat.Items.Remove(j);

                }
            }



        }

        void goster()
        {
            SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
            DataTable dt = new DataTable();
            String sql = "Select Ogrenciler.ogr_id,Ogrenciler.tc,Ogrenciler.adi_soyadi,Ogrenciler.dogum_tarihi,Ogrenciler.dogum_yeri,Ogrenciler.kayit_tarihi,Ogrenciler.okulu,Ogrenciler.bolumu,Ogrenciler.ogr_turu,Ogrenciler.tel_no,Ogrenciler.adres , Oda_Bilgileri.oda_numarasi, Oda_Bilgileri.kat ,Yatak_Bilgileri.yatak_numarasi,Yatak_Bilgileri.fiyat FROM Ogrenciler INNER JOIN Yatak_Bilgileri ON Ogrenciler.ogr_id=Yatak_Bilgileri.ogr_id INNER JOIN Oda_Bilgileri ON Yatak_Bilgileri.yatak_id=Oda_Bilgileri.yatak_id ";
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }



        private void btn_kayıt_tamamla_Click(object sender, EventArgs e)
        {
            // SQL SERVER'A BAĞLANTIMIZI OLUŞTURDUK
            SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
            string sql = "Select ogr_id from Ogrenciler where tc='" + txt_tc.Text + "'";
            baglanti.Open();
            komut = new SqlCommand(sql, baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut);
            DataTable dt2 = new DataTable();
            //ÖĞRENCİ İD'SİNİ ÇEKTİĞİMİZ SORGUYU TABLOYA DOLDURDUK
            da2.Fill(dt2);
            baglanti.Close();

            if (dt2.Rows.Count == 0)
            {
                // ÖĞRENCİLER TABLOSUNA VERİ EKLEMEK İÇİN BİR SORGU YAZDIK
                string sorgu = "INSERT INTO Ogrenciler(tc,adi_soyadi,dogum_tarihi,dogum_yeri,kayit_tarihi,okulu,bolumu,ogr_turu,tel_no,adres) VALUES (@tc,@adi_soyadi,@dogum_tarihi,@dogum_yeri,@kayit_tarihi,@okulu,@bolumu,@ogr_turu,@tel_no,@adres)";
                //SORGU İÇİN SQL KOMUT OLUŞTURDUK
                komut = new SqlCommand(sorgu, baglanti);
                //YUKARIDAKİ SORGUMUZUN İÇİNDEKİ VERİLERİ AŞAĞIDA DEĞER ATADIK
                komut.Parameters.AddWithValue("@tc", txt_tc.Text);
                komut.Parameters.AddWithValue("@adi_soyadi", txt_ogrenci_adsoyad.Text);
                komut.Parameters.AddWithValue("@dogum_tarihi", dtp_dogum_tarihi.Value);
                komut.Parameters.AddWithValue("@dogum_yeri", txt_dogum_yeri.Text);
                komut.Parameters.AddWithValue("@kayit_tarihi", dtp_kayit_tarihi.Value);
                komut.Parameters.AddWithValue("@okulu", txt_okulu.Text);
                komut.Parameters.AddWithValue("@bolumu", txt_bolumu.Text);
                komut.Parameters.AddWithValue("@ogr_turu", cmb_ogrturu.Text);
                komut.Parameters.AddWithValue("@tel_no", txt_telefon.Text);
                komut.Parameters.AddWithValue("@adres", txt_adres.Text);
                //VERİTABANIMIZA BAĞLANTI AÇTIK
                baglanti.Open();
                //ÖĞRENCİ EKLEME KOMUTUMUZU ÇALIŞTIRDIK
                komut.ExecuteNonQuery();
                baglanti.Close();

                //YATAK BİLGİLERİ TABLOSUNDA ÖĞRENCİ İD KULLANILDIĞI İÇİN ÖĞRENCİLER TABLOSUNDAN ÖĞRENCİ İD'SİNİ ÇEKTİK
                string sorgu1 = "Select ogr_id from Ogrenciler where tc='" + txt_tc.Text + "'";
                baglanti.Open();
                komut = new SqlCommand(sorgu1, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                //ÖĞRENCİ İD'SİNİ ÇEKTİĞİMİZ SORGUYU TABLOYA DOLDURDUK
                da.Fill(dt);
                baglanti.Close();
                //TABLODA BULUNAN ÖĞRENCİ İD SİNİ ÇEKTİK
                int ogrenciid = Convert.ToInt32(dt.Rows[0][0]);
                //YATAK TABLOSUNA VERİ EKLEMEK İÇİN SORGU OLUŞTURDUK
                string sorgu2 = "INSERT INTO Yatak_Bilgileri(ogr_id,fiyat,yatak_numarasi,yatak_durum) VALUES (@ogr_id,@fiyat,@yatak_numarasi,@yatak_durum)";

                komut = new SqlCommand(sorgu2, baglanti);
                komut.Parameters.AddWithValue("@ogr_id", ogrenciid + "");
                komut.Parameters.AddWithValue("@fiyat", txt_yatak_fiyat.Text);
                komut.Parameters.AddWithValue("@yatak_numarasi", cmb_yatakno.Text);
                komut.Parameters.AddWithValue("@yatak_durum", true);

                baglanti.Open();

                komut.ExecuteNonQuery();
                baglanti.Close();
                //ODA BİLGİLERİ TABLOSUNDA YATAK İD KULLANILDIĞI İÇİN YATAK TABLOSUNDAN YATAK İD'SİNİ ÇEKTİK
                string sorgu4 = "Select yatak_id from Yatak_Bilgileri where ogr_id='" + ogrenciid + "'";
                baglanti.Open();
                komut = new SqlCommand(sorgu4, baglanti);
                da = new SqlDataAdapter(komut);
                dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                int yatakid = Convert.ToInt32(dt.Rows[0][0]);
                //ODA TABLOSUNA VERİ EKLEMEK İÇİN SORGU OLUŞTURDUK
                string sorgu3 = "INSERT INTO Oda_Bilgileri(kat,oda_numarasi,yatak_id) VALUES (@kat,@oda_numarasi,@yatak_id);";

                komut = new SqlCommand(sorgu3, baglanti);

                komut.Parameters.AddWithValue("@kat", cmb_kat.Text);
                komut.Parameters.AddWithValue("@oda_numarasi", cmb_odano.Text);
                komut.Parameters.AddWithValue("@yatak_id", yatakid + "");
                baglanti.Open();

                komut.ExecuteNonQuery();
                baglanti.Close();
                goster();

            }
            else
                MessageBox.Show("Bu Kimlik Numarasına sahip öğrenci bulunmaktadır.!!");
               
            
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            a.Show();
            this.Hide();
        }

        private void cmb_odano_SelectedIndexChanged(object sender, EventArgs e)
        {
            //COMBOBOX DAN SEÇİLEN VERİLER İÇİN SQL SORGUSU YAZDIK
            cmb_yatakno.Enabled = true;
            SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
            string sorgu = "Select yatak_numarasi from Yatak_Bilgileri where yatak_id in( Select yatak_id from Oda_Bilgileri where oda_numarasi=" + cmb_odano.Text + " and kat='" + cmb_kat.Text + "')";
            
            baglanti.Open();
            komut = new SqlCommand(sorgu, baglanti);
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            cmb_yatakno.Items.Clear();
            for(int i=1; i<=yataksayisi;i++)
            {
                cmb_yatakno.Items.Add(i);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                cmb_yatakno.Items.Remove(dt.Rows[i][0]);
            }
           
            
        }
        int odasayisi = 4;
        int yataksayisi = 3;
        int katsayisi = 3;
        private void cmb_kat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //KATLAR COMBOBOX INDAN SEÇİLEN DEĞER İLE ODANUMARALARINI EKLEYEN SORGUMUZU OLUŞTURDUK
            cmb_odano.Enabled = true;
            if (cmb_kat.Text != "")
            {
                int katlar = Convert.ToInt32(cmb_kat.Text);
                //ODA NUMARALARINI KAT BİLGİSİNE GÖRE ODANO COMBOBOX A EKLEDİK
                cmb_odano.Items.Clear();
                for (int i = 0; i < odasayisi; i++)
                {
                    cmb_odano.Items.Add(katlar * 100 + i);
                }
                //HERHANGİ BİR YATAĞIN HANGİ KAT VE HANGİ ODADA BULUNDUĞUNU GÖSTEREN SQL SORGUSUNU OLUŞTURDUK 
                for (int i = 0; i < odasayisi; i++)
                {
                    int odanumaralari = katlar * 100 + i;
                    SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
                string sorgu = "Select yatak_id from Oda_Bilgileri where oda_numarasi=" + odanumaralari+""+ " and kat='" + cmb_kat.Text + "' ";

                baglanti.Open();
                komut = new SqlCommand(sorgu, baglanti);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                    //EĞER DOLU YATAK VARSA ODA NUMARASINDAN O YATAĞI DOLU OLDUĞU İÇİN SİLİYORUZ
                    if (dt.Rows.Count==yataksayisi)
                    {
                        cmb_odano.Items.Remove(odanumaralari);
                    }
                }
               
            }




        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //TABLOMUZU VERİTABANINDAN GELEN BİLGİLERLE DOLDURUYORUZ
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_ogrenci_adsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtp_dogum_tarihi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_dogum_yeri.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtp_kayit_tarihi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_okulu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_bolumu.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmb_ogrturu.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_telefon.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txt_adres.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            cmb_kat.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            cmb_odano.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            cmb_yatakno.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txt_yatak_fiyat.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();

            cmb_odano.Enabled = false;
            cmb_yatakno.Enabled = false;

        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
         
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btn_kaydı_temizle_Click(object sender, EventArgs e)
        {
            //YENİ KAYIT OLUŞTURULACAĞI ZAMAN TEXTBOXDAKİ DEĞERLERİ TEMİZLİYORUZ
            txt_tc.Clear();
            txt_ogrenci_adsoyad.Clear();
            txt_dogum_yeri.Clear();
            txt_okulu.Clear();
            txt_bolumu.Clear();
            txt_telefon.Clear();
            txt_adres.Clear();
            txt_yatak_fiyat.Clear();
            txt_id.Clear();
        }


    }
}
