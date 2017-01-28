﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2Book.Common;
using WebApi2Book.Web.Api.MaintenanceProcessing;
using WebApi2Book.Web.Api.Models;
using WebApi2Book.Web.Common;
using WebApi2Book.Web.Common.Routing;

namespace WebApi2Book.Web.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("")]
    [UnitOfWorkActionFilter]
    public class TaskWorkflowController : ApiController
    {
        private readonly IStartTaskWorkflowProcessor _startTaskWorkflowProcessor;

        public TaskWorkflowController(IStartTaskWorkflowProcessor startTaskWorkflowProcessor)
        {
            _startTaskWorkflowProcessor = startTaskWorkflowProcessor;
        }

        [HttpPost]
        [Route("tasks/{taskId:long}/activations", Name ="StartTaskRoute")]
        [Authorize(Roles =Constants.RoleNames.SeniorWorker)]
        public Task StartTask(long taskId)
        {
            var task = _startTaskWorkflowProcessor.StartTask(taskId);
            return task;
        }
    }
}
