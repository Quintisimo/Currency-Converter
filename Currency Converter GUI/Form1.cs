using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter_GUI {

    /// <summary>
    /// GUI program that converts currencies.
    /// 
    /// Author Quintus Cardozo April 2015
    /// Student Number: n9703578
    /// 
    /// </summary>
    public partial class Form1 : Form {
        string myCurrency = "";
        string convertCurrency = "";
        string userInput = "";

        public Form1() {
            InitializeComponent();
            myCurrencyBox.DataSource = Currency_Exchange_Class.InitialiseComboBox();
            convertCurrencyBox.DataSource = Currency_Exchange_Class.InitialiseComboBox();
            myCurrencyBox.SelectedIndexChanged += new EventHandler(myCurrencyBox_SelectedIndexChanged);
            convertCurrencyBox.SelectedIndexChanged += new EventHandler(convertCurrencyBox_SelectedIndexChanged);
            DisableControls();
        }//end Form1

        /// <summary>
        /// Disables all the controls except the first combo box.
        /// </summary>
        private void DisableControls() {
            convertCurrencyLabel.Enabled = false;
            convertCurrencyBox.Enabled = false;
            myAmountLabel.Enabled = false;
            myAmountText.Enabled = false;
            myAmountCode.Visible = false;
            convertAmountCode.Visible = false;
            equalsButton.Enabled = false;
            convertAmountLabel.Enabled = false;
            convertAmountText.Enabled = false;
            repeatConversionGroup.Visible = false;
        }

        /// <summary>
        /// Resets the form so the user can perform another calculation.
        /// </summary>
        private void ResetForm() {
            myCurrencyBox.ResetText();
            convertCurrencyBox.ResetText();
            myAmountText.Clear();
            convertAmountText.Clear();
            yesButton.Checked = false;
            noButton.Checked = false;
            DisableControls();
            myCurrencyLabel.Enabled = true;
            myCurrencyBox.Enabled = true;
        }

        private void myCurrencyBox_SelectedIndexChanged(object sender, EventArgs e) {
            myCurrency = myCurrencyBox.SelectedValue.ToString();

            if (myCurrency != "") {
                myAmountCode.Text = ((Currencies)myCurrencyBox.SelectedIndex).ToString();
                myCurrencyLabel.Enabled = false;
                myCurrencyBox.Enabled = false;
                convertCurrencyLabel.Enabled = true;
                convertCurrencyBox.Enabled = true;
            }
        }

        private void convertCurrencyBox_SelectedIndexChanged(object sender, EventArgs e) {
            convertCurrency = convertCurrencyBox.SelectedValue.ToString();

            if (convertCurrency != "") {
                convertAmountCode.Text = ((Currencies)convertCurrencyBox.SelectedIndex).ToString();
                convertCurrencyLabel.Enabled = false;
                convertCurrencyBox.Enabled = false;
                myAmountLabel.Enabled = true;
                myAmountText.Enabled = true;
                myAmountCode.Visible = true;
            }
            
        }

        private void myAmountText_TextChanged(object sender, EventArgs e) {
            userInput = myAmountText.Text;

            if (userInput != "") {
                equalsButton.Enabled = true;
                convertAmountLabel.Enabled = false;
                convertAmountText.Enabled = false;
                repeatConversionGroup.Visible = false;
            }
        }

        private void equalsButton_Click(object sender, EventArgs e) {
            double my_amount = 0;
            double converted_amount = 0;

            if (double.TryParse(userInput, out my_amount) == true) {
                if (my_amount > 0) {
                    converted_amount = Currency_Exchange_Class.CurrencyConversion(
                        (Currencies)myCurrencyBox.SelectedIndex, 
                        (Currencies)convertCurrencyBox.SelectedIndex, my_amount);
                    convertAmountText.Text = converted_amount.ToString();
                    myAmountLabel.Enabled = false;
                    myAmountText.Enabled = false;
                    convertAmountCode.Visible = true;
                    repeatConversionGroup.Visible = true;
                } else {
                    MessageBox.Show("You entered a negative number", "Negative Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myAmountText.Clear();
                }
            } else {
                MessageBox.Show("Please enter a number greater than zero", "Non-Numerical Value",MessageBoxButtons.OK, MessageBoxIcon.Error);
                myAmountText.Clear();
            }
        }

        private void repeatConversion_CheckedChanged(object sender, EventArgs e) {
            DialogResult quit;

            if (yesButton.Checked) {
                ResetForm();
            } else if (noButton.Checked) {
                quit = MessageBox.Show("Are you sure you want to exit", "Quit Applicaion", MessageBoxButtons.YesNo);
                
                if (quit == System.Windows.Forms.DialogResult.Yes) {
                    this.Close();
                } else if (quit == System.Windows.Forms.DialogResult.No) {
                    noButton.Checked = false;
                }
            }
        }

    }//end class
}