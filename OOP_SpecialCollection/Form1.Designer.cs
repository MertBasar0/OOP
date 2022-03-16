namespace OOP_SpecialCollection
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
            this.btn_HashTable = new System.Windows.Forms.Button();
            this.btn_ListDictionary = new System.Windows.Forms.Button();
            this.btn_HybridDictionary = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_HashTable
            // 
            this.btn_HashTable.Location = new System.Drawing.Point(12, 12);
            this.btn_HashTable.Name = "btn_HashTable";
            this.btn_HashTable.Size = new System.Drawing.Size(286, 39);
            this.btn_HashTable.TabIndex = 0;
            this.btn_HashTable.Text = "HashTable";
            this.btn_HashTable.UseVisualStyleBackColor = true;
            this.btn_HashTable.Click += new System.EventHandler(this.btn_HashTable_Click);
            // 
            // btn_ListDictionary
            // 
            this.btn_ListDictionary.Location = new System.Drawing.Point(12, 57);
            this.btn_ListDictionary.Name = "btn_ListDictionary";
            this.btn_ListDictionary.Size = new System.Drawing.Size(286, 39);
            this.btn_ListDictionary.TabIndex = 0;
            this.btn_ListDictionary.Text = "ListDictionary";
            this.btn_ListDictionary.UseVisualStyleBackColor = true;
            this.btn_ListDictionary.Click += new System.EventHandler(this.btn_ListDictionary_Click);
            // 
            // btn_HybridDictionary
            // 
            this.btn_HybridDictionary.Location = new System.Drawing.Point(12, 102);
            this.btn_HybridDictionary.Name = "btn_HybridDictionary";
            this.btn_HybridDictionary.Size = new System.Drawing.Size(286, 39);
            this.btn_HybridDictionary.TabIndex = 0;
            this.btn_HybridDictionary.Text = "HybridDictionary";
            this.btn_HybridDictionary.UseVisualStyleBackColor = true;
            this.btn_HybridDictionary.Click += new System.EventHandler(this.btn_HybridDictionary_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 277);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 458);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_HybridDictionary);
            this.Controls.Add(this.btn_ListDictionary);
            this.Controls.Add(this.btn_HashTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HashTable;
        private System.Windows.Forms.Button btn_ListDictionary;
        private System.Windows.Forms.Button btn_HybridDictionary;
        private System.Windows.Forms.ListBox listBox1;
    }
}

