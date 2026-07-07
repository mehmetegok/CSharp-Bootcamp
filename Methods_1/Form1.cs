using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle() { 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;   
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
        }

        private void renklendir() {
            textBox1.BackColor = Color.Red;
            textBox2.BackColor = Color.Green;
            textBox3.BackColor = Color.Blue;
            textBox4.BackColor = Color.BurlyWood;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
    }
}
