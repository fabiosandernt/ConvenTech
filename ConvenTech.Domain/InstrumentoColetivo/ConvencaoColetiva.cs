using ConvenTech.CrossCutting.BaseEntity;

namespace ConvenTech.Domain.InstrumentoColetivo
{
    public class ConvencaoColetiva: Entity<Guid>    {
        
        public string NumeroProtocolo { get; set; }
        public string Cnpj { get; set; }
        public ICollection<Vigencia> Vigencias { get; set; }
    }
}
