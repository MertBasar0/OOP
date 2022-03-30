using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTekrarınTekrarı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kaleci kl = new Kaleci()
        {
            AdSoyad = "Muslera",
            FormaNo = 1,
            Refleks = 4,
            Agresiflik = 2,
            Dayanılılık = 3,
            SutGucu = 1,
            MilliMi = true,
        };

        Defans df = new Defans()
        {
            AdSoyad = "Sabri Sari",
            FormaNo = 2,
            Refleks = 2,
            Agresiflik = 3,
            Dayanılılık = 3,
            SutGucu = 2,
            MilliMi = true,
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(kl);
            listBox1.Items.Add(df);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Kaleci kl = listBox1.SelectedItem as Kaleci;
            Defans df = listBox1.SelectedItem as Defans;

            //////////// UZUN YOL  /////////////

            //if (listBox1.SelectedItem.GetType() == typeof(Kaleci))
            //{
            //    flowLayoutPanel1.Controls.Clear();
            //    foreach (PropertyInfo item in listBox1.SelectedItem.GetType().GetProperties())
            //    {
            //        Label lb = new Label();
            //        lb.Text = item.Name+" "+item.GetValue(kl);
            //        flowLayoutPanel1.Controls.Add(lb);
            //    }
            //}
            //else if (listBox1.SelectedItem.GetType() == typeof(Defans))
            //{
            //    flowLayoutPanel1.Controls.Clear();
            //    foreach (PropertyInfo item in listBox1.SelectedItem.GetType().GetProperties())
            //    {
            //        Label lb = new Label();
            //        lb.Text = item.Name+" "+ item.GetValue(df);
            //        flowLayoutPanel1.Controls.Add(lb);
            //    }
            //}


            /////////////KISA YOL /////////////////

            if (listBox1.SelectedItem.GetType().GetInterface("IFutbolcu") == typeof(IFutbolcu))
            {
                IFutbolcu ft = listBox1.SelectedItem as IFutbolcu;
                flowLayoutPanel1.Controls.Clear();
                foreach (PropertyInfo item in ft.GetType().GetInterface("IFutbolcu").GetProperties())
                {
                    Label lb = new Label();
                    lb.Text = item.Name+" "+ item.GetValue(ft);
                    flowLayoutPanel1.Controls.Add(lb);
                }
            }
        }
    }
}
