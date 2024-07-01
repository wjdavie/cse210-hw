using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override int CalculatePoints()
    {
        if (_completed == true)
        {
            return GetPoints();
        }
        else
        {
            return 0;
        }
    }

    public override void RecordProgress()
    {
        _completed = true;
    }

    public override void MarkCompleted()
    {
        Console.Write("[ ] ");
    }
}