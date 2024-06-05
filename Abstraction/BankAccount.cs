namespace Abstraction
{
    // This is an abstract class that defines the common properties and methods for all bank accounts.

    public abstract class BankAccount
    {
        protected BankAccount(string accountNumber)
        {
            _accountNumber = accountNumber;
        }

        // 
        protected readonly string _accountNumber;
        protected decimal _balance;

        public string AccountNumber => _accountNumber;  // Read-only property

        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }


        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);

        public void Log(string message)
        {
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            Console.WriteLine($"[{timestamp}] {message}");
            Console.WriteLine($"[{timestamp}] Balance Info: Account No: '{_accountNumber}', Balance:'{_balance.ToString("C")}'");
        }

    }
}