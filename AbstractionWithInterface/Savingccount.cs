using Abstraction;
namespace AbstractionWithInterface
{
    // This is a concrete class that implements the IBankAccount interface.
    public class Savingccount : IBankAccount
    {
        private const decimal DailyWithdrawalLimit = 2000;

        // Note here That we have to implement the properties of the interface Unlike the abstract class where we can choose to implement them or not.
        public string AccountNumber { get ; set ; }
        public decimal Balance { get ; set ; }

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
