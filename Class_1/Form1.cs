using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car rb= new Car();
            rb.renk = "Kırmızı";
            rb.hız = 150;
            rb.motorhacmi = 1.6;
            rb.durum = 'S';
            rb.fiyat = 2000000;
            rb.YIL = -2020;
            rb.MARKA = "bmw";
            rb.plaka = "34ABC123";
            rb.muayene = 2024;
            rb.sahip = "Murat Yücedağ";

            label1.Text = rb.renk;
            label2.Text = rb.hız.ToString();
            label3.Text = rb.motorhacmi.ToString();
            label4.Text = rb.durum.ToString();
            label5.Text = rb.fiyat.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKA.ToString();
            label8.Text = rb.plaka.ToString();
            label9.Text = rb.muayene.ToString();
            label10.Text = rb.sahip.ToString(); 
        }
    }
}
