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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Car rb2 = new Car();
            rb2.renk = "Siyah";
            rb2.hız = 200;
            rb2.motorhacmi = 2.0;
            rb2.durum = 'S';
            rb2.fiyat = 3000000;

            label6.Text = rb2.renk;
            label7.Text = rb2.hız.ToString();
            label8.Text = rb2.motorhacmi.ToString();
            label9.Text= rb2.durum.ToString();
            label10.Text = rb2.fiyat.ToString();
        }
    }
}
