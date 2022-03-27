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
using Abstract;

namespace Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Bateri_Click(object sender, EventArgs e)
        {

            Müzisyen mz = new Müzisyen();
            mz.Adi = "Mert";
            mz.Tel = "123123";
            mz.CaldıgıAlet = new Bateri();
            mz.CaldıgıAlet.Marka = "Yamaha";
            mz.CaldıgıAlet.Aciklama = "pahali";
            MessageBox.Show(mz.Adi + "\n" + mz.Tel + "\n" + mz.CaldıgıAlet.Marka + "\n" + mz.CaldıgıAlet.Aciklama +"\n" + mz.CaldıgıAlet.Call());

        }

        private void btn_yanFlut_Click(object sender, EventArgs e)
        {
            Müzisyen k = new Müzisyen();
            k.Adi = "Saki Vatan";
            k.Tel = "121421";
            k.CaldıgıAlet=new YanFlüt();
            k.CaldıgıAlet.Marka = "honda";
            k.CaldıgıAlet.Aciklama = "ucuz";

            MessageBox.Show(k.Adi+"\n"+k.Tel+"\n"+k.CaldıgıAlet.Marka+"\n"+k.CaldıgıAlet.Aciklama+"\n"+k.CaldıgıAlet.Call());
        }

        private void btn_gitar_Click(object sender, EventArgs e)
        {
            Müzisyen k = new Müzisyen();
            k.Adi = "Melis Atalay";
            k.Tel = "5456546";
            k.CaldıgıAlet = new Gitar();
            k.CaldıgıAlet.Marka = "kawasaki";
            k.CaldıgıAlet.Aciklama = "çok pahalı";

            MessageBox.Show(k.Adi + "\n" + k.Tel + "\n" + k.CaldıgıAlet.Marka + "\n" + k.CaldıgıAlet.Aciklama + "\n" + k.CaldıgıAlet.Call());
        }
    }
}
