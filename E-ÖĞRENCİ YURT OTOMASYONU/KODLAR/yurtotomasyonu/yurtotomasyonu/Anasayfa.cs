using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtotomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        
        private void toolstrip_anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            a.Show();
            this.Hide();
        }
        //KAYIT İSLEMLERİ SAYFASINI AÇMA İŞLEMİNİ YAPIYORUZ
        private void toolstrip_kayıtislemleri_Click(object sender, EventArgs e)
        {
            Kayit_İslemleri a = new Kayit_İslemleri();
            a.Show();
            this.Hide();
        }
        //ÖĞRENCİ İŞLEMLERİ SAYFASINI AÇMA İŞLEMİNİ YAPIYORUZ
        private void toolstrip_ogrenci_islemleri_Click(object sender, EventArgs e)
        {
            Ogrenci_İslemleri a = new Ogrenci_İslemleri();
            a.Show();
            this.Hide();
        }
        //ODALAR SAYFASINI AÇMA İŞLEMİNİ YAPIYORUZ
        private void toolstrip_odalar_Click(object sender, EventArgs e)
        {
            Odalar a = new Odalar();
            a.Show();
            this.Hide();
        }
        //PERSONEL SAYFASINI AÇMA İŞLEMİNİ YAPIYORUZ
        private void toolstrip_personel_Click(object sender, EventArgs e)
        {
            Personel a = new Personel();
            a.Show();
            this.Hide();
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            girispaneli a = new girispaneli();
            a.Show();
            this.Hide();
        }
        ////YÖNETİCİ SAYFASINI AÇMA İŞLEMİNİ YAPIYORUZ
        private void toolstrip_yonetici_Click(object sender, EventArgs e)
        {
            Yonetici a = new Yonetici();
            a.Show();
            this.Hide();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
