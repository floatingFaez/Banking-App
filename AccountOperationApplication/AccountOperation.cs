using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApplication
{
    public partial class AccountOperationForm : Form
    {
        public AccountOperationForm()
        {
            InitializeComponent();
        }

        private Account anAccount;
        private void createButton_Click(object sender, EventArgs e)
        {
            if (customerNameTextBox.Text != string.Empty && accountNumberTextBox.Text != string.Empty)
            {
                anAccount = new Account();
                anAccount.Name = customerNameTextBox.Text;
                anAccount.Number = accountNumberTextBox.Text;

                customerNameTextBox.Text = string.Empty;
                accountNumberTextBox.Text = string.Empty;
                MessageBox.Show(@"Your Account has been created !!");
            }
            else
            {
                MessageBox.Show(@"Please enter acount number and customer name !!");
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
                anAccount.DoDeposit(Convert.ToDouble(amountTextBox.Text));    
            }
            else
                MessageBox.Show(@"Create an account first");    
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
            anAccount.DoWitdraw(Convert.ToDouble(amountTextBox.Text));
            }
            else
                 MessageBox.Show(@"Create an account first");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
            string msg = anAccount.Name + ", your account number is " + anAccount.Number + " and it's balance : " +
                         anAccount.Balance;
            MessageBox.Show(msg);
            }
            else
                MessageBox.Show(@"Create an account first");
        }
    }
}
