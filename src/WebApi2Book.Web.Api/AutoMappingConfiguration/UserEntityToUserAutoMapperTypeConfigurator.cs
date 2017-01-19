using AutoMapper;
using WebApi2Book.Data.Entities;

namespace WebApi2Book.Web.Api.AutoMappingConfiguration
{
    public class UserEntityToUserAutoMapperTypeConfigurator : Profile
    {
        public UserEntityToUserAutoMapperTypeConfigurator()
        {
            CreateMap<User, Models.User>().ForMember(opt => opt.Links, x => x.Ignore());
        }
    }
}