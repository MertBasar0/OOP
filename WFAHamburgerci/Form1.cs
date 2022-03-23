using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<menu> Menuler = new List<menu>()
        {
            new menu(){MenuAdi = "StaakBurger", Fiyat=18.25m},
            new menu(){MenuAdi = "Whooper", Fiyat=8},
            new menu(){MenuAdi = "BigKing", Fiyat=12},
            new menu(){MenuAdi = "Chicken Royal", Fiyat=13.75m},
            new menu(){MenuAdi = "King Chicken", Fiyat=11}
        };

        public static List<Siparis> MevcutSiparisler = new List<Siparis>();


        public static List<Siparis> EskiSiparisler = new List<Siparis>();



        public static List<Extra> extralar = new List<Extra>() 
        {
            new Extra(){ExtraAdi ="Ranch sos", Fiyat =2.5m },
            new Extra(){ExtraAdi ="Hardal", Fiyat = 1.5m},
            new Extra(){ExtraAdi ="BBQ", Fiyat=(3)},
            new Extra(){ExtraAdi ="Buffalo sos", Fiyat=1.5m}
        }; 


        private void btn_siparisEkle_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();
            s.SeciliMenu = (menu)cb_menu.SelectedItem;

            if (rb_buyuk.Checked)
            {
                s.Boyutu = BoyutEnum.Buyuk;
            }
            else if(rb_orta.Checked)
            {
                s.Boyutu = BoyutEnum.Orta;
            }
            else
            {
                s.Boyutu = BoyutEnum.Kucuk;
            }


            s.ExtraMalzemeler =  new List<Extra>();
            foreach (CheckBox item in flw_Extramalzemeler.Controls)
            {
                if (item.Checked )
                {
                    s.ExtraMalzemeler.Add((Extra)item.Tag);
                }
            }

            //s.ExtraMalzemeler = new List<Extra>(); // Çalış
            //foreach (CheckBox item in flw_Extramalzemeler.Controls)
            //{
            //    if (item.Checked)
            //    {
            //        s.ExtraMalzemeler.Add((Extra)item.Tag);
            //    }
            //}

            s.Adet = Convert.ToInt32(numericUpDown1.Value);

            s.Hesapla();
            MevcutSiparisler.Add(s);
            lst_siparisler.Items.Add(s);
            EskiSiparisler.Add(s);         
            lbl_toplamTutar.Text = ToplamTutar().ToString();

            Temizlik.Temizle(this.Controls);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (menu item in Menuler)
            {
                cb_menu.Items.Add(item);
            }

            foreach (Extra ex in extralar)
            {
                flw_Extramalzemeler.Controls.Add(new CheckBox() { Text = ex.ExtraAdi, Tag = ex });// Çalış
            }

            cb_menu.SelectedIndex = 0;

            rb_kucuk.Checked = true;
        }

        decimal ToplamTutar()
        {

            decimal toplam = 0;
            foreach (Siparis item in MevcutSiparisler)
            {
                toplam +=item.ToplamTutar;
            }
            return toplam;
        }

        private void btn_siparisOnay_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Toplam sipariş ücreti : {ToplamTutar().ToString("C2")}  Satın alma işlemine devam etmek istiyor musunuz ?", "Sipariş Bilgisi", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Sipariş Tamamlandı.." + ToplamTutar());
                MevcutSiparisler.Clear();
                lst_siparisler.Items.Clear();
                lbl_toplamTutar.Text = "0";
            }
            else
            {      
                MessageBox.Show("Siparişiniz iptal edildi..");
                MevcutSiparisler.Clear();
                lst_siparisler.Items.Clear();
                lbl_toplamTutar.Text = "0";
            }
        }

        private void btn_gecis_Click(object sender, EventArgs e)
        {
            Form4 FRM = new Form4();
            FRM.ShowDialog();
        }
    }
}
