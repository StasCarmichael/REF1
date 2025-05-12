
namespace REF1
{
    class UserRepository : IUserRepository
    {
        public void Save(User user)
        {
            Console.WriteLine("Saving user to database...");
        }
    }

}
