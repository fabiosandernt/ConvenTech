using ConvenTech.Domain.Account.Repository;
using ConvenTech.Domain.Cliente.Repository;
using ConvenTech.Domain.InstrumentoColetivo.Repository;
using ConvenTech.Infrastructure.Context;
using ConvenTech.Infrastructure.Database;
using ConvenTech.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ConvenTech.Infrastructure
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ConvenTechContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });
           
            services.AddScoped(typeof(GenericRepository<>));            
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IConvencaoColetivaRepository, ConvencaoColetivaRepository>();

            return services;
        }
    }
}
