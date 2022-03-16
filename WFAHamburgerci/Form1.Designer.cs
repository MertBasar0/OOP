namespace WFAHamburgerci
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lst_siparisler = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_buyuk = new System.Windows.Forms.RadioButton();
            this.rb_orta = new System.Windows.Forms.RadioButton();
            this.rb_kucuk = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cb_menu = new System.Windows.Forms.ComboBox();
            this.btn_siparisEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_toplamTutar = new System.Windows.Forms.Label();
            this.btn_siparisOnay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_siparisler
            // 
            this.lst_siparisler.FormattingEnabled = true;
            this.lst_siparisler.Location = new System.Drawing.Point(460, 12);
            this.lst_siparisler.Name = "lst_siparisler";
            this.lst_siparisler.Size = new System.Drawing.Size(830, 394);
            this.lst_siparisler.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menü Seçin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_buyuk);
            this.groupBox1.Controls.Add(this.rb_orta);
            this.groupBox1.Controls.Add(this.rb_kucuk);
            this.groupBox1.Location = new System.Drawing.Point(15, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boyut Seçiniz..";
            // 
            // rb_buyuk
            // 
            this.rb_buyuk.AutoSize = true;
            this.rb_buyuk.Location = new System.Drawing.Point(352, 34);
            this.rb_buyuk.Name = "rb_buyuk";
            this.rb_buyuk.Size = new System.Drawing.Size(54, 17);
            this.rb_buyuk.TabIndex = 0;
            this.rb_buyuk.TabStop = true;
            this.rb_buyuk.Text = "büyük";
            this.rb_buyuk.UseVisualStyleBackColor = true;
            // 
            // rb_orta
            // 
            this.rb_orta.AutoSize = true;
            this.rb_orta.Location = new System.Drawing.Point(199, 34);
            this.rb_orta.Name = "rb_orta";
            this.rb_orta.Size = new System.Drawing.Size(43, 17);
            this.rb_orta.TabIndex = 0;
            this.rb_orta.TabStop = true;
            this.rb_orta.Text = "orta";
            this.rb_orta.UseVisualStyleBackColor = true;
            // 
            // rb_kucuk
            // 
            this.rb_kucuk.AutoSize = true;
            this.rb_kucuk.Location = new System.Drawing.Point(39, 34);
            this.rb_kucuk.Name = "rb_kucuk";
            this.rb_kucuk.Size = new System.Drawing.Size(55, 17);
            this.rb_kucuk.TabIndex = 0;
            this.rb_kucuk.TabStop = true;
            this.rb_kucuk.Text = "küçük";
            this.rb_kucuk.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(15, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(434, 106);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ekstra malzemeler";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 539);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(433, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_menu
            // 
            this.cb_menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_menu.FormattingEnabled = true;
            this.cb_menu.Location = new System.Drawing.Point(15, 237);
            this.cb_menu.Name = "cb_menu";
            this.cb_menu.Size = new System.Drawing.Size(433, 21);
            this.cb_menu.TabIndex = 7;
            // 
            // btn_siparisEkle
            // 
            this.btn_siparisEkle.Location = new System.Drawing.Point(15, 580);
            this.btn_siparisEkle.Name = "btn_siparisEkle";
            this.btn_siparisEkle.Size = new System.Drawing.Size(433, 53);
            this.btn_siparisEkle.TabIndex = 8;
            this.btn_siparisEkle.Text = "Sipariş Ekle";
            this.btn_siparisEkle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Toplam Tutar..";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_toplamTutar
            // 
            this.lbl_toplamTutar.AutoSize = true;
            this.lbl_toplamTutar.Location = new System.Drawing.Point(559, 423);
            this.lbl_toplamTutar.Name = "lbl_toplamTutar";
            this.lbl_toplamTutar.Size = new System.Drawing.Size(29, 13);
            this.lbl_toplamTutar.TabIndex = 9;
            this.lbl_toplamTutar.Text = "0 TL";
            // 
            // btn_siparisOnay
            // 
            this.btn_siparisOnay.Location = new System.Drawing.Point(1102, 453);
            this.btn_siparisOnay.Name = "btn_siparisOnay";
            this.btn_siparisOnay.Size = new System.Drawing.Size(187, 35);
            this.btn_siparisOnay.TabIndex = 10;
            this.btn_siparisOnay.Text = "Siparişi Onayla";
            this.btn_siparisOnay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 687);
            this.Controls.Add(this.btn_siparisOnay);
            this.Controls.Add(this.lbl_toplamTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_siparisEkle);
            this.Controls.Add(this.cb_menu);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lst_siparisler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_siparisler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_buyuk;
        private System.Windows.Forms.RadioButton rb_orta;
        private System.Windows.Forms.RadioButton rb_kucuk;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cb_menu;
        private System.Windows.Forms.Button btn_siparisEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_toplamTutar;
        private System.Windows.Forms.Button btn_siparisOnay;
    }
}

