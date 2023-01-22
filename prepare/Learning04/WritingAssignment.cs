using System;


public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studenName, string topic, string title)
        : base(studenName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studenName = GetStudentName();

        return $"{_title} by {studenName}";
    }
}

