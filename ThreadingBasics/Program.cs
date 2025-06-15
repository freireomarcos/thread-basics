using ThreadingBasics.ConsoleApp.ResetEvents;
using ThreadingBasics.ConsoleApp.Semaphores;
using ThreadingBasics.ConsoleApp.SynchronizationPrimitives;

namespace ThreadingBasics.ConsoleApp;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Threading Basics Examples");

        while (true)
        {
            Console.WriteLine("\nSelect an example to run:");
            Console.WriteLine("1 - ManualResetEvent");
            Console.WriteLine("2 - AutoResetEvent");
            Console.WriteLine("3 - SemaphoreSlim");
            Console.WriteLine("4 - Semaphore");
            Console.WriteLine("5 - Mutex");
            Console.WriteLine("6 - Lock");
            Console.WriteLine("7 - Monitor");
            Console.WriteLine("0 - Exit");
            Console.Write("Option: ");

            var input = Console.ReadLine();

            if (input == "0")
            {
                break;
            }

            switch (input)
            {
                case "1": new ManualResetEventExample().Run(); break;
                case "2": new AutoResetEventExample().Run(); break;
                case "3": new SemaphoreSlimExample().Run(); break;
                case "4": new SemaphoreExample(3).Run(); break;
                case "5": new MutexExample().Run(); break;
                case "6": new LockExample().Run(); break;
                case "7": new MonitorExample().Run(); break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
    }
}