using System;
public class Order
{
    private double _productTotal = 0;
    private List<Products> _products = new List<Products>();
    private Customer _customer; 
    private double _shippingCost;
    private double _finalTotal;
    private string _label;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Products product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        
        foreach (Products product in _products)
        {
            double cost = product.GetTotal();
            _productTotal += cost;
        }

        if (_customer.LivesInUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }

        _finalTotal = _productTotal = _productTotal + _shippingCost;
        return _finalTotal;
         
    }
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";

        foreach (Products product in _products)
        {
            label += product.GetProductName() + " (ID: " + product.GetID() + ")\n";
        }

        return label;
    }


    public string GetShippingLabel()
    {
        _label = "SHIPPING LABEL:\n";
        _label += _customer.GetName() + "\n";
        _label += _customer.GetAddress();

        return _label;
        
    }
}