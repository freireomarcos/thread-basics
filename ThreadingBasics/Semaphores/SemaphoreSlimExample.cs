using ThreadingBasics.ConsoleApp.Utils;

namespace ThreadingBasics.ConsoleApp.Semaphores;

public class SemaphoreSlimExample(int initialCount = 3)
{
    private readonly SemaphoreSlim _semaphore = new(initialCount);

    public void Run()
    {
        for (int i = 0; i < 10; i++)
        {
            int id = i;
            new Thread(() =>
            {
                Console.WriteLine($"[SemaphoreSlim] Thread {id} waiting...");
                _semaphore.Wait();
                try
                {
                    Console.WriteLine($"[SemaphoreSlim] Thread {id} entered critical section.");
                    WorkSimulator.SimulateWork(1000);
                }
                finally
                {
                    Console.WriteLine($"[SemaphoreSlim] Thread {id} exiting.");
                    _semaphore.Release();
                }
            }).Start();
        }
    }
}
