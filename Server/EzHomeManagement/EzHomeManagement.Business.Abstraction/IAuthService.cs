namespace EzHomeManagement.Business.Abstraction
{
    using EzHomeManagement.Business.Models.Auth.Entrance;
    using FluentResult;
    public interface IAuthService
    {
        Task<Result<string>> RegisterEntrance(RegisterEntranceModel registerEntranceModel);
    }
}
