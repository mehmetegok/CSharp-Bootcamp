using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld    //Project Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya!"); //MessageBox ile ekrana Merhaba Dünya! yazdırır.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Ahmet"; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = textBox2.Text;
            label7.Text = textBox3.Text;
            label8.Text = textBox4.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazılım Mühendisi";
            label9.Text = textBox1.Text; //textBox1'deki yazıyı label9'a atar.nereye atayacaksan o solda nereden gelecekse o sağda olur.
        }
    }
}
