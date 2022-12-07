using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TestCompany.TestFunction
{
    public class TimerTrigger1
    {
        [FunctionName("TimerTrigger1")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogWarning($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
