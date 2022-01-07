using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav_oncesi_calisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tekadet = 0;
        int ciftadet = 0;
        int tektoplam = 0;
        int cifttoplam = 0;
        

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            tekadet = cifttoplam = tektoplam = cifttoplam = 0;
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            int sayimiktari = Convert.ToInt32(textBox3.Text);
            Random x = new Random();
            int[] sayilar = new int[sayimiktari];
            int i = 0;
            int rastgele;
            while (i < sayimiktari)
            {
               rastgele=x.Next(baslangic, bitis);
              if (sayilar.Contains(rastgele)==false)
              {
                  sayilar[i]=rastgele; 
                  i++;

                  if (rastgele % 2 == 0)
                  {
                      ciftadet += 1;
                      cifttoplam += rastgele;
                  }
                  else {
                      tekadet += 1;
                      tektoplam += rastgele;
                  }

                  listBox1.Items.Add(rastgele);
              }

            }
            
        }

     

        private void button2_Click(object sender, EventArgs e)
        {

            textBox7.Text = ciftadet.ToString();
            textBox6.Text = tekadet.ToString();
           
            if (ciftadet != 0)  textBox5.Text = (cifttoplam / ciftadet).ToString();
            if (tekadet != 0) textBox4.Text = (tektoplam / tekadet).ToString();
        }
    }
}
