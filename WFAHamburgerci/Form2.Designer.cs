namespace WFAHamburgerci
{
    partial class Form2
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
            this.grb_menuBilgileri = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.nmr_fiyat = new System.Windows.Forms.NumericUpDown();
            this.txt_menuAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grb_menuBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_fiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_menuBilgileri
            // 
            this.grb_menuBilgileri.Controls.Add(this.btn_kaydet);
            this.grb_menuBilgileri.Controls.Add(this.nmr_fiyat);
            this.grb_menuBilgileri.Controls.Add(this.txt_menuAdi);
            this.grb_menuBilgileri.Controls.Add(this.label2);
            this.grb_menuBilgileri.Controls.Add(this.label1);
            this.grb_menuBilgileri.Location = new System.Drawing.Point(0, -2);
            this.grb_menuBilgileri.Name = "grb_menuBilgileri";
            this.grb_menuBilgileri.Size = new System.Drawing.Size(407, 242);
            this.grb_menuBilgileri.TabIndex = 0;
            this.grb_menuBilgileri.TabStop = false;
            this.grb_menuBilgileri.Text = "Menü Bilgileri";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(196, 120);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(114, 29);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // nmr_fiyat
            // 
            this.nmr_fiyat.Location = new System.Drawing.Point(112, 76);
            this.nmr_fiyat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_fiyat.Name = "nmr_fiyat";
            this.nmr_fiyat.Size = new System.Drawing.Size(198, 20);
            this.nmr_fiyat.TabIndex = 2;
            this.nmr_fiyat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_menuAdi
            // 
            this.txt_menuAdi.Location = new System.Drawing.Point(112, 30);
            this.txt_menuAdi.Name = "txt_menuAdi";
            this.txt_menuAdi.Size = new System.Drawing.Size(199, 20);
            this.txt_menuAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 241);
            this.Controls.Add(this.grb_menuBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.grb_menuBilgileri.ResumeLayout(false);
            this.grb_menuBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_fiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_menuBilgileri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.NumericUpDown nmr_fiyat;
        private System.Windows.Forms.TextBox txt_menuAdi;
    }
}