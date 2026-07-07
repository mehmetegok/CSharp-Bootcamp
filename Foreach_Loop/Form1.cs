using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] notlar = { 50, 60, 70, 80, 90 };
            foreach (int k in notlar) {
                listBox1.Items.Add(k);
                toplam = toplam + k;
            }
            label1.Text = "Toplam: " + toplam;
            int ortalama = toplam / notlar.Length;
            label2.Text = "Ortalama: " + ortalama;
        }
    }
}
