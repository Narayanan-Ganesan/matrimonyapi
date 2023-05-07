using MatrimonyAPI.Context;
using MatrimonyAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace MatrimonyAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected readonly MatrimonyDbContext _dbContext;
        public UserRepository(MatrimonyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<User> CreateUserAsync(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return Task.FromResult(user);
        }
        public Task<User?> GetLastUser()
        {
            var user = _dbContext.Users.OrderByDescending(u=>u.CreatedDate).FirstOrDefault();
            return Task.FromResult(user);
        }
        public Task<User?> GetUserbyIDAsync(string id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.MatrimonyID == id);
            return Task.FromResult(user);
        }
    }
}
