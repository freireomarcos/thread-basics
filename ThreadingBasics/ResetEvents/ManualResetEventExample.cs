using ThreadingBasics.ConsoleApp.Utils;

namespace ThreadingBasics.ConsoleApp.ResetEvents;

public class ManualResetEventExample(bool initialState = false)
{
    private readonly ManualResetEvent _event = new(initialState);

    public void Run()
    {
        for (int i = 0; i < 3; i++)
        {
            int id = i;
            new Thread(() =>
            {
                Console.WriteLine($"[ManualResetEvent] Thread {id} waiting...");
                _event.WaitOne();
                Console.WriteLine($"[ManualResetEvent] Thread {id} passed!");
            }).Start();
        }

        WorkSimulator.SimulateWork(2000);

        Console.WriteLine("[ManualResetEvent] Signaling all threads");
        _event.Set();
    }
}
