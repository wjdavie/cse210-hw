using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int activityLength, double speed) : base(date, activityLength)
    {
        _speed = speed;
    }

    public override double GetDistance() //Calculated in miles
    {
        return _speed * (_activityLength / 60);
    }

    public override double GetSpeed() //Calculated in miles per hour
    {
        return _speed;
    }

    public override double GetPace() //Calculated in minutes per mile
    {
        return _activityLength / GetDistance();
    }

    public override string GetSummary()
    {
        return base.GetSummary();
    }
}