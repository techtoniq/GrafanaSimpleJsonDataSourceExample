using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;

namespace GrafanaSimpleJsonDataSourceExample.Apis
{
    public class SimpleJsonApi
    {
        [FunctionName("test")]
        public IActionResult Test(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req
            )
        {
            return new OkResult();
        }
    }
}
