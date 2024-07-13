using System;
using System.Text;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        //code to check for edge cases
        if (string.IsNullOrEmpty(street))
        {
            throw new ArgumentException("Street cannot be null or empty. ", nameof(street));
        }
        if (string.IsNullOrEmpty(city))
        {
            throw new ArgumentException("City cannot be null or empty. ", nameof(city));
        }
        if (string.IsNullOrEmpty(stateProvince))
        {
            throw new ArgumentException("State / Province cannot be null or empty. ", nameof(stateProvince));
        }
        if (string.IsNullOrEmpty(country))
        {
            throw new ArgumentException("Country cannot be null or empty. ", nameof(country));
        }

        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public Address(string street, string city, string country)
    {
        //code to check for edge cases
        if (string.IsNullOrEmpty(street))
        {
            throw new ArgumentException("Street cannot be null or empty. ", nameof(street));
        }
        if (string.IsNullOrEmpty(city))
        {
            throw new ArgumentException("City cannot be null or empty. ", nameof(city));
        }
        if (string.IsNullOrEmpty(country))
        {
            throw new ArgumentException("Country cannot be null or empty. ", nameof(country));
        }

        _street = street;
        _city = city;
        _country = country;
    }

    public bool IsUSA()
    {
        if (_country == "USA" || _country == "United States" || _country == "U.S.A" || _country == "United States of America")
        {
            return true;
        }
        else
        {
            return false;
        }
            
    }

    public string GetAddressString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"{_street} ");
        builder.Append($"{_city} ");
        builder.Append($"{_stateProvince} ");
        builder.Append($"{_country} ");
        return builder.ToString();
    }
}