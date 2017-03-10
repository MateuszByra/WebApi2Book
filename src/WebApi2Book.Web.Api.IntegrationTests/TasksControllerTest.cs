using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi2Book.Web.Api.Models;
using Task = WebApi2Book.Web.Api.Models.Task;

namespace WebApi2Book.Web.Api.IntegrationTests
{
    [TestFixture]
    public class TasksControllerTest
    {
        private WebClientHelper _webClientHelper;
        private const string UriRoot = "http://localhost:65348/api/v1/";

        [SetUp]
        public void Setup()
        {
            _webClientHelper = new WebClientHelper();
        }

        [Test]
        public void GetTasks()
        {
            var client = _webClientHelper.CreateWebClient();
            try
            {
                const string address = UriRoot + "tasks";
                var responseString = client.DownloadString(address);
                var jsonResponse = JObject.Parse(responseString);
                Assert.IsNotNull(jsonResponse.ToObject<PagedDataInquiryResponse<Task>>());
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
