using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using WebApi2Book.Common.Extensions;

namespace WebApi2Book.Web.Api.LegacyProcessing
{
    public class LegacyMessageParser : ILegacyMessageParser
    {
        public XElement GetOperationElement(XDocument soapRequest)
        {
            var body = soapRequest.GetSoapBody();
            var operationElement = GetOperationElement(body);
            return operationElement;
        }

        public XElement GetOperationElement(XElement soapBody)
        {
            var operationElement = soapBody.Elements().First();
            return operationElement;
        }
    }
}