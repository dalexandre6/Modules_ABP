using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace MainAppn;

public class MainAppnWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<MainAppnWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
