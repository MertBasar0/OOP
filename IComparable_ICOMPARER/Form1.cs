using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IComparable_ICOMPARER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Takim> puanDurumu = new List<Takim>();

        private void listViewDoldur()
        {
            int siralama = 1;
            foreach (var item in puanDurumu)
            {
                ListViewItem lvi = new ListViewItem(siralama.ToString());

                lvi.SubItems.Add(item.Adi);
                lvi.SubItems.Add(item.Averaji.ToString());
                lvi.SubItems.Add(item.Puani.ToString());

                siralama++;
                listView1.Items.Add(lvi);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            puanDurumu.Add(new Takim { Adi = "Galatasaray", Averaji = 50, Puani = 74 });
            puanDurumu.Add(new Takim { Adi = "Fenerbahçe", Averaji = 40, Puani = 80 });
            puanDurumu.Add(new Takim { Adi = "Beşiktaş", Averaji = 60, Puani = 75 });
            puanDurumu.Add(new Takim { Adi = "Sivasspor", Averaji = 80, Puani = 65 });
            puanDurumu.Sort();
            listViewDoldur();
        }
    }
}
