namespace Abstraction
{

    // This is a concrete class that inherits from the BankAccount class.
    // It provides the implementation details for the Deposit and Withdraw methods.

    public class Savingccount : BankAccount
    {
        private const decimal DailyWithdrawalLimit = 2000;
        public override void Deposit(decimal amount)
        {
            //implementation details
            if (amount < 0)
                throw new InvalidOperationException();

            Balance += amount;
        }
        public override void Withdraw(decimal amount)
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