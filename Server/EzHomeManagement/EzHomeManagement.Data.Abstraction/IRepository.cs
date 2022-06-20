namespace EzHomeManagement.Data.Abstraction
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);
    }
}
