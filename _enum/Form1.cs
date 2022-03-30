using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_depart.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();

            p.AdSoyad = txt_Ad.Text;
            p.Departman = (Departmanlar)Enum.Parse(typeof(Departmanlar), cmb_depart.Text);


            MessageBox.Show(p.ToString());
        }
    }
}
