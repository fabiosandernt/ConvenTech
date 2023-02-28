using Microsoft.EntityFrameworkCore;

namespace ConvenTech.Infrastructure.Context
{
    public class ConvenTechContext : DbContext
    {
        public ConvenTechContext(DbContextOptions<ConvenTechContext> options) : base(options)
        {
        }        
    }
}
