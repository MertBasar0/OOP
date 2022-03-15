using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayıtProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Personel addPerson(Personel person)
        {
                person.Name = txtAd.Text;
                person.Surname = txtSoyad.Text;
                person.TCKN = txtTckimlikno.Text;
                person.Birtdate = dt_dogumTarihi.Value;
                person.PhoneNo = msk_phoneNo.Text;
                person.Mail = txtMail.Text;
                person.Address = txtAdres.Text;
                person.IseGirisTarihi = dt_Isegiristarihi.Value;
                person.Unvan = (Unvan)Enum.Parse(typeof(Unvan), cmb_Unvan.Text);

                if (pcb_resim != null)
                {
                    person.PersonelResmi = Guid.NewGuid() + pcb_resim.Tag.ToString();
                }
                pcb_resim.Image.Save(Application.StartupPath + "/Images/" + person.PersonelResmi);

                return person;
        }

        public ListViewItem listViewDoldur(Personel p)
        {
            ListViewItem listItem = new ListViewItem(p.TCKN);
            listItem.SubItems.Add(p.Name);
            listItem.SubItems.Add(p.Surname);
            listItem.SubItems.Add(p.IseGirisTarihi.ToString());
            listItem.SubItems.Add(p.PhoneNo);
            listItem.SubItems.Add(p.Mail);
            listItem.Tag = p;
            return listItem ;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            addPerson(personel);
        }
    }
}
