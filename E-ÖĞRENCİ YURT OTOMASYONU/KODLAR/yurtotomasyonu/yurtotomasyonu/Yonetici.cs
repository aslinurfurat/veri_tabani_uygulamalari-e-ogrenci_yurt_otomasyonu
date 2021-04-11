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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");


        void goster()
        {
            //VERİTABANINDAKİ PERSONEL BİLGİLERİ VE YÖNETİCİ TABLOSUNDAN VERİLERİ ÇEKİP TABLOMUZA EKLİYORUZ
            DataTable dt = new DataTable();
            String sql = "Select * from Personel_Bilgileri";
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            DataTable dt2 = new DataTable();
            String sql2 = "Select * from Yonetici";
            baglanti.Open();
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, baglanti);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            baglanti.Close();
        }
        private void Yonetici_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //GİRİLEN PERSONELİN KULLANICI ADI VE PAROLASINI VERİTABANINA EKLEYEN SQL SORGUMUZU YAZIYORUZ
                int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                string sorgu = "INSERT INTO Yonetici(personel_id,kullanici_adi,sifre) VALUES (@personel_id,@kullanici_adi,@sifre)";

               SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@personel_id", i);
                komut.Parameters.AddWithValue("@kullanici_adi", txt_kullanici_adi.Text);
                komut.Parameters.AddWithValue("@sifre", txt_parola.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                goster();
            }
            
            catch (Exception)
            {
                MessageBox.Show("Lütfen Tablodan Bir Personel Seçiniz..!!");
                
            }
}

        private void btn_sil_Click(object sender, EventArgs e)
        {
            //GİRİLEN PERSONELİN İD SİNE GÖRE VERİTABANINDAN SİLEN SQL SORGUMUZU YAZIYORUZ
            String sql = "delete Yonetici where personel_id=@personel_id ";
            SqlCommand komut = new SqlCommand(sql, baglanti);

            komut.Parameters.AddWithValue("@personel_id", dataGridView2.CurrentRow.Cells[2].Value.ToString());
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            goster();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            a.Show();
            this.Hide();
        }
    }
}
