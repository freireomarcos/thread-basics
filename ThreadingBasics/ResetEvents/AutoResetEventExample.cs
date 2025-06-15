using ThreadingBasics.ConsoleApp.Utils;

namespace ThreadingBasics.ConsoleApp.ResetEvents;

public class AutoResetEventExample(bool initialState = false)
{
    private readonly AutoResetEvent _event = new(initialState);

    public void Run()
    {
        for (int i = 0; i < 3; i++)
        {
            int id = i;
            new Thread(() =>
            {
                Console.WriteLine($"[AutoResetEvent] Thread {id} waiting...");
                _event.WaitOne();
                Console.WriteLine($"[AutoResetEvent] Thread {id} passed!");
            }).Start();
        }

        WorkSimulator.SimulateWork(2000);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("[AutoResetEvent] Signaling one thread...");

            _event.Set();
            WorkSimulator.SimulateWork(1000);
        }
    }
}
