using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        string choice = "0";
        Journal journal1 = new Journal();
    do{
        Console.WriteLine("\nPlease select one of the following choices:");
        Console.WriteLine("1. Write \n2. Display \n3. Add Prompt \n4. Show Prompts \n5. Save \n6. Load \n7. Quit");
        Console.Write("What would you like to do? ");
        choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                journal1.writePrompt();
                break;
            case "2":
                journal1.Display();
                break;
            case "3":
                journal1.userPrompt();
                break; 
            case "4":
                journal1.showPrompt();
                break;
            case "5":
                journal1.writeToCSV();
                Console.WriteLine($"\nJournal entries were saved to {journal1._filePath}");
                break;
            case "6":
                journal1.readFromCSV();
                Console.WriteLine($"\nJournal entries were loaded from {journal1._filePath}");
                break;
            case "7":
                break;

        }
    }while (choice != "7");
    {
        Console.WriteLine("Goodbye!");
    }

    }
}