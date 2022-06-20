namespace EzHomeManagement.Business.Abstraction
{
    using FluentResult;
    public interface IAuthService
    {
        Task<Result<object>> Register(object userModel);
    }
}
