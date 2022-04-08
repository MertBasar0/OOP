namespace EventHandlerTekrar
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
            this.btn_calistir = new System.Windows.Forms.Button();
            this.lst_sonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_calistir
            // 
            this.btn_calistir.Location = new System.Drawing.Point(12, 22);
            this.btn_calistir.Name = "btn_calistir";
            this.btn_calistir.Size = new System.Drawing.Size(776, 49);
            this.btn_calistir.TabIndex = 0;
            this.btn_calistir.Text = "Çalıştır";
            this.btn_calistir.UseVisualStyleBackColor = true;
            this.btn_calistir.Click += new System.EventHandler(this.btn_calistir_Click);
            // 
            // lst_sonuc
            // 
            this.lst_sonuc.FormattingEnabled = true;
            this.lst_sonuc.Location = new System.Drawing.Point(12, 90);
            this.lst_sonuc.Name = "lst_sonuc";
            this.lst_sonuc.Size = new System.Drawing.Size(776, 342);
            this.lst_sonuc.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_sonuc);
            this.Controls.Add(this.btn_calistir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calistir;
        private System.Windows.Forms.ListBox lst_sonuc;
    }
}

