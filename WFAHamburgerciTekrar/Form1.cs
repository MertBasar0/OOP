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
        public static List<Siparis> siparisler = new List<Siparis>();

        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

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

            foreach (var item in mevcutSiparisler)
            {
                lst_Siparis.Items.Add(item.ToString());
            }

            cmbMenuler.SelectedIndex = 0;

            rbKucuk.Checked = true;

        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();

            yeniSiparis.SeciliMenu = ((Menu)cmbMenuler.SelectedItem);

            if (rbOrta.Checked)
            {
                yeniSiparis.Boyutu = Boyut.Orta;
            }
            else if (rbBuyuk.Checked)
            {
                yeniSiparis.Boyutu = Boyut.Buyuk;
            }
            else
            {
                yeniSiparis.Boyutu = Boyut.Kucuk;
            }

            yeniSiparis.Extras = new List<Extra>();
            foreach (CheckBox item in flowLayoutPanel1.Controls)
            {
                if (item.Checked)
                {
                    yeniSiparis.Extras.Add((Extra)item.Tag);
                }
            }

            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);

            yeniSiparis.Hesapla();
            mevcutSiparisler.Add(yeniSiparis);

            lst_Siparis.Items.Add(yeniSiparis.ToString());

            ToplamTutar();

            TemizlikSinifi.Temizle(this.Controls);
        }

        decimal ToplamTutar()
        {
            decimal toplamTutar = 0;

            foreach (var item in mevcutSiparisler)
            {
                toplamTutar += item.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btn_SiparisOnay_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Ücreti : " + ToplamTutar().ToString("C2") + " Satın alma işlemine devam etmek istiyor musunuz ?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                lst_Siparis.Items.Clear();
                foreach (var item in mevcutSiparisler)
                {
                    siparisler.Add(item);
                }
                mevcutSiparisler.Clear();
                ToplamTutar();
                MessageBox.Show("Sipariş Tamamlandı.");
            }
            else
            {
                MessageBox.Show("Sipariş iptal edildi.");
            }
        }
    }
}