using System;
using System.Text;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipcode;

    public Address(string street, string city, string state, string zipcode)
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
        if (string.IsNullOrEmpty(state))
        {
            throw new ArgumentException("Country cannot be null or empty. ", nameof(state));
        }
        if (string.IsNullOrEmpty(zipcode))
        {
            throw new ArgumentException("Zipcode cannot be null or empty. ", nameof(zipcode));
        }

        _street = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
    }

    public string GetAddressString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append($"{_street} ");
        builder.Append($"{_city}, ");
        builder.Append($"{_state} ");
        builder.Append($"{_zipcode} ");
        return builder.ToString();
    }
}