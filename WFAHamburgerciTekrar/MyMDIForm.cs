using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerciTekrar
{
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            ChildForm(form);
        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            ChildForm(form);
        }

        private void extraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            ChildForm(form);
        }

        private void siparişBİlgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            ChildForm(form);
        }

        void ChildForm(Form childForm)
        {
            this.Width = childForm.Width + 25;
            this.Height = childForm.Height + 68;

            childForm.ShowDialog();
        }
    }
}
