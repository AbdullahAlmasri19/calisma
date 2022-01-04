using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav_sorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bas = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            int uretimsayisi = Convert.ToInt32(textBox3.Text);
            int[] sayilar = new int[uretimsayisi];
            Random x = new Random();
            int rastgele;
            int sayac = 0;
            while (sayac < uretimsayisi)
            {
                rastgele = x.Next(bas,bitis);
                if (sayilar.Contains(rastgele) == false)
                {
                    sayilar[sayac] = rastgele;
                    sayac++;
                }
            }
            foreach (int sayi in sayilar)
            {
                listBox1.Items.Add(sayi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = Convert.ToInt32(listBox1.Items[i]);
            }
            int tekadet = 0;
            int ciftadet = 0;
            int tektop = 0;
            int cifttop = 0;
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    ciftadet++;
                    cifttop += sayi;
                }
                else
                {
                    tekadet++;
                    tektop += sayi;
                }
                
            }
            textBox4.Text = tekadet.ToString();
            textBox5.Text = ciftadet.ToString();
            textBox6.Text = (tektop / tekadet).ToString();
            textBox7.Text = (cifttop / ciftadet).ToString();
        }
    }
}
