using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerciTekrar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_menuAdi != null)
            {
                Form1.Menuler.Add(MenuAdd());
                TemizlikSinifi.Temizle(this.Controls);
                MessageBox.Show($"{txt_menuAdi.Text} Menulere eklendi..");
            } 
        }


        public Menu MenuAdd()
        {
            Menu menu = new Menu()
            {
                MenuAdi = txt_menuAdi.Text,
                Fiyati = nmr_Fiyat.Value
            };
            return menu;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
