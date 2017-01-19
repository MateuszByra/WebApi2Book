using AutoMapper;
using System.Collections.Generic;
using WebApi2Book.Data.Entities;
using WebApi2Book.Web.Common;
using System;
using System.Linq;
using User = WebApi2Book.Web.Api.Models.User;

namespace WebApi2Book.Web.Api.AutoMappingConfiguration
{
    public class TaskAssigneesResolver : IValueResolver<Task, Models.Task, List<User>>
    {
        public IMapper AutoMapper { get { return WebContainerManager.Get<IMapper>(); } }

        public List<User> Resolve(Task source)
        {
            return source.Users.Select(x => AutoMapper.Map<User>(x)).ToList();
        }

        public List<User> Resolve(Task source, Models.Task destination, List<User> destMember, ResolutionContext context)
        {
            return source.Users.Select(x => AutoMapper.Map<User>(x)).ToList();
        }

    }
}