using AutoMapper;
using WebApiTest.Dtos;
using WebApiTest.Models;

namespace WebApiTest.Mapper
{
    public class AutoMapperProfiles : Profile 
    {
        public AutoMapperProfiles()
        {
            CreateMap<CourseResultCreateDto, CourseResult>();
            CreateMap<CourseResult, CourseResultListDto>();
            CreateMap<UserRegisterDto, User>();
            CreateMap<UserLoginDto, User>();
            CreateMap<User, UserListDto>();
        }
    }
}
