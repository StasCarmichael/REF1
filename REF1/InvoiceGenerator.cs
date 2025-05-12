
namespace REF1
{
    class InvoiceGenerator
    {
        public void GenerateInvoice(Order order)
        {
            Console.WriteLine($"Generating invoice for order {order.Id} with total {order.TotalAmount}...");
        }
    }

}
