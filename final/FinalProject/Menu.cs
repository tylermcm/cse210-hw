using System;

class Menu
{
    private List<string> mainMenu;
    private List<string> gamesMenu;
    private List<string> calculatorsMenu;

    public Menu()
    {
        mainMenu = new List<string>
        {
            "Program categories:",
            "1. Games",
            "2. Calculators",
            "3. Quit"
        };
        gamesMenu = new List<string>
        {
            "Available programs:",
            "1. Monty Hall Problem",
            "2. Tic Tac Toe",
            "3. Wordle",
            "4. Quit"
        };
        calculatorsMenu = new List<string>
        {
            "Available programs:",
            "1. Loan Amortization Generator",
            "2. Tire Volume",
            "3. Wind Chill",
            "4. Quit"
        };
    }

    public int DisplayMainMenu()
    {
        foreach (string menuItem in mainMenu)
        {
            Console.WriteLine(menuItem);   
        }
        Console.Write("What type of program would you like to launch?: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayGamesMenu()
    {
        foreach (string menuItem in gamesMenu)
        {
            Console.WriteLine(menuItem);
        }
        Console.Write("What program would you like to run?: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayCalculatorMenu()
    {
        foreach (string menuItem in calculatorsMenu)
        {
            Console.WriteLine(menuItem);
        }
        Console.Write("What program would you like to run?: ");
        return int.Parse(Console.ReadLine());
    }



}

