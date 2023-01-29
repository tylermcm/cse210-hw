// To exceed requirements, I added a counter to track the number of activities completed.
// Additionally, I added code to keep the same prompt from occuring more than once in both reflecting and listing activities.

using System;
class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        int activityCounter = 0;
        Activity activity = new Activity();

        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity \n2. Start reflecting activity \n3. Start listing activity \n4. Display number of activities completed \n5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        BreathingActivity activity1 = new BreathingActivity();
                        activityCounter += 1;
                        break;
                    case "2":
                        Console.Clear();
                        ReflectingActivity activity2 = new ReflectingActivity();
                        activityCounter += 1;

                    break;
                    case "3":
                        Console.Clear();
                        ListingActivity activity3 = new ListingActivity();
                        activityCounter += 1;
                    break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine($"Great work! You have completed {activityCounter} activities.");
                        activity.Timer();
                        Console.Clear();
                        break;
                    case "5":
                        break;
                    default: 
                        Console.Clear();
                        break;
                }
        }
        while (choice != "5");
    }
}