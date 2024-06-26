using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractionWithOutAbstractClass
{


    /*
        توضيح بعض الفروقات بين استخدام الكلاسات الابستراكت والكلاسات العادية مع الفانكشنات الافتراضية

        يبدو أن الفرق بين استخدام كلاس ابستراكت وكلاس عادي مع الفانكشنات الافتراضية يؤثر بشكل كبير على التصميم 
        والقابلية للتوسيع والصيانة لنظام البرمجيات. كل نهج له مجموعة من المزايا والاعتبارات التي تؤثر على كيفية تطور النظام مع مرور الوقت.

        
        The choice between using an abstract class and a non-abstract class with virtual methods significantly impacts the design,
        extensibility, and maintainability of a software system. Each approach has its own set of advantages and considerations that
        influence how a system can evolve over time.

        [Abstract Class]

        Advantages:
        1.	Enforces a Contract: Abstract classes allow you to define a set of methods that derived classes must implement, ensuring a consistent interface across all subclasses.
        2.	Prevents Instantiation: Abstract classes cannot be instantiated on their own, preventing misuse and ensuring that only complete, derived classes are used within the system.
        3.	Supports Base Functionality: They can provide default implementations of some methods while leaving others as abstract, requiring overrides.


        Considerations:
        •	Single Inheritance: In languages like C#, a class can only inherit from one abstract class, which might limit flexibility if a class needs to inherit behavior from multiple sources.
        •	Design Rigidity: The contract defined by an abstract class is relatively rigid. Changes to the abstract class can have widespread implications for all derived classes.


        [ Non-Abstract Class with Virtual Methods ]

        Advantages:
        1.	Flexibility in Implementation: Derived classes can choose to override virtual methods, but it's not mandatory. This allows for more flexible implementations.
        2.	Direct Instantiation: Non-abstract classes can be instantiated, making them suitable for scenarios where a default implementation might be sufficient but can be extended if needed.
        3.	Multiple Usage Scenarios: They provide a base implementation that can be used as-is, extended, or completely overridden, offering a range of options to developers.


        Considerations:
        •	Inconsistent Implementation: Since overriding virtual methods is optional, there's a risk of inconsistent
            implementations across derived classes. Some might override the methods, while others use the base implementation.

        •	Potential for Misuse: The ability to instantiate the base class directly might lead to misuse in scenarios where
            only derived implementations should be used, potentially leading to errors if the base class's implementation is not intended for direct use.


        Impact on Design and Extensibility
        •	Abstract Classes are ideal when you have a clear and stable contract that all implementations must adhere to.
            They are best used when you want to enforce a certain structure or behavior across a family of classes.

        •	Non-Abstract Classes with Virtual Methods offer more flexibility and are suitable for scenarios where the
            base behavior can stand on its own but also allows for customization. This approach is beneficial when 
            the system needs to be open for extension but closed for modification, adhering to the Open/Closed Principle.


        Choosing between these two approaches depends on the specific requirements of your system, the expected evolution of your
            class hierarchy, and the need for flexibility versus consistency. In practice, a combination of both approaches is often used 
            to balance the benefits of each and address the limitations of a single inheritance model, especially in complex systems.
     
     
     */


    public class BankAccount
    {
        public BankAccount(string accountNumber)
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


        public virtual void Deposit(decimal amount)
        {
            Console.WriteLine("d");
        }

        public virtual void Withdraw(decimal amount)
        {
            Console.WriteLine("w");
        }

        public void Log(string message)
        {
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            Console.WriteLine($"[{timestamp}] {message}");
            Console.WriteLine($"[{timestamp}] Balance Info: Account No: '{_accountNumber}', Balance:'{_balance.ToString("C")}'");
        }

    }

    public class Savingccount : BankAccount
    {
        public Savingccount(string accountNumber) : base(accountNumber) //  
        {

        }

        private const decimal DailyWithdrawalLimit = 2000;

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
        //public override void Withdraw(decimal amount)
        //{
        //    //implementation details

        //    if (amount > DailyWithdrawalLimit)
        //    {
        //        Log($"REJECTED: MAX WITHDRAWABLE {amount.ToString("C")} > {DailyWithdrawalLimit.ToString("C")}");
        //        return;
        //    }

        //    if (amount > _balance)
        //    {
        //        Log($"REJECTED: INSUFFICIENT BALANCE {amount.ToString("C")} > {_balance.ToString("C")}");
        //        return;
        //    }

        //    _balance -= amount;

        //    Log($"ACCEPTED:  {amount.ToString("C")} withdrawed");

        //}


    }

    public class Program
    { 
        public static void Main(string[] args)
        {

            BankAccount account1 = new Savingccount("111");



            account1.Deposit(100);
            account1.Withdraw(1000);

            BankAccount account2 = new BankAccount("222");

            account2.Deposit(100);
            account2.Withdraw(1000);


        }

    }


}
