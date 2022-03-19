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

        public static void Temizle(Control.ControlCollection kolleksiyon)
        {
            foreach (Control item in kolleksiyon)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                else if(item is PictureBox)
                {
                    ((PictureBox)item).Image = null;
                }
                else if (item is GroupBox)
                {
                    Temizle(((GroupBox)item).Controls);
                }
            }
        }
    }
}
