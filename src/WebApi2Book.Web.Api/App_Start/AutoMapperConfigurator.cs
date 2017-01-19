using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi2Book.Common.TypeMapping;

namespace WebApi2Book.Web.Api.App_Start
{
    public class AutoMapperConfigurator
    {
        public void Configure(IEnumerable<IAutomapperTypeConfigurator> autoMapperTypeConfigurations)
        {
            autoMapperTypeConfigurations.ToList().ForEach(x => x.Configure());
            Mapper.AssertConfigurationIsValid();
        }
    }
}