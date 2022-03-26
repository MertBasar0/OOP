namespace Abstract
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
            this.btn_Bateri = new System.Windows.Forms.Button();
            this.btn_yanFlut = new System.Windows.Forms.Button();
            this.btn_gitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Bateri
            // 
            this.btn_Bateri.Location = new System.Drawing.Point(250, 12);
            this.btn_Bateri.Name = "btn_Bateri";
            this.btn_Bateri.Size = new System.Drawing.Size(260, 101);
            this.btn_Bateri.TabIndex = 0;
            this.btn_Bateri.Text = "Bateri";
            this.btn_Bateri.UseVisualStyleBackColor = true;
            this.btn_Bateri.Click += new System.EventHandler(this.btn_Bateri_Click);
            // 
            // btn_yanFlut
            // 
            this.btn_yanFlut.Location = new System.Drawing.Point(250, 152);
            this.btn_yanFlut.Name = "btn_yanFlut";
            this.btn_yanFlut.Size = new System.Drawing.Size(260, 101);
            this.btn_yanFlut.TabIndex = 1;
            this.btn_yanFlut.Text = "YanFlüt";
            this.btn_yanFlut.UseVisualStyleBackColor = true;
            this.btn_yanFlut.Click += new System.EventHandler(this.btn_yanFlut_Click);
            // 
            // btn_gitar
            // 
            this.btn_gitar.Location = new System.Drawing.Point(250, 309);
            this.btn_gitar.Name = "btn_gitar";
            this.btn_gitar.Size = new System.Drawing.Size(260, 101);
            this.btn_gitar.TabIndex = 1;
            this.btn_gitar.Text = "Gitar";
            this.btn_gitar.UseVisualStyleBackColor = true;
            this.btn_gitar.Click += new System.EventHandler(this.btn_gitar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_gitar);
            this.Controls.Add(this.btn_yanFlut);
            this.Controls.Add(this.btn_Bateri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Bateri;
        private System.Windows.Forms.Button btn_yanFlut;
        private System.Windows.Forms.Button btn_gitar;
    }
}

