using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._1._3_BankAccount
{
    public partial class Form1 : Form
    {
        


        private readonly Account _account1 = new Account(50,-100);
        private readonly Account _account2 = new Account(150,-50);

        private double inputValue;

        public Form1()
        {
            InitializeComponent();
            UpdateBalanceLabels();

        }

        private void txtbox_Input_TextChanged(object sender, EventArgs e)
        {
            //make default colour of text red, only change to black if it is valid
            txtbox_Input.ForeColor = Color.Red;
            try
            {
                inputValue = double.Parse(txtbox_Input.Text);
                //input is valid but still need to check if it is negative
                txtbox_Input.ForeColor = double.Parse(txtbox_Input.Text) < 0 ? Color.Red : Color.Black;
            }
            catch//this is here to deal with inputs that are not parseable to a double
            {
                //there is no need for an error message here because it will be given later
                //if someone tries to perform an action with a string or negative number
            }
        }

        private void btn_Deposit2_Click(object sender, EventArgs e)
        {
            if (inputValue <= 0) MessageBox.Show(@"Please enter a positive value", @"Invalid amount entered",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                _account2.Deposit(inputValue);
                UpdateBalanceLabels();
            }
        }

        private void btn_Deposit1_Click(object sender, EventArgs e)
        {
            if (inputValue <= 0) MessageBox.Show(@"Please enter a positive value", @"Invalid amount entered",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _account1.Deposit(inputValue);
                UpdateBalanceLabels();
            }
        }

        private void btn_Withdraw1_Click(object sender, EventArgs e)
        {
            if(!_account1.Withdraw(inputValue)) MessageBox.Show(@"Balance too low", @"Invalid amount entered",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            UpdateBalanceLabels();
        }

        private void btn_Withdraw2_Click(object sender, EventArgs e)
        {
            if (!_account2.Withdraw(inputValue)) MessageBox.Show(@"Balance too low", @"Invalid amount entered",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            UpdateBalanceLabels();
        }

        private void btn_Transfer1_Click(object sender, EventArgs e)
        {
            if(!_account1.TransferTo(_account2,inputValue)) MessageBox.Show(@"Balance too low", @"Invalid amount entered",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            UpdateBalanceLabels();
        }

        private void btn_Transfer2_Click(object sender, EventArgs e)
        {
            if (!_account2.TransferTo(_account1, inputValue)) MessageBox.Show(@"Balance too low", @"Invalid amount entered",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            UpdateBalanceLabels();
        }

        private void UpdateBalanceLabels()
        {
            lbl_Balance1Value.ForeColor = _account1.Balance < 0 ? Color.Red : Color.Black;
            lbl_Balance2Value.ForeColor = _account2.Balance < 0 ? Color.Red : Color.Black;
            lbl_Balance1Value.Text = _account1.GetStringBalance();
            lbl_Balance2Value.Text = _account2.GetStringBalance();
        }
    }
}
