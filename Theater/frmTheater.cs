using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater
{
    public partial class frmTheater : Form
    {
        public frmTheater()
        {
            InitializeComponent();
        }

        private void frmTheater_Load(object sender, EventArgs e)
        {
            string strPrices;

            strPrices = "Gallery Seat - $30.00 per ticket" + Environment.NewLine
                + "Floor Seat (rows 1 to 20) - $55.50 per ticket" + Environment.NewLine
                + "Floor Seat (rows 21 to 40) - $45.25 per ticket" + Environment.NewLine
                + "Mezzanine Seat - $85.00 per ticket" + Environment.NewLine
                + "Vehicle Parking - $10.00 per vehicle" + Environment.NewLine
                + "Event Fee - $5.00 per ticket (Free if 5 or more tickets are purchased)" + Environment.NewLine
                + "Dinner Package - $35.00 per ticket";

            txtPriceInfo.Text = strPrices;

            // List of numbers for the number of vehicles 
            lstNumOfVehicles.Items.Add(0);
            lstNumOfVehicles.Items.Add(1);
            lstNumOfVehicles.Items.Add(2);
            lstNumOfVehicles.Items.Add(3);
            lstNumOfVehicles.Items.Add(4);
            lstNumOfVehicles.Items.Add(5);

            // Default number
            lstNumOfVehicles.SelectedIndex = 0;

            
        }

        // Counts the total number of tickets 
        public int TicketCounter()
        {
            int intGallery, intFloorOneToTwenty, intFloorTwentyoneToForty, intMezzanine, intTotalNumTickets;
           
            int.TryParse(txtGallery.Text, out intGallery);
            int.TryParse(txtFloorOne.Text, out intFloorOneToTwenty);
            int.TryParse(txtFloorTwo.Text, out intFloorTwentyoneToForty);
            int.TryParse(txtMezzanine.Text, out intMezzanine);

            intTotalNumTickets = intGallery + intFloorOneToTwenty + intFloorTwentyoneToForty
                + intMezzanine;
            
            return intTotalNumTickets;
        }
        
        // Gives the user an error if they have yes picked for rdoVehicles and select 0 for the number of vehicles
        public bool IsEnoughCars(bool rdoVehicle) 
        {
            if(lstNumOfVehicles.SelectedIndex == 0 && rdoVehiclesYes.Checked == true)
            {
                MessageBox.Show("You need to have at least one car selected", "Error Entry");
                return false;
            }
           
            return true;

        }


        // Takes the total number of tickets returns what the event fee will be
        // It also calls IsEnoughTickets which will determine if the user has ordered too many or too few tickets 
        public int switchEventFee()
        {
            int intTotalNumTickets;
            int intEventFee;

            intTotalNumTickets = TicketCounter();

            IsEnoughTickets(intTotalNumTickets);

            switch (intTotalNumTickets)
            {
                case 1:
                    intEventFee = 5;
                    break;
                case 2:
                    intEventFee = 10;
                    break;
                case 3:
                    intEventFee = 15;
                    break;
                case 4:
                    intEventFee = 20;
                    break;
                default:
                    intEventFee = 0;
                    break;
            }
            return intEventFee;

        }

        // Checks to make sure the user enters an integer and gives an error if they don't
        public bool IsInteger(TextBox textBox, string name)
        {
            int intNumber;
            if(int.TryParse(textBox.Text, out intNumber) == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        // Determines if the user has ordered too many or too few tickets 
        public bool IsEnoughTickets(int tickets)
        {
            if(tickets < 1)
            {
                MessageBox.Show("You must purchase at least one ticket.", "Entry Error");
                return false;
            }
            else if(tickets > 8)
            {
                MessageBox.Show("You can not purchase more than 8 tickets.", "Entry Error");
                return false;
            }
            return true;
        }

        // Checks to make sure the user enters something 
        public bool IsPresent(TextBox textBox, string name)
        {
            if(textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        // Calls the various methods and returns a boolian
        public bool IsValidData()
        {
            return IsPresent(txtName, "Customer name") &&
                IsPresent(txtPhoneNumber, "Customer phone number") &&
                IsInteger(txtGallery, "Gallery seat") &&
                IsInteger(txtFloorOne, "Floor seat (rows 1 to 20)") &&
                IsInteger(txtFloorTwo, "Floor seat (rows 21 to 40)") &&
                IsInteger(txtMezzanine, "Mezzanine seat") &&
                IsEnoughCars(rdoVehiclesYes.Checked);
        }

        // Closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Should the user change something the output will clear 
        private void Clear_Output(object sender, EventArgs e)
        {
            lblTotal.Text = "";
        }

        // Clears the text boxes, labels, radio buttons, and check boxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtGallery.Text = "";
            txtFloorOne.Text = "";
            txtFloorTwo.Text = "";
            txtMezzanine.Text = "";
            lblTotal.Text = "";

            chbDinnerPackage.Checked = false;
            rdoVehiclesNo.Checked = false;
            rdoVehiclesYes.Checked = false;

            lstNumOfVehicles.SelectedIndex = 0;
        }

        // Calculates the total and outputs it along with their name and phone number
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // constants
            const decimal GALLERY = 30.00m;
            const decimal FLOORONE = 55.50m;
            const decimal FLOORTWO = 45.25m;
            const decimal MEZZANINE = 85.00m;
            const decimal PARKINGFEE = 10.00m;
            const decimal DINNERPACKAGE = 35.00m;

            // variables
            int intNumOfGallery, intNumOfFloorOne, intNumOfFloorTwo, intNumOfMezzanine;
            decimal decTotalCost;
            string strName, strPhoneNumber, strOutput;

            strName = txtName.Text;
            strPhoneNumber = txtPhoneNumber.Text;

            int intSelectedNumOfVehicles = lstNumOfVehicles.SelectedIndex;
            int intEventFee = switchEventFee();
            int intTotalNumTickets = TicketCounter();

            int.TryParse(txtGallery.Text, out intNumOfGallery);
            int.TryParse(txtFloorOne.Text, out intNumOfFloorOne);
            int.TryParse(txtFloorTwo.Text, out intNumOfFloorTwo);
            int.TryParse(txtMezzanine.Text, out intNumOfMezzanine);

            if (IsValidData() == false) return;

            decTotalCost = (GALLERY * intNumOfGallery) 
                + (FLOORONE * intNumOfFloorOne) + (FLOORTWO * intNumOfFloorTwo) 
                + (MEZZANINE * intNumOfMezzanine) 
                + (intSelectedNumOfVehicles * PARKINGFEE) + intEventFee;
            if(chbDinnerPackage.Checked == true)
            {
                decTotalCost += (DINNERPACKAGE * intTotalNumTickets);
            }

            strOutput = "Name: " + strName + Environment.NewLine
                + "Phone number: " + strPhoneNumber + Environment.NewLine
                + "Total cost: $" + decTotalCost + Environment.NewLine;

            lblTotal.Text = strOutput;
        }
    }
}
