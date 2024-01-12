using Microsoft.Extensions.Hosting;

namespace ConsoleAppEfSandbox;

public class ConsoleHostBuilder
    {
        public IHost Build()
        {
            var hostBuilder = Host.CreateDefaultBuilder();
            return hostBuilder
                .ConfigureAppConfiguration(Startup.Configure)
                .ConfigureServices(Startup.Configure)
                .Build();
        }
    }
