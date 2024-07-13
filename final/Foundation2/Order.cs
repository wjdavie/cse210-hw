using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private string _packingLabel;
    private string _shippingLabel;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    } 

    public decimal GetOrderCost()
    {
        decimal orderCost = 0;

        foreach (Product product in _products)
        {
            orderCost += product.GetProductTotal();
        }

        orderCost += _customer.IsInUSA() ? 5 : 35;

        return orderCost;
    }

    public void DisplayOrderTotal()
    {
        Console.WriteLine($"Total Cost: ${GetOrderCost()} ");
    }

    public string GetPackingLabel()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("Packing Label: ");
        
        foreach (Product product in _products)
        {
            builder.AppendLine($"Product Name: {product.GetProductName()} - Product ID: {product.GetProductId()}");
        }
        
        return builder.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("Shipping Label: ");
        builder.AppendLine($"{_customer.GetCustomerName()}");
        builder.AppendLine(_customer.GetAddress().GetAddressString());
        
        return builder.ToString();
    }
}