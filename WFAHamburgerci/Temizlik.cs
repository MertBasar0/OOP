using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerci
{
    public class Temizlik
    {
        public static void Temizle(Control.ControlCollection kolleksiyon)
        {
            foreach (Control item in kolleksiyon)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }
                else if(item is RadioButton)
                {
                    RadioButton radio = (RadioButton)item;
                    if (radio.Name == "rbKucuk")
                    {
                        radio.Checked = true;
                    }
                    else
                    {
                        radio.Checked = false;
                    }
                }
                else if (item is ComboBox)
                {
                    ComboBox b = (ComboBox)item;
                    b.SelectedIndex = 0;
                }
                else if(item is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)item;
                    numericUpDown.Value = 1;
                }
                else if (item is GroupBox)
                {
                    GroupBox gb = (GroupBox)item;
                    Temizle(gb.Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)item;
                    Temizle(flowLayoutPanel.Controls);
                }
            }
        }
    }
}
