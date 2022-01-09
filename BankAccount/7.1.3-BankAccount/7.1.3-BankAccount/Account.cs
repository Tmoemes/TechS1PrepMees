using System;
using System.Collections.Generic;
using System.Text;

namespace _7._1._3_BankAccount
{
    class Account
    {
        public double Balance { get; private set; }
        private double _minBalance;

        public Account(double startingBalance, double minBalance)
        {
            Balance = startingBalance;
            _minBalance = minBalance;
        }

        public string GetStringBalance()
        {
            return Balance.ToString();
        }

        public bool Withdraw(double amount)
        {
            if (Balance - amount < _minBalance) return false;
            Balance -= amount;
            return true;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool TransferTo(Account account, double amount)
        {
            if (Balance - amount < _minBalance) return false;
            Withdraw(amount);
            account.Deposit(amount);
            return true;
        }

    }
}
