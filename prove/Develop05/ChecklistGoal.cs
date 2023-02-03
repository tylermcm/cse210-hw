using System;

public class ChecklistGoal : Goals
{
    private const int goalType = 3;
    private bool goalCompleted;
    private int numEventsCompleted = 0;

    public ChecklistGoal()
    {
    }

    public ChecklistGoal(string _goalName, string _goaldescription, int _points, int _checklistGoalCount, int _checklistGoalBonus, bool _goalCompleted)
        : base (_goalName, _goaldescription, _points, _checklistGoalCount, _checklistGoalBonus)
    {
        goalCompleted = _goalCompleted;
    }

    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", goalType, getGoalName(), getGoalDescription(), getGoalPoints(), goalCompleted);
    }

    public override string ToString()
    {
        return string.Format("[{0}] {1} ({2}) -- Currently completed: {3}/{4}",((goalCompleted == false) ? " " : "X"), getGoalName(), getGoalDescription(),numEventsCompleted, getChecklistGoalCount());
    }

    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("Congratulations! You've earned {0} points", getGoalPoints()));
        numEventsCompleted++;
        if (numEventsCompleted != getChecklistGoalCount())
        {
            goalCompleted = false;
            Console.WriteLine(numEventsCompleted);
        }
        else
        {
            goalCompleted = true;
            Console.WriteLine(string.Format("Congratulations! You've earned {0} bonus points", getChecklistGoalBonus()));
        }
    }
}

