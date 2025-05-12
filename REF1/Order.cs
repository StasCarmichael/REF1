
namespace REF1
{
    public class Order
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

}
