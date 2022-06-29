namespace EzHomeManagement.Data.Repositories
{
    using EzHomeManagement.Data.Abstraction;
    using EzHomeManagement.Data.Models.EntityModels;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public Task<User?> GetUserByEmailAsync(string email)
            => this.Entities
                .AsNoTracking()
                .FirstOrDefaultAsync(user => user.Email.ToLower() == email.ToLower());
    }
}
