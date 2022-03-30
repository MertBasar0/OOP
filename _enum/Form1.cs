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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Enum.Parse() fonsiyonu çağırılır ve int bir değişkene atanırsa seçili enumun
        //index değerini elde edebilirsiniz.

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_depart.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();

            p.AdSoyad = txt_Ad.Text;
            p.Departman = (Departmanlar)Enum.Parse(typeof(Departmanlar), cmb_depart.Text);

            int seciliEnumIndex = (int)Enum.Parse(typeof(Departmanlar),cmb_depart.Text);

            Departmanlar Cikacak;
            bool sonuc = Enum.TryParse<Departmanlar>(cmb_depart.Text, out Cikacak);

            if (sonuc)
            {
                switch (p.Departman)
                {
                    case Departmanlar.Yazilim:
                        MessageBox.Show("Hoşgeldin yazılımcı");
                        break;
                    case Departmanlar.GrafikTasarim:
                        MessageBox.Show("Hoşgeldin tasarımcı");
                        break;
                    case Departmanlar.InsanKaynaklari:
                        MessageBox.Show("hoşgeldin ik'cı");
                        break;
                    case Departmanlar.Muhasebe:
                        MessageBox.Show("Hoşgeldin Muhasebeci");
                        break;
                }
                MessageBox.Show("Personel departmani =>"+Cikacak.ToString()+" "+seciliEnumIndex.ToString());
            }
           
        }
    }
}