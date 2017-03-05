using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using WebApi2Book.Data.QueryProcessors;
using WebApi2Book.Web.Api.InquiryProcessing;
using WebApi2Book.Web.Api.LinkServices;
using PagedTaskDataInquiryResponse
    = WebApi2Book.Web.Api.Models.PagedDataInquiryResponse<WebApi2Book.Web.Api.Models.Task>;
using Task = WebApi2Book.Data.Entities.Task;
using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.Web.Api.Tests.InquiryProcessing
{
    public class AllTasksInquiryProcessorTestDouble : AllTasksInquiryProcessor
    {
        public AllTasksInquiryProcessorTestDouble(IMapper autoMapper, ICommonLinkService commonLinkService, ITaskLinkService taskLinkService, IAllTasksQueryProcessor queryProcessor) : base(autoMapper, commonLinkService, taskLinkService, queryProcessor)
        {
        }

        public Func<IEnumerable<Task>, IEnumerable<Models.Task>>GetTasksTestDouble { get; set; }
        public Action<PagedTaskDataInquiryResponse> AddLinksToInquiryResponseTestDouble { get; set; }
        public Func<PagedTaskDataInquiryResponse, string> GetCurrentPageQueryStringTestDouble { get; set; }
        public Func<PagedTaskDataInquiryResponse, string> GetNextPageQueryStringTestDouble { get; set; }
        public Func<PagedTaskDataInquiryResponse,string> GetPreviousPageQueryStringTestDouble { get; set; }
        public override IEnumerable<Models.Task> GetTasks(IEnumerable<Task> taskEntities)
        {
            return GetTasksTestDouble == null ? base.GetTasks(taskEntities) : GetTasksTestDouble(taskEntities);
        }

        public override void AddLinksToInquiryResponse(PagedDataInquiryResponse<Models.Task> inquiryResponse)
        {
            if (AddLinksToInquiryResponseTestDouble == null)
            {
                base.AddLinksToInquiryResponse(inquiryResponse);
            }
            else
            {
                AddLinksToInquiryResponseTestDouble(inquiryResponse);
            }
        }

        public override string GetCurrentPageQueryString(PagedTaskDataInquiryResponse inquiryResponse)
        {
            return GetCurrentPageQueryStringTestDouble == null
                ? base.GetCurrentPageQueryString(inquiryResponse) :
                GetCurrentPageQueryStringTestDouble(inquiryResponse);
        }

        public override string GetNextPageQueryString(PagedTaskDataInquiryResponse inquiryResponse)
        {
            return GetNextPageQueryStringTestDouble == null
                ? base.GetNextPageQueryString(inquiryResponse) :
                GetNextPageQueryStringTestDouble(inquiryResponse);
        }

        public override string GetPreviousPageQueryString(PagedTaskDataInquiryResponse inquiryResponse)
        {
            return GetPreviousPageQueryStringTestDouble == null
                ? base.GetPreviousPageQueryString(inquiryResponse) :
                GetPreviousPageQueryStringTestDouble(inquiryResponse);
        }
    }
}
