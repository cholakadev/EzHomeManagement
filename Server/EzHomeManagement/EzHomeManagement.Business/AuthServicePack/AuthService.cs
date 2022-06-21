namespace EzHomeManagement.Business.AuthServicePack
{
    using AutoMapper;
    using EzHomeManagement.Business.Abstraction;
    using EzHomeManagement.Business.Extensions;
    using EzHomeManagement.Business.Factories;
    using EzHomeManagement.Business.Models.Auth.Entrance;
    using EzHomeManagement.Business.Models.Auth.User;
    using EzHomeManagement.Data.Abstraction;
    using EzHomeManagement.Data.Models.EntityModels;
    using FluentResult;
    using System.Threading.Tasks;

    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly IEntranceRepository _entranceRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRepository<Entrance> _entranceBaseRepository;
        private readonly IRepository<User> _userBaseRepository;

        public AuthService(
            IMapper mapper,
            IEntranceRepository entranceRepository,
            IUserRepository userRepository, 
            IRepository<Entrance> entranceBaseRepository,
            IRepository<User> userBaseRepository)
        {
            this._mapper = mapper;
            this._entranceRepository = entranceRepository;
            this._userRepository = userRepository;
            this._entranceBaseRepository = entranceBaseRepository;
            this._userBaseRepository = userBaseRepository;
        }

        public Task<Result<string>> RegisterEntrance(RegisterEntranceModel registerEntranceModel)
        {
            return Result
                .Create(registerEntranceModel)
                .MapAsync(async registerEntranceModel =>
                {
                    bool unique = false;
                    while (unique == false)
                    {
                        registerEntranceModel.GenerateEntranceCode();
                        var entrance = await this._entranceRepository.GetEntranceByCodeAsync(registerEntranceModel.Code);
                        unique = entrance == null ? true : false;
                    }

                    return unique;
                })
                .MapAsync(unique => this._mapper.Map<Entrance>(registerEntranceModel))
                .MapAsync(entrance => this._entranceBaseRepository.Add(entrance))
                .ValidateAsync(entrance => entrance != null, ResultComplete.OperationFailed, "Entrance registration failed")
                .MapAsync(entrance => entrance.Code);
        }

        public Task<Result<UserModel>> RegisterUser(RegisterUserModel registerUserModel)
        {
            return Result
                .Create(registerUserModel)
                .MapAsync(registerUserModel => this._userRepository.GetUserByEmailAsync(registerUserModel.Email))
                .ValidateAsync(user => user == null, ResultComplete.Conflict, "User with the same email is already registered")
                .MapAsync(user =>
                {
                    var mappedUser = this._mapper.Map<User>(registerUserModel);
                    var passwordHash = registerUserModel.Password.EncryptString(registerUserModel.PasswordSalt);
                    mappedUser.PasswordHash = passwordHash;

                    return mappedUser;
                })
                .MapAsync(user => this._userBaseRepository.Add(user))
                .MapAsync(UserFactory.ToModel);
        }
    }
}
