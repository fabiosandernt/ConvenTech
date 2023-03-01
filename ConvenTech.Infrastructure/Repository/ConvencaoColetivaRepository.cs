using ConvenTech.Infrastructure.Context;
using ConvenTech.Infrastructure.Database;
using ConvenTech.Domain.InstrumentoColetivo.Repository;
using ConvenTech.Domain.InstrumentoColetivo;

namespace ConvenTech.Infrastructure.Repository
{
    public class ConvencaoColetivaRepository : GenericRepository<ConvencaoColetiva>, IConvencaoColetivaRepository
    {
        public ConvencaoColetivaRepository(ConvenTechContext context) : base(context)
        {

        }
    }
}
