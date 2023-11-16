// Project 2 1 / 3
//Filename: Student
//Name: Tiffany Ledbetter
//Date: 10/23/2023

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        private const decimal CreditHourPrice = 76.0m;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCreditHours.Text, out int creditHours))
            {
                decimal amountOwed = creditHours * CreditHourPrice;

                // Display the selected payment option
                if (radioButtonCash.Checked)
                {
                   labelAmountOwed.Text = "Pay the cashier $" + amountOwed;

                }
                else if (radioButtonCheck.Checked)
                {
                    labelAmountOwed.Text = "Please make check for $" + amountOwed + " payable to RCCC";
                }
                else if (radioButtonCredit.Checked)
                {
                    labelAmountOwed.Text = "Your card will be charged $" + amountOwed;
                    textBoxCreditCardNumber.Visible = true;
                    textBoxCreditCardNumber.Text = "Enter your credit card number";
                }
                else if (radioButtonFinancialAid.Checked)
                {
                    labelAmountOwed.Text = "Please check your student email for further instructions.";
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBoxCreditHours.Clear();
            labelAmountOwed.Text = string.Empty;
            radioButtonCash.Checked = false;
            radioButtonCheck.Checked = false;
            radioButtonCredit.Checked = false;
            radioButtonFinancialAid.Checked = false;
            textBoxCreditCardNumber.Clear();
            textBoxCreditCardNumber.Visible = false;

            textBoxCreditHours.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelAmountOwed_Click(object sender, EventArgs e)
        {

        }
    }
}
