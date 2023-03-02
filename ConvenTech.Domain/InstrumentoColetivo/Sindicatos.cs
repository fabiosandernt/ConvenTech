using ConvenTech.CrossCutting.BaseEntity;
using ConvenTech.Domain.ValueObject;

namespace ConvenTech.Domain.InstrumentoColetivo
{
    public class Sindicatos: Entity<Guid>
    {
        public TipoSindicatoEnum TipoSindicato { get; set; }    
        public string RazaoSocial { get; set; }
        public Cnpj Cnpj { get; set; }
    }
}
