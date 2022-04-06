using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitProjesiTekrar.Constrat
{
    public static class Temizle
    {
        public static void FormTemizle(Control.ControlCollection collection)
        {
            foreach (var item in collection)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedItem = null;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Today;
                }
                else if(item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = "";
                }
                else if(item is PictureBox)
                {
                    ((PictureBox)item).Image = null;
                }
            }
        }
    }
}
