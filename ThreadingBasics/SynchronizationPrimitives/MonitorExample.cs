using ThreadingBasics.ConsoleApp.Utils;

namespace ThreadingBasics.ConsoleApp.SynchronizationPrimitives;

public class MonitorExample
{
    private readonly object _lockObj = new();

    public void Run()
    {
        for (int i = 0; i < 5; i++)
        {
            int threadId = i;
            new Thread(() =>
            {
                Console.WriteLine($"[Monitor] Thread {threadId} trying to enter the critical section...");

                Monitor.Enter(_lockObj);

                try
                {
                    Console.WriteLine($"[Monitor] Thread {threadId} entered critical section.");

                    WorkSimulator.SimulateWork(1000);

                    Console.WriteLine($"[Monitor] Thread {threadId} leaving the critical section.");
                }
                finally
                {
                    Monitor.Exit(_lockObj);
                }
            }).Start();
        }
    }
}