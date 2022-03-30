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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Enumlarda başlangıç indexine kendiniz değer atarsanız sonrakiler bu değerden devam eder.
        //Her birine kendiniz de değer atayabilirsiniz.

        //08.03 - 1.36.00
        enum sehiler
        {
            istanbul, izmir, ankara, adana, eskişehir
        }


        private void btn_islemYap_Click(object sender, EventArgs e)
        {

        }
    }
}
