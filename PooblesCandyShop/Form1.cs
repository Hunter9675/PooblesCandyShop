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
                errorLabel1.Text = "";
                errorLabel2.Text = "";

            }
            
            catch
            {
                pooble.Image = PooblesCandyShop.Properties.Resources.poobleerror;
                errorLabel1.Text = "You're confusing Pooble!";
                errorLabel2.Text = "Please type a Number.";
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
