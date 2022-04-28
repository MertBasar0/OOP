using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerciTekrar
{
    public static class TemizlikSinifi
    {

        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control control in koleksiyon)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = " ";
                }
                else if (control is ComboBox)
                {
                    ComboBox cB = (ComboBox)control;
                    cB.SelectedIndex = 0;
                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown nU = (NumericUpDown)control;
                    nU.Value = 1;
                }
                else if (control is GroupBox)
                {
                    foreach (var item in ((GroupBox)control).Controls)
                    {
                        if (item is RadioButton)
                        {
                            RadioButton rB = (RadioButton)item;
                            if (rB.Name == "rbKucuk")
                            {
                                rB.Checked = true;
                            }
                            else
                            {
                                rB.Checked = false;
                            }
                        }
                    }
                }
                else if (control is FlowLayoutPanel)
                {
                    foreach (var item in ((FlowLayoutPanel)control).Controls)
                    {
                        if (item is CheckBox)
                        {
                            CheckBox cB = item as CheckBox;
                            cB.Checked = false;
                        }
                    }
                }
            }
        }
    }
}
