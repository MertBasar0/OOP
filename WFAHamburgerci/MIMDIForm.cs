using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerci
{
    public partial class MIMDIForm : Form
    {
        public MIMDIForm()
        {
            InitializeComponent();
        }
        void ChildForm(Form childForm)
        {
            this.Width = childForm.Width +20 ;
            this.Height = childForm.Height + 68;

            bool durum = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item.Text == childForm.Text)
                {
                    durum = true;
                    item.Activate();
                }
                else
                {
                    item.Close();
                }
            }

            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }

        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());

        }
    }
}
