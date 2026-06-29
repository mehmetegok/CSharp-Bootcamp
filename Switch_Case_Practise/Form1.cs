using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_Practise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi_1, sayi_2, sonuc;
            String islem;
            sayi_1 = Convert.ToInt32(textBox1.Text);
            sayi_2 = Convert.ToInt32(textBox3.Text);
            islem = comboBox1.Text;
            switch (islem)
            {
                case "+":
                    sonuc = sayi_1 + sayi_2;
                    textBox2.Text = sonuc.ToString(); break;
                case "-":
                    sonuc = sayi_1 - sayi_2;
                    textBox2.Text = sonuc.ToString(); break;
                case "*":
                    sonuc = sayi_1 * sayi_2;
                    textBox2.Text = sonuc.ToString(); break;
                case "/":
                    sonuc = sayi_1 / sayi_2;
                    textBox2.Text = sonuc.ToString(); break;

            }
        }
    }
}
