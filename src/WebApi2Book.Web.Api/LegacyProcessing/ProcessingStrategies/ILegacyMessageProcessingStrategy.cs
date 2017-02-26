using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebApi2Book.Web.Api.LegacyProcessing.ProcessingStrategies
{
    public interface ILegacyMessageProcessingStrategy
    {
        bool CanProcess(string operationName);
        object Execute(XElement operationElement);
    }
}
