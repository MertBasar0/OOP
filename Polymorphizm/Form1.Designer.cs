namespace Polymorphizm
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
            this.btn_Nokia = new System.Windows.Forms.Button();
            this.btn_Samsung = new System.Windows.Forms.Button();
            this.btn_Iphone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Nokia
            // 
            this.btn_Nokia.Location = new System.Drawing.Point(12, 29);
            this.btn_Nokia.Name = "btn_Nokia";
            this.btn_Nokia.Size = new System.Drawing.Size(125, 44);
            this.btn_Nokia.TabIndex = 0;
            this.btn_Nokia.Text = "Nokia";
            this.btn_Nokia.UseVisualStyleBackColor = true;
            this.btn_Nokia.Click += new System.EventHandler(this.btn_Nokia_Click);
            // 
            // btn_Samsung
            // 
            this.btn_Samsung.Location = new System.Drawing.Point(220, 29);
            this.btn_Samsung.Name = "btn_Samsung";
            this.btn_Samsung.Size = new System.Drawing.Size(125, 44);
            this.btn_Samsung.TabIndex = 1;
            this.btn_Samsung.Text = "Samsung";
            this.btn_Samsung.UseVisualStyleBackColor = true;
            this.btn_Samsung.Click += new System.EventHandler(this.btn_Samsung_Click);
            // 
            // btn_Iphone
            // 
            this.btn_Iphone.Location = new System.Drawing.Point(420, 29);
            this.btn_Iphone.Name = "btn_Iphone";
            this.btn_Iphone.Size = new System.Drawing.Size(125, 44);
            this.btn_Iphone.TabIndex = 2;
            this.btn_Iphone.Text = "Iphone";
            this.btn_Iphone.UseVisualStyleBackColor = true;
            this.btn_Iphone.Click += new System.EventHandler(this.btn_Iphone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 112);
            this.Controls.Add(this.btn_Iphone);
            this.Controls.Add(this.btn_Samsung);
            this.Controls.Add(this.btn_Nokia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Nokia;
        private System.Windows.Forms.Button btn_Samsung;
        private System.Windows.Forms.Button btn_Iphone;
    }
}

