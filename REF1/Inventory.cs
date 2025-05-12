namespace REF1
{
    class Inventory
    {
        private List<string> products = new List<string> { "Laptop", "Mouse", "Keyboard" };

        public bool CheckStock(string product)
        {
            return products.Contains(product);
        }
    }

}
