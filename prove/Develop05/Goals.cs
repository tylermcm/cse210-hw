using System;

public abstract class Goals
{
    private string _goalName;
    private string _goalDescription;
    private int _points;
    private int _checklistGoalCount;
    private int _checklistGoalBonus;
    public Goals()
    {
    }
    public Goals(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }

    public Goals(string goalName, string goalDescription, int points, int checklistGoalCount, int checklistGoalBonus)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
        _checklistGoalCount = checklistGoalCount;
        _checklistGoalBonus = checklistGoalBonus;
    }
    public string getGoalName()
    {
        return _goalName;
    }

    public void DisplayGetGoalName()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
    }

    public string getGoalDescription()
    {
        return _goalDescription;
    }

    public void DisplayGetGoalDescription()
    {
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
    }

    public int getGoalPoints()
    {
        return _points;
    }

    public void DisplayGetGoalPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public int getChecklistGoalCount()
    {
        return _checklistGoalCount;
    }

    public void DisplayGetChecklistGoalCount()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _checklistGoalCount = int.Parse(Console.ReadLine());
    }

    public int getChecklistGoalBonus()
    {
        return _checklistGoalBonus;
    }

    public void DisplayGetChecklistGoalBonus()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _checklistGoalBonus = int.Parse(Console.ReadLine());
    }

    public abstract string ToCSVRecord();
    public abstract void RecordEvent();
}

