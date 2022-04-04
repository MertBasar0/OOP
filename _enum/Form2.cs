using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _enum
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Enum'a byte implemente ederek index değerlerinin byte olarak tutulmasını sağlayabilirsiniz.

        enum sehiler : byte
        {
            istanbul, izmir, ankara, adana, eskişehir
        }


        private void btn_islemYap_Click(object sender, EventArgs e)
        {
            byte index = (byte)Enum.Parse(typeof(sehiler), listBox1.Text);
            MessageBox.Show($"Seçili şehir indexi: {index}");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Enum.GetNames(typeof(sehiler)));
            //Indexten herhangi bir enum değerine ulaşmak isterseniz;
            //sehiler gelen = (sehiler)Enum.Parse(typeof(sehiler), "2");
        }
    }
}
