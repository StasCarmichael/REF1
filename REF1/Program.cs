namespace REF1
{

    class Program
    {
        static void Main()
        {
            IUserRepository userRepository = new UserRepository();
            IEmailService emailService = new EmailService();

            User user = new User { Name = "John", Email = "john@example.com", Password = "12345" };
            userRepository.Save(user);
            emailService.SendEmail(user.Email, "Welcome!");

            IPaymentProcessor payment = new CreditCardPayment();
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Order order = new Order(payment, invoiceGenerator)
            {
                Id = 1,
                Products = new List<string> { "Laptop", "Mouse" },
                TotalAmount = 1500
            };
            order.ProcessOrder();
        }
    }

}