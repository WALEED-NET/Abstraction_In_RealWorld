namespace Abstraction
{
    // This is an abstract class that defines the common properties and methods for all bank accounts.

    public abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);
    }
}