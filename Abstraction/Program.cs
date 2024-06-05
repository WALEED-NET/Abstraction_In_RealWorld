namespace Abstraction
{
    class Program
    {
        /*
         
         What's Abstraction : Abstraction is the concept of hiding the complex implementation details and showing only the necessary features of the object.
        --------------------

         When to use Abstraction : 
        --------------------------
        •	When you want to provide a common interface for a group of related classes.
        •	When you want to hide the complex implementation details and only show the necessary features of the object.
        •	When you want to define a contract for the derived classes and require them to implement the contract.

        1.	Frameworks and Libraries: When developing frameworks or libraries, abstraction is crucial.

        2.	User Interfaces: Abstraction is commonly used in user interface development.

        3.	Database Access: Abstraction is essential when working with databases.
            Instead of directly interacting with the database implementation,
            developers can use an abstraction layer, such as an Object-Relational Mapping (ORM) framework.
            This allows for easier database operations, decouples the code from specific database technologies,
            and provides a consistent interface for data access.


        4.	Dependency Injection: Abstraction plays a vital role in dependency injection. By defining interfaces 
            or abstract classes for dependencies, you can easily swap out implementations without modifying the code 
            that relies on them. This promotes flexibility, testability, and maintainability.

        5.	System Architecture: Abstraction is fundamental in designing scalable and modular system architectures.
            By abstracting complex subsystems into separate modules or services, you can isolate their functionality
            and interactions. This promotes loose coupling, making it easier to modify or replace individual
            components without affecting the entire system.
         
        How to implement Abstraction in C# :
        -----------------------------------

        1. Abstract Classes : An abstract class is typically used when you have a base class that provides some default
            behavior (implemented methods), but also includes some methods that must be implemented by any 
            derived classes (abstract methods).

        2. Interfaces : An interface is a contract that defines the properties and methods that a class must implement.
            It provides a way to achieve abstraction and multiple inheritance in C#.

         
         */


        public static void Main(string[] args)
        {
            // Here we are creating an object of the Savingccount class and assigning it to the BankAccount type.
            // This is possible because the Savingccount class inherits from the BankAccount class.
            // This is an example of polymorphism, where an object can be treated as an instance of its base class.

            BankAccount account1 = new Savingccount();

            account1.AccountNumber = "1111";
            account1.Balance = 6000;

            account1.Deposit(100);
            account1.Withdraw(1000);

            Console.ReadKey();

        }

    }
}