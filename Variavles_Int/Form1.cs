using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variavles_Int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 24;
            sayi2 = 36;
            toplam = sayi1 + sayi2;
            label1.Text = toplam.ToString(); // int tipinde olan toplam değişkenini ToString() metoduyla string tipine çevirip label1'e yazdırıyoruz.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;
            kenar = 5;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label2.Text = "Alan: " + alan + " Çevre: " + cevre; // en az 1 string ifade varsa bile ToString() metodunu kullanmaya gerek yoktur.
                                                                // C# otomatik olarak string tipine çevirir.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int giris_degeri, sonuc;
            giris_degeri = Convert.ToInt32(textBox1.Text); // textBox1'den girilen String değeri int tipindeki giris_degeri değişkenine Convert.ToInt32 metoduyla çeviriyoruz.
            label4.Text = giris_degeri.ToString(); // giris_degeri değişkenini label4'e yazdırıyoruz.
            sonuc = giris_degeri*giris_degeri* giris_degeri; // giris_degeri değişkeninin küpünü alıyoruz.
            label5.Text = sonuc.ToString();
        }
    }
}
