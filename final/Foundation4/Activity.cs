using System;

public class Activity
{
    private string _date;
    protected float _activityLength; //Time in minutes

    public Activity(string date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }

    public string GetDate()
    {
        return _date;
    }

    public float GetActivityLength()
    {
        return _activityLength;
    }

    public virtual double GetDistance() // Measured in miles - To be overridden by derived classes
    {
        return 0;
    }
    public virtual double GetSpeed() //To be overridden by derived classes
    {
        return 0;
    }
    public virtual double GetPace() //To be overridden by derived classes
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_activityLength} min)- Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile ";
    }
}