namespace EzHomeManagement.Business.Abstraction
{
    using EzHomeManagement.Business.Models.Auth.Entrance;
    using FluentResult;
    public interface IAuthService
    {
        Task<Result<bool>> Register(RegisterEntranceModel registerEntranceModel);
    }
}
