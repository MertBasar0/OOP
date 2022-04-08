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
        ListViewItem list;
        int index = -1;
        Employee guncellenecek;


        public Employee AddEmployee(Employee e)
        {

            e.TCKN = txt_tckn.Text;
            e.Name = txt_ad.Text;
            e.Surname = txt_soyad.Text;
            e.Birthdate = dtp_dogumT.Value;
            e.Tel = txt_tel.Text;
            e.Mail = txt_mail.Text;
            e.Adres = txt_adres.Text;
            e.Title = (Unvan)Enum.Parse(typeof(Unvan), cmb_unvan.Text);
            e.WorkStartDate = dtp_iseGiris.Value;
            if (picEmployee.Image != null)
            {
                e.Pic = Guid.NewGuid().ToString()+ picEmployee.Tag;
                picEmployee.Image.Save(Application.StartupPath+"/Image/"+e.Pic);
            }
            else
            {
                picEmployee.Image = Image.FromFile(@"C:\Users\Lenovo\Desktop\13b8af1c-a454-4d95-acb7-2a5d5136a54f[2449].jpg");
                picEmployee.Tag = Path.GetExtension(@"C:\Users\Lenovo\Desktop\13b8af1c-a454-4d95-acb7-2a5d5136a54f[2449].jpg");
                e.Pic= Guid.NewGuid().ToString()+ picEmployee.Tag;
                picEmployee.Image.Save(Application.StartupPath + "/Image/" + e.Pic);
            }

            return e;
            
        }
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
            try
            {
                Employee employee = new Employee();
                listView1.Items.Add(AddList(AddEmployee(employee)));
                Temizle.FormTemizle(gb_personelBilgileri.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu.."+"\n"+ex.Message);                
            }
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            index = listView1.SelectedItems[0].Index;
            guncellenecek = (Employee)listView1.SelectedItems[0].Tag;

            txt_ad.Text = guncellenecek.Name;
            txt_soyad.Text = guncellenecek.Surname;
            txt_tckn.Text = guncellenecek.TCKN;
            dtp_dogumT.Value = guncellenecek.Birthdate;
            txt_tel.Text = guncellenecek.Tel;
            txt_adres.Text = guncellenecek.Adres;
            txt_mail.Text = guncellenecek.Mail;
            dtp_iseGiris.Value = guncellenecek.WorkStartDate;
            cmb_unvan.Text = guncellenecek.Title.ToString();

            if (!string.IsNullOrWhiteSpace(guncellenecek.Pic))
            {
                picEmployee.Image = Image.FromFile(Application.StartupPath + "/Image/" + guncellenecek.Pic);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle.FormTemizle(gb_personelBilgileri.Controls);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("lütfen bir kayıt seçiniz..");
            }
            else
            {
                try
                {

                    listView1.Items.RemoveAt(index);
                    listView1.Items.Insert(index, AddList(AddEmployee(guncellenecek)));
                    Temizle.FormTemizle(gb_personelBilgileri.Controls);
                }
                catch (Exception)
                {

                    MessageBox.Show("Bir hata oluştu..");
                }
                index = -1;
            } 
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            index = listView1.SelectedItems[0].Index;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("lütfen bir kayıt seçiniz..");
            }
            else
            {
                try
                {
                    listView1.Items.RemoveAt(index);
                }
                catch (Exception)
                {

                    MessageBox.Show("Bir hata oluştu..");
                }
                
                index = -1;
            }
            
        }

        
    }
}
