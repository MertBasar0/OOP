namespace SpecialCollections
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
            this.btn_hashTable = new System.Windows.Forms.Button();
            this.btn_hybridDictionary = new System.Windows.Forms.Button();
            this.btn_listDictionary = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_hashTable
            // 
            this.btn_hashTable.Location = new System.Drawing.Point(12, 39);
            this.btn_hashTable.Name = "btn_hashTable";
            this.btn_hashTable.Size = new System.Drawing.Size(389, 54);
            this.btn_hashTable.TabIndex = 0;
            this.btn_hashTable.Text = "HashTable";
            this.btn_hashTable.UseVisualStyleBackColor = true;
            this.btn_hashTable.Click += new System.EventHandler(this.btn_hashTable_Click);
            // 
            // btn_hybridDictionary
            // 
            this.btn_hybridDictionary.Location = new System.Drawing.Point(12, 195);
            this.btn_hybridDictionary.Name = "btn_hybridDictionary";
            this.btn_hybridDictionary.Size = new System.Drawing.Size(389, 54);
            this.btn_hybridDictionary.TabIndex = 1;
            this.btn_hybridDictionary.Text = "HybridDictionary";
            this.btn_hybridDictionary.UseVisualStyleBackColor = true;
            this.btn_hybridDictionary.Click += new System.EventHandler(this.btn_hybridDictionary_Click);
            // 
            // btn_listDictionary
            // 
            this.btn_listDictionary.Location = new System.Drawing.Point(12, 116);
            this.btn_listDictionary.Name = "btn_listDictionary";
            this.btn_listDictionary.Size = new System.Drawing.Size(389, 54);
            this.btn_listDictionary.TabIndex = 2;
            this.btn_listDictionary.Text = "ListDictionary";
            this.btn_listDictionary.UseVisualStyleBackColor = true;
            this.btn_listDictionary.Click += new System.EventHandler(this.btn_listDictionary_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(389, 251);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 539);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_listDictionary);
            this.Controls.Add(this.btn_hybridDictionary);
            this.Controls.Add(this.btn_hashTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hashTable;
        private System.Windows.Forms.Button btn_hybridDictionary;
        private System.Windows.Forms.Button btn_listDictionary;
        private System.Windows.Forms.ListBox listBox1;
    }
}

