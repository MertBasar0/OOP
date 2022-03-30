namespace _enum
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
            this.btn_islemYap = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_islemYap
            // 
            this.btn_islemYap.Location = new System.Drawing.Point(81, 259);
            this.btn_islemYap.Name = "btn_islemYap";
            this.btn_islemYap.Size = new System.Drawing.Size(100, 25);
            this.btn_islemYap.TabIndex = 0;
            this.btn_islemYap.Text = "İşlem Yap";
            this.btn_islemYap.UseVisualStyleBackColor = true;
            this.btn_islemYap.Click += new System.EventHandler(this.btn_islemYap_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 225);
            this.listBox1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 367);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_islemYap);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_islemYap;
        private System.Windows.Forms.ListBox listBox1;
    }
}