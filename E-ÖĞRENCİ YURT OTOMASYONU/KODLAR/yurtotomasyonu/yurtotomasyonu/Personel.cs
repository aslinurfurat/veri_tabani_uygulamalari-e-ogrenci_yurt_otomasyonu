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
    public partial class Personel : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        SqlCommand komut;

        public Personel()
        {
            InitializeComponent();
        }


        void personelgoster()
        {
            //VERİTABANINDAN PERSONEL BİLGİLERİNİ FORMUMUZDAKİ TABLOMIZDA GÖSTERMEK İÇİN SQL SORGUMUZU YAZIYORUZ
            baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB; Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select * From Personel_Bilgileri ", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();



        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {

            Anasayfa a = new Anasayfa();
            a.Show();
            this.Hide();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            personelgoster();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //TABLOMUZA TEXTBOXLARDAKİ DEĞERLERİ GİRİYORUZ
            txt_pkodu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_p_adisoyadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtp_p_isegiristarihi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_p_adres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_p_telefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmb_p_gorev.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_p_maas.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_personel_ekle_Click(object sender, EventArgs e)
        {
            //PERSONEL BİLGİLERİ TABLOSUNA PERSONEL EKLEMEK İÇİN SQL SORGUMUZU YAZIYORUZ
            string sorgu = "INSERT INTO Personel_Bilgileri(p_adi_soyadi,ise_giris_tarihi,adres,tel_no,gorevi,maas) VALUES (@p_adi_soyadi,@ise_giris_tarihi,@adres,@tel_no,@gorevi,@maas)";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p_adi_soyadi", txt_p_adisoyadi.Text);
            komut.Parameters.AddWithValue("@ise_giris_tarihi", dtp_p_isegiristarihi.Value);
            komut.Parameters.AddWithValue("@adres", txt_p_adres.Text);
            komut.Parameters.AddWithValue("@tel_no", txt_p_telefon.Text);
            komut.Parameters.AddWithValue("@gorevi", cmb_p_gorev.Text);
            komut.Parameters.AddWithValue("@maas", txt_p_maas.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            personelgoster();
        }

        private void btn_personel_sil_Click(object sender, EventArgs e)
        {
            //PERSONEL BİLGİLERİ TABLOSUNDAN PERSONEL TABLOLARI SİLMEK İÇİN SQL SORGUMUZU YAZIYORUZ
            string sorgu2 = "DELETE FROM Yonetici WHERE personel_id=@personel_id";
            SqlCommand komut2 = new SqlCommand(sorgu2,baglanti);
            komut2.Parameters.AddWithValue("@personel_id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();
            string sorgu = "DELETE FROM Personel_Bilgileri WHERE personel_id=@personel_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@personel_id", Convert.ToInt32(txt_pkodu.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            personelgoster();
        }

        private void btn_personel_guncelle_Click(object sender, EventArgs e)
        {
            //PERSONEL BİLGİLERİ TABLOSUNDAKİ BİLGİLERİ GÜNCELLEME İŞLEMİ YAPIYORUZ
            string sorgu = "UPDATE Personel_Bilgileri SET p_adi_soyadi=@p_adi_soyadi,ise_giris_tarihi=@ise_giris_tarihi,adres=@adres,tel_no=@tel_no,gorevi=@gorevi,maas=@maas WHERE personel_id=@personel_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@personel_id", Convert.ToInt32(txt_pkodu.Text));
            komut.Parameters.AddWithValue("@p_adi_soyadi", txt_p_adisoyadi.Text);
            komut.Parameters.AddWithValue("@ise_giris_tarihi", dtp_p_isegiristarihi.Value);
            komut.Parameters.AddWithValue("@adres", txt_p_adres.Text);
            komut.Parameters.AddWithValue("@tel_no", txt_p_telefon.Text);
            komut.Parameters.AddWithValue("@gorevi", cmb_p_gorev.Text);
            komut.Parameters.AddWithValue("@maas", txt_p_maas.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            personelgoster();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            //YENİ PERSONEL EKLEMEK İÇİN TEXTBOXLARI TEMİZLEME İSLEMİ YAPIYORUZ
            txt_pkodu.Clear();
            txt_p_adisoyadi.Clear();
            txt_p_adres.Clear();
            txt_p_maas.Clear();
            txt_p_telefon.Clear();
        }
    }
}
