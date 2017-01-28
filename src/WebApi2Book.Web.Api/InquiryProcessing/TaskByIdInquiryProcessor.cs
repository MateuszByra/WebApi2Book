using AutoMapper;
using System;
using WebApi2Book.Data.Exceptions;
using WebApi2Book.Data.QueryProcessors;
using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.Web.Api.InquiryProcessing
{
    public class TaskByIdInquiryProcessor : ITaskByIdInquiryProcessor
    {
        private readonly IMapper _autoMapper;
        private readonly ITaskByIdQueryProcessor _taskByIdQueryProcessor;

        public TaskByIdInquiryProcessor(ITaskByIdQueryProcessor taskByIdQueryProcessor, IMapper autoMapper)
        {
            _taskByIdQueryProcessor = taskByIdQueryProcessor;
            _autoMapper = autoMapper;
        }
        public Task GetTask(long taskId)
        {
            var taskEntity = _taskByIdQueryProcessor.GetTask(taskId);

            if (taskEntity == null)
            {
                throw new RootObjectNotFoundException("Task not found");
            }

            var task = _autoMapper.Map<Task>(taskEntity);
            return task;
        }
    }
}