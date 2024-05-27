using Exercise.Entities.Exception;

namespace Exercise.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withdraw)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdraw;
        }

        public void Deposit(double amount)
        {
            Balance += amount;   
        }

        public void Withdraw(double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}
