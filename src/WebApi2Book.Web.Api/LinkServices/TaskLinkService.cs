﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WebApi2Book.Common;
using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.Web.Api.LinkServices
{
    public class TaskLinkService : ITaskLinkService
    {
        private readonly ICommonLinkService _commonLinkService;
        private readonly IUserLinkService _userLinkService;
        public TaskLinkService(ICommonLinkService commonLinkService,
            IUserLinkService userLinkService)
        {
            _commonLinkService = commonLinkService;
            _userLinkService = userLinkService;
        }
        public void AddLinksToChildObjects(Task task)
        {
            task.Assignees.ForEach(x => _userLinkService.AddSelfLink(x));
        }

        public void AddSelfLink(Task task)
        {
            task.AddLink(GetSelfLink(task.TaskId.Value));
        }

        public Link GetAllTasksLink()
        {
            const string pathFragment = "tasks";
            return _commonLinkService.GetLink(pathFragment, Constants.CommonLinkRelValues.All,
                HttpMethod.Get);
        }

        public virtual Link GetSelfLink(long taskId)
        {
            var pathFragment = string.Format("tasks/{0}", taskId);
            var link = _commonLinkService.GetLink(pathFragment, Constants.CommonLinkRelValues.Self,
                HttpMethod.Get);
            return link;
        }
    }
}