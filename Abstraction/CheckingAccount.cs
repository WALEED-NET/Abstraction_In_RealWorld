namespace Abstraction
{

    // This is a concrete class that inherits from the BankAccount class.
    // It provides the implementation details for the Deposit and Withdraw methods.

    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountNumber) : base(accountNumber) //  
        {

        }

        private const decimal DailyWithdrawalLimit = 5000;
        public override void Deposit(decimal amount)
        {
            //implementation details
            if (amount <= 0)
            {
                Log($"REJECTED: Deposit NEGATIVE {amount.ToString("C")}");
                return;
            }

            _balance += amount;
            Log($"ACCEPTED:  {amount.ToString("C")} deposited");
        }

        public override void Withdraw(decimal amount)
        {
            //implementation details 

            if (amount > DailyWithdrawalLimit)
            {
                Log($"REJECTED: MAX WITHDRAWABLE {amount.ToString("C")} > {DailyWithdrawalLimit.ToString("C")}");
                return;
            }

            if (amount > _balance)
            {
                Log($"REJECTED: INSUFFICIENT BALANCE {amount.ToString("C")} > {_balance.ToString("C")}");
                return;
            }

            _balance -= amount;

            Log($"ACCEPTED:  {amount.ToString("C")} withdrawed");
        }
    }
}