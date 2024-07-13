using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        //code to check for edge cases
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty. ", nameof(name));
        }

        _name = name;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool IsInUSA()
    {
        return _address.IsUSA();
    }
}