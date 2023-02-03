using System;

class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new AllGoals();
        int choice = 0;
        
        do
        {
            Menu menu = new Menu();
            allGoals.DisplayPoints(allGoals.getTotalPoints());
            menu.DisplayMainMenu();
            choice = menu.DisplayGetMainMenu();
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    int goalSelection = menu.DisplayGoalsMenu();
                    Goals goal = null;      
                    switch (goalSelection)
                    {
                        case 1:
                            goal = new SimpleGoal();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetGoalPoints();
                            break;
                        case 2:
                            goal = new EternalGoal();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetGoalPoints();
                            break;
                        case 3:
                            goal = new ChecklistGoal();
                            goal.DisplayGetGoalName();
                            goal.DisplayGetGoalDescription();
                            goal.DisplayGetGoalPoints();
                            goal.DisplayGetChecklistGoalCount();
                            goal.DisplayGetChecklistGoalBonus();
                            break;
                    }          
                    if (goal != null)
                    {
                        allGoals.addGoal(goal);
                    }    
                    break;
                case 2:
                    Console.Clear();
                    allGoals.DisplayGoals();
                    break;
                case 3:
                    Console.Clear();
                    allGoals.SaveGoals();
                    break;
                case 4:
                    Console.Clear();
                    allGoals.LoadGoals();
                    break;
                case 5:
                    Console.Clear();
                    allGoals.DisplayGoalRecordEvent();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.Clear();
                    break;
            } 
        } while (choice != 6);
    }
}