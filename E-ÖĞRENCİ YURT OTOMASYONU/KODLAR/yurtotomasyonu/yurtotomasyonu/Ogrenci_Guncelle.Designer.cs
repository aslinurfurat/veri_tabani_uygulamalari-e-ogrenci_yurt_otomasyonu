namespace yurtotomasyonu
{
    partial class Ogrenci_Guncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_Guncelle));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.cmb_ogrturu = new System.Windows.Forms.ComboBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_bolumu = new System.Windows.Forms.TextBox();
            this.txt_okulu = new System.Windows.Forms.TextBox();
            this.txt_dogum_yeri = new System.Windows.Forms.TextBox();
            this.txt_ogrenci_adsoyad = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.dtp_kayit_tarihi = new System.Windows.Forms.DateTimePicker();
            this.dtp_dogum_tarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_gerii = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_yatak_id = new System.Windows.Forms.TextBox();
            this.txt_yatak_fiyat = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmb_yatakno = new System.Windows.Forms.ComboBox();
            this.cmb_odano = new System.Windows.Forms.ComboBox();
            this.cmb_kat = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 480);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1032, 247);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.btn_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.Image")));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.Location = new System.Drawing.Point(899, 92);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(199, 66);
            this.btn_guncelle.TabIndex = 66;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.btn_geri.Image = ((System.Drawing.Image)(resources.GetObject("btn_geri.Image")));
            this.btn_geri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geri.Location = new System.Drawing.Point(899, 217);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(199, 66);
            this.btn_geri.TabIndex = 67;
            this.btn_geri.Text = "Öğrenci İşlemlerine Dön";
            this.btn_geri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(31, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 444);
            this.tabControl1.TabIndex = 68;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txt_id);
            this.tabPage1.Controls.Add(this.btn_ileri);
            this.tabPage1.Controls.Add(this.cmb_ogrturu);
            this.tabPage1.Controls.Add(this.txt_adres);
            this.tabPage1.Controls.Add(this.txt_telefon);
            this.tabPage1.Controls.Add(this.txt_bolumu);
            this.tabPage1.Controls.Add(this.txt_okulu);
            this.tabPage1.Controls.Add(this.txt_dogum_yeri);
            this.tabPage1.Controls.Add(this.txt_ogrenci_adsoyad);
            this.tabPage1.Controls.Add(this.txt_tc);
            this.tabPage1.Controls.Add(this.dtp_kayit_tarihi);
            this.tabPage1.Controls.Add(this.dtp_dogum_tarihi);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(843, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "İD";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(153, 334);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(191, 28);
            this.txt_id.TabIndex = 41;
            // 
            // btn_ileri
            // 
            this.btn_ileri.Image = ((System.Drawing.Image)(resources.GetObject("btn_ileri.Image")));
            this.btn_ileri.Location = new System.Drawing.Point(691, 361);
            this.btn_ileri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(77, 38);
            this.btn_ileri.TabIndex = 40;
            this.btn_ileri.UseVisualStyleBackColor = true;
            this.btn_ileri.Click += new System.EventHandler(this.btn_ileri_Click);
            // 
            // cmb_ogrturu
            // 
            this.cmb_ogrturu.FormattingEnabled = true;
            this.cmb_ogrturu.Items.AddRange(new object[] {
            "Birinci Öğretim",
            "İkinci Öğretim"});
            this.cmb_ogrturu.Location = new System.Drawing.Point(625, 150);
            this.cmb_ogrturu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_ogrturu.Name = "cmb_ogrturu";
            this.cmb_ogrturu.Size = new System.Drawing.Size(191, 28);
            this.cmb_ogrturu.TabIndex = 39;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(625, 262);
            this.txt_adres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(191, 77);
            this.txt_adres.TabIndex = 38;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(625, 207);
            this.txt_telefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(191, 28);
            this.txt_telefon.TabIndex = 37;
            // 
            // txt_bolumu
            // 
            this.txt_bolumu.Location = new System.Drawing.Point(625, 91);
            this.txt_bolumu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bolumu.Name = "txt_bolumu";
            this.txt_bolumu.Size = new System.Drawing.Size(191, 28);
            this.txt_bolumu.TabIndex = 36;
            // 
            // txt_okulu
            // 
            this.txt_okulu.Location = new System.Drawing.Point(625, 34);
            this.txt_okulu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_okulu.Name = "txt_okulu";
            this.txt_okulu.Size = new System.Drawing.Size(191, 28);
            this.txt_okulu.TabIndex = 35;
            // 
            // txt_dogum_yeri
            // 
            this.txt_dogum_yeri.Location = new System.Drawing.Point(153, 209);
            this.txt_dogum_yeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dogum_yeri.Name = "txt_dogum_yeri";
            this.txt_dogum_yeri.Size = new System.Drawing.Size(191, 28);
            this.txt_dogum_yeri.TabIndex = 33;
            // 
            // txt_ogrenci_adsoyad
            // 
            this.txt_ogrenci_adsoyad.Location = new System.Drawing.Point(153, 91);
            this.txt_ogrenci_adsoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ogrenci_adsoyad.Name = "txt_ogrenci_adsoyad";
            this.txt_ogrenci_adsoyad.Size = new System.Drawing.Size(191, 28);
            this.txt_ogrenci_adsoyad.TabIndex = 31;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(153, 34);
            this.txt_tc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(191, 28);
            this.txt_tc.TabIndex = 30;
            // 
            // dtp_kayit_tarihi
            // 
            this.dtp_kayit_tarihi.Location = new System.Drawing.Point(153, 274);
            this.dtp_kayit_tarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_kayit_tarihi.Name = "dtp_kayit_tarihi";
            this.dtp_kayit_tarihi.Size = new System.Drawing.Size(191, 28);
            this.dtp_kayit_tarihi.TabIndex = 34;
            // 
            // dtp_dogum_tarihi
            // 
            this.dtp_dogum_tarihi.Location = new System.Drawing.Point(153, 153);
            this.dtp_dogum_tarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_dogum_tarihi.Name = "dtp_dogum_tarihi";
            this.dtp_dogum_tarihi.Size = new System.Drawing.Size(191, 28);
            this.dtp_dogum_tarihi.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(493, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Adres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Ögrenim Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Bolumu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Okulu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kayıt Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Doğum Yeri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Adı Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tc Kimlik No";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_gerii);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txt_yatak_id);
            this.tabPage2.Controls.Add(this.txt_yatak_fiyat);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.cmb_yatakno);
            this.tabPage2.Controls.Add(this.cmb_odano);
            this.tabPage2.Controls.Add(this.cmb_kat);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(843, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oda Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_gerii
            // 
            this.btn_gerii.Image = ((System.Drawing.Image)(resources.GetObject("btn_gerii.Image")));
            this.btn_gerii.Location = new System.Drawing.Point(115, 346);
            this.btn_gerii.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gerii.Name = "btn_gerii";
            this.btn_gerii.Size = new System.Drawing.Size(77, 38);
            this.btn_gerii.TabIndex = 41;
            this.btn_gerii.UseVisualStyleBackColor = true;
            this.btn_gerii.Click += new System.EventHandler(this.btn_gerii_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 255);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Yatak İD";
            // 
            // txt_yatak_id
            // 
            this.txt_yatak_id.Enabled = false;
            this.txt_yatak_id.Location = new System.Drawing.Point(240, 252);
            this.txt_yatak_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yatak_id.Name = "txt_yatak_id";
            this.txt_yatak_id.Size = new System.Drawing.Size(188, 28);
            this.txt_yatak_id.TabIndex = 32;
            // 
            // txt_yatak_fiyat
            // 
            this.txt_yatak_fiyat.Location = new System.Drawing.Point(240, 196);
            this.txt_yatak_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yatak_fiyat.Name = "txt_yatak_fiyat";
            this.txt_yatak_fiyat.Size = new System.Drawing.Size(188, 28);
            this.txt_yatak_fiyat.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(56, 194);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 24);
            this.label20.TabIndex = 30;
            this.label20.Text = "Yatak Fiyat";
            // 
            // cmb_yatakno
            // 
            this.cmb_yatakno.Enabled = false;
            this.cmb_yatakno.FormattingEnabled = true;
            this.cmb_yatakno.Location = new System.Drawing.Point(240, 143);
            this.cmb_yatakno.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_yatakno.Name = "cmb_yatakno";
            this.cmb_yatakno.Size = new System.Drawing.Size(188, 28);
            this.cmb_yatakno.TabIndex = 26;
            // 
            // cmb_odano
            // 
            this.cmb_odano.Enabled = false;
            this.cmb_odano.FormattingEnabled = true;
            this.cmb_odano.Location = new System.Drawing.Point(240, 98);
            this.cmb_odano.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_odano.Name = "cmb_odano";
            this.cmb_odano.Size = new System.Drawing.Size(188, 28);
            this.cmb_odano.TabIndex = 25;
            this.cmb_odano.SelectedIndexChanged += new System.EventHandler(this.cmb_odano_SelectedIndexChanged);
            // 
            // cmb_kat
            // 
            this.cmb_kat.FormattingEnabled = true;
            this.cmb_kat.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmb_kat.Location = new System.Drawing.Point(240, 46);
            this.cmb_kat.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_kat.Name = "cmb_kat";
            this.cmb_kat.Size = new System.Drawing.Size(188, 28);
            this.cmb_kat.TabIndex = 24;
            this.cmb_kat.SelectedIndexChanged += new System.EventHandler(this.cmb_kat_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(56, 143);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 24);
            this.label19.TabIndex = 23;
            this.label19.Text = "Yatak Numarası";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(56, 98);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 24);
            this.label18.TabIndex = 22;
            this.label18.Text = "Oda Numarası";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(56, 46);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 24);
            this.label17.TabIndex = 21;
            this.label17.Text = "Kat";
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anasayfa.Location = new System.Drawing.Point(899, 341);
            this.btn_anasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(199, 66);
            this.btn_anasayfa.TabIndex = 69;
            this.btn_anasayfa.Text = "Anasayfaya Dön";
            this.btn_anasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // Ogrenci_Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 740);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ogrenci_Guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogrenci_Guncelle";
            this.Load += new System.EventHandler(this.Ogrenci_Guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.ComboBox cmb_ogrturu;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_bolumu;
        private System.Windows.Forms.TextBox txt_okulu;
        private System.Windows.Forms.TextBox txt_dogum_yeri;
        private System.Windows.Forms.TextBox txt_ogrenci_adsoyad;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.DateTimePicker dtp_kayit_tarihi;
        private System.Windows.Forms.DateTimePicker dtp_dogum_tarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_yatak_fiyat;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmb_yatakno;
        private System.Windows.Forms.ComboBox cmb_odano;
        private System.Windows.Forms.ComboBox cmb_kat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_yatak_id;
        private System.Windows.Forms.Button btn_gerii;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}