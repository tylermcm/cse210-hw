using System;


public class ListingActivity : Activity
{
    Activity _activity = new Activity();
    private int duration;
    private string _entry = "";
    private int _entryCount = 0;

    public ListingActivity() : base()
    {
        Console.WriteLine("Welcome to the Listing Activity.\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        _activity.DisplayGetDuration();
        duration = _activity.GetDuration();
        Console.Clear();
        Listing();

    }

    private void Listing()
    {
        _activity.activityStart();
        Console.WriteLine("List as many responses you can to the follow prompt:");
        _activity.listingPrompt();
        _activity.startingTimer();
        listingCountdown();
        _activity.activityEnd();
    }
    private void listingCountdown()
    {     
        Console.WriteLine();
        var startTime = DateTime.Now;
        while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
        {   
            Console.Write("> ");
            _entry = Console.ReadLine();
            _entryCount++;
        }
        Console.WriteLine($"You listed {_entryCount} items!");
    }

}

