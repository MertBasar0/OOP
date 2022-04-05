using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KayitProjesiTekrar.Constrat;

namespace KayitProjesiTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee e;
        ListViewItem list;

        public Employee AddEmployee()
        {
            e = new Employee()
            {
                TCKN = txt_tckn.Text,
                Name = txt_ad.Text,
                Surname = txt_soyad.Text,
                Birthdate = dtp_dogumT.Value,
                Tel = txt_tel.Text,
                Mail = txt_mail.Text,
                Adres = txt_adres.Text,
                Title = (Unvan)Enum.Parse(typeof(Unvan), cmb_unvan.Text)
            };
            if (picEmployee.Image != null)
            {
                e.Pic = Guid.NewGuid().ToString()+ picEmployee.Tag;
                picEmployee.Image.Save(Application.StartupPath+"/Image/"+e.Pic);
            }
            return e;
        }
        //Güncelle ve sil butonları yazılacak..
        public ListViewItem AddList(Employee e)
        {
            list = new ListViewItem(e.TCKN);
            list.SubItems.Add(e.Name);
            list.SubItems.Add(e.Surname);
            list.SubItems.Add(e.Birthdate.ToString());
            list.SubItems.Add(e.Tel);
            list.SubItems.Add(e.Mail);
            list.Tag = e;
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_unvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));
        }

        private void btn_resimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "jpg files (*.jpg)|*jpg";
            dlg.Title = "lütfen resim seçiniz..";
            DialogResult = dlg.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                picEmployee.Image = Image.FromFile(dlg.FileName);
                picEmployee.Tag = Path.GetExtension(dlg.FileName);
            }
            else return;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(AddList(AddEmployee()));
            Temizle.FormTemizle(gb_personelBilgileri.Controls);
        }
    }
}
