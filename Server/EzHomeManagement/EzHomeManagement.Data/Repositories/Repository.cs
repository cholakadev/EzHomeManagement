namespace EzHomeManagement.Data.Repositories
{
    using EzHomeManagement.Data.Abstraction;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        public Repository(ApplicationDbContext dbContext)
        {
            this.Entities = dbContext.Set<TEntity>();
            this.Context = dbContext;
        }

        protected DbSet<TEntity> Entities { get; private set; }

        protected ApplicationDbContext Context { get; private set; }

        public async Task<TEntity> Add(TEntity entity)
        {
            if (entity == null)
                return null;

            await this.Entities.AddAsync(entity);
            return await this.SaveAsync(entity);
        }

        protected async Task<TEntity> SaveAsync(TEntity entity)
        {
            var rows = await Context.SaveChangesAsync();
            return rows != 0 ? entity : null;
        }
    }
}
