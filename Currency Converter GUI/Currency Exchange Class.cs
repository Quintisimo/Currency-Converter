using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter_GUI {

    enum Currencies { AUD = 1, CYN, DKK, EUR, INR, NZD, AED, GBP, USD, VND };
    /// <summary>
    /// 
    /// </summary>
    static class Currency_Exchange_Class {

        private static double[] xRates = { 0, 1, 4.2681, 5.0844, 0.6849, 43.5921, 0.9705, 2.7094, 0.4963, 0.7382, 19115.5547 };


        /// <summary>
        /// Provides country names and currency code which  can be used to initialise a Combo Box
        /// </summary>
        /// <returns> string array each elemnt of which contains the country name and three letter currency code</returns>
        public static string[] InitialiseComboBox() {

            string[] countries = {   "",
                                    "Australia (AUD)",
                                    "China (CNY)",
                                    "Denmark (DKK)",
                                    "Europe (EUR)",
                                    "India (INR)",
                                    "New Zealand (NZD)",
                                    "United Arab Emirates (AED)",
                                    "United Kingdom (GBP)",
                                    "United States (USD)",
                                    "Vietnam (VND)" };

            return countries;
        } //end InitialiseComboBox()             

        /// <summary>
        /// Converts the amount entered by the user to Australian dollars first and then converts that
        /// to the currency they want.
        /// </summary>
        /// <param name="my_currency_type">User's Currency type</param>
        /// <param name="convert_currency_type">Cureency the user wants to convert to</param>
        /// <param name="amount">The amount the user entered</param>
        /// <returns></returns>
        public static double CurrencyConversion(string my_currency_type, string convert_currency_type, double amount) {
            double convert_amount = 0;
            int country = 0;

            if (my_currency_type == "Australia (AUD)") {
                country = (int)Currencies.AUD;
                amount = amount * xRates[country];
            } else if (my_currency_type == "China (CNY)") {
                country = (int)Currencies.CYN;
                amount = amount * xRates[country];
            } else if (my_currency_type == "Denmark (DKK)") {
                country = (int)Currencies.DKK;
                amount = amount * xRates[country];
            } else if (my_currency_type == "Europe (EUR)") {
                country = (int)Currencies.EUR;
                amount = amount * xRates[country];
            } else if (my_currency_type == "India (INR)") {
                country = (int)Currencies.INR;
                amount = amount * xRates[country];
            } else if (my_currency_type == "New Zealand (NZD)") {
                country = (int)Currencies.NZD;
                amount = amount * xRates[country];
            } else if (my_currency_type == "United Arab Emirates (AED)") {
                country = (int)Currencies.AED;
                amount = amount * xRates[country];
            } else if (my_currency_type == "United Kingdom (GBP)") {
                country = (int)Currencies.GBP;
                amount = amount * xRates[country];
            } else if (my_currency_type == "United States (USD)") {
                country = (int)Currencies.USD;
                amount = amount * xRates[country];
            } else if (my_currency_type == "Vietnam (VND)") {
                country = (int)Currencies.VND;
                amount = amount * xRates[country];
            }

            if (convert_currency_type == "Australia (AUD)") {
                country = (int)Currencies.AUD;
                convert_amount = Math.Round(amount * xRates[country], 4);
            } else if (convert_currency_type == "China (CNY)") {
                country = (int)Currencies.CYN;
                convert_amount = Math.Round(amount * xRates[country], 4);
            } else if (convert_currency_type == "Denmark (DKK)") {
                country = (int)Currencies.DKK;
                convert_amount = Math.Round(amount * xRates[country], 4);
            } else if (convert_currency_type == "Europe (EUR)") {
                country = (int)Currencies.EUR;
                convert_amount = Math.Round(amount * xRates[country], 4);
            } else if (convert_currency_type == "India (INR)") {
                country = (int)Currencies.INR;
                convert_amount = Math.Round(amount * xRates[country], 4);
            } else if (convert_currency_type == "New Zealand (NZD)") {
                country = (int)Currencies.NZD;
                convert_amount = Math.Round(amount * xRates[country], 4);
            } else if (convert_currency_type == "United Arab Emirates (AED)") {
                country = (int)Currencies.AED;
                convert_amount = Math.Round(amount * xRates[country], 4);
            } else if (convert_currency_type == "United Kingdom (GBP)") {
                country = (int)Currencies.GBP;
                convert_amount = Math.Round(amount * xRates[country], 4);
            } else if (convert_currency_type == "United States (USD)") {
                country = (int)Currencies.USD;
                convert_amount = Math.Round(amount * xRates[country], 4);
            } else if (convert_currency_type == "Vietnam (VND)") {
                country = (int)Currencies.VND;
                convert_amount = Math.Round(amount * xRates[country], 4);
            }

            return convert_amount;
        }

    }//end class
}
