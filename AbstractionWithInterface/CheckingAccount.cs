namespace AbstractionWithInterface
{
    // This is a concrete class that implements the IBankAccount interface.
    public class CheckingAccount : IBankAccount
    {
        private const decimal DailyWithdrawalLimit = 5000;

        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            //implementation details
            if (amount < 0)
                throw new InvalidOperationException();

            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            //implementation details 

            if (amount < 0)
                throw new InvalidOperationException();

            if (amount > DailyWithdrawalLimit)
                throw new InvalidOperationException();

            Balance -= amount;
        }
    }

    
}