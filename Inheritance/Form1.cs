using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MobilePhone phone = new MobilePhone()
            //{
            //    HasCam = true,
            //    isTouched = true,
            //    Brand = "Iphone",
            //    Connection = "XR"
            //};
            //MessageBox.Show(phone.HasCam.ToString()+"\n"+phone.isTouched+"\n"+phone.Brand+"\n"+phone.Connection+"\n"+phone.TakePhoto()+"\n"+phone.ToString());
            
            SmartPhone ph = new SmartPhone()
            {
                FrontCam = true,
                HasCam = true,
                isTouched = true,
                Brand = "Iphone",
                Connection ="kablosuz"
            };
            string a = "";
            foreach (PropertyInfo item in ph.GetType().GetProperties())
            {
                a += item.Name+": "+item.GetValue(ph).ToString()+"\n";
            }
            MessageBox.Show(ph.VideoCall());


        }
    }
}
