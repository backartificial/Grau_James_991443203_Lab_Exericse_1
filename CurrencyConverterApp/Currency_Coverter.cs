/**
 * 
 * File: Currency_Converter.cs
 * Date: May 27, 2018
 * Developer: James Grau
 * Student ID: 991443203 
 * 
**/

// Include the Needed Packages
using System;
using System.Windows.Forms;

// Is the Projects Namespace
namespace CurrencyConverterApp {
    // Derive this form from the base Form Class
    public partial class frmCurrencyConverter : Form {

        // This method is used to initialize the form
        public frmCurrencyConverter() {
            // Initialize the form
            InitializeComponent();
        }

        /**
         * 
         * This method is called when the form is loaded to load all of the options into the combobox
         * 
         **/
        private void Currency_Coverter_Load(object sender, EventArgs e) {
            // Add each "Convert To" Option into it's respective combobox
            cmbConvertTo.Items.Add("Australian Dollar (AUD)");
            cmbConvertTo.Items.Add("European Euro (EUR)");
            cmbConvertTo.Items.Add("Jamaican Dollar (JMD)");
            cmbConvertTo.Items.Add("Philippine Peso (PHP)");
            cmbConvertTo.Items.Add("United States Dollar (USD)");            
        }

        /**
         * 
         * This method is used to add an action to perform the conversion when the convert button is pressed
         * 
         **/
        private void btnConvert_Click(object sender, EventArgs e) {
            // Initialize needed variables
            double CADAmount, newAmount = 0;
            string srtForm = "";

            // Check if nothing and non number entered as amount value
            if (txtAmount.Text.Length  <= 0 || double.TryParse(txtAmount.Text, out CADAmount) == false) {
                // Display error message
                MessageBox.Show("Oops.. That is an invalid amount.  Please enter a number.");

                // Return nothing to exit our of method
                return;
            }

            // Check if a "convert to" option is not selected
            if (cmbConvertTo.SelectedIndex == -1) {
                // Display an error message
                MessageBox.Show("Oops... You need to select a conver to value in order to convert entered amount.  Please try again.");

                // Return nothing to get out of method
                return;
            }
            
            // After input/selection validation, based on the selected "convert to" value, switch the case
            switch (cmbConvertTo.SelectedIndex) {
                // Case for index 0
                case 0:
                    // Calculate the new value
                    newAmount = CADAmount * 1.02;

                    // Set the short form surrency identifier
                    srtForm = "AUD";
                break;

                // Case for index 1
                case 1:
                    // Calculate the new value
                    newAmount = CADAmount * 0.66;

                    // Set the short form surrency identifier
                    srtForm = "EUR";
                break;

                // Case for index 2
                case 2:
                    // Calculate the new value
                    newAmount = CADAmount * 97.31;

                    // Set the short form surrency identifier
                    srtForm = "JMD";
                break;

                // Case for index 3
                case 3:
                    // Calculate the new value
                    newAmount = CADAmount * 40.47;

                    // Set the short form surrency identifier
                    srtForm = "PHP";
                break;

                // Case for index 4
                case 4:
                    // Calculate the new value
                    newAmount = CADAmount * 0.77;

                    // Set the short form surrency identifier
                    srtForm = "USD";
                break;
            }

            // Display the conversion lbl and then set it to the correct conversion value
            lblResult.Visible = true;
            lblResult.Text = string.Format("{0:C}", CADAmount) + " CAD is \n" + string.Format("{0:C}", newAmount) + " " + srtForm;
        }
    }
}