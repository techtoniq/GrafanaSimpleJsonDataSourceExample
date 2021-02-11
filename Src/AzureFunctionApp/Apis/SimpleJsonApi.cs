using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using GrafanaSimpleDataSource.Data;

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

        [FunctionName("query")]
        public IActionResult Query(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "api/query")] TimeSeriesRequest req
            )
        {

            return new OkResult();
        }

    }
}
