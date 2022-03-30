namespace _PiggyBank
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Break = new System.Windows.Forms.Button();
            this.btn_Shake = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 420);
            this.listBox1.TabIndex = 8;
            // 
            // btn_Break
            // 
            this.btn_Break.Location = new System.Drawing.Point(601, 103);
            this.btn_Break.Name = "btn_Break";
            this.btn_Break.Size = new System.Drawing.Size(187, 54);
            this.btn_Break.TabIndex = 7;
            this.btn_Break.Text = "Kumbarayı Kır";
            this.btn_Break.UseVisualStyleBackColor = true;
            this.btn_Break.Click += new System.EventHandler(this.btn_Break_Click);
            // 
            // btn_Shake
            // 
            this.btn_Shake.Location = new System.Drawing.Point(417, 177);
            this.btn_Shake.Name = "btn_Shake";
            this.btn_Shake.Size = new System.Drawing.Size(187, 54);
            this.btn_Shake.TabIndex = 5;
            this.btn_Shake.Text = "Salla";
            this.btn_Shake.UseVisualStyleBackColor = true;
            this.btn_Shake.Click += new System.EventHandler(this.btn_Shake_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(239, 103);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(187, 54);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Para At";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(417, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 439);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Break);
            this.Controls.Add(this.btn_Shake);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Break;
        private System.Windows.Forms.Button btn_Shake;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

