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
    public partial class Form1 : Form {
        const int GET_CODE = 4;
        const int CODE_LENGTH = 3;
        string my_currency = "";
        string convert_currency = "";
        string user_input = "";

        public Form1() {
            InitializeComponent();
            MyCurrencyBox.DataSource = Currency_Exchange_Class.InitialiseComboBox();
            ConvertCurrencyBox.DataSource = Currency_Exchange_Class.InitialiseComboBox();
            MyCurrencyBox.SelectedIndexChanged += new EventHandler(MyCurrencyBox_SelectedIndexChanged);
            ConvertCurrencyBox.SelectedIndexChanged += new EventHandler(ConvertCurrencyBox_SelectedIndexChanged);
            ConvertCurrencyLabel.Enabled = false;
            ConvertCurrencyBox.Enabled = false;
            MyAmountLabel.Enabled = false;
            MyAmountText.Enabled = false;
            MyAmountCode.Visible = false;
            ConvertAmountCode.Visible = false;
            EqualsButton.Enabled = false;
            ConvertAmountLabel.Enabled = false;
            ConvertAmountText.Enabled = false;
            RepeatConversionGroup.Visible = false;
        }//end Form1

        private void MyCurrencyBox_SelectedIndexChanged(object sender, EventArgs e) {
            my_currency = MyCurrencyBox.SelectedValue.ToString();

            if (my_currency != "") {
                MyAmountCode.Text = my_currency.Substring(my_currency.Length - GET_CODE, CODE_LENGTH); ;
                MyCurrencyLabel.Enabled = false;
                MyCurrencyBox.Enabled = false;
                ConvertCurrencyLabel.Enabled = true;
                ConvertCurrencyBox.Enabled = true;
            }
        }

        private void ConvertCurrencyBox_SelectedIndexChanged(object sender, EventArgs e) {
            convert_currency = ConvertCurrencyBox.SelectedValue.ToString();
      
            if (convert_currency != "") {
                ConvertAmountCode.Text = convert_currency.Substring(convert_currency.Length - GET_CODE, CODE_LENGTH);
                ConvertCurrencyLabel.Enabled = false;
                ConvertCurrencyBox.Enabled = false;
                MyAmountLabel.Enabled = true;
                MyAmountText.Enabled = true;
                MyAmountCode.Visible = true;
            }
            
        }

        private void MyAmountText_TextChanged(object sender, EventArgs e) {
            user_input = MyAmountText.Text;

            if (user_input != "") {
                EqualsButton.Enabled = true;
                ConvertAmountLabel.Enabled = false;
                ConvertAmountText.Enabled = false;
                RepeatConversionGroup.Visible = false;
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e) {
            double my_amount = 0;
            double converted_amount = 0;

            if (double.TryParse(user_input, out my_amount) == true) {
                if (my_amount > 0) {
                    converted_amount = Currency_Exchange_Class.CurrencyConversion(my_currency, convert_currency, my_amount);
                    ConvertAmountText.Text = converted_amount.ToString();
                    MyAmountLabel.Enabled = false;
                    MyAmountText.Enabled = false;
                    ConvertAmountCode.Visible = true;
                    RepeatConversionGroup.Visible = true;
                } else {
                    MessageBox.Show("You entered a negative number", "Negative Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Please enter a number greater than zero", "Non-Numerical Value",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RepeatConversion_CheckedChanged(object sender, EventArgs e) {
            if (YesButton.Checked) {
                Application.Restart();
            } else if (NoButton.Checked) {
                this.Close();
            }
        }

    }//end class
}

