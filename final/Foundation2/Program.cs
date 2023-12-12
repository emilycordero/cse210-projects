using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Heavenly Fresh, where we make delicious juices. This is our product ordering System. Shipping cost in USA $5.00 while international is $35.00.");

        // These are the products the company has
        Product product1 = new Product("Apple Juice", "J001", 7.00, 5);
        Product product2 = new Product("Orange Juice", "J002", 5.00, 10);
        Product product3 = new Product("Detox Juice", "J003", 7.50, 6);

        // These are the addresses and customers 
        Address address = new Address("111 main St", "Seattle", "Washington", "USA");
        Customer customer = new Customer("Emily Cordero", address);

        // An order is being created
        Order order1 = new Order(customer, new Product[] { product1, product2 });
        double totalPrice1 = order1.CalculateTotalPrice();
        string packingLabel1 = order1.GetPackingLabel();
        string shippingLabel1 = order1.GetShippingLabel();

        Console.WriteLine("Order 1: ");
        Console.WriteLine(packingLabel1);
        Console.WriteLine(shippingLabel1);
        Console.WriteLine($"Total Price: ${totalPrice1}");

        // I will give the user an opportunity to create new order
        Console.WriteLine();

        Console.WriteLine("Would you like to make an order? (y/n) ");
        string userChoice = Console.ReadLine();
        if (userChoice == "y")
        {
            // These are the addresses and customers 
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your shipping address: ");
            Console.WriteLine();

            Console.WriteLine("Street: ");
            string street = Console.ReadLine();
            Console.WriteLine("City: ");
            string city = Console.ReadLine();
            Console.WriteLine("State: ");
            string state = Console.ReadLine();
            Console.WriteLine("Country: ");
            string country = Console.ReadLine();

            Address address1 = new Address(street, city, state, country);
            Customer customer1 = new Customer(name, address1);

            // An order is being created
            Order order2 = new Order(customer1, new Product[] { product1, product2, product3 });
            double totalPrice2 = order2.CalculateTotalPrice();
            string packingLabel2 = order2.GetPackingLabel();
            string shippingLabel2 = order2.GetShippingLabel();

            Console.WriteLine("Order 2: ");
            Console.WriteLine(packingLabel2);
            Console.WriteLine(shippingLabel2);
            Console.WriteLine($"Total Price: ${totalPrice2}");
        }
        else if (userChoice == "n")
        {
            Console.WriteLine("No worries, we have another order coming in.");

            // These are the addresses and customers 
            Address address2 = new Address("1234 E Hajishi", "Tokyo", "Tokyo", "Japan");
            Customer customer2 = new Customer("Emiri Desu", address2);

            // An order is being created
            Order order2 = new Order(customer2, new Product[] { product1, product2 });
            double totalPrice2 = order2.CalculateTotalPrice();
            string packingLabel2 = order2.GetPackingLabel();
            string shippingLabel2 = order2.GetShippingLabel();

            Console.WriteLine("Order 2: ");
            Console.WriteLine(packingLabel2);
            Console.WriteLine(shippingLabel2);
            Console.WriteLine($"Total Price: ${totalPrice2}");
        }
        else
        {
            Console.WriteLine("Invalid. Try Again.");
            Console.WriteLine("Would you like to make an order? (y/n) ");
        }
    }
}