using ConvenTech.Domain.Usuario;
using ConvenTech.Domain.Usuario.Repository;
using ConvenTech.Infrastructure.Context;
using ConvenTech.Infrastructure.Database;

namespace ConvenTech.Infrastructure.Repository
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ConvenTechContext context) : base(context)
        {

        }
    }
}
