using ConvenTech.CrossCutting.Repository;

namespace ConvenTech.Domain.InstrumentoColetivo
{
    public class ConvencaoColetiva: Entity<Guid>    {
        
        public string NumeroProtocolo { get; set; }
        public string CNPJ { get; set; }
        public ICollection<Vigencia> Vigencias { get; set; }
    }
}
