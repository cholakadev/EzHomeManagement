namespace EzHomeManagement.Data.Abstraction
{
    using EzHomeManagement.Data.Models.EntityModels;

    public interface IEntranceRepository
    {
        Task<Entrance?> GetEntranceByCodeAsync(string entranceCode);
    }
}
