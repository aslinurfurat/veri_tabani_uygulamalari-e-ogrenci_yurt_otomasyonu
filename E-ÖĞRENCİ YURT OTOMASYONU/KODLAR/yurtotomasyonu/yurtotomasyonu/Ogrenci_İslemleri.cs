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
using wordeaktar = Microsoft.Office.Interop.Word;

namespace yurtotomasyonu
{
    public partial class Ogrenci_İslemleri : Form
    {
        public Ogrenci_İslemleri()
        {
            InitializeComponent();
        }

        static wordeaktar.Application worduygulama = new wordeaktar.Application();
        wordeaktar.Document wordDocument = worduygulama.Documents.Add(Type.Missing,Type.Missing, Type.Missing, Type.Missing);
        
        public void WordAktar()
        {
            //WORD E YAZDIR BUTONUNUN İŞLEMİNİ YAPAN FONKSİYON
            try
            {
                worduygulama.Visible = true;
                wordDocument.PageSetup.PaperSize = wordeaktar.WdPaperSize.wdPaperA4;

                worduygulama.Selection.Font.Bold = (int)wordeaktar.WdConstants.wdFirst;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count -1; j++)
                    {
                        worduygulama.Selection.TypeText(dataGridView1[j, i].Value.ToString() + " ");
                    }
                    worduygulama.Selection.TypeParagraph();
                }

                string wyol = @"C:\Users\hp\Desktop\belge1" + DateTime.Now.ToShortDateString() + ".docx";
                wordDocument.SaveAs(wyol, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception)
            {
                MessageBox.Show("İslemleriniz Word Dosyasına Aktarıldı.!!");
                
            }

        }


        private void button12_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ogrenci_Guncelle a = new Ogrenci_Guncelle();
            a.Show();
            this.Hide();
        }
        SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
        SqlCommand komut,komut2,komut3,komut4;
        void goster()
        {
            //VERİ TABANINDAN VERİLERİ TABLOYA DOLDURACAK SQL KODUNU YAZIYORUZ
            DataTable dt = new DataTable();
            String sql = "Select Ogrenciler.ogr_id,Ogrenciler.tc,Ogrenciler.adi_soyadi,Ogrenciler.dogum_tarihi,Ogrenciler.dogum_yeri,Ogrenciler.kayit_tarihi,Ogrenciler.okulu,Ogrenciler.bolumu,Ogrenciler.ogr_turu,Ogrenciler.tel_no,Ogrenciler.adres , Oda_Bilgileri.oda_numarasi, Oda_Bilgileri.kat , Yatak_Bilgileri.yatak_numarasi,Yatak_Bilgileri.fiyat,Yatak_Bilgileri.yatak_id,Oda_Bilgileri.oda_id FROM Ogrenciler INNER JOIN Yatak_Bilgileri ON Ogrenciler.ogr_id=Yatak_Bilgileri.ogr_id INNER JOIN Oda_Bilgileri ON Yatak_Bilgileri.yatak_id=Oda_Bilgileri.yatak_id ";
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void txt_ogr_ara_TextChanged(object sender, EventArgs e)
        {
            //ARANILACAK ÖĞRENCİNİN İSİM BİLGİSİNE GÖRE ARAMA YAPAN SQL BİLGİSİNİ YAZIYORUZ
            baglanti.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("Select Ogrenciler.ogr_id,Ogrenciler.tc,Ogrenciler.adi_soyadi,Ogrenciler.dogum_tarihi,Ogrenciler.dogum_yeri,Ogrenciler.kayit_tarihi,Ogrenciler.okulu,Ogrenciler.bolumu,Ogrenciler.ogr_turu,Ogrenciler.tel_no,Ogrenciler.adres , Oda_Bilgileri.oda_numarasi, Oda_Bilgileri.kat ,Yatak_Bilgileri.yatak_numarasi,Yatak_Bilgileri.fiyat FROM Ogrenciler INNER JOIN Yatak_Bilgileri ON Ogrenciler.ogr_id=Yatak_Bilgileri.ogr_id INNER JOIN Oda_Bilgileri ON Yatak_Bilgileri.yatak_id=Oda_Bilgileri.yatak_id  Where adi_soyadi like '%" + txt_ogr_ara.Text +"%'",baglanti);
            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        
        }

        private void btn_ogr_yazdir_Click(object sender, EventArgs e)
        {
            WordAktar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ÜCRET BİLGİSİ FORMUNDA KULLANACAĞIMIZ ÖĞRENCİ İD VE YATAK FİYATI BİLGİSİNİ GÖNDERİYORUZ
            Ucret_Bilgisi a = new Ucret_Bilgisi();
            a.txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            a.txt_miktar.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            a.Show();
            this.Hide();
        }

        private void btn_izin_Click(object sender, EventArgs e)
        {
            //İZİNLER FORMUNDA KULLANCAĞIMIZ ÖĞRENCİ İD TC VE İSİM BİLGİSİNİ GÖNDERİYORUZ
            Izinler a = new Izinler();
            a.txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            a.txt_tc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            a.txt_adi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            a.Show();
            this.Hide();
        }

        private void Ogrenci_İslemleri_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void btn_ogrenci_sil_Click(object sender, EventArgs e)
        {
            string sorgu4 = "DELETE FROM Izinler WHERE ogr_id=@ogr_id";
            komut4 = new SqlCommand(sorgu4, baglanti);
            komut4.Parameters.AddWithValue("@ogr_id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            baglanti.Open();
            komut4.ExecuteNonQuery();
            baglanti.Close();

            //SEÇİLEN ÖĞRENCİYİ BAĞLI OLDUĞU EN UÇ TABLODAN SİLECEK ŞEKİLDE SQL SORGUMUZU YAZIYORUZ
            string sorgu3 = "DELETE FROM Oda_Bilgileri WHERE oda_id=@oda_id";
            komut3 = new SqlCommand(sorgu3, baglanti);
            komut3.Parameters.AddWithValue("@oda_id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[16].Value.ToString()));
            baglanti.Open();
            komut3.ExecuteNonQuery();
            baglanti.Close();

            string sorgu2 = "DELETE FROM Yatak_Bilgileri WHERE yatak_id=@yatak_id";
            komut2 = new SqlCommand(sorgu2, baglanti);
            komut2.Parameters.AddWithValue("@yatak_id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[15].Value.ToString()));
            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();

            string sorgu = "DELETE FROM Ogrenciler WHERE ogr_id=@ogr_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ogr_id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            

            
            goster();
        }
    }
}
