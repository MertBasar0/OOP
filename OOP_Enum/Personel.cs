using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Enum
{
    public enum Departmanlar
    {
        Muhasebe, SistemVeAgUzmanligi, GrafikTasarim, Yazilim, Ingilizce
    }


    public class Personel
    {
        private string _adisoyadi;

        public string AdiSoyadi
        {
            get { return _adisoyadi; }
            set { _adisoyadi = value; }
        }


        private Departmanlar departman;

        public Departmanlar Departman
        {
            get { return departman; }
            set { departman = value; }
        }


        public static void Listeyedoldur(TextBox adi, ComboBox departman, ListBox liste)
        {
            Personel p = new Personel();

            p.AdiSoyadi = adi.Text;
            p.Departman = (Departmanlar)Enum.Parse(typeof(Departmanlar), departman.Text);


            //liste.Items.Add(p.AdiSoyadi);
            //liste.Items.Add(p.Departman);
            //liste.Items.Add("---");
            MessageBox.Show($"{p.AdiSoyadi}  {p.Departman}");
        }
    }

}


