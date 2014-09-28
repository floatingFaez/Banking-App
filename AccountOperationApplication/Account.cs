using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApplication
{
    class Account
    {
        private string name;
        private string number;
        private double balance;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Number
        {
            set
            {
                number = value;
            }
            get
            {
                return number;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
        }

        public void DoDeposit(double amount)
        {
            balance += amount;
        }

        public void DoWitdraw(double amount)
        {
            balance -= amount;
        }

    }
}
