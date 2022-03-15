namespace OOP
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
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_motor = new System.Windows.Forms.TextBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(21, 19);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(180, 20);
            this.txt_marka.TabIndex = 0;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(21, 45);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(180, 20);
            this.txt_model.TabIndex = 0;
            // 
            // txt_motor
            // 
            this.txt_motor.Location = new System.Drawing.Point(21, 71);
            this.txt_motor.Name = "txt_motor";
            this.txt_motor.Size = new System.Drawing.Size(180, 20);
            this.txt_motor.TabIndex = 0;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(80, 125);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(121, 40);
            this.btn_kayit.TabIndex = 1;
            this.btn_kayit.Text = "Kayıt";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(258, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 433);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.txt_motor);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_marka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_motor;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

