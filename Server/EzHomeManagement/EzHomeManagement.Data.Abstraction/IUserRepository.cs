namespace EzHomeManagement.Data.Abstraction
{
    using EzHomeManagement.Data.Models.EntityModels;

    public interface IUserRepository
    {
        Task<User?> GetUserByEmailAsync(string email);
    }
}
