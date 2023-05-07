using MatrimonyAPI.Domain;

namespace MatrimonyAPI.Repositories
{
    public interface IUserRepository
    {
        Task<User> CreateUserAsync(User user);
        Task<User?> GetLastUser();
        Task<User?> GetUserbyIDAsync(string ID);
    }
}
