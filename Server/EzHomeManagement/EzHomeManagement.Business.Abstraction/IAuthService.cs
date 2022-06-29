namespace EzHomeManagement.Business.Abstraction
{
    using EzHomeManagement.Business.Models.Auth.Entrance;
    using EzHomeManagement.Business.Models.Auth.User;
    using FluentResult;
    public interface IAuthService
    {
        Task<Result<string>> RegisterEntrance(RegisterEntranceModel registerEntranceModel);
        Task<Result<UserModel>> RegisterUser(RegisterUserModel registerUserModel);
    }
}
