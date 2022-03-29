using PiggyBank.Coins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiggyBank.Banknots;
using PiggyBank.Concrate.Enums;

namespace PiggyBank
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
            comboBox1.Items.AddRange(Enum.GetNames(typeof(MoneyEnums)));
        }



        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null)
            {
                string b = Enum.Parse(typeof(MoneyEnums), comboBox1.Text).ToString();

                if (b.ToString() == "ElliLira")
                {
                    FiftyBanknot ft = new FiftyBanknot();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                else if (b.ToString() == "BesLira")
                {
                    FiveBanknot ft = new FiveBanknot();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                else if (b.ToString() == "YüzLira")
                {
                    HundredBanknot ft = new HundredBanknot();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                else if (b.ToString() == "OnLira")
                {
                    TenBanknot ft = new TenBanknot();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                else if (b.ToString() == "YirmiLira")
                {
                    TwentyBanknot ft = new TwentyBanknot();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                else if (b.ToString() == "IkiyuzLira")
                {
                    TwoHundredBanknot ft = new TwoHundredBanknot();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                else if (b.ToString() == "BirLira")
                {
                    OneLira ft = new OneLira();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                else if (b.ToString() == "BirKurus")
                {
                    OneKurus ft = new OneKurus();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                else if (b.ToString() == "BeşKurus")
                {
                    FiveKurus ft = new FiveKurus();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                else if (b.ToString() == "OnKurus")
                {
                    TenKurus ft = new TenKurus();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                else if (b.ToString() == "YirmiBeşKurus")
                {
                    TwentyFiveKurus ft = new TwentyFiveKurus();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                else if (b.ToString() == "ElliKurus")
                {
                    FiftyKurus ft = new FiftyKurus();
                    listBox1.Items.Add(ft.CalculateArea());
                    foreach (var item in ft.GetType().GetProperties())
                    {
                        listBox1.Items.Add(item.GetValue(ft));
                    }
                    list.Add(ft);
                }
                pg.TotalMoney = list;

                MessageBox.Show(pg.ControlCash().ToString("C"));
            }
        }
    }
}
