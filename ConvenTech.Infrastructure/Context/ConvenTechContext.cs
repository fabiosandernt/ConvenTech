using ConvenTech.Domain.Cliente;
using Microsoft.EntityFrameworkCore;

namespace ConvenTech.Infrastructure.Context
{
    public class ConvenTechContext : DbContext
    {

        public ConvenTechContext(DbContextOptions<ConvenTechContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConvenTechContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
