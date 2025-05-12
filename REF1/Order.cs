
namespace REF1
{
    class Order
    {
        public int Id { get; set; }
        public List<string> Products { get; set; }
        public double TotalAmount { get; set; }
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly InvoiceGenerator _invoiceGenerator;

        public Order(IPaymentProcessor paymentProcessor, InvoiceGenerator invoiceGenerator)
        {
            _paymentProcessor = paymentProcessor;
            _invoiceGenerator = invoiceGenerator;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Processing order...");
            _paymentProcessor.ProcessPayment(TotalAmount);
            _invoiceGenerator.GenerateInvoice(this);
        }
    }

}
