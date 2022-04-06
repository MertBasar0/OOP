namespace KayıtProjesi
{
    partial class Form1
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
            this.lst_personel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.pcb_resim = new System.Windows.Forms.PictureBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_resimSec = new System.Windows.Forms.Button();
            this.msk_phoneNo = new System.Windows.Forms.MaskedTextBox();
            this.cmb_Unvan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_Isegiristarihi = new System.Windows.Forms.DateTimePicker();
            this.dt_dogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTckimlikno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersonelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_personel
            // 
            this.lst_personel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lst_personel.FullRowSelect = true;
            this.lst_personel.HideSelection = false;
            this.lst_personel.Location = new System.Drawing.Point(12, 303);
            this.lst_personel.Name = "lst_personel";
            this.lst_personel.Size = new System.Drawing.Size(786, 279);
            this.lst_personel.TabIndex = 3;
            this.lst_personel.UseCompatibleStateImageBehavior = false;
            this.lst_personel.View = System.Windows.Forms.View.Details;
            this.lst_personel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_personel_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "tcKimlikNo";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşe Giriş Tarihi";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 101;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adres";
            this.columnHeader7.Width = 82;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ünvan";
            this.columnHeader8.Width = 84;
            // 
            // gbPersonelBilgileri
            // 
            this.gbPersonelBilgileri.Controls.Add(this.pcb_resim);
            this.gbPersonelBilgileri.Controls.Add(this.btn_temizle);
            this.gbPersonelBilgileri.Controls.Add(this.btn_sil);
            this.gbPersonelBilgileri.Controls.Add(this.btn_guncelle);
            this.gbPersonelBilgileri.Controls.Add(this.btn_ekle);
            this.gbPersonelBilgileri.Controls.Add(this.btn_resimSec);
            this.gbPersonelBilgileri.Controls.Add(this.msk_phoneNo);
            this.gbPersonelBilgileri.Controls.Add(this.cmb_Unvan);
            this.gbPersonelBilgileri.Controls.Add(this.label9);
            this.gbPersonelBilgileri.Controls.Add(this.label8);
            this.gbPersonelBilgileri.Controls.Add(this.dt_Isegiristarihi);
            this.gbPersonelBilgileri.Controls.Add(this.dt_dogumTarihi);
            this.gbPersonelBilgileri.Controls.Add(this.txtAdres);
            this.gbPersonelBilgileri.Controls.Add(this.txtMail);
            this.gbPersonelBilgileri.Controls.Add(this.txtSoyad);
            this.gbPersonelBilgileri.Controls.Add(this.txtAd);
            this.gbPersonelBilgileri.Controls.Add(this.txtTckimlikno);
            this.gbPersonelBilgileri.Controls.Add(this.label7);
            this.gbPersonelBilgileri.Controls.Add(this.label6);
            this.gbPersonelBilgileri.Controls.Add(this.label5);
            this.gbPersonelBilgileri.Controls.Add(this.label4);
            this.gbPersonelBilgileri.Controls.Add(this.label3);
            this.gbPersonelBilgileri.Controls.Add(this.label2);
            this.gbPersonelBilgileri.Controls.Add(this.label1);
            this.gbPersonelBilgileri.Location = new System.Drawing.Point(12, 12);
            this.gbPersonelBilgileri.Name = "gbPersonelBilgileri";
            this.gbPersonelBilgileri.Size = new System.Drawing.Size(786, 285);
            this.gbPersonelBilgileri.TabIndex = 2;
            this.gbPersonelBilgileri.TabStop = false;
            this.gbPersonelBilgileri.Text = "Ekleme Bilgileri";
            // 
            // pcb_resim
            // 
            this.pcb_resim.Location = new System.Drawing.Point(333, 117);
            this.pcb_resim.Name = "pcb_resim";
            this.pcb_resim.Size = new System.Drawing.Size(142, 128);
            this.pcb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_resim.TabIndex = 9;
            this.pcb_resim.TabStop = false;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(563, 252);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(195, 28);
            this.btn_temizle.TabIndex = 8;
            this.btn_temizle.Text = "temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(562, 218);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(195, 28);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(562, 184);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(195, 28);
            this.btn_guncelle.TabIndex = 8;
            this.btn_guncelle.Text = "Guncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(562, 150);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(195, 28);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_resimSec
            // 
            this.btn_resimSec.Location = new System.Drawing.Point(562, 118);
            this.btn_resimSec.Name = "btn_resimSec";
            this.btn_resimSec.Size = new System.Drawing.Size(195, 28);
            this.btn_resimSec.TabIndex = 8;
            this.btn_resimSec.Text = "Resim ekle";
            this.btn_resimSec.UseVisualStyleBackColor = true;
            this.btn_resimSec.Click += new System.EventHandler(this.btn_resimSec_Click);
            // 
            // msk_phoneNo
            // 
            this.msk_phoneNo.Location = new System.Drawing.Point(77, 161);
            this.msk_phoneNo.Mask = "(999) 000-0000";
            this.msk_phoneNo.Name = "msk_phoneNo";
            this.msk_phoneNo.Size = new System.Drawing.Size(178, 20);
            this.msk_phoneNo.TabIndex = 7;
            // 
            // cmb_Unvan
            // 
            this.cmb_Unvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Unvan.FormattingEnabled = true;
            this.cmb_Unvan.Location = new System.Drawing.Point(559, 81);
            this.cmb_Unvan.Name = "cmb_Unvan";
            this.cmb_Unvan.Size = new System.Drawing.Size(199, 21);
            this.cmb_Unvan.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ünvan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "İşe giriş tarihi";
            // 
            // dt_Isegiristarihi
            // 
            this.dt_Isegiristarihi.Location = new System.Drawing.Point(558, 41);
            this.dt_Isegiristarihi.Name = "dt_Isegiristarihi";
            this.dt_Isegiristarihi.Size = new System.Drawing.Size(200, 20);
            this.dt_Isegiristarihi.TabIndex = 4;
            // 
            // dt_dogumTarihi
            // 
            this.dt_dogumTarihi.Location = new System.Drawing.Point(77, 132);
            this.dt_dogumTarihi.Name = "dt_dogumTarihi";
            this.dt_dogumTarihi.Size = new System.Drawing.Size(178, 20);
            this.dt_dogumTarihi.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(77, 229);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(178, 20);
            this.txtAdres.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(77, 195);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(178, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(77, 100);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(178, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(77, 68);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(178, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtTckimlikno
            // 
            this.txtTckimlikno.Location = new System.Drawing.Point(77, 40);
            this.txtTckimlikno.Name = "txtTckimlikno";
            this.txtTckimlikno.Size = new System.Drawing.Size(178, 20);
            this.txtTckimlikno.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doğum tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tc kimlik no";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 589);
            this.Controls.Add(this.lst_personel);
            this.Controls.Add(this.gbPersonelBilgileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPersonelBilgileri.ResumeLayout(false);
            this.gbPersonelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_personel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox gbPersonelBilgileri;
        private System.Windows.Forms.PictureBox pcb_resim;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_resimSec;
        private System.Windows.Forms.MaskedTextBox msk_phoneNo;
        private System.Windows.Forms.ComboBox cmb_Unvan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_Isegiristarihi;
        private System.Windows.Forms.DateTimePicker dt_dogumTarihi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTckimlikno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btn_temizle;
    }
}

