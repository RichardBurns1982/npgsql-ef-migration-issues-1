using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEfSandbox.Contexts
{
    internal class DataContextPostgreSqlDesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .AddEnvironmentVariables()
                .Build();

            var dbContextOptionsBuilder = new DbContextOptionsBuilder<DataContext>()
                .UseNpgsql(
                    config.GetConnectionString("Postgres"),
                    builder =>
                        builder
                            .MigrationsAssembly($"{nameof(ConsoleAppEfSandbox)}")
                );

            return new DataContext(dbContextOptionsBuilder.Options);
        }
    }
}
