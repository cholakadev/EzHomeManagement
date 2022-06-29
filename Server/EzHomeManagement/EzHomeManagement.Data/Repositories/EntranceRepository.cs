namespace EzHomeManagement.Data.Repositories
{
    using EzHomeManagement.Data.Abstraction;
    using EzHomeManagement.Data.Models.EntityModels;
    using Microsoft.EntityFrameworkCore;

    public class EntranceRepository : Repository<Entrance>, IEntranceRepository
    {
        public EntranceRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<Entrance?> GetEntranceByCodeAsync(string entranceCode)
            => await this.Entities
                .AsNoTracking()
                .FirstOrDefaultAsync(entrance => entrance.Code == entranceCode);
    }
}
