using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public override string GetFullDetails()
    {
        return $"Event Type: Lecture\nTitle: {GetTitle()}\nSpeaker: {GetSpeaker()}\nDescription: {GetDescription()}\nDate: {GetDate()}\nTime: {GetTime()}\nAddress: {GetAddressString()}\nCapacity: {GetCapacity()} people ";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Lecture\nTitle: {GetTitle()}\nDate: {GetDate()} ";
    }
}