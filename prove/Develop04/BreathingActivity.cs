using System;
using System.ComponentModel;
using System.Diagnostics;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will walk you through a breathing exercise that asks you to slowly inhale and exhale, and will help you to relax. Clear your mind and focus on your breathing.")
    {
    }

    public void RunActivity()
    {
        base.StartActivity();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write($"Breathe in..." );
            Countdown();
            Console.WriteLine();
            
            Console.Write("Breathe out..." );
            Countdown();
            Console.WriteLine();
            Console.WriteLine("");
        }

        base.EndActivity();
    }
}