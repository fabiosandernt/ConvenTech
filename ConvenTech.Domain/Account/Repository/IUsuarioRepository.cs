using ConvenTech.CrossCutting.GenericRepository;

namespace ConvenTech.Domain.Account.Repository
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        Task<IEnumerable<Usuario>> ObterTodosUsuarios();
        Task<IEnumerable<Usuario>> ObterUsuarioPorId(Guid id);
    }
}
