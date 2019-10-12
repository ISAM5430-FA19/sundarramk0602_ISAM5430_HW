using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW05_B
{
    class Account
    {
        public string Name { get; set; }
        private decimal balance;

        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            balance = initialBalance;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > 0.0m)
                    balance = value;
            }

        }

        public void Withdrawal(decimal withdrawAmount)
        {
            if (withdrawAmount < balance)
            {
                balance = balance - withdrawAmount;
            }
            else if (withdrawAmount > balance)
            {
                balance = balance + 0;
                WriteLine("Withdrawal amount exceeded account Balance");
            }
        }
    }
}
