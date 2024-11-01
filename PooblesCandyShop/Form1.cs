using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooblesCandyShop
{
    public partial class Form1 : Form
    {
        double candyPrice = 3.00;
        int numOfCandys = 0;
        double taxRate = 0.13;
        double subtotal = 0;
        double taxAmount = 0;
        double totalPrice = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void activateCalButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfCandys = Convert.ToInt32(candyInput.Text);
                pooble.Image = PooblesCandyShop.Properties.Resources.pooble;
                errorLabel1.Text = "Thanks for shopping at";
                errorLabel2.Text = "Pooble's Candy Shop.";

            }
            
            catch
            {
                pooble.Image = PooblesCandyShop.Properties.Resources.poobleerror;
                errorLabel1.Text = "You're confusing Pooble!";
                errorLabel2.Text = "Please type a Number.";
            }

            if (numOfCandys < 0)
            {
                errorLabel1.Text = "You cant buy negitive candys!";
                errorLabel2.Text = "";
                pooble.Image = PooblesCandyShop.Properties.Resources.poobleerror;
            }

            else if (numOfCandys == 0)
            {
                errorLabel1.Text = "Well, Thanks for stopping by!";
                errorLabel2.Text = "";

            }

            subtotal = candyPrice * numOfCandys;

            taxAmount = subtotal * taxRate;

            totalPrice = subtotal + taxAmount;

            subtotalOutput.Text = $"{subtotal.ToString("C")}";

            taxOutput.Text = $"{taxAmount.ToString("C")}";

            totalOutput.Text = $"{totalPrice.ToString("C")}";

            
        }
    }
}
