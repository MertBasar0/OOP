using _PiggyBank.Consrate.Banknots;
using _PiggyBank.Consrate.Coins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PiggyBank.Abstract
{
    public class Piggy
    {
        private int _breakCount;



        public decimal Capacity { get; } = 6000.00M;

        public decimal CashValue { get; set; }

        public List<IMoney> TotalMoney { get; set; }

        public int ShakeCount { get; set; }

        public int BreakCount
        {
            get { return _breakCount; }
            set
            {
                if (value < 2)
                {
                    _breakCount = value;
                }
                else
                {
                    MessageBox.Show("Kumbara artık yapıştırılamaz..");
                    BreakCount = 0;
                }

            }
        }


        public bool ControlCapacity()
        {
            decimal _total = 0;
            foreach (IMoney money in TotalMoney)
            {


                _total += money.CalculateArea();
            }
            if (Capacity <= _total)
            {
                MessageBox.Show("Kumbara doldu");

                PiggyBreak();

                return true;
            }
            else
            {
                return false;
            }
        }


        public decimal ControlCash()
        {
            decimal _total = 0;
            foreach (IMoney money in TotalMoney)
            {
                _total += money.Amount;
            }
            CashValue = _total;
            return _total;
        }


        public void PiggyBreak()
        {
            MessageBox.Show($"{CashValue} tl para biriktirdiniz..");
            CashValue = 0;
            TotalMoney.Clear();
            BreakCount++;
            if (BreakCount == 2)
            {
                ShakeCount = 0;
                BreakCount = 0;
            }
        }


        public List<IMoney> StartPiggy()
        {
            List<IMoney> list = new List<IMoney>();

            FiftyBanknot ft = new FiftyBanknot(); list.Add(ft);
            FiveBanknot ff = new FiveBanknot(); list.Add(ff);
            HundredBanknot hf = new HundredBanknot(); list.Add(hf);
            TenBanknot ten = new TenBanknot(); list.Add(ten);
            TwentyBanknot twenty = new TwentyBanknot(); list.Add(twenty);
            TwoHundredBanknot two = new TwoHundredBanknot(); list.Add(two);
            FiftyKurus kf = new FiftyKurus(); list.Add(kf);
            FiveKurus f = new FiveKurus(); list.Add(f);
            OneKurus one = new OneKurus(); list.Add(one);
            OneLira oneLira = new OneLira(); list.Add(oneLira);
            TenKurus tenkurus = new TenKurus(); list.Add(tenkurus);
            TwentyFiveKurus tw = new TwentyFiveKurus(); list.Add(tw);

            return list;
        }


        public void ShakePiggy()
        {
            //decimal _totalAir = 0;
            //decimal _totalMinAir = 0;
            //foreach (IMoney item in TotalMoney)
            //{
            //    Capacity -= item.Air;
            //    _totalMinAir += item.MinAir;
            //}
            //Capacity -
        }

    }
}
