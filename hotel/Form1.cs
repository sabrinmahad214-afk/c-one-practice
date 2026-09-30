using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nights = double.Parse(txtnumberofnights.Text);
            double price = double.Parse(txtpricepernight.Text);

            // Calculate room cost
            double cost = nights * price;

            // Calculate tax 10%
            double tax = cost * 0.10;

            // Calculate discount 5%
            double discount = cost * 0.05;

            // Calculate final total
            double total = cost + tax - discount;

            // Display results
            txtservicetax.Text = tax.ToString("C2");
            txtdiscount.Text = discount.ToString("C2");
            txttotalamount.Text = total.ToString("C2");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
