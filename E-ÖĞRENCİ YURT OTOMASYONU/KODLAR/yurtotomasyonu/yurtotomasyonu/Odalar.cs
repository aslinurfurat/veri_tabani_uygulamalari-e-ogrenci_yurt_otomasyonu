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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=YurtOtomasyonDB;Integrated Security=SSPI");
        SqlCommand komut;
        int odasayisi = 4;
        int yataksayisi = 3;
        int katsayisi = 3;
        private void Odalar_Load(object sender, EventArgs e)
        {
            int[] a = new int[katsayisi];
            
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
                    a[j-1] = 1;
                }
                else
                {
                    a[j-1] = 0;
                }
            }
            if (a[0] == 1)
            {
                lbl_kat1.Text = "KAT 1 DOLU";
                lbl_kat1.BackColor = Color.Red;
                lbl_kat1.ForeColor = Color.White;

            }
            else
            {
                lbl_kat1.Text = "KAT 1";
                lbl_kat1.BackColor = Color.Purple;
                lbl_kat1.ForeColor = Color.White;

            }

            if (a[1] == 1)
            {
                lbl_kat2.Text = "KAT 2 DOLU";
                lbl_kat2.BackColor = Color.Red;
                lbl_kat2.ForeColor = Color.White;
            }
            else
            {
                lbl_kat2.Text = "KAT 2";
                lbl_kat2.BackColor = Color.Purple;
                lbl_kat2.ForeColor = Color.White;
            }

            if (a[2] == 1)
            {
                lbl_kat3.Text = "KAT 3 DOLU";
                lbl_kat3.BackColor = Color.Red;
                lbl_kat3.ForeColor = Color.White;
            }
            else
            {
                lbl_kat3.Text = "KAT 3";
                lbl_kat3.BackColor = Color.Purple;
                lbl_kat3.ForeColor = Color.White;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Katlardaki_Odalar a = new Katlardaki_Odalar();
            a.bulundugu_kat = 1; 
            a.Show();
            this.Hide();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Katlardaki_Odalar a = new Katlardaki_Odalar();
             a.bulundugu_kat = 2;
            a.Show();
            this.Hide();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Katlardaki_Odalar a = new Katlardaki_Odalar();
           a.bulundugu_kat = 3;
            a.Show();
            this.Hide();
            
        }


        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            a.Show();
            this.Hide();

        }
    }
}
