using System;


public class BreathingActivity
{
    private int _duration;
    public BreathingActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine(_duration);
        for (int i = _duration; i >= 0; i--)
        {
            Console.Write("\r" + i);
            Thread.Sleep(1000);
        }
    }
}

