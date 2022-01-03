using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreach_diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[10];
            Random x = new Random();
            int rastgele;
            int i = 0;
            while (i < 10)
            {
                rastgele = x.Next(1,101);
                if (sayilar.Contains(rastgele) == false)
                {
                    sayilar[i] = rastgele;
                    i++;
                }
            }
            // 2 yolla yazdirabiliriz
            // 1.yol foreach kullanarak
            foreach (int sayi in sayilar)
            {
                listBox1.Items.Add(sayi);
            }
            // 2.yol for kullanarak
            for (int j = 0; j < 10; j++)
            {
                listBox1.Items.Add(sayilar[j]);
            }
        }
    }
}
