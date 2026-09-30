using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip___tax_and_total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String food1;
                double price1;
                String food2;
                double price2;
                double total;
                double tax;

                // Get values from TextBoxes
                food1 = txtfood1.Text;
                price1 = double.Parse(txtprice1.Text);

                food2 = txtfood2.Text;
                price2 = double.Parse(txtprice2.Text);

                // Calculate total price
                total = price1 + price2;

                // Calculate sales tax (7%)
                tax = total * 0.07;

                // Final total including tax
                total = total + tax;

                // Display sales tax and total amount
                txtsales.Text = tax.ToString("0.00");
                txttotalamount.Text = total.ToString("0.00");

            }
             catch
            {
                MessageBox.Show("kulabo");
            }
        }
    }
}
