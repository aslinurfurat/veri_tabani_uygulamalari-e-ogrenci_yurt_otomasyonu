namespace yurtotomasyonu
{
    partial class Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_p_isegiristarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.cmb_p_gorev = new System.Windows.Forms.ComboBox();
            this.txt_p_maas = new System.Windows.Forms.TextBox();
            this.txt_p_adres = new System.Windows.Forms.TextBox();
            this.txt_p_adisoyadi = new System.Windows.Forms.TextBox();
            this.txt_pkodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.btn_personel_guncelle = new System.Windows.Forms.Button();
            this.btn_personel_ekle = new System.Windows.Forms.Button();
            this.btn_personel_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_p_telefon = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_p_telefon);
            this.groupBox1.Controls.Add(this.dtp_p_isegiristarihi);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.cmb_p_gorev);
            this.groupBox1.Controls.Add(this.txt_p_maas);
            this.groupBox1.Controls.Add(this.txt_p_adres);
            this.groupBox1.Controls.Add(this.txt_p_adisoyadi);
            this.groupBox1.Controls.Add(this.txt_pkodu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(47, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 286);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kaydı";
            // 
            // dtp_p_isegiristarihi
            // 
            this.dtp_p_isegiristarihi.Location = new System.Drawing.Point(187, 146);
            this.dtp_p_isegiristarihi.Name = "dtp_p_isegiristarihi";
            this.dtp_p_isegiristarihi.Size = new System.Drawing.Size(229, 30);
            this.dtp_p_isegiristarihi.TabIndex = 25;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Image")));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.Location = new System.Drawing.Point(764, 218);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(149, 47);
            this.btn_temizle.TabIndex = 24;
            this.btn_temizle.Text = "    Temizle";
            this.btn_temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // cmb_p_gorev
            // 
            this.cmb_p_gorev.FormattingEnabled = true;
            this.cmb_p_gorev.Items.AddRange(new object[] {
            "Yönetici",
            "Muhasebeci",
            "Temizlikçi",
            "Tamirci"});
            this.cmb_p_gorev.Location = new System.Drawing.Point(715, 83);
            this.cmb_p_gorev.Name = "cmb_p_gorev";
            this.cmb_p_gorev.Size = new System.Drawing.Size(229, 31);
            this.cmb_p_gorev.TabIndex = 13;
            // 
            // txt_p_maas
            // 
            this.txt_p_maas.Location = new System.Drawing.Point(715, 146);
            this.txt_p_maas.Name = "txt_p_maas";
            this.txt_p_maas.Size = new System.Drawing.Size(229, 30);
            this.txt_p_maas.TabIndex = 11;
            // 
            // txt_p_adres
            // 
            this.txt_p_adres.Location = new System.Drawing.Point(187, 197);
            this.txt_p_adres.Multiline = true;
            this.txt_p_adres.Name = "txt_p_adres";
            this.txt_p_adres.Size = new System.Drawing.Size(229, 68);
            this.txt_p_adres.TabIndex = 9;
            // 
            // txt_p_adisoyadi
            // 
            this.txt_p_adisoyadi.Location = new System.Drawing.Point(187, 90);
            this.txt_p_adisoyadi.Name = "txt_p_adisoyadi";
            this.txt_p_adisoyadi.Size = new System.Drawing.Size(229, 30);
            this.txt_p_adisoyadi.TabIndex = 8;
            // 
            // txt_pkodu
            // 
            this.txt_pkodu.Enabled = false;
            this.txt_pkodu.Location = new System.Drawing.Point(187, 36);
            this.txt_pkodu.Name = "txt_pkodu";
            this.txt_pkodu.Size = new System.Drawing.Size(229, 30);
            this.txt_pkodu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Maaş ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Görev ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefonu ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "İşe Giriş Tarihi ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Kodu ";
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anasayfa.Location = new System.Drawing.Point(844, 341);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(182, 55);
            this.btn_anasayfa.TabIndex = 36;
            this.btn_anasayfa.Text = "Anasayfaya Dön";
            this.btn_anasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // btn_personel_guncelle
            // 
            this.btn_personel_guncelle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personel_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_personel_guncelle.Image")));
            this.btn_personel_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personel_guncelle.Location = new System.Drawing.Point(599, 341);
            this.btn_personel_guncelle.Name = "btn_personel_guncelle";
            this.btn_personel_guncelle.Size = new System.Drawing.Size(194, 55);
            this.btn_personel_guncelle.TabIndex = 35;
            this.btn_personel_guncelle.Text = "Personel Güncelle";
            this.btn_personel_guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_personel_guncelle.UseVisualStyleBackColor = true;
            this.btn_personel_guncelle.Click += new System.EventHandler(this.btn_personel_guncelle_Click);
            // 
            // btn_personel_ekle
            // 
            this.btn_personel_ekle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personel_ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_personel_ekle.Image")));
            this.btn_personel_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personel_ekle.Location = new System.Drawing.Point(105, 341);
            this.btn_personel_ekle.Name = "btn_personel_ekle";
            this.btn_personel_ekle.Size = new System.Drawing.Size(183, 55);
            this.btn_personel_ekle.TabIndex = 33;
            this.btn_personel_ekle.Text = "Yeni Personel";
            this.btn_personel_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_personel_ekle.UseVisualStyleBackColor = true;
            this.btn_personel_ekle.Click += new System.EventHandler(this.btn_personel_ekle_Click);
            // 
            // btn_personel_sil
            // 
            this.btn_personel_sil.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personel_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_personel_sil.Image")));
            this.btn_personel_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personel_sil.Location = new System.Drawing.Point(359, 341);
            this.btn_personel_sil.Name = "btn_personel_sil";
            this.btn_personel_sil.Size = new System.Drawing.Size(183, 55);
            this.btn_personel_sil.TabIndex = 34;
            this.btn_personel_sil.Text = "Personel Sil";
            this.btn_personel_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_personel_sil.UseVisualStyleBackColor = true;
            this.btn_personel_sil.Click += new System.EventHandler(this.btn_personel_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 432);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 294);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // txt_p_telefon
            // 
            this.txt_p_telefon.Location = new System.Drawing.Point(715, 33);
            this.txt_p_telefon.Mask = "(999) 000-0000";
            this.txt_p_telefon.Name = "txt_p_telefon";
            this.txt_p_telefon.Size = new System.Drawing.Size(229, 30);
            this.txt_p_telefon.TabIndex = 26;
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 738);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.btn_personel_guncelle);
            this.Controls.Add(this.btn_personel_ekle);
            this.Controls.Add(this.btn_personel_sil);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_p_isegiristarihi;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.ComboBox cmb_p_gorev;
        private System.Windows.Forms.TextBox txt_p_maas;
        private System.Windows.Forms.TextBox txt_p_adres;
        private System.Windows.Forms.TextBox txt_p_adisoyadi;
        private System.Windows.Forms.TextBox txt_pkodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Button btn_personel_guncelle;
        private System.Windows.Forms.Button btn_personel_ekle;
        private System.Windows.Forms.Button btn_personel_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox txt_p_telefon;
    }
}