namespace REF1
{
    class PayPalPayment : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}...");
        }
    }

}
