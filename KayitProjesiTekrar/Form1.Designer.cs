namespace KayitProjesiTekrar
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
            this.gb_personelBilgileri = new System.Windows.Forms.GroupBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_resimSec = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.cmb_unvan = new System.Windows.Forms.ComboBox();
            this.dtp_dogumT = new System.Windows.Forms.DateTimePicker();
            this.dtp_iseGiris = new System.Windows.Forms.DateTimePicker();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_tckn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_personelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_personelBilgileri
            // 
            this.gb_personelBilgileri.Controls.Add(this.btn_guncelle);
            this.gb_personelBilgileri.Controls.Add(this.button1);
            this.gb_personelBilgileri.Controls.Add(this.btn_sil);
            this.gb_personelBilgileri.Controls.Add(this.btn_resimSec);
            this.gb_personelBilgileri.Controls.Add(this.btn_ekle);
            this.gb_personelBilgileri.Controls.Add(this.picEmployee);
            this.gb_personelBilgileri.Controls.Add(this.txt_tel);
            this.gb_personelBilgileri.Controls.Add(this.cmb_unvan);
            this.gb_personelBilgileri.Controls.Add(this.dtp_dogumT);
            this.gb_personelBilgileri.Controls.Add(this.dtp_iseGiris);
            this.gb_personelBilgileri.Controls.Add(this.txt_adres);
            this.gb_personelBilgileri.Controls.Add(this.txt_mail);
            this.gb_personelBilgileri.Controls.Add(this.txt_soyad);
            this.gb_personelBilgileri.Controls.Add(this.txt_ad);
            this.gb_personelBilgileri.Controls.Add(this.txt_tckn);
            this.gb_personelBilgileri.Controls.Add(this.label7);
            this.gb_personelBilgileri.Controls.Add(this.label6);
            this.gb_personelBilgileri.Controls.Add(this.label4);
            this.gb_personelBilgileri.Controls.Add(this.label5);
            this.gb_personelBilgileri.Controls.Add(this.label3);
            this.gb_personelBilgileri.Controls.Add(this.label10);
            this.gb_personelBilgileri.Controls.Add(this.label2);
            this.gb_personelBilgileri.Controls.Add(this.label9);
            this.gb_personelBilgileri.Controls.Add(this.label1);
            this.gb_personelBilgileri.Location = new System.Drawing.Point(12, 12);
            this.gb_personelBilgileri.Name = "gb_personelBilgileri";
            this.gb_personelBilgileri.Size = new System.Drawing.Size(776, 262);
            this.gb_personelBilgileri.TabIndex = 0;
            this.gb_personelBilgileri.TabStop = false;
            this.gb_personelBilgileri.Text = "Personel Bilgileri";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(621, 168);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(134, 23);
            this.btn_guncelle.TabIndex = 8;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(621, 196);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(134, 23);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_resimSec
            // 
            this.btn_resimSec.Location = new System.Drawing.Point(621, 111);
            this.btn_resimSec.Name = "btn_resimSec";
            this.btn_resimSec.Size = new System.Drawing.Size(134, 23);
            this.btn_resimSec.TabIndex = 8;
            this.btn_resimSec.Text = "Resim Seç";
            this.btn_resimSec.UseVisualStyleBackColor = true;
            this.btn_resimSec.Click += new System.EventHandler(this.btn_resimSec_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(621, 139);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(134, 23);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // picEmployee
            // 
            this.picEmployee.Location = new System.Drawing.Point(311, 83);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(132, 114);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 7;
            this.picEmployee.TabStop = false;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(112, 151);
            this.txt_tel.Mask = "(999) 000-0000";
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(141, 20);
            this.txt_tel.TabIndex = 6;
            // 
            // cmb_unvan
            // 
            this.cmb_unvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unvan.FormattingEnabled = true;
            this.cmb_unvan.Location = new System.Drawing.Point(581, 73);
            this.cmb_unvan.Name = "cmb_unvan";
            this.cmb_unvan.Size = new System.Drawing.Size(174, 21);
            this.cmb_unvan.TabIndex = 5;
            // 
            // dtp_dogumT
            // 
            this.dtp_dogumT.Location = new System.Drawing.Point(112, 122);
            this.dtp_dogumT.Name = "dtp_dogumT";
            this.dtp_dogumT.Size = new System.Drawing.Size(141, 20);
            this.dtp_dogumT.TabIndex = 4;
            // 
            // dtp_iseGiris
            // 
            this.dtp_iseGiris.Location = new System.Drawing.Point(581, 39);
            this.dtp_iseGiris.Name = "dtp_iseGiris";
            this.dtp_iseGiris.Size = new System.Drawing.Size(174, 20);
            this.dtp_iseGiris.TabIndex = 4;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(112, 203);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(141, 20);
            this.txt_adres.TabIndex = 3;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(112, 177);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(141, 20);
            this.txt_mail.TabIndex = 3;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(112, 96);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(141, 20);
            this.txt_soyad.TabIndex = 3;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(112, 69);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(141, 20);
            this.txt_ad.TabIndex = 3;
            // 
            // txt_tckn
            // 
            this.txt_tckn.Location = new System.Drawing.Point(112, 43);
            this.txt_tckn.Name = "txt_tckn";
            this.txt_tckn.Size = new System.Drawing.Size(141, 20);
            this.txt_tckn.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(498, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ünvan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(498, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "İşe Giriş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TCKN";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 280);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 189);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TCKN";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşe giriş";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gb_personelBilgileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_personelBilgileri.ResumeLayout(false);
            this.gb_personelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_personelBilgileri;
        private System.Windows.Forms.ComboBox cmb_unvan;
        private System.Windows.Forms.DateTimePicker dtp_dogumT;
        private System.Windows.Forms.DateTimePicker dtp_iseGiris;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_tckn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MaskedTextBox txt_tel;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_resimSec;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button button1;
    }
}

