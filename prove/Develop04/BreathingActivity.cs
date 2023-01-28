using System;


public class BreathingActivity : Activity
{
    Activity _activity = new Activity();
    private int duration;
    
    public BreathingActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.\n");

        _activity.DisplayGetDuration();
        duration = _activity.GetDuration();
        Breathing();
        Console.Clear();

    }

    private void Breathing()
    {
        _activity.ActivityStart();
        Countdown();
        _activity.ActivityEnd();
    }

    private void Countdown()
    {
        int i = 10;
        for (int a = duration / i - 1; a >= 0; a--)
        {
            for (i = 5; i >= 0; i--)
            {
                Console.Write("\rBreathe in....{0}", i);
                Thread.Sleep(1000);
            }
            for (i = 5; i >= 0; i--)
            {
                Console.Write("\rBreathe out...{0}", i);
                Thread.Sleep(1000);
            }
        }
    }

}

