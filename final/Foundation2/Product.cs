using System;

public class Product
{
	private string name;
	private string productID;
	private double price;
	private int quantity;

	public Product(string name, string productID, double price, int quantity)
	{
		this.name = name;
		this.productID = productID;
		this.price = price;
		this.quantity = quantity;
	}

	public double CalculatePrice()
	{
		return price * quantity;
	}

	public string Name
	{
		get { return name; }
	}

    public string ProductID
    {
        get { return productID; }
    }

    public double Price
    {
        get { return price; }
    }
    public int Quantity
    {
        get { return quantity; }
    }
}
