using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KayıtProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Unvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));//Form yüklenirken enum değerlerinin combobox da listelenmesini sağladım.
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

                if (pcb_resim.Tag.ToString() == ".jpg" || pcb_resim.Tag.ToString() ==".png") //Burada pcb_resim componenti üzerinde bulunan seçilmiş resmin Tagına attığım
                                                                                             //dosya yolu uzantısı string ifadesinin ne olduğuna dair kontrol gerçekleştirdim.
                                                                                             //Burada sonuc belirttiğim türlerden biri ise person nesnesinin "PersonelResmi"
                                                                                             //komponentine, NewGuid ile oluşturduğum benzersiz ifade ve sonunda pcb_resim.Tag
                                                                                             //üzerindeki dosya yolu uzantısını string türünde birleştirerek atacak.

                {
                person.PersonelResmi = Guid.NewGuid() + pcb_resim.Tag.ToString();
                }
                pcb_resim.Image.Save(Application.StartupPath + "/Images/" + person.PersonelResmi); //Prop atamaları gerçekleştikten sonra pcb_resim komponentinin
                                                                                                   //Image.Save() metodundan yararlanarak resmi kaydettim.
                                                                                                   //parametre olarak string türünde dosya yolunu verdim..

                return person; //Son olarak metodun, propları doldurulan person isimli nesneyi döndürmesini istedim.
        }

        public ListViewItem[] listViewDoldur(Personel p) //personel parametresi alıp geriye listViewItem[] listesi döndürmesini istedim..
        {
            List<ListViewItem> vs = new List<ListViewItem>();//ListViewItem değerlerini gönderebilmek için bir genericlist oluşturdum..
            ListViewItem listItem = new ListViewItem(p.TCKN);//ListViewItem elemanlarını oluşturabilmek için bir listItem isimli nesne oluşturdum. Ve ilk değerini atadım.

            listItem.SubItems.Add(p.Name);//Kalan elemanları SubItems ile gönderdim.
            listItem.SubItems.Add(p.Surname);
            listItem.SubItems.Add(p.IseGirisTarihi.ToString());
            listItem.SubItems.Add(p.PhoneNo);
            listItem.SubItems.Add(p.Mail);
            listItem.Tag = p;

            vs.Add(listItem); //GenericList'e listItem üzerine attığım değerleri tek seferde gönderdim.
            return vs.ToArray();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel(); //Proplarını doldurabilmek için öncelikle nesnemi oluşturdum.
            addPerson(personel);//Metodumla nesnemin proplarını doldurdum.
            lst_personel.Items.AddRange(listViewDoldur(personel));//ListView komponentinin Items.AddRange() metodundan yararlanarak parametre olarak ListViewItem türünde
                                                                  //array döndüren metodumu gönderdim.
            temizle.GBTemizle(gbPersonelBilgileri);//Ve ekleme işleminden sonra componentleri temizledim.
        }


        private void btn_resimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();//OpenFileDialog class'ı ile dlg isimli bir nesne oluşturdum. Bu nesne ile DialogResult enumundan result isimli bir değer
                                                      //oluşturarak dlg nesnesi üzerinden dialog penceresi açtım ve buradan dönecek cevabı result değeri ile yakaladım.
                                                      //Eğer dönecek değer ok olursa aşağıdaki işlemlerin yapılmasını istedim..
                                                      //Buradan sonra bir dosya uzantı filtresi konulabilirdi..

            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                pcb_resim.Image = Image.FromFile(dlg.FileName);//OpenFileDialog class'ı ile oluşturduğum dlg nesnesinin resim seçimi yaptıktan sonra
                                                               //FileName propuna düşen Image türünde resmi pcb_resim olarak adlandırdığım form nesnesinin image propuna
                                                               //attım. Burada image resmin pathini ifade etmez bit olarak resmin kendisidir.
                                                               //BU sayede form üzerinde resmin görüntülenebilmesini sağladım..

                pcb_resim.Tag = Path.GetExtension(dlg.FileName);//Sistem.IO namespace'ini ekledim ve Path classından "GetExtension()"
                                                                //metoduyla string olarak döndürdüğü dosyanın uzantı ekini pcb_resim componentinin Tag prop'una attım. 
            }

        }
    }
}
