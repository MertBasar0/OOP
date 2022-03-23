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

namespace InterfaceTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kaleci kl = new Kaleci()
        {
            FormaNo = 1,
            AdiSoyadi = "Muslera",
            Agresiflik = 2,
            SutGucu = 3,
            Dayaniklilik = 4,
            Refleks = 5,
            MilliMi = true
        };
        Defans df = new Defans()
        {
            FormaNo = 2,
            AdiSoyadi = "Sabri Sari",
            Agresiflik = 4,
            SutGucu = 3,
            Dayaniklilik = 5,
            Refleks = 4,
            MilliMi = true
        };
        Forvet fv = new Forvet()
        {
            FormaNo = 3,
            AdiSoyadi = "Drogba",
            Agresiflik = 4,
            SutGucu = 5,
            Dayaniklilik = 3,
            Refleks = 2,
            MilliMi = true
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(kl);
            listBox1.Items.Add(df);
            listBox1.Items.Add(fv);
        }


        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
           
            //if (listBox1.SelectedItem.GetType() == typeof(Kaleci))
            //{
            //    Kaleci c = listBox1.SelectedItem as Kaleci;

            //    foreach (PropertyInfo item in c.GetType().GetProperties())
            //    {
            //        Label label = new Label();
            //        flowLayoutPanel1.Controls.Add(label);
            //        label.Text = item.Name + item.GetValue(c);
            //    }
            //}
            //else if (listBox1.SelectedItem.GetType() == typeof(Defans))
            //{
            //    Defans d = listBox1.SelectedItem as Defans;

            //    foreach (var item in d.GetType().GetProperties())
            //    {
            //        Label lb = new Label();
            //        flowLayoutPanel1.Controls.Add(lb);
            //        lb.Text = item.Name + item.GetValue(d);
            //    }
            //}
            if (listBox1.SelectedItem != null && listBox1.SelectedItem.GetType().GetInterface("IFutbolcu") == typeof(IFutbolcu))
            {
                IFutbolcu f = listBox1.SelectedItem as IFutbolcu;

                foreach (var item in f.GetType().GetProperties())
                {
                    Label lbl = new Label();
                    flowLayoutPanel1.Controls.Add(lbl);
                    lbl.Text = item.Name + item.GetValue(f);
                }
            }
        }
    }
}
