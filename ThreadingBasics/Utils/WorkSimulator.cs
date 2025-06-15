namespace ThreadingBasics.ConsoleApp.Utils;

public static class WorkSimulator
{
    public static void SimulateWork(int milliseconds = 1000)
    {
        Thread.Sleep(milliseconds);
    }
}