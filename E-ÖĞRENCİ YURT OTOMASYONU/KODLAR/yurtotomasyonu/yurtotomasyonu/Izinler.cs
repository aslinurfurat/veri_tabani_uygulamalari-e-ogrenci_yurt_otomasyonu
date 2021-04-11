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
    public partial class Izinler : Form
    {
        public Izinler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
        SqlCommand komut;

        void goster()
        {
            //VERİ TABANINDAN VERİLERİ TABLOYA DOLDURACAK SQL KODUNU YAZIYORUZ
            SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
            DataTable dt = new DataTable();
            String sql = "Select Ogrenciler.ogr_id,Ogrenciler.tc,Ogrenciler.adi_soyadi,Izinler.baslangic_tarihi,Izinler.bitis_tarihi,Izinler.gidecegi_adres,Izinler.telefon FROM Ogrenciler INNER JOIN Izinler ON Ogrenciler.ogr_id=Izinler.ogr_id ";
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

 




        private void Izinler_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //TABLOMUZU TEXTBOXLARDAN GELEN DEĞERLERE DOLDURUYORUZ
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_adi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtp_baslangic_tarihi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dtp_bitis_tarihi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_Adres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_telefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Ogrenci_İslemleri a = new Ogrenci_İslemleri();
            a.Show();
            this.Hide();


        }

        private void btn_izin_ekle_Click_1(object sender, EventArgs e)
        {
            //İZİN ALAN ÖĞRENCİYİ VERİTABANINA KAYIT EDEN SQL SORGUSUNU YAPIYORUZ
            string sorgu = "INSERT INTO Izinler(ogr_id,adi_soyadi,baslangic_tarihi,bitis_tarihi,gidecegi_adres,telefon) VALUES(@ogr_id,@adi_soyadi,@baslangic_tarihi,@bitis_tarihi,@gidecegi_adres,@telefon)";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ogr_id", txt_id.Text);
            komut.Parameters.AddWithValue("@adi_soyadi", txt_adi.Text);
            komut.Parameters.AddWithValue("@baslangic_tarihi", dtp_baslangic_tarihi.Value);
            komut.Parameters.AddWithValue("@bitis_tarihi", dtp_bitis_tarihi.Value);
            komut.Parameters.AddWithValue("@gidecegi_adres", txt_Adres.Text);
            komut.Parameters.AddWithValue("@telefon", txt_telefon.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            goster();
        }
    }
}
