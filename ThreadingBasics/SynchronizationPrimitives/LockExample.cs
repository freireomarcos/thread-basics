using ThreadingBasics.ConsoleApp.Utils;

namespace ThreadingBasics.ConsoleApp.SynchronizationPrimitives;

public class LockExample
{
    private readonly object _lockObj = new();

    public void Run()
    {
        for (int i = 0; i < 5; i++)
        {
            int id = i;

            new Thread(() =>
            {
                Console.WriteLine($"[Lock] Thread {id} trying to enter...");

                lock (_lockObj) //syntactic sugar to monitor enter / finally monitor exit
                {
                    Console.WriteLine($"[Lock] Thread {id} entered critical section.");

                    WorkSimulator.SimulateWork(1000);

                    Console.WriteLine($"[Lock] Thread {id} leaving.");
                }

            }).Start();
        }
    }
}
