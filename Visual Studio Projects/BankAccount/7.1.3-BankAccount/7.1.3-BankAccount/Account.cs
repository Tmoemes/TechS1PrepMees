namespace BankAccount
{
    public  class Account
    {
        public double Balance { get; private set; }
        private readonly double _minBalance;

        public Account(double startingBalance = 0, double minBalance = 0)
        {
            _minBalance = minBalance;
            Balance = startingBalance > minBalance ? startingBalance:minBalance;
        }

        public string GetStringBalance()
        {
            return Balance.ToString();
        }

        public bool Withdraw(double amount)
        {
            if (amount < 0) return false;
            if (Balance - amount < _minBalance) return false;
            Balance -= amount;
            return true;
        }

        public bool Deposit(double amount)
        {
            if (amount < 0) return false;
            Balance += amount;
            return true;
        }

        public bool TransferTo(Account account, double amount)
        {
            if (amount < 0) return false;
            if (Balance - amount < _minBalance) return false;
            Withdraw(amount);
            account.Deposit(amount);
            return true;
        }

    }
}
