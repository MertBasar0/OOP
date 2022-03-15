using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<araba> arabalar = new List<araba>();

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (txt_marka != null)
            {
                if (txt_model != null)
                {
                    if (txt_motor != null)
                    {
                        araba a1 = new araba(txt_marka.Text, txt_model.Text, Convert.ToInt32(txt_motor.Text));
                        arabalar.Add(a1);
                        foreach (var item in arabalar)
                        {
                            listBox1.Items.Add(item.Marka);
                            listBox1.Items.Add(item.Model);
                            listBox1.Items.Add(item.Motor);
                            listBox1.Items.Add("-------");
                        }
                    }
                }
            }
        }
    }
}
