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

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kaleci kl = new Kaleci() { AdiSoyadi = "Muslera",FormaNumarasi="1", Dayaniklilik=30 ,Agresiflik =2,MilliMi=true,Refleks=100,SutGucu=4};

        Defans df = new Defans()
        {
            AdiSoyadi = "Sabri Sarı",
            Agresiflik = 98,
            FormaNumarasi="55",
            MilliMi=true,
            Refleks=2,
            SutGucu=70,
            Dayaniklilik = 30
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(kl);
            listBox1.Items.Add(df);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (listBox1.SelectedItem.GetType() == typeof(Kaleci))
            {  
                Kaleci k = listBox1.SelectedItem as Kaleci;
                
                foreach (PropertyInfo item in k.GetType().GetProperties())
                {
                    Label lb = new Label();
                    flowLayoutPanel1.Controls.Add(lb);
                    lb.Text = item.Name + " :" + item.GetValue(k);
                    lb.AutoSize = false;
                    lb.Width = 100;
                    lb.Height = 20;
                    
                }
            }
            else if (listBox1.SelectedItem.GetType() == typeof(Defans))
            {
                Defans d = (Defans)listBox1.SelectedItem;

                foreach (PropertyInfo item in d.GetType().GetProperties())
                {
                    Label lbl = new Label();
                    flowLayoutPanel1.Controls.Add(lbl);
                    lbl.Text = item.Name+" "+item.GetValue(d);
                }
            }
        }
    }
}
