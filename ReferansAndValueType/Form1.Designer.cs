namespace ReferansAndValueType
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
            this.btn_referenceType = new System.Windows.Forms.Button();
            this.btn_valueType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_referenceType
            // 
            this.btn_referenceType.Location = new System.Drawing.Point(11, 13);
            this.btn_referenceType.Name = "btn_referenceType";
            this.btn_referenceType.Size = new System.Drawing.Size(263, 110);
            this.btn_referenceType.TabIndex = 0;
            this.btn_referenceType.Text = "ReferenceType";
            this.btn_referenceType.UseVisualStyleBackColor = true;
            this.btn_referenceType.Click += new System.EventHandler(this.btn_referenceType_Click);
            // 
            // btn_valueType
            // 
            this.btn_valueType.Location = new System.Drawing.Point(12, 129);
            this.btn_valueType.Name = "btn_valueType";
            this.btn_valueType.Size = new System.Drawing.Size(262, 111);
            this.btn_valueType.TabIndex = 1;
            this.btn_valueType.Text = "ValueType";
            this.btn_valueType.UseVisualStyleBackColor = true;
            this.btn_valueType.Click += new System.EventHandler(this.btn_valueType_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 288);
            this.Controls.Add(this.btn_valueType);
            this.Controls.Add(this.btn_referenceType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_referenceType;
        private System.Windows.Forms.Button btn_valueType;
    }
}

