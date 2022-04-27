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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Siparis> siparis = new List<Siparis>();

        public static List<Siparis> mevcutSiparis = new List<Siparis>();

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu()
            {
                Id = 1,
                MenuAdi ="SteakHouse",
                Fiyati = 15
            },
            new Menu()
            {
                Id = 2,
                MenuAdi ="ChickenBurger",
                Fiyati = 7
            },
            new Menu()
            {
                Id = 3,
                MenuAdi ="Whooper",
                Fiyati=16
            },
            new Menu()
            {
                Id = 4,
                MenuAdi ="BigKing",
                Fiyati = 9
            }
        };

        public static List<Extra> Extralar = new List<Extra>()
        {
            new Extra()
            {
                Id=1,
                ExtraAdi = "Ranch",
                Fiyati = 2
            },
            new Extra()
            {
                Id = 2,
                ExtraAdi = "Soğan",
                Fiyati = 1
            }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Menuler)
            {
                cmbMenuler.Items.Add(item);
            }

            foreach (var item in Extralar)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item.ToString();
                checkBox.Tag = item;
                flowLayoutPanel1.Controls.Add(checkBox);   
            }

            foreach (var item in mevcutSiparis)
            {
                lst_Siparis.Items.Add(item.ToString());
            }

            cmbMenuler.SelectedIndex = 0;

        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            siparis.SeciliMenu = ((Menu)cmbMenuler.SelectedItem);

            if (rbOrta.Checked)
            {
                siparis.Boyutu = Boyut.Orta;
            }
            else if (rbBuyuk.Checked)
            {
                siparis.Boyutu = Boyut.Buyuk;
            }
            else
            {
                siparis.Boyutu = Boyut.Kucuk;
            }

            siparis.Extras = new List<Extra>();
            foreach (CheckBox item in flowLayoutPanel1.Controls)
            {
                if (item.Checked)
                {
                    siparis.Extras.Add((Extra)item.Tag);
                }
            }

            siparis.Adet = Convert.ToInt32(nmrAdet.Value);

            siparis.Hesapla();

            lst_Siparis.Items.Add(siparis.ToString());
        }
    }
}
