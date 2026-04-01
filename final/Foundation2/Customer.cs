using System;

public class Customer
{
    private string _customer;
    private Address _address;

    public string GetName()
    {
        return _customer;
    }

    public string GetAddress()
    {
        return _address;
    }

    public bool LiveInUS()
    {
        
    }
}