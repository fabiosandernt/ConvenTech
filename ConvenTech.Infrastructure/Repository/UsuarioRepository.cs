using ConvenTech.Domain.Account;
using ConvenTech.Domain.Account.Repository;
using ConvenTech.Infrastructure.Context;
using ConvenTech.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace ConvenTech.Infrastructure.Repository
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ConvenTechContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Usuario>> ObterTodosUsuarios()
        {
            return await this.Query.ToListAsync();
        }

        public async Task<IEnumerable<Usuario>> ObterUsuarioPorId(Guid id)
        {
            return await this.Query.Where(x => x.Id == id).ToListAsync();
        }
    }
}
