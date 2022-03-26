using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Math;  BU şekilde math sınıfının içinde bulunan bütün memberlara ulaşılabilir.

namespace Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            //ExtensionMethod.KarekterTemizle(textBox1);

            MessageBox.Show(FizikKütüphanesi.YercekimiKuvveti.ToString());
        }
    }

}
