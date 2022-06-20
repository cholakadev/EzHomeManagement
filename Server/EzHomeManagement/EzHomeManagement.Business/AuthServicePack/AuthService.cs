namespace EzHomeManagement.Business.AuthServicePack
{
    using EzHomeManagement.Business.Abstraction;
    using EzHomeManagement.Business.Models.Auth.Entrance;
    using FluentResult;
    using System.Threading.Tasks;

    public class AuthService : IAuthService
    {
        public Task<Result<bool>> Register(RegisterEntranceModel registerEntranceModel)
        {
            throw new NotImplementedException();
        }
    }
}
