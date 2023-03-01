using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace ConvenTech.Infrastructure.Context
{
    public  class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ConvenTechContext>
    {
        public ConvenTechContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<ConvenTechContext>()
                .AddEnvironmentVariables()
                .Build();

            var builder = new DbContextOptionsBuilder<ConvenTechContext>();
            var connectionString = 
                config.GetConnectionString("ConvenTech");
            builder.UseSqlServer(connectionString);
            Console.WriteLine(connectionString);
            return new ConvenTechContext(builder.Options);
        }
    }
}
