using System;

class Menu
{
    private List<string> _mainMenu;
    private List<string> _goalsMenu;
    public Menu()
    {
        _mainMenu = new List<string>
        {
            "Menu options: ",
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Goals",
            "6. Quit"
        };

        _goalsMenu = new List<string>
        {
            "The types of goals are: ",
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
        };
    }

    public void DisplayMainMenu()
    {
        foreach (string menuItem in _mainMenu)
        {
            Console.WriteLine(menuItem);
        }
    }

    public int DisplayGetMainMenu()
    {
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }


    public int DisplayGoalsMenu()
    {
        foreach (string menuItem in _goalsMenu)
        {
            Console.WriteLine(menuItem);
        }
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }


}

