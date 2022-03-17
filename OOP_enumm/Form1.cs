using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//enumdan departmanalrı combobox'a basıcak. Textbox 'dan isim soyisim alacak.listeye bastırıcak.

namespace OOP_enumm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.AdiSoyadi = textBox1.Text;
            p.departman = (Departmanlar)Enum.Parse(typeof(Departmanlar), comboBox1.SelectedItem.ToString());


            listBox1.Items.Add(p.AdiSoyadi);
            listBox1.Items.Add(p.departman);
            listBox1.Items.Add("----");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));
        }
    }
}
