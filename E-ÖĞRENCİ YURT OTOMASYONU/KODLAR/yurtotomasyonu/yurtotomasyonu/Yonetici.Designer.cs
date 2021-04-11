namespace yurtotomasyonu
{
    partial class Yonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.txt_kullanici_adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_sil);
            this.panel1.Controls.Add(this.btn_kaydet);
            this.panel1.Controls.Add(this.txt_parola);
            this.panel1.Controls.Add(this.txt_kullanici_adi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(267, 246);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 295);
            this.panel1.TabIndex = 0;
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(317, 208);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(137, 51);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.Location = new System.Drawing.Point(66, 208);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(133, 51);
            this.btn_kaydet.TabIndex = 4;
            this.btn_kaydet.Text = "   Kaydet";
            this.btn_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_parola
            // 
            this.txt_parola.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_parola.Location = new System.Drawing.Point(213, 137);
            this.txt_parola.Margin = new System.Windows.Forms.Padding(4);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(196, 28);
            this.txt_parola.TabIndex = 3;
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanici_adi.Location = new System.Drawing.Point(213, 66);
            this.txt_kullanici_adi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Size = new System.Drawing.Size(196, 28);
            this.txt_kullanici_adi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parolası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 166);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(567, 28);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 166);
            this.dataGridView2.TabIndex = 2;
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anasayfa.Location = new System.Drawing.Point(829, 454);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(182, 55);
            this.btn_anasayfa.TabIndex = 37;
            this.btn_anasayfa.Text = "Anasayfaya Dön";
            this.btn_anasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // Yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Yonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yonetici";
            this.Load += new System.EventHandler(this.Yonetici_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.TextBox txt_kullanici_adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}