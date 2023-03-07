

using ConvenTech.CrossCutting.GenericRepository;

namespace ConvenTech.Domain.Client.Repository
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        Task<IEnumerable<Cliente>> ObterTodasEmpresas();
        Task<IEnumerable<Cliente>> ObterTodasEmpresasPorCnpj(string parametro);
    }
}
