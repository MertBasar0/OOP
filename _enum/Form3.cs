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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        enum sehirler
        {
            istanbul=34,adana=01,ankara=06,izmir=35,bursa=16,sivas=58
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int enumdeger = Convert.ToInt32(textBox1.Text);
            sehirler sehir = (sehirler)enumdeger;
            MessageBox.Show(sehir.ToString());
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(sehirler)))
            {
                listBox1.Items.Add(item + (int)Enum.Parse(typeof(sehirler), item));
            }
        }
    }
}
