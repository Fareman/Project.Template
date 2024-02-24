namespace Template.Implementations.Services
{
    using AutoMapper;
    using Template.Abstractions.Models;
    using Template.Domain.Entities;

    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}
