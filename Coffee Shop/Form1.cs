using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class frmTomsDiner : Form
    {
        public frmTomsDiner()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            txtCustomerName.Text = string.Empty;
            txtDateOfSale.Text = string.Empty;
            txtNumOfCoffees.Text = string.Empty;
            txtNumOfDonuts.Text = string.Empty;
            txtNumOfCookies.Text = string.Empty;
            txtNumOfBagels.Text = string.Empty;
            txtNumOfMuffins.Text = string.Empty;

            //Clear labels
            lblCustomerName.Text = string.Empty;
            lblSaleDate.Text = string.Empty;
            lblCostNoSalesTax.Text = string.Empty;
            lblSalesTax.Text = string.Empty;
            lblTotal.Text = string.Empty;

            // Set focus to customer name
            txtCustomerName.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare variables
            string customerName;
            string salesDate;
            int intNumOfCoffees;
            int intNumOfDonuts;
            int intNumOfCookies;
            int intNumOfBagels;
            int intNumOfMuffins;
            decimal decCost;
            decimal decSalesTax;
            decimal decTotal;

            // Declare constants
            const decimal SALES_TAX = .06m;
            const decimal PRICE_COFFEE = 2.55m;
            const decimal PRICE_DONUT = 1.45M;
            const decimal PRICE_COOKIE = .70M;
            const decimal PRICE_MUFFIN = .95M;
            const decimal PRICE_BAGEL = 1.55M;

            // Convert strings to integers
            int.TryParse(txtNumOfCoffees.Text, out intNumOfCoffees);
            int.TryParse(txtNumOfDonuts.Text, out intNumOfDonuts);
            int.TryParse(txtNumOfCookies.Text, out intNumOfCookies);
            int.TryParse(txtNumOfBagels.Text, out intNumOfBagels);
            int.TryParse(txtNumOfMuffins.Text, out intNumOfMuffins);

            customerName = txtCustomerName.Text;
            salesDate = txtDateOfSale.Text;

            // Math calculations
            decCost = (PRICE_COFFEE * intNumOfCoffees) + (PRICE_DONUT * intNumOfDonuts) 
                + (PRICE_COOKIE * intNumOfCookies) + (PRICE_MUFFIN * intNumOfMuffins) 
                + (PRICE_BAGEL * intNumOfBagels);

            decSalesTax = decCost * SALES_TAX;

            decTotal = decCost + decSalesTax;
            
            // Display output
            lblCustomerName.Text = customerName;
            lblSaleDate.Text = salesDate;
            lblCostNoSalesTax.Text = decCost.ToString("#.##");
            lblSalesTax.Text = decSalesTax.ToString("#.##");
            lblTotal.Text = decTotal.ToString("#.##");


        }

        private void frmTomsDiner_Load(object sender, EventArgs e)
        {
            this.Text = "Customer Order - Tom's Diner";
        }
    }
}
