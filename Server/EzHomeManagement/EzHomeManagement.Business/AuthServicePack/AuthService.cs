namespace EzHomeManagement.Business.AuthServicePack
{
    using AutoMapper;
    using EzHomeManagement.Business.Abstraction;
    using EzHomeManagement.Business.Models.Auth.Entrance;
    using EzHomeManagement.Data.Abstraction;
    using EzHomeManagement.Data.Models.EntityModels;
    using FluentResult;
    using System.Threading.Tasks;

    public class AuthService : IAuthService
    {
        private readonly IRepository<Entrance> _entranceBaseRepository;
        private readonly IEntranceRepository _entranceRepository;
        private readonly IMapper _mapper;

        public AuthService(
            IRepository<Entrance> entranceBaseRepository,
            IEntranceRepository entranceRepository, 
            IMapper mapper)
        {
            this._entranceBaseRepository = entranceBaseRepository;
            this._entranceRepository = entranceRepository;
            this._mapper = mapper;
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
                .MapAsync(entrance => entrance.Code);
        }
    }
}
