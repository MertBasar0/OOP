namespace PiggyBank
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_Break = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Shake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(417, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(239, 105);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(187, 54);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.Text = "Para At";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_Break
            // 
            this.btn_Break.Location = new System.Drawing.Point(601, 105);
            this.btn_Break.Name = "btn_Break";
            this.btn_Break.Size = new System.Drawing.Size(187, 54);
            this.btn_Break.TabIndex = 2;
            this.btn_Break.Text = "Kumbarayı Kır";
            this.btn_Break.UseVisualStyleBackColor = true;
            this.btn_Break.Click += new System.EventHandler(this.btn_Break_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 420);
            this.listBox1.TabIndex = 3;
            // 
            // btn_Shake
            // 
            this.btn_Shake.Location = new System.Drawing.Point(417, 179);
            this.btn_Shake.Name = "btn_Shake";
            this.btn_Shake.Size = new System.Drawing.Size(187, 54);
            this.btn_Shake.TabIndex = 1;
            this.btn_Shake.Text = "Salla";
            this.btn_Shake.UseVisualStyleBackColor = true;
            this.btn_Shake.Click += new System.EventHandler(this.btn_Shake_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_Break;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Shake;
    }
}

