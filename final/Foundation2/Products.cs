using System;

public class Products
{
    private string _name;
    private string _productID;
    private double _pricePerUnit;
    private int _quantity;

    public Products(string name, string productID, double pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _name;
    }

    public string GetID()
    {
        return _productID;
    }
    
    public double GetTotal()
    {
        return _pricePerUnit * _quantity ;
    }

}