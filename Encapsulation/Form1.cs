using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Urun> urunler = new List<Urun>();   
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1!= null)
            {
                if (textBox2 != null)
                {
                    if (textBox3 != null)
                    {
                        Urun urun = new Urun()
                        {
                            Id = Convert.ToInt32(textBox1.Text),
                            Ad = textBox2.Text,
                            Fiyat =Convert.ToInt32(textBox3.Text)
                        };

                        urunler.Add(urun);
                        foreach (Urun item in urunler)
                        {
                            listBox1.Items.Add($"{item.Id}  {item.Ad}  {item.Fiyat}");
                        }
                        

                        foreach (Control item in groupBox1.Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = "";
                            }
                        }
                    }
                }
            }
        }
    }
}
