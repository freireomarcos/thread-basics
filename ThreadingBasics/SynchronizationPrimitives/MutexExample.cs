using ThreadingBasics.ConsoleApp.Utils;

namespace ThreadingBasics.ConsoleApp.SynchronizationPrimitives;

public class MutexExample
{
    private readonly Mutex _mutex = new();

    public void Run()
    {
        for (int i = 0; i < 5; i++)
        {
            int id = i;
            new Thread(() =>
            {
                Console.WriteLine($"[Mutex] Thread {id} waiting...");
                _mutex.WaitOne();
                try
                {
                    Console.WriteLine($"[Mutex] Thread {id} entered critical section.");
                    WorkSimulator.SimulateWork(1000);
                }
                finally
                {
                    Console.WriteLine($"[Mutex] Thread {id} releasing.");
                    _mutex.ReleaseMutex();
                }
            }).Start();
        }
    }
}

