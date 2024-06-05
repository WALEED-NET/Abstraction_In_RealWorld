namespace AbstractionWithInterface
{
    // This is an interface that defines the common properties and methods for all bank accounts.

    public interface IBankAccount
    {
        string AccountNumber { get; set; }
        decimal Balance { get; set; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

    
}