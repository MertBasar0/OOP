namespace OOP_Delegate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_sms = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_html = new System.Windows.Forms.Label();
            this.lbl_xml = new System.Windows.Forms.Label();
            this.lbl_db = new System.Windows.Forms.Label();
            this.btn_log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sms Log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail Log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xlm Log";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Html Log";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Db Log";
            // 
            // lbl_sms
            // 
            this.lbl_sms.AutoSize = true;
            this.lbl_sms.Location = new System.Drawing.Point(85, 30);
            this.lbl_sms.Name = "lbl_sms";
            this.lbl_sms.Size = new System.Drawing.Size(0, 13);
            this.lbl_sms.TabIndex = 0;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(85, 66);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(0, 13);
            this.lbl_mail.TabIndex = 1;
            // 
            // lbl_html
            // 
            this.lbl_html.AutoSize = true;
            this.lbl_html.Location = new System.Drawing.Point(85, 134);
            this.lbl_html.Name = "lbl_html";
            this.lbl_html.Size = new System.Drawing.Size(0, 13);
            this.lbl_html.TabIndex = 1;
            // 
            // lbl_xml
            // 
            this.lbl_xml.AutoSize = true;
            this.lbl_xml.Location = new System.Drawing.Point(85, 98);
            this.lbl_xml.Name = "lbl_xml";
            this.lbl_xml.Size = new System.Drawing.Size(0, 13);
            this.lbl_xml.TabIndex = 2;
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Location = new System.Drawing.Point(85, 167);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(0, 13);
            this.lbl_db.TabIndex = 2;
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(246, 85);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(109, 38);
            this.btn_log.TabIndex = 3;
            this.btn_log.Text = "Logla";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 310);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.lbl_db);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_xml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_html);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_sms);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_sms;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_html;
        private System.Windows.Forms.Label lbl_xml;
        private System.Windows.Forms.Label lbl_db;
        private System.Windows.Forms.Button btn_log;
    }
}

