using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity \n2. Start reflecting activity \n3. Start listing activity \n4. Quit");
        Console.Write("Select a choice from the menu: ");
        choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Clear();
                BreathingActivity activity1 = new BreathingActivity();
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            default: 
                break;
        } 
    }
}