namespace Polymorphism
{

    // Polymorphism is the ability of an object to take on many forms.
    // The most common use of polymorphism in OOP is when a parent class reference is used to refer to a child class object.
    // Polymorphism is the ability to present the same interface for different data types.
    // Polymorphism allows methods to do different things based on the object that it is acting upon.
    // Polymorphism is extensively used in implementing inheritance.


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Worker> workers = new List<Worker>
            {
                new Developer(),
                new Designer(),
                new Manager(),
            };

            foreach (var worker in workers)
            {
                Console.WriteLine();
                Console.WriteLine($"######## Worker ({worker.GetType().Name}) ##############");
                Console.WriteLine();
                Console.WriteLine(worker.PerformWork());
            }

        }
    }

    public abstract class Worker
    {
        public abstract string PerformWork();
    }

    public class Developer : Worker
    {
        public override string PerformWork()
        {
            return "1. Analyze the requirements.\n" +
                   "2. Write the code.\n" +
                   "3. Test the code.\n" +
                   "4. Debug and fix any issues.\n" +
                   "5. Commit and push the code to the repository.";
        }
    }

    public class Designer : Worker
    {
        public override string PerformWork()
        {
            return "1. Understand the project requirements.\n" +
                   "2. Sketch the design ideas.\n" +
                   "3. Create the digital design.\n" +
                   "4. Review and revise the design.\n" +
                   "5. Finalize and submit the design.";
        }
    }

    public class Manager : Worker
    {
        public override string PerformWork()
        {
            return "1. Plan the project.\n" +
                   "2. Assign tasks to team members.\n" +
                   "3. Monitor the project progress.\n" +
                   "4. Resolve any issues.\n" +
                   "5. Report the project status to stakeholders.";
        }
    }
}
