using _PiggyBank.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PiggyBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Piggy pg = new Piggy();
        List<IMoney> list = new List<IMoney>();


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(pg.StartPiggy().ToArray());
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            IMoney Money = comboBox1.SelectedItem as IMoney;

            if (comboBox1.SelectedItem != null)
            {

                IMoney Clonemoney = Money.Clone();

                Clonemoney.CalculateAir();

                list.Add(Clonemoney);

                pg.TotalMoney = list;

                MessageBox.Show(pg.ControlCash().ToString("C"));

                pg.ControlCapacity();

                pg.ShowAir(lbl_air);
            }

        }

        private void btn_Break_Click(object sender, EventArgs e)
        {
            pg.PiggyBreak();
        }

        private void btn_Shake_Click(object sender, EventArgs e)
        {
            pg.ShakePiggy();
            pg.ShowAir(lbl_air);
        }
    }
}
