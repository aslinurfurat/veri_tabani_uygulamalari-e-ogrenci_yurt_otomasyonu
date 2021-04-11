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
    public partial class Ogrenci_Guncelle : Form
    {
        public Ogrenci_Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
        SqlCommand komut;
        int odasayisi = 4;
        int yataksayisi = 3;
        int katsayisi = 3;
        void goster()
        {
            
            DataTable dt = new DataTable();
            String sql = "Select Ogrenciler.ogr_id,Ogrenciler.tc,Ogrenciler.adi_soyadi,Ogrenciler.dogum_tarihi,Ogrenciler.dogum_yeri,Ogrenciler.kayit_tarihi,Ogrenciler.okulu,Ogrenciler.bolumu,Ogrenciler.ogr_turu,Ogrenciler.tel_no,Ogrenciler.adres , Oda_Bilgileri.oda_numarasi, Oda_Bilgileri.kat ,Yatak_Bilgileri.yatak_numarasi,Yatak_Bilgileri.fiyat,Yatak_Bilgileri.yatak_id FROM Ogrenciler INNER JOIN Yatak_Bilgileri ON Ogrenciler.ogr_id=Yatak_Bilgileri.ogr_id INNER JOIN Oda_Bilgileri ON Yatak_Bilgileri.yatak_id=Oda_Bilgileri.yatak_id ";
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void Ogrenci_Guncelle_Load(object sender, EventArgs e)
        {
            goster();
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
                    string sorgu = "Select yatak_id from Oda_Bilgileri where oda_numarasi=" + odanumaralari + "" + " and kat='" + j + "' ";

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
                if (doluodasayisi == odasayisi)
                {
                    cmb_kat.Items.Remove(j);

                }
            }


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
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
            cmb_odano.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            cmb_kat.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            cmb_yatakno.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txt_yatak_fiyat.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txt_yatak_id.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            cmb_odano.Enabled = false;
            cmb_yatakno.Enabled = false;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
            string sorgu = "UPDATE Ogrenciler SET tc=@tc,adi_soyadi=@adi_soyadi,dogum_tarihi=@dogum_tarihi,dogum_yeri=@dogum_yeri,kayit_tarihi=@kayit_tarihi,okulu=@okulu,bolumu=@bolumu,ogr_turu=@ogr_turu,tel_no=@tel_no,adres=@adres WHERE ogr_id=@ogr_id";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            
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
            komut.Parameters.AddWithValue("@ogr_id",txt_id.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            string sorgu2 = "UPDATE Yatak_Bilgileri SET fiyat=@fiyat,yatak_numarasi=@yatak_numarasi WHERE ogr_id=@ogr_id";
            SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);

            komut2.Parameters.AddWithValue("@fiyat", txt_yatak_fiyat.Text);
            komut2.Parameters.AddWithValue("@yatak_numarasi", cmb_yatakno.Text);
            komut2.Parameters.AddWithValue("@ogr_id", txt_id.Text);

            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();

            string sorgu3 = "UPDATE Oda_Bilgileri SET oda_numarasi=@oda_numarasi,kat=@kat WHERE yatak_id=@yatak_id";
            SqlCommand komut3 = new SqlCommand(sorgu3, baglanti);

            komut3.Parameters.AddWithValue("@oda_numarasi", cmb_odano.Text);
            komut3.Parameters.AddWithValue("@kat", cmb_kat.Text);
            komut3.Parameters.AddWithValue("@yatak_id", txt_yatak_id.Text);

            baglanti.Open();
            komut3.ExecuteNonQuery();
            baglanti.Close();

            goster();

            cmb_odano.Enabled = false;
            cmb_yatakno.Enabled = false;

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Ogrenci_İslemleri a = new Ogrenci_İslemleri();
            a.Show();
            this.Hide();
        }

        private void cmb_kat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_odano.Enabled = true;
            if (cmb_kat.Text != "")
            {
                int katlar = Convert.ToInt32(cmb_kat.Text);

                cmb_odano.Items.Clear();
                for (int i = 0; i < odasayisi; i++)
                {
                    cmb_odano.Items.Add(katlar * 100 + i);
                }

                for (int i = 0; i < odasayisi; i++)
                {
                    int odanumaralari = katlar * 100 + i;
                    SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
                    string sorgu = "Select yatak_id from Oda_Bilgileri where oda_numarasi=" + odanumaralari + "" + " and kat='" + cmb_kat.Text + "' ";

                    baglanti.Open();
                    komut = new SqlCommand(sorgu, baglanti);

                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    baglanti.Close();
                    if (dt.Rows.Count == yataksayisi)
                    {
                        cmb_odano.Items.Remove(odanumaralari);
                    }
                }

            }
        }

        private void cmb_odano_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            for (int i = 1; i <= yataksayisi; i++)
            {
                cmb_yatakno.Items.Add(i);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                cmb_yatakno.Items.Remove(dt.Rows[i][0]);
            }
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btn_gerii_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            a.Show();
            this.Hide();

        }

    }
}
