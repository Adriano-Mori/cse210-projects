using System;
public class Product
{
    private string _name;
    private string _productID;
    private int _quantity;
    private float _price;
    public Product(string name, string productID, float price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public float GetTotalPrice()
    {
        return _price * _quantity;
    }
    public string DisplayProduct()
    {
        return $"{_name} (ID: {_productID}) - Quantity: {_quantity}";
    }
    public string GetName() => _name;
    public string GetID() => _productID;
}