using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decision_Structure_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, proje, ortalama;
            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);
            ortalama = (vize *0.3) + (final*0.5) + (proje * 0.2);
            if(ortalama >= 60)
            {
                textBox4.Text = Convert.ToString(ortalama) + " - Geçti";
            }
            else
            {
                textBox4.Text = Convert.ToString(ortalama) + " - Kaldı";
            }
        }
    }
}
