using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contains
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class ogrenciler
        {
            public string ad, soyad;
            public double not1, not2;
            public ogrenciler(string adi, string soyadi,double not1,double not2)
            {
                ad = adi;
                soyad = soyadi;
                this.not1 = not1;
                this.not2 = not2;
            }
            public double orthesapla()
            {
                return (not1 + not2) / 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            double not1 = Convert.ToDouble(textBox3.Text);
            double not2 = Convert.ToDouble(textBox4.Text);
            ogrenciler ogr1 = new ogrenciler(ad,soyad,not1,not2); 
            MessageBox.Show(ogr1.ad +" "+ ogr1.soyad +" "+ "adli ogrencinin ortalamasi: "+ogr1.orthesapla().ToString());
        }
    }
}
