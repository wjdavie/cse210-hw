using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public SimpleGoal(string name, string description, int points, bool completed) : base(name, description, points, completed)
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
         if (_completed == true)
            {
                Console.Write("[X] ");
            }
            else
            {
                Console.Write("[ ] ");
            }
    }
}