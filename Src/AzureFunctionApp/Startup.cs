using System.Reflection;
using AzureFunctions.Extensions.Swashbuckle;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi;

[assembly: FunctionsStartup(typeof(AzureFunctionApp.Startup))]

namespace AzureFunctionApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.AddSwashBuckle(Assembly.GetExecutingAssembly(), opts =>
            {
                opts.Title = "Swagger Test";
                opts.SpecVersion = OpenApiSpecVersion.OpenApi3_0;
                /*
                                opts.AddCodeParameter = true;
                                opts.PrependOperationWithRoutePrefix = true;
                                opts.Documents = new[]
                                {
                                    new SwaggerDocument
                                    {
                                        Name = "v1",
                                        Title = "Swagger document",
                                        Description = "Swagger test document",
                                        Version = "v2"
                                    }
                                };
                                //opts.OverridenPathToSwaggerJson = new Uri("http://localhost:7071/api/Swagger/json");
                                opts.ConfigureSwaggerGen = (x =>
                                {
                                    x.CustomOperationIds(apiDesc =>
                                    {
                                        return apiDesc.TryGetMethodInfo(out MethodInfo methodInfo)
                                            ? methodInfo.Name
                                            : new Guid().ToString();
                                    });
                                });
                */
            });
            /*
            builder.Services.AddSingleton<ISimpleJsonDataSource>((s) => {
                return new ExampleDataSource();
            });
            */
        }
    }
}
