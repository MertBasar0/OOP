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

namespace OOP_Delegate
{
    public delegate void Logger(string message);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Bir olay gerçekleştirğinde birden fazla fonksiyonu çağırmak istediğinizi düşünün.
        Örneğin kullanıcı bir düğmeye takladığında birden gazla metod'un otomatik olarak çağırılmasını istiyoruz.
        Bunun için delegate kullanabilirsiniz. Buradaki asıl amaç bir olay olduğunda birden fazla yere bu olayı bildirmek,
        bu olaayla ilgilenen delegeta e haber vermektir.

            Temsilci olarak adlandırılabilecek bu yapı, projeyi asıl ayakta tutan nesneleri yormak yerine, onların
        işleyişlerini üzerine alarak gerçekleştirmekten sorumlu olan tiplerdir.
        Bu sayede uygulamamızın bir kolu, üzerine düşen görevi eksiksiz yerine getirerek daha uzun süreli ve performanslı
        uygulamalar uygulamalar ortaya koyar.

            Delege Tanımlamak
        1) Delege tanımla
        2)Öncelikle delege tanımlaması konusunda sorumlu olan metotlar bir arada yazılır..
        3)İlgili delegeden instance almaya kalktığınızda ilgili metot delegeye bağlanır ve metot yerine delegenin invoke() metodu
        çağırılır.

        */
        //İlk örnek loglama sistemi;

        public void SmsLogger(string message)
        {
            lbl_sms.Text = message;
        }

        public void MailLogger(string message)
        {
            lbl_mail.Text = message;    
        }

        public void XmlLogger(string message)
        {
            lbl_xml.Text = message;
        }

        public void HtmlLogger(string message)
        {
            lbl_html.Text = message;    
        }

        public void DbLogger(string message)
        {
            lbl_db.Text = message;
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            Logger logger = new Logger(SmsLogger);
            logger += MailLogger;
            logger += HtmlLogger;
            logger += XmlLogger;
            logger += DbLogger;

            logger.Invoke("BilgeAdam");
        }
    }
}
