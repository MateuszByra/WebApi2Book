using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebApi2Book.Common;

namespace WebApi2Book.Web.Api.IntegrationTests
{
    public class WebClientHelper
    {
        public WebClient CreateWebClient(string username = "bhogg", string contentType=Constants.MediaTypeNames.TextJson)
        {
            var webClient = new WebClient();
            var creds = username + ":" + "ignored";
            var bcreds = Encoding.ASCII.GetBytes(creds);
            var base64Creds = Convert.ToBase64String(bcreds);
            webClient.Headers.Add("Authorization", "Basic " + base64Creds);
            webClient.Headers.Add("Content-Type", contentType);
            return webClient;
        }
    }
}
