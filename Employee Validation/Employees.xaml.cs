using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment04_Start
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EmployeesWindow : Window
    {

        //declare a field for a List<string> collection
        List<string> employeeList = new List<string>();
        public EmployeesWindow()
        {
            InitializeComponent();

            Load_Data();
        }

        private void Load_Data()
        {
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");

            for (decimal decRate=1.0m; decRate<=5.00m; decRate+=.5m)
            {
                cboCommissionRate.Items.Add(decRate.ToString("N1"));
            }
        }

        private void btnEmployeeList_Click(object sender, RoutedEventArgs e)
        {
            //Create an instance of the EmployeeList window
            EmployeeListWindow employeeListWindow = new EmployeeListWindow();
            //load txtEmployeeList TextBox control with string data from List<string> collection

            foreach(string emp in employeeList)
            {
                employeeListWindow.txtEmployeeList.Text = employeeListWindow.txtEmployeeList.Text + emp;
            }
            //Call method to display window as a dialog
            employeeListWindow.ShowDialog();


        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string employeeInfo;
            DateTime localDate = DateTime.Now;
            DateTime.TryParse(txtStartDate.Text, out DateTime startDay);
            TimeSpan intDays = startDay.Subtract(localDate);

            // Must perform all data validation. Create a method to do this
            txtEmployeeName.Text.Trim();

            if (ValidateEmployeeID(txtEmployeeID) &&
                IsPresent(txtEmployeeName, txtEmployeeName.Text) &&
                IsPresent(txtStartDate, txtStartDate.Text) &&
                DateValidation(txtStartDate) &&
                IsChecked(cboGender) &&
                IsChecked(cboCommissionRate) == false) return;

            if (cboGender.SelectedItem.ToString() == "Male")
            {
                employeeInfo = txtEmployeeName.Text + "Starts work in " + intDays + " day(s). He will have a commission rate of "
                    + cboCommissionRate.Text;
            }
            else
            {
                employeeInfo = txtEmployeeName.Text + "Starts work in " + intDays + " day(s). She will have a commission rate of "
                    + cboCommissionRate.Text;
            }
            employeeList.Add(employeeInfo);

            //employeeInfo = $"{txtEmployeeName.Text} Starts work in {intDays}";
            //Add employee information to List<string> collection. Make
            //sure you use String.Format or $ string interpolated technique

        }

        public bool ValidateEmployeeID(TextBox textBox)
        {
            int idLength = 7;
            var employeeID = txtEmployeeID.Text.Trim();
            var idSplit = employeeID.Split('-');

            if(employeeID.Length != idLength ||
                idSplit.Length != 2 ||
                idSplit[0].Length != 2 ||
                idSplit[1].Length != 4 ||
                !idSplit[0].All(char.IsLetter) ||
                !idSplit[0].All(char.IsUpper) ||
                !idSplit[1].All(char.IsDigit)) // I still need to validate the 2 0s  
            {
                MessageBox.Show("The employee ID must follow the format XX-0099", "Entry Error");
                txtEmployeeID.Focus();
                return false;
            }
            return true;
        }
        public bool DateValidation(TextBox textBox)
        {
            DateTime date;
            if(DateTime.TryParse(txtStartDate.Text, out date) == false)
            {
                MessageBox.Show("That is not a valid date, please try again", "Entry Error.");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public bool IsPresent(TextBox textBox, string name)
        {
            if(textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public bool IsChecked(ComboBox comboBox)
        {
            if(comboBox.SelectedItem == null)
            {
                MessageBox.Show("You must select something.", "Entry Error");
                return false;
            }
            return true;
        }

    }
}
