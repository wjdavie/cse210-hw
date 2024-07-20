using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int activityLength, double distance) : base(date, activityLength)
    {
        _distance = distance;
    }

    public override double GetDistance() //Stored variable in this class
    {
        return _distance;
    }

    public override double GetSpeed() //Calculated in miles per hour
    {
        return _distance / _activityLength * 60;
    }

    public override double GetPace() //Calculated in minutes per mile
    {
        return _activityLength / _distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary();
    }
}