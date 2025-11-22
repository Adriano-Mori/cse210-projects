using System;
using System.Collections.Generic;
public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public float GetTotalCost()
    {
        float totalCost = 0;
        foreach (Product p in _products)
        {
            totalCost += p.GetTotalPrice();
        }
        totalCost += _customer.LivesInUSA() ? 5 : 35;

        return totalCost;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} - ID: {p.GetID()}";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL: \n{_customer.GetCustomerInfo()}";
    }
}