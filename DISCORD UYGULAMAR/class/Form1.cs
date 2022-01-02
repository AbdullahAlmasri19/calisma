using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class dikdortgen
        {
            public double ukenar;
            public double kkenar;
            public dikdortgen(double u, double k)
            {
                ukenar = u;
                kkenar = k;
            }
            public double ananHesapla()
            {
                return ukenar * kkenar;
            }
            public double cevreHesapla()
            {
                return (ukenar + kkenar) * 2;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double uzunkenar = Convert.ToDouble(textBox1.Text);
            double kisakenar = Convert.ToDouble(textBox2.Text);
            dikdortgen dik1 = new dikdortgen(uzunkenar,kisakenar);
            MessageBox.Show("girilen dikdortgenin alani: " + dik1.ananHesapla().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double uzunkenar = Convert.ToDouble(textBox1.Text);
            double kisakenar = Convert.ToDouble(textBox2.Text);
            dikdortgen dik1 = new dikdortgen(uzunkenar, kisakenar);
            MessageBox.Show("girilen dikdortgenin cevresi: " + dik1.cevreHesapla().ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
