using System;
using System.Threading;

class ThreadStatic
{
    [ThreadStatic]
    public static int value;

    public void TestMethod()
    {
        new Thread(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                value++;
                System.Console.WriteLine("Thread 1: " + value);
            }
        }).Start();

        new Thread(() =>
        {
            for (int x = 0; x < 10; x++)
            {
                value++;
                System.Console.WriteLine("Thread 2: " + value);
            }
        }).Start();

        Console.ReadKey();
    }
}