using System;


public class ReflectingActivity : Activity
{
    Activity _activity = new Activity();
    private int duration;
    
    public ReflectingActivity()
    {
        Console.WriteLine("Welcome to the reflecting activity\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have show strength and resilience. This will help you reeconize the power you have and how you can use it in other aspects of your life.\n");
        _activity.DisplayGetDuration();
        duration = _activity.GetDuration();
        Reflecting();
        Console.Clear();
    }
    

    private void Reflecting()
    {
        _activity.ActivityStart();
        Console.WriteLine("Consider the follow prompt:\n");
        _activity.ReflectingPrompt();
        Countdown();
        _activity.ActivityEnd();
    }

    private void Countdown()
    {
        Console.Clear();
        Console.WriteLine("> How did you feel when it was complete? <");
        Thread.Sleep((duration / 2) * 1000);

        Console.WriteLine("> What is your favorite thing about this experience? <");
        Thread.Sleep((duration / 2) * 1000);
    }



}

