using ThreadingBasics.ConsoleApp.Utils;

namespace ThreadingBasics.ConsoleApp.Semaphores;

public class SemaphoreExample(int initialCount = 3)
{
    private readonly Semaphore _semaphore = new(initialCount, initialCount);

    public void Run()
    {
        for (int i = 0; i < 10; i++)
        {
            int id = i;
            new Thread(() =>
            {
                Console.WriteLine($"[Semaphore] Thread {id} waiting...");
                _semaphore.WaitOne();
                try
                {
                    Console.WriteLine($"[Semaphore] Thread {id} entered critical section.");
                    WorkSimulator.SimulateWork(1000);
                }
                finally
                {
                    Console.WriteLine($"[Semaphore] Thread {id} exiting.");
                    _semaphore.Release();
                }
            }).Start();
        }
    }
}
