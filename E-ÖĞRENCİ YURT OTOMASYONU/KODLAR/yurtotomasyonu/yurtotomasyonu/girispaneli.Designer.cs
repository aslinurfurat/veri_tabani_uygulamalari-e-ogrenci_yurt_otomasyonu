namespace yurtotomasyonu
{
    partial class girispaneli
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girispaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullanici_adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cıkıs = new System.Windows.Forms.PictureBox();
            this.btn_giris = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chc_sifre = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cıkıs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_giris)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 95);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSalmon;
            this.label5.Location = new System.Drawing.Point(268, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(425, 48);
            this.label5.TabIndex = 8;
            this.label5.Text = "Düzce Özel Kız Yurdu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 103);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(431, 264);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(184, 28);
            this.txt_sifre.TabIndex = 21;
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanici_adi.Location = new System.Drawing.Point(431, 219);
            this.txt_kullanici_adi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Size = new System.Drawing.Size(184, 28);
            this.txt_kullanici_adi.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(259, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(259, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(327, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 53);
            this.label2.TabIndex = 17;
            this.label2.Text = "Giriş Paneli";
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Image = ((System.Drawing.Image)(resources.GetObject("btn_cıkıs.Image")));
            this.btn_cıkıs.Location = new System.Drawing.Point(482, 319);
            this.btn_cıkıs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(84, 82);
            this.btn_cıkıs.TabIndex = 16;
            this.btn_cıkıs.TabStop = false;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.Image = ((System.Drawing.Image)(resources.GetObject("btn_giris.Image")));
            this.btn_giris.Location = new System.Drawing.Point(321, 319);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(84, 82);
            this.btn_giris.TabIndex = 15;
            this.btn_giris.TabStop = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Location = new System.Drawing.Point(0, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 41);
            this.panel2.TabIndex = 22;
            // 
            // chc_sifre
            // 
            this.chc_sifre.AutoSize = true;
            this.chc_sifre.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chc_sifre.Location = new System.Drawing.Point(650, 268);
            this.chc_sifre.Name = "chc_sifre";
            this.chc_sifre.Size = new System.Drawing.Size(131, 24);
            this.chc_sifre.TabIndex = 23;
            this.chc_sifre.Text = "Şifreyi Göster";
            this.chc_sifre.UseVisualStyleBackColor = true;
            this.chc_sifre.CheckedChanged += new System.EventHandler(this.chc_sifre_CheckedChanged);
            // 
            // girispaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 505);
            this.Controls.Add(this.chc_sifre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanici_adi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "girispaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Paneli";
            this.Load += new System.EventHandler(this.girispaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cıkıs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_giris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullanici_adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_cıkıs;
        private System.Windows.Forms.PictureBox btn_giris;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chc_sifre;
    }
}

