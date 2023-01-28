using System;

public class Activity
{
    private int _counter;
    private int _duration;
    private string userInput = "";
    private List<string> _listingQuestions = new List<string>
        {
            "What blessings do you feel the Lord has blessed you with this month?",
            "When have you felt the Holy Ghost this month?",
            "What good deeds did you feel you did this week?",
            "In what ways did you feel God's love this week?",
            "What are some ways you can help others in the coming week?"
        };
    private List<string> _questions = new List<string>
    {
        "What was the funniest things to happen to you this week?",
        "What is the most inspirational quote you have heard?",
        "Who has been the greatest influence in your life?",
        "What has been the best book your read recently and why?",
        "If you could experience anything again like it was the first time, what would it be and why?"
    };

    public int GetDuration()
    {
        return _duration; 
    }
    
    public void DisplayGetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void ActivityStart()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Timer();
    }
    public void ActivityEnd()
    {
        Console.WriteLine("\nWell done!");
        Timer();
        Console.WriteLine($"You have completed another {_duration} seconds of the Activity.");
        Timer();
        Console.Clear();
    }

    public void StartingTimer()
    {
        for (int i = 3; i >= 0; i--)
        {
            Console.Write("\rYou may begin in: {0}", i);
            Thread.Sleep(1000);
        }
    }


    public void Timer()
    {
        for (var i = 0; i < 10; i++)
        {
            Turn();
            Thread.Sleep(350);
        }
    }

    public void Turn()
    {
        _counter++;
        switch (_counter % 4)
        {
            case 0:
                Console.Write("/");
                break;
            case 1:
                Console.Write("-");
                break;
            case 2:
                Console.Write("\\");
                break;
            case 3:
                Console.Write("|");
                break;
        }
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }

    public void ListingPrompt()
    {
        Random rand = new Random();
        int randIndex = rand.Next(0, _listingQuestions.Count - 1);
        string random = _listingQuestions[randIndex];
        Console.WriteLine($" --- {random} --- \n");
        _listingQuestions.Remove(random);

    }

        public void ReflectingPrompt()
    {
        Random rand = new Random();
        int randIndex = rand.Next(0, _questions.Count - 1);
        string random = _questions[randIndex];
        Console.WriteLine($" --- {random} --- \n");
        _questions.Remove(random);
        Console.Write("When you have something in mind, press enter to continue.\n");
        userInput = Console.ReadLine();
        Console.WriteLine("Now ponder the following questions as they related to this experience.");
        for (int i = 3; i >= 0; i--)
        {
            Console.Write("\rYou may begin in: {0}", i);
            Thread.Sleep(1000);
        }    
    }



}
