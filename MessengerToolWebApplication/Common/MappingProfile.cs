using AutoMapper;
using MessengerToolWebApplication.DTOs.Requests;
using MessengerToolWebApplication.Models;
using MessengerToolWebApplication.DTOs.Responses;

namespace MessengerToolWebApplication.Common
{
    /// <summary>
    /// Mapping profile for AutoMapper
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserLoginDTO>();
            CreateMap<UserLoginDTO, User>();

            CreateMap<User, UserLoginDTO>();
            CreateMap<UserLoginDTO, User>();

            CreateMap<User, UserUnlockDTO>();
            CreateMap<UserUnlockDTO, User>();

            CreateMap<User, UserDTO>();
        }
    }
}
