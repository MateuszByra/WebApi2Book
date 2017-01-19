using AutoMapper;
using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.Web.Api.AutoMappingConfiguration
{
    public class UserToUserEntityAutoMapperTypeConfigurator : Profile
    {
        public UserToUserEntityAutoMapperTypeConfigurator()
        {
            CreateMap<User, Data.Entities.User>().ForMember(opt=>opt.Version, x=>x.Ignore());
        }
    }
}