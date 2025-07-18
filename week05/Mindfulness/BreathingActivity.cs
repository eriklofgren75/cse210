using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through slowly breathing in and out slowly. Clear your mind and focus on your breath.")
    {

    }

    public void Run()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Countdown(4);
            Console.WriteLine("Breathe out...");
            Countdown(6);
            Console.WriteLine();

        }

        EndActivity();

    }
}