using System;
// Added code to display a 'level up' when the user reaches 1000 points
class Program
{
    static void Main(string[] args)
    {
        AllGoals goals = new AllGoals();
        int choice = 0;
        do
        {
            Menu menu = new Menu();
            goals.DisplayPoints(goals.getTotalPoints(),goals.getLevel());
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
                        goals.addGoal(goal);
                    }    
                    break;
                case 2:
                    Console.Clear();
                    goals.DisplayGoals();
                    break;
                case 3:
                    Console.Clear();
                    goals.SaveGoals();
                    break;
                case 4:
                    Console.Clear();
                    goals.LoadGoals();
                    break;
                case 5:
                    Console.Clear();
                    goals.DisplayGoalRecordEvent();
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