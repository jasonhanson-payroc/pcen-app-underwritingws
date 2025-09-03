using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Underwriting.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder =
            new DbContextOptionsBuilder<ApplicationDbContext>();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString;
            if (configuration
                .Providers
                .FirstOrDefault()
                .TryGet("ConnectionStrings:DefaultConnection",
                    out connectionString))
            {
                optionsBuilder.UseSqlServer(connectionString);
                var dbContext =
                    new ApplicationDbContext(optionsBuilder.Options);
                return dbContext;
            }
            else
                throw new Exception("The design-time connection string not found!");
        }
    }
}