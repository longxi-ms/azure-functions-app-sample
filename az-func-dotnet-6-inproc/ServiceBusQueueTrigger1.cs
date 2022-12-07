using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TestCompany.TestFunction
{
    public class ServiceBusQueueTrigger1
    {
        [FunctionName("ServiceBusQueueTrigger1")]
        public void Run([ServiceBusTrigger("myqueue01", Connection = "CUSTCONF_CONNSTR_SRVBUS_01")] string myQueueItem, ILogger log)
        {
            if (myQueueItem == "show me an error")
            {
                throw new Exception();
            }
            log.LogWarning($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
