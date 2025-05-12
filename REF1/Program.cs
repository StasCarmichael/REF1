using System;
using System.Collections.Generic;

class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public void SaveToDatabase()
    {
        Console.WriteLine("Saving user to database...");
    }

    public void SendEmail(string message)
    {
        Console.WriteLine($"Sending email to {Email}: {message}");
    }
}

class Order
{
    public int Id { get; set; }
    public List<string> Products { get; set; }
    public string PaymentMethod { get; set; }
    public double TotalAmount { get; set; }

    public void ProcessPayment()
    {
        if (PaymentMethod == "CreditCard")
        {
            Console.WriteLine("Processing credit card payment...");
        }
        else if (PaymentMethod == "PayPal")
        {
            Console.WriteLine("Processing PayPal payment...");
        }
        else
        {
            Console.WriteLine("Unsupported payment method");
        }
    }

    public void GenerateInvoice()
    {
        Console.WriteLine("Generating invoice...");
    }
}

class Inventory
{
    private List<string> products = new List<string> { "Laptop", "Mouse", "Keyboard" };

    public void CheckStock(string product)
    {
        if (products.Contains(product))
            Console.WriteLine($"{product} is in stock.");
        else
            Console.WriteLine($"{product} is out of stock.");
    }
}

class Program
{
    static void Main()
    {
        User user = new User { Name = "John", Email = "john@example.com", Password = "12345" };
        user.SaveToDatabase();
        user.SendEmail("Welcome!");

        Order order = new Order { Id = 1, Products = new List<string> { "Laptop", "Mouse" }, PaymentMethod = "CreditCard", TotalAmount = 1500 };
        order.ProcessPayment();
        order.GenerateInvoice();

        Inventory inventory = new Inventory();
        inventory.CheckStock("Laptop");
        inventory.CheckStock("Phone");
    }
}
