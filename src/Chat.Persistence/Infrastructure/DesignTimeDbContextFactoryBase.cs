using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Chat.Persistence.Infrastructure
{
    public abstract class DesignTimeDbContextFactoryBase<TContext> : IDesignTimeDbContextFactory<TContext>
        where TContext : DbContext
    {
        private const string ConnectionStringName = "ChatConnection";
        private const string AspNetCoreEnvironment = "ASPNETCORE_ENVIRONMENT";

        public TContext CreateDbContext(string[] args)
        {
            string basePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "Chat.WebHost");
            string environmentName = Environment.GetEnvironmentVariable(AspNetCoreEnvironment);

            Console.WriteLine($"Environment name: {environmentName}");

            return Create(basePath, environmentName);
        }

        protected abstract TContext CreateNewInstance(DbContextOptions<TContext> options);

        private TContext Create(string basePath, string environmentName)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile("appsettings.Local.json", optional: true)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            string connectionString = configuration.GetConnectionString(ConnectionStringName);
            return Create(connectionString);
        }

        private TContext Create(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException($"Connection string '{ConnectionStringName}' is null", nameof(connectionString));
            }

            Console.WriteLine($"Connection string '{ConnectionStringName}': {connectionString}");

            DbContextOptionsBuilder<TContext> optionsBuilder = new DbContextOptionsBuilder<TContext>();
            optionsBuilder.UseMySql(connectionString);
            return CreateNewInstance(optionsBuilder.Options);
        }
    }
}