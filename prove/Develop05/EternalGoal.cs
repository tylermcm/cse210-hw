using System;

public class EternalGoal : Goals
{
    private const int goalType = 2;
    private bool goalCompleted;

    public EternalGoal()
    {
    }

    public EternalGoal(string _goalName, string _goaldescription, int _points, bool _goalCompleted)
        : base(_goalName, _goaldescription, _points)
    {
        goalCompleted = _goalCompleted;
    }

    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", goalType, getGoalName(), getGoalDescription(), getGoalPoints(), goalCompleted);
    }

    public override string ToString()
    {
        return string.Format("[] {0} ({1})", getGoalName(), getGoalDescription());
    }

    public override void RecordEvent()
    {
        Console.WriteLine(string.Format("Congratulations! You've earned {0} points", getGoalPoints()));
        goalCompleted = true;
    }
}

