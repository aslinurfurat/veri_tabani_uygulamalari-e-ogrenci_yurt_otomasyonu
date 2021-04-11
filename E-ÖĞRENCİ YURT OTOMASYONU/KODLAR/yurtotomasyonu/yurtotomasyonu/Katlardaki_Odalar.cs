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
    public partial class Katlardaki_Odalar : Form
    {
        public Katlardaki_Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
        SqlCommand komut;

        int odasayisi = 4;
        int yataksayisi = 3;
        int katsayisi = 3;
        public int bulundugu_kat=0;
        private void Katlardaki_Odalar_Load(object sender, EventArgs e)
        {

            this.Text = "KAT "+(bulundugu_kat);
            
            
            
            int[] a = new int[odasayisi];
            for (int j = 1; j <= katsayisi; j++)
            {
                for (int i = 0; i < odasayisi; i++)
                {
                    //GELEN KAT DEĞERİNE GÖRE ODA NUMARALARINI BULUYORUZ
                    int odanumaralari = j * 100 + i;
                    SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
                    string sorgu = "Select yatak_id from Oda_Bilgileri where oda_numarasi=" + odanumaralari + "" + " and kat='" + j + "' ";

                    baglanti.Open();
                    komut = new SqlCommand(sorgu, baglanti);

                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    baglanti.Close();
                    if (dt.Rows.Count == yataksayisi)
                    {
                        a[i] = 1;
                    }
                    else
                    {
                        a[i] = 0;
                    }
                }
            }
            //ODALAR EĞER DOLARSA LABELİMİZE ODA NUMARASINA GÖRE DOLU YAZDIRIP RENGİNİ DEĞİŞTİRİYORUZ
            //ODALARIMIZ BOŞ İSE RENGİ MOR YAPIYORUZ
            if (a[0] == 1)
            {
                lbl_oda1.Text ="ODA"+((bulundugu_kat)*100)+ " DOLU";
                lbl_oda1.BackColor = Color.Red;
                lbl_oda1.ForeColor = Color.White;
            }
            else
            {
                lbl_oda1.Text = "ODA" + ((bulundugu_kat ) * 100);
                lbl_oda1.BackColor = Color.Purple;
                lbl_oda1.ForeColor = Color.White;
            }

            if (a[1] == 1)
            {
                lbl_oda2.Text = "ODA" + ((bulundugu_kat ) * 100+1) + " DOLU";
                lbl_oda2.BackColor = Color.Red;
                lbl_oda2.ForeColor = Color.White;
            }
            else
            {
                lbl_oda2.Text = "ODA" + ((bulundugu_kat ) * 100+1);
                lbl_oda2.BackColor = Color.Purple;
                lbl_oda2.ForeColor = Color.White;
            }

            if (a[2] == 1)
            {
                lbl_oda3.Text = "ODA" + ((bulundugu_kat ) * 100+2) + " DOLU";
                lbl_oda3.BackColor = Color.Red;
                lbl_oda3.ForeColor = Color.White;
            }
            else
            {
                lbl_oda3.Text = "ODA" + ((bulundugu_kat ) * 100+2);
                lbl_oda3.BackColor = Color.Purple;
                lbl_oda3.ForeColor = Color.White;
            }

            if (a[3] == 1)
            {
                lbl_oda4.Text = "ODA" + ((bulundugu_kat ) * 100+3) + " DOLU";
                lbl_oda4.BackColor = Color.Red;
                lbl_oda4.ForeColor = Color.White;
            }
            else
            {
                lbl_oda4.Text = "ODA" + ((bulundugu_kat ) * 100+3);
                lbl_oda4.BackColor = Color.Purple;
                lbl_oda4.ForeColor = Color.White;
            }

        }
        //TIKLANILAN ODANIN YATAKLARINI GÖSTEREN FORM EKRANI AÇILMASINI SAĞLAYAN KODLARIMIZ
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Odalardaki_Yataklar a = new Odalardaki_Yataklar();
            a.oda_numarasi = bulundugu_kat*100;
            a.bulundugu_kat = this.bulundugu_kat;
            a.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Odalardaki_Yataklar a = new Odalardaki_Yataklar();
            a.oda_numarasi = bulundugu_kat * 100+1;
            a.bulundugu_kat = this.bulundugu_kat;
            a.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Odalardaki_Yataklar a = new Odalardaki_Yataklar();
            a.oda_numarasi = bulundugu_kat * 100+2;
            a.bulundugu_kat = this.bulundugu_kat;
            a.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Odalardaki_Yataklar a = new Odalardaki_Yataklar();
            a.oda_numarasi = bulundugu_kat * 100+3;
            a.bulundugu_kat = this.bulundugu_kat;
            a.Show();
            this.Hide();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            a.Show();
            this.Hide();

        }

        private void btn_odaya_dön_Click(object sender, EventArgs e)
        {
            Odalar a = new Odalar();
            a.Show();
            this.Hide();
        
        }
    }
}
