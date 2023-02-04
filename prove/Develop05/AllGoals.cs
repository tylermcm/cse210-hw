using System;


class AllGoals
{
    private List<Goals> _allGoals = new List<Goals>();
    private int totalPoints;
    private int numEventsCompleted = 0;
    private int levelUp = 0;

    public int getTotalPoints()
    {
        return totalPoints;
    }

    public int getLevel()
    {
        return levelUp;
    }

    public void addGoal(Goals _goal)
    {
        _allGoals.Add(_goal);
    }

    public void DisplayGoals()
    {
        if (_allGoals.Count() == 0)
        {
            Console.WriteLine("No goals have been created yet");
        }
        foreach (Goals goal in _allGoals)
        {
            Console.WriteLine(goal.ToString());
        }
    }

    public void SaveGoals()
    {
        if (_allGoals.Count() == 0)
        {
            Console.WriteLine("There are no goals to save");
            return;
        }
        string fileToSave = DisplayGetGoalFile();
        List<string> _saveGoals = new List<string>();
        _saveGoals.Add(totalPoints.ToString());

        foreach (Goals goal in _allGoals)
        {
            _saveGoals.Add(goal.ToCSVRecord());
        }
        SaveLoadCSV.SaveToCSV(_saveGoals, fileToSave);
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals(string _filePath = "")
    {
        List<string> _fileGoals;
        if (File.Exists(_filePath))
        {
            _fileGoals = SaveLoadCSV.LoadFromCSV(_filePath);
        }
        else
        {
            _fileGoals = SaveLoadCSV.LoadFromCSV(DisplayGetGoalFile());
        }
        Goals goal = null;
        foreach (string goalInFile in _fileGoals)
        {
            string[] goalParts = goalInFile.Split('|');
            int _goalType = int.Parse(goalParts[0]);
            switch (_goalType)
            {
                case 1:
                    goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
                    break;
            }

            if (goal != null && _allGoals.Contains(goal) == false)
            {
                _allGoals.Add(goal);
            }
        }
        Console.WriteLine("\nGoals loaded.\n");

    }

    public string DisplayGetGoalFile()
    {
        Console.Write("What is the filename of the goal file? ");
        return Directory.GetCurrentDirectory() + "\\Files\\" + Console.ReadLine();
    }

    public void DisplayGoalRecordEvent()
    {
        Console.WriteLine("The goals are:");
        foreach (Goals goal in _allGoals)
        {
            Console.WriteLine(string.Format("{0}. {1}", _allGoals.IndexOf(goal) + 1, goal.getGoalName()));
        }
        Console.Write("Which goal did you complete? ");
        int recordEvent = int.Parse(Console.ReadLine()) - 1;
        _allGoals[recordEvent].RecordEvent();
        numEventsCompleted++;
        totalPoints += _allGoals[recordEvent].getGoalPoints();
        if (numEventsCompleted == _allGoals[recordEvent].getChecklistGoalCount())
        {
            totalPoints += _allGoals[recordEvent].getChecklistGoalBonus();
        }
        if (totalPoints >= 1000)
        {
            levelUp++;
            totalPoints = 0;
            Console.WriteLine(string.Format("Congratulations! You've reached level {0}", levelUp));
        }
    }

    public void DisplayPoints(int _totalPoints, int _levelUp)
    {
        Console.WriteLine(string.Format("You have {0} points\nYou are level {1}\n", _totalPoints, _levelUp));
    }
}
