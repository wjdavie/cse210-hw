using System;

public class Product
{
    private string _productName;
    private string _productId;
    private decimal _unitPrice;
    private int _quantity;

    public Product(string productName, string productId, decimal unitPrice, int quantity )
    {
        //code to check for edge cases
        if (string.IsNullOrEmpty(productName))
        {
            throw new ArgumentException("Product name cannot be null or empty. ", nameof(productName));
        }
        if (string.IsNullOrEmpty(productId))
        {
            throw new ArgumentException("Product ID cannot be null or empty. ", nameof(productId));
        }
        if (unitPrice < 0)
        {
            throw new ArgumentException("Unit price cannot be negative. ", nameof(unitPrice));
        }
        if (quantity <= 0)
        {
            throw new ArgumentException("Quantity must be a positive number. ", nameof(quantity));
        }
        
        _productName = productName;
        _productId = productId;
        _unitPrice = unitPrice;
        _quantity = quantity;
    } 

    public decimal GetProductTotal()
    {
        return _unitPrice * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }    
}