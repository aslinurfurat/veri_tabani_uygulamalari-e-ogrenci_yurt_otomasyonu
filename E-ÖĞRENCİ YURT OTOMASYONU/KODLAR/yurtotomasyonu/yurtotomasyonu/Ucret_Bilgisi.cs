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
    public partial class Ucret_Bilgisi : Form
    {
        public Ucret_Bilgisi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
        SqlCommand komut;

        private void Form1_Load(object sender, EventArgs e)
        {
            goster();
        }

        void goster()
        {

            DataTable dt = new DataTable();
            String sql = "Select * from Ucret_Bilgisi ";
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int toplam_tutar = 0;


            DataTable dt = new DataTable();
            string sorgu2 = "Select sum (odenen_tutar) from Ucret_Bilgisi where ogr_id='" + txt_id.Text + "'";
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sorgu2, baglanti);
            da.Fill(dt);
            baglanti.Close();
            try
            {
                toplam_tutar = Convert.ToInt32(dt.Rows[0][0]);

            }
            catch (Exception)
            {

            }
            int yeni_borc = Convert.ToInt32(txt_miktar.Text) - toplam_tutar - Convert.ToInt32(txt_odenen_tutar.Text);

            txt_yeni_borc.Text = yeni_borc.ToString();

            string sorgu = "INSERT INTO Ucret_Bilgisi(ogr_id,miktar,odeme_tarihi,odenen_tutar,yeni_borc) VALUES (@ogr_id,@miktar,@odeme_tarihi,@odenen_tutar,@yeni_borc)";

            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@ogr_id", txt_id.Text);
            komut.Parameters.AddWithValue("@miktar", txt_miktar.Text);
            komut.Parameters.AddWithValue("@odeme_tarihi", dtp_odeme_Tarih.Value);
            komut.Parameters.AddWithValue("@odenen_tutar", txt_odenen_tutar.Text);
            komut.Parameters.AddWithValue("@yeni_borc", txt_yeni_borc.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            goster();
        }

        private void btn_silme_Click(object sender, EventArgs e)
        {
            String sql = "delete Ucret_Bilgisi where ucret_id=@ucret_id ";
            komut = new SqlCommand(sql, baglanti);

            komut.Parameters.AddWithValue("@ucret_id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            goster();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {

            Ogrenci_İslemleri a = new Ogrenci_İslemleri();
            a.Show();
            this.Hide();
        }
    }
}
