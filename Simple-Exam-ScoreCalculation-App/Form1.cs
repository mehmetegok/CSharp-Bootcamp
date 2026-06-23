using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Exam_ScoreCalculation_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ad, soyad;
            int ogrenci_no;
            double vize, final, proje, ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            ogrenci_no = Convert.ToInt32(maskedTextBox1.Text);
            vize = Convert.ToDouble(textBox3.Text);
            final = Convert.ToDouble(textBox4.Text);
            proje = Convert.ToDouble(textBox5.Text);
            ortalama = (vize * 0.3) + (final * 0.5) + (proje * 0.2);
            listBox1.Items.Add(ad + " " + soyad + " " + ogrenci_no + " " + "Ortalama: "+ ortalama + "(Vize: " + vize + ", Final: " + final + ", Proje: " + proje + ")");
        }
    }
}
