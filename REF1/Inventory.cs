namespace REF1
{
    public class Inventory
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
}
