using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2Book.Web.Api.Tests
{
    public static class HttpRequestMessageFactory
    {
        public static HttpRequestMessage CreateRequestMessage(HttpMethod method = null, string uriString = null)
        {
            method = method ?? HttpMethod.Get;
            var uri = string.IsNullOrEmpty(uriString) ?
                new Uri("http://localhost:65348/api/whatever") : new Uri(uriString);

            var requestMessage = new HttpRequestMessage(method, uri);
            requestMessage.SetConfiguration(new System.Web.Http.HttpConfiguration());
            return requestMessage;
        }
    }
}
