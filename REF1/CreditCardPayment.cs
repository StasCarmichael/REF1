

namespace REF1
{
    class CreditCardPayment : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}...");
        }
    }

}
