using System;

public class Order
{
    private Customer customer;
    private Product[] products;

    public Order(Customer customer, Product[] products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double CalculateTotalPrice()
    {
        const double USAShippingCost = 5.0;
        const double InternationalShippingCost = 35.0;
        // USA shipping adds 5 dollars while non usa adds 35
        double totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.CalculatePrice();
        }
        totalPrice += customer.IsInUSA() ? USAShippingCost : InternationalShippingCost;
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Packing label for {customer.Name}:\n";
        foreach (Product product in products)
        {
            packingLabel += $"- {product.Name}, Product ID: {product.ProductID}, Product Price: ${product.Price}, Product Quantity Ordered: {product.Quantity}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping Label for {customer.Name}:\n";
        shippingLabel += $"{customer.GetShippingAddress()}\n";
        return shippingLabel;
    }
}