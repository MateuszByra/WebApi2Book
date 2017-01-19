using AutoMapper;
using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.Web.Api.AutoMappingConfiguration
{
    public class StatusToStatusEntityAutoMapperTypeConfigurator : Profile
    {
        public StatusToStatusEntityAutoMapperTypeConfigurator()
        {
            CreateMap<Status, Data.Entities.Status>().ForMember(opt => opt.Version, x => x.Ignore());
        }
    }
}