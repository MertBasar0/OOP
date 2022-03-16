using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_IEnumerable_IEnumerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_TakimOyuncularınıGetir_Click(object sender, EventArgs e)
        {
            Futbolcu f1 = new Futbolcu() 
            {
                Adi = "Fernando Muslera",
                FormaNumarasi =1,
                Mevkisi = Mevkiler.Kaleci
            };

            Futbolcu f2 = new Futbolcu()
            {
                Adi = "Gökhan Tas",
                FormaNumarasi=2,
                Mevkisi= Mevkiler.Defans
            };

            Futbolcu f3 = new Futbolcu()
            {
                Adi = "Sabri Sarıoğlu",
                FormaNumarasi =3,
                Mevkisi = Mevkiler.Ortasaha
            };

            Futbolcu f4 = new Futbolcu()
            {
                Adi = "Tuncay Şanlı",
                FormaNumarasi = 10,
                Mevkisi = Mevkiler.Forvet
            };


            Takim YildizlarToplulugu = new Takim(f1, f2, f3, f4);

            foreach (var item in YildizlarToplulugu)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
    }
}
