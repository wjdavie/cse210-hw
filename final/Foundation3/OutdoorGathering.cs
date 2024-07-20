using System;

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public override string GetFullDetails()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDate()}\nTime: {GetTime()}\nAddress: {GetAddressString()}\nWeather Forecast: {GetWeather()} ";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {GetTitle()}\nDate: {GetDate()} ";
    }
}