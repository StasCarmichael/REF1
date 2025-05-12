
namespace REF1
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void SaveToDatabase()
        {
            Console.WriteLine("Saving user to database...");
        }

        public void SendEmail(string message)
        {
            Console.WriteLine($"Sending email to {Email}: {message}");
        }
    }
}
