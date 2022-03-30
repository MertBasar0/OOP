﻿using _PiggyBank.Abstract;
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
            //comboBox1.Items.AddRange(Enum.GetNames(typeof(MoneyEnums)));
            comboBox1.Items.AddRange(pg.StartPiggy().ToArray());
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Banknot Money = comboBox1.SelectedItem as Banknot;

            //Coin Coin = comboBox1.SelectedItem as Coin;

            if (comboBox1.SelectedItem != null)
            {
                //string b = Enum.Parse(typeof(MoneyEnums), comboBox1.Text).ToString();

                Money = new Banknot();

                Money.CalculateAir();

                list.Add(Money);

                pg.TotalMoney = list;

                MessageBox.Show(pg.ControlCash().ToString("C"));

                pg.ControlCapacity();

                //else if (Coin.GetType() == typeof(Coin))
                //{
                //    Coin = new Coin();

                //    Coin.CalculateAir();

                //    list.Add(Coin);

                //    pg.TotalMoney = list;

                //    MessageBox.Show(pg.ControlCash().ToString("C"));

                //    pg.ControlCapacity();
                //}
            }

        }

        private void btn_Break_Click(object sender, EventArgs e)
        {
            pg.PiggyBreak();
        }

        private void btn_Shake_Click(object sender, EventArgs e)
        {

        }
    }
}