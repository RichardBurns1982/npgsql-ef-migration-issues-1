using ConsoleAppEfSandbox.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleAppEfSandbox;

public static class Startup
{
    public static void Configure(HostBuilderContext hostContext, IConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.AddEnvironmentVariables();
    }

    public static void Configure(HostBuilderContext hostContext, IServiceCollection services)
    {
        var config = hostContext.Configuration;


        services.AddDbContext<DataContext>(options =>
        {
            var connString = config.GetConnectionString("Postgres") ??
                config.GetValue<string>("Postgres") ??
                Environment.GetEnvironmentVariable("POSTGRESQLCONNSTR_Postgres");
            options.UseNpgsql(connString, o =>
            {
                o.MigrationsAssembly($"{nameof(ConsoleAppEfSandbox)}");
            });
        });
    }
}
