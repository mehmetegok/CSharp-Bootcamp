using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String adsoyad, meslek; // Değişken türü + değişken adı şeklinde tanımlanır.
            adsoyad = "mehmet gok";
            meslek = "mühendis";
            label1.Text = adsoyad; //adsoyad değişkeninin içeriği label1'e aktarılır.
            label2.Text = meslek; //meslek değişkeninin içeriği label2'ye aktarılır.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Kullanici_girisi;
            Kullanici_girisi = textBox1.Text; //textBox1'deki yazı Kullanici_girisi değişkenine aktarılır.
            label3.Text = Kullanici_girisi; //Kullanici_girisi değişkeninin içeriği label3'e aktarılır.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String adsoyad, meslek, yas;
            adsoyad = textBox2.Text; //textBox2'deki yazı adsoyad değişkenine aktarılır.
            meslek = textBox4.Text; //textBox3'deki yazı meslek değişkenine aktarılır.
            yas = maskedTextBox1.Text; //maskedTextBox1'deki yazı yas değişkenine aktarılır.
            listBox1.Items.Add(adsoyad + ", " + meslek + ", " + yas); //adsoyad değişkeninin içeriği listBox1'e eklenir.
        }
    }
}
