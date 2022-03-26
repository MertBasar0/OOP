using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasePhone basePhone = new BasePhone();
            basePhone.CallSound();
        }

        private void btn_Nokia_Click(object sender, EventArgs e)
        {
            Nokia nk = new Nokia();
            nk.CallSound();
        }

        private void btn_Iphone_Click(object sender, EventArgs e)
        {
            Iphone ip = new Iphone();
            ip.CallSound();
        }

        private void btn_Samsung_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.CallSound();
        }


    }
}
