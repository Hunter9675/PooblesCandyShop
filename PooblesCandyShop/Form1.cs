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
        double candyPrice = 3.50;
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
            int userinput = Convert.ToInt32(candyInput.Text);

            
        }
    }
}
