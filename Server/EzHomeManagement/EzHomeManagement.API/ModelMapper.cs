namespace EzHomeManagement.API
{
    using AutoMapper;
    using EzHomeManagement.Business.Models.Auth.Entrance;
    using EzHomeManagement.Business.Models.Auth.User;
    using EzHomeManagement.Data.Models.EntityModels;

    public class ModelMapper : Profile
    {
        public ModelMapper()
        {
            CreateMap<RegisterEntranceModel, Entrance>()
                .ForMember(
                    dest => dest.Code,
                    opt => opt.MapFrom(src => src.Code)
                )
                .ForMember(
                    dest => dest.Number,
                    opt => opt.MapFrom(src => src.Number)
                )
                .ForMember(
                    dest => dest.Town,
                    opt => opt.MapFrom(src => src.Town)
                )
                .ForMember(
                    dest => dest.Country,
                    opt => opt.MapFrom(src => src.Country)
                )
                .ForMember(
                    dest => dest.Address,
                    opt => opt.MapFrom(src => src.Address)
                );

            CreateMap<RegisterUserModel, User>()
                .ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => src.Email)
                )
                .ForMember(
                    dest => dest.PasswordHash,
                    opt => opt.MapFrom(src => src.Password)
                )
                .ForMember(
                    dest => dest.PasswordSalt,
                    opt => opt.MapFrom(src => src.PasswordSalt)
                );
        }
    }
}
