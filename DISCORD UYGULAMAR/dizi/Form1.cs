using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dizininsayisi = Convert.ToInt32(textBox1.Text);
            int[] sayilar = new int[dizininsayisi];

            Random a = new Random();
            int rastgelesayi;

            int whilesayac = 0;

            while (whilesayac < dizininsayisi)
            {
                rastgelesayi = a.Next(1,101);
                if (sayilar.Contains(rastgelesayi) == false)
                {
                    sayilar[whilesayac] = rastgelesayi;
                    whilesayac++;
                }
            }
            foreach (int sayi in sayilar)
            {
                listBox1.Items.Add(sayi);
            }
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
