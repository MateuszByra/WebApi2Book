using AutoMapper;
using WebApi2Book.Data.Entities;

namespace WebApi2Book.Web.Api.AutoMappingConfiguration
{
    public class StatusEntityToStatusAutoMapperTypeConfigurator : Profile
    {
        public StatusEntityToStatusAutoMapperTypeConfigurator()
        {
            CreateMap<Status, Models.Status>();
        }
    }
}