using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Usages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);  // Add the text from the TextBox to the ComboBox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);  // Add the text from the TextBox to the ListBox
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text+" "+textBox4.Text+" "+textBox5.Text+" "+textBox6.Text+" "+textBox7.Text);  // Add the text from the TextBox to the ListBox)
        }
    }
}
