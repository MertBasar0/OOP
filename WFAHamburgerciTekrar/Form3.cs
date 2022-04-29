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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txt_ExtraAdi.Text != null)
            {
                Form1.Extralar.Add(AddExtra());
                TemizlikSinifi.Temizle(this.Controls);
                MessageBox.Show($"{txt_ExtraAdi.Text} extralara eklendi..");
            }
        }

        public Extra AddExtra()
        {
            Extra extra = new Extra()
            {
                ExtraAdi = txt_ExtraAdi.Text,
                Fiyati = nmr_Fiyat.Value
            };

            return extra;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
