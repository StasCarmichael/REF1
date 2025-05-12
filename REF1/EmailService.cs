
namespace REF1
{
    class EmailService : IEmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending email to {email}: {message}");
        }
    }

}
