using System;

public class Swimming : Activity
{
    private float _laps;

    public Swimming(string date, int activityLength, float laps) : base(date, activityLength)
    {
        _laps = laps;
    }

    public override double GetDistance() //Using the calculation of a lap in an olympic size swimming pool (50 meters)
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed() //Calculated in miles per hour
    {
        return GetDistance() / _activityLength * 60;
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