using System;
using System.Collections.Generic;
using REF1;

public class Program
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
