using ConsoleAppEfSandbox;
using Microsoft.Extensions.Hosting;

var host = new ConsoleHostBuilder().Build();
await host.RunAsync();