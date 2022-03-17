using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayıtProjesi
{
    public static class temizle
    {

        public static void GBTemizle(GroupBox Grb)
        {
            foreach (Control item in Grb.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is ComboBox)
                {
                    item.Enabled = false;
                }
                else if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
                else if (item is DateTimePicker)
                {
                    item.Enabled = false;
                }
            }
        }
    }
}
