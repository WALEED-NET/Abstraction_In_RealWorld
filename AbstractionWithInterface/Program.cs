using Abstraction;
using AbstractionWithInterface;

namespace AbstractionWithInterface
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Here interface is used to create an object of the SavingAccount class that implements the IBankAccount interface.
            IBankAccount account1 = new Savingccount();

            account1.AccountNumber = "1111";
            account1.Balance = 6000;

            account1.Deposit(100);
            account1.Withdraw(1000);

        }

    }

    
}