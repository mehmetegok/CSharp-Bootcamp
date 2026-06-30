using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i= 1; i<=10; i++)  //ilk durumda i sayacı tanımlanır, 2. durumda i sayacı 10'dan küçük veya eşit olduğu sürece döngü çalışır,
                                       //3. durumda i sayacı her döngü sonunda 1 artırılır.
            {
                listBox1.Items.Add(i + " " + "Merhaba Ankara");
            }
        }
    }
}
