using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ShopBridgeDataModel;
using System;
using System.IO;

namespace ShopBridgeMigrations
{
    class Program : IDesignTimeDbContextFactory<DataContext>
    {
        static void Main(string[] args)
        {
            using (DataContext shopBridgeDbContext = new Program().CreateDbContext(args))
            {
                shopBridgeDbContext.Database.Migrate();
            }
        }

        public DataContext CreateDbContext(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = configurationBuilder.Build();
            string connectionString = configuration.GetConnectionString("ShopBridge");

            if (args.Length != 0 && !string.IsNullOrEmpty(args[0]))
                connectionString = args[0].ToString().Trim();

            Console.WriteLine("Connection String to database " + connectionString);

            DbContextOptionsBuilder<DataContext> optionsBuilder = new DbContextOptionsBuilder<DataContext>()
                .UseSqlServer(connectionString);

            return new DataContext(optionsBuilder.Options);
        }
    }
}
