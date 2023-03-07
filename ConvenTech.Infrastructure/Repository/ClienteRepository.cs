using ConvenTech.Domain.Client;
using ConvenTech.Domain.Client.Repository;
using ConvenTech.Infrastructure.Context;
using ConvenTech.Infrastructure.Database;

namespace ConvenTech.Infrastructure.Repository
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ConvenTechContext context) : base(context)
        {

        }

        public Task<IEnumerable<Cliente>> ObterTodasEmpresas()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> ObterTodasEmpresasPorCnpj(string parametro)
        {
            throw new NotImplementedException();
        }
    }
}