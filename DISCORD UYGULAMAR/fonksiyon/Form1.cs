using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void sayilarinToplami(int sayi1, int sayi2)
        {
            MessageBox.Show("sayilarin toplami: " + (sayi1+sayi2).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            sayilarinToplami(a,b);
        }
        public void sayilarinFarki(int sayi1, int sayi2)
        {
            MessageBox.Show("sayilarin farki: " + (sayi1 - sayi2).ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            sayilarinFarki(a, b);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
