using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {

        //variables here
        double slicePrice = 2.25;
        double breadPrice = 2;
        double drinkPrice = 1.50;

        int numbOfSlice = 0;
        int numbOfBread = 0;
        int numbOfDrink = 0;

        double subtotal;
        double taxPercent = 0.13;
        double taxValue;
        double total;

        //subtotal, taxRate, tasAmount, total
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // get the inputs and put them in the variables
            numbOfSlice = Convert.ToInt32(slicesInput.Text);
            numbOfBread = Convert.ToInt32(breadInput.Text);
            numbOfDrink = Convert.ToInt32(drinkInput.Text);

            subtotal = numbOfSlice * slicePrice + numbOfBread * breadPrice + numbOfDrink * drinkPrice;
            subtotalLabel.Text = subtotal.ToString();
            taxValue = subtotal * taxPercent;
            total = subtotal + taxValue;
            taxLabel.Text = taxValue.ToString(); 
            totalLabel.Text = total.ToString();

            
            
            
            



            
            






            

            //calc your subtotal

            //calc your tax

            //calc your total

            //output all the totals to labels
        }

        private void printerLabel_Click(object sender, EventArgs e)
        {

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Text = "Coles Pizza Place";
            receiptLabel.Refresh();
            Thread.Sleep(300);

            receiptLabel.Text += "\n\nOctober 26,2021";
            receiptLabel.Refresh();
            Thread.Sleep(300);

            receiptLabel.Text += $"\n\nSlices x {numbOfSlice}   @ {slicePrice} ";
            receiptLabel.Refresh();
            Thread.Sleep(300);

            receiptLabel.Text += $"\n\nBread x {numbOfBread}   @ {breadPrice} ";
            receiptLabel.Refresh();
            Thread.Sleep(300);

            receiptLabel.Text += $"\n\nDrank x {numbOfDrink}   @ {drinkPrice} ";
            receiptLabel.Refresh();
            Thread.Sleep(300);

            receiptLabel.Text += $"\n\nSubtotal {subtotal}";
            receiptLabel.Refresh();
            Thread.Sleep(300);

            receiptLabel.Text += $"\n\nTax {taxValue}";
            receiptLabel.Refresh();
            Thread.Sleep(300);

            receiptLabel.Text += $"\n\nTotal {total}";
            receiptLabel.Refresh();
            Thread.Sleep(300);

            receiptLabel.Text += $"\n\n Have a Great Day!";
            
           



        }
    }
}
