using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Buffet_Sales_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        double casetotal = 0;
        private void Price_button_Click(object sender, EventArgs e)
        {
            int water, popcorn, ticket;
            double tea, total_price;
            water = Convert.ToInt16(TxtWater.Text);
            popcorn = Convert.ToInt16(TxtPopcorn.Text);
            ticket = Convert.ToInt16(TxtTicket.Text);
            tea = Convert.ToDouble(TxtTea.Text);

            total_price = (water * 2) + (popcorn * 5) + (ticket * 7) + (tea * 2.5);

            casetotal += total_price;
            TotalPriceLabel.Text = total_price.ToString();
            Case.Text = casetotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtWater.Text = ""; 
            TxtTicket.Text = "";
            TxtPopcorn.Text = "";
            TxtTea.Text = "";
            TxtWater.Focus();
        }
    }
}
